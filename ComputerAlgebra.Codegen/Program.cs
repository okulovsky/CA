// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AIRLab.CA.Tree.Tools;
using Microsoft.CSharp;

namespace Codegen
{
    internal static class Program
    {
        private const string GeneratedCodeAttribute = "[GeneratedCode(\"ComputerAlgebra.Codegen\", \"1.0.0.1\")]";
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static int MaxLetter
        {
            get
            {
                return (int)Math.Floor(Letters.Count() / 2f);
            }
        }

        static string Where(int letterIndex)
        {
            var builder = new StringBuilder();
            for (var currentLetterIndex = 0; currentLetterIndex < letterIndex; currentLetterIndex += 1)
            {
                builder.AppendFormatedLine("where T{0}: INode ", currentLetterIndex);
            }
            return builder.ToString();
        }

        private static string GenericTypeDeclaration(int letterIndex)
        {
            var builder = new StringBuilder();
            for (var currentLetterIndex = 0; currentLetterIndex < letterIndex; currentLetterIndex += 1)
            {
                builder.AppendFormat("{0}T{1}", (currentLetterIndex == 0 ? "" : ","), currentLetterIndex);
            }
            return builder.ToString();
        }

        private static string MakeTypizedNodeArray(int letterIndex)
        {
            return string.Format("TypizedNodeArray<{0}>", GenericTypeDeclaration(letterIndex));
        }

        private static StringBuilder AppendTypizedNodeArrayClasses(this StringBuilder builder)
        {
            for (var letterIndex = 1; letterIndex <= MaxLetter; letterIndex += 1)
            {
                var g = GenericTypeDeclaration(letterIndex);
                var where = Where(letterIndex);

                builder = builder
                    .AppendFormatedLine("    {0}", GeneratedCodeAttribute)
                    .AppendFormatedLine("    public class TypizedNodeArray<{0}> : WhereOutput {1}", g, where)
                    .AppendLine("    {")
                    .AppendTypizedNodeArrayMember(letterIndex)
                    .AppendLine("        override protected ModInput MakeSafeRuleInstance(INode[] c)")
                    .AppendLine("        {")
                    .AppendFormatedLine("            return new TypizedDecorArray<{0}>(c);", g)
                    .AppendLine("        }")
                    .AppendLine("    }");
            }
            return builder;
        }

        private static StringBuilder AppendTypizedNodeArrayMember(this StringBuilder builder, int letterIndex)
        {
            for (var currentLetterIndex = 0; currentLetterIndex < letterIndex; currentLetterIndex += 1)
            {
                builder = builder.AppendFormat("        public T{0} {1} ", currentLetterIndex, Letters[currentLetterIndex]).AppendLine("{ get; set; }");
            }
            return builder;
        }

        private static StringBuilder AppendTypizedDecorArrayClasses(this StringBuilder builder)
        {
            for (var letterIndex = 1; letterIndex <= MaxLetter; letterIndex += 1)
            {
                var g = GenericTypeDeclaration(letterIndex);
                var where = Where(letterIndex);

                builder = builder
                    .AppendFormatedLine("    {0}", GeneratedCodeAttribute)
                    .AppendFormatedLine("    public class TypizedDecorArray<{0}> : ModInput {1}", g, where)
                    .AppendLine("    {")
                    .AppendGenericNodeDecorators(letterIndex)
                    .AppendLine()
                    .AppendLine("        public TypizedDecorArray(IList<INode> c) ")
                    .AppendLine("        { ")
                    .AppendNodeDecoratorInitialzer(letterIndex)
                    .AppendLine("        }")
                    .AppendLine("    }");
            }
            return builder;
        }

        private static StringBuilder AppendNodeDecoratorInitialzer(this StringBuilder builder, int letterIndex)
        {
            for (var currentLetterIndex = 0; currentLetterIndex < letterIndex; currentLetterIndex += 1)
            {
                builder = builder.AppendFormatedLine("{0} = new NodeDecorator<T{1}>(this, (T{1})c[{1}]);", Letters[currentLetterIndex], currentLetterIndex);
            }
            return builder;
        }

        private static StringBuilder AppendGenericNodeDecorators(this StringBuilder builder, int letterIndex)
        {
            for (var currentLetterIndex = 0; currentLetterIndex < letterIndex; currentLetterIndex += 1)
            {
                builder
                    .AppendFormat("        public NodeDecorator<T{0}> {1} ", currentLetterIndex, Letters[currentLetterIndex])
                    .AppendLine("{ get; private set; }");
            }
            return builder;
        }

        private static StringBuilder AppendSelectRuleClasses(this StringBuilder builder)
        {
            return builder
                .AppendFormatedLine("    {0}", GeneratedCodeAttribute)
                .AppendLine("    public class SelectRule")
                .AppendLine("    {")
                .AppendLine("        public ComplexSelector Selector;")
                .AppendLine("        public NewRule NewRule;")
                .AppendLine("        public SelectRule(NewRule newRule, ComplexSelector selector)")
                .AppendLine("        {")
                .AppendLine("            Selector = selector;")
                .AppendLine("            NewRule = newRule;")
                .AppendLine("        }")
                .AppendSelectRuleFunctions()
                .AppendLine("    }");
        }

        private static StringBuilder AppendSelectRuleFunctions(this StringBuilder builder)
        {
            for (var letterIndex = 1; letterIndex <= MaxLetter; letterIndex += 1)
            {
                var g = GenericTypeDeclaration(letterIndex);
                var where = Where(letterIndex);
                var typizedNodeArray = MakeTypizedNodeArray(letterIndex);

                builder = builder
                    .AppendFormatedLine("        public SelectWhereRule<{0}> Where<{0}>() {1}", g, @where)
                    .AppendLine("        {")
                    .AppendFormatedLine("            return Where<{0}>(z => true);", g)
                    .AppendLine("        }")
                    .AppendLine()
                    .AppendFormatedLine(
                        "        public SelectWhereRule<{0}> Where<{0}>(Func<TypizedNodeArray<{0}>,bool> where) {1}", g,
                        @where)
                    .AppendLine("        {")
                    .AppendFormat("            return new SelectWhereRule<{0}>(this, selector => ", g).AppendLine("{")
                    .AppendFormatedLine("                var tna = Typize<{0}>(selector.SelectedNodes);", g)
                    .AppendLine("                if (tna == null) ")
                    .AppendLine("                    return null;")
                    .AppendLine("                tna.SelectResult = selector;")
                    .AppendLine("                return where(tna) ? tna : null;")
                    .AppendLine("            });")
                    .AppendLine("        }")
                    .AppendFormatedLine("        {2} Typize<{0}>(INode[] array) {1}", g, @where, typizedNodeArray)
                    .AppendLine("        {")
                    .AppendLine("            if (array == null)")
                    .AppendLine("                return null;")
                    .AppendFormatedLine("            var typizedNodeArray = new {0}();", typizedNodeArray)
                    .AppendTypizedNodeArrays(letterIndex)
                    .AppendLine("            return typizedNodeArray;")
                    .AppendLine("        }");
            }
            return builder;
        }

        private static StringBuilder AppendTypizedNodeArrays(this StringBuilder builder, int letterIndex)
        {
            for (var currentLetterIndex = 0; currentLetterIndex < letterIndex; currentLetterIndex += 1)
            {
                builder = builder
                    .AppendFormatedLine("if (!(array[{0}] is T{0})) ", currentLetterIndex)
                    .AppendLine("    return null;")
                    .AppendFormatedLine("typizedNodeArray.{1} = (T{0})array[{0}];", currentLetterIndex, Letters[currentLetterIndex])
                    .AppendLine();
            }
            return builder;
        }

        private static StringBuilder AppendSelectWhereRuleClasses(this StringBuilder builder)
        {
            for (var letterIndex = 1; letterIndex <= MaxLetter; letterIndex += 1)
            {
                var g = GenericTypeDeclaration(letterIndex);
                var typizedNodeArray = MakeTypizedNodeArray(letterIndex);

                builder = builder
                    .AppendFormatedLine("    {0}", GeneratedCodeAttribute)
                    .AppendFormatedLine("    public class SelectWhereRule<{0}> : SelectWhereRule  {1}", g,
                        Where(letterIndex))
                    .AppendLine("    {")
                    .AppendFormatedLine("        readonly Func<SelectOutput, {0}> _where;", typizedNodeArray)
                    .AppendLine()
                    .AppendFormatedLine(
                        "        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, {0}> where) : base(selectRule)",
                        typizedNodeArray)
                    .AppendLine("        {")
                    .AppendLine("            _where = where;")
                    .AppendLine("        }")
                    .AppendLine()
                    .AppendFormatedLine("        public Rule Mod(Action<TypizedDecorArray<{0}>> replace)", g)
                    .AppendLine("        {")
                    .AppendFormatedLine(
                        "            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<{0}>)z));",
                        g)
                    .AppendLine("        }")
                    .AppendLine("    }");
            }
            return builder;
        }

        private static StringBuilder AppendNamespaceDeclaration(this StringBuilder builder)
        {
            return builder
                .AppendLine("using System;")
                .AppendLine("using System.CodeDom.Compiler;")
                .AppendLine("using AIRLab.CA.Tree.Nodes;")
                .AppendLine("using AIRLab.CA.Tree.Tools;")
                .AppendLine()
                .AppendLine("namespace AIRLab.CA.Tree.Rules ");
        }

        private static StringBuilder AppendCopyright(this StringBuilder builder)
        {
            return builder
                .AppendLine("// ComputerAlgebra Library")
                .AppendLine()
                .AppendLine("// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013")
                .AppendLine("// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com")
                .AppendLine();
        }

        static StringBuilder MakeSelectClause(this StringBuilder builder, int li)
        {
            return builder
                .SelectClauseNodeAny(li)
                .SelectClauseNodeChild(li)
                .AppendSelectClauseNode(li);
        }

        private static StringBuilder SelectClauseNodeAny(this StringBuilder builder, int li)
        {
            return builder
                .AppendFormatedLine("        public static SelectClauseNode Any{0}", Letters[li])
                .AppendLine("        {")
                .AppendLine("            get")
                .AppendLine("            {")
                .AppendFormatedLine("                return new SelectClauseNode({0}, LetterRecursionType.Subtree);", li)
                .AppendLine("            }")
                .AppendLine("        }")
                .AppendLine();
        }

        private static StringBuilder SelectClauseNodeChild(this StringBuilder builder, int li)
        {
            return builder
                .AppendFormatedLine("        public static SelectClauseNode Child{0}", Letters[li])
                .AppendLine("        {")
                .AppendLine("            get")
                .AppendLine("            {")
                .AppendFormatedLine("                return new SelectClauseNode({0}, LetterRecursionType.Children);", li)
                .AppendLine("            }")
                .AppendLine("        }")
                .AppendLine();
        }

        private static StringBuilder AppendSelectClauseNode(this StringBuilder builder, int li)
        {
            return builder
                .AppendFormatedLine("        public static SelectClauseNode {0}", Letters[li])
                .AppendLine("        {")
                .AppendLine("            get")
                .AppendLine("            {")
                .AppendFormatedLine("                return new SelectClauseNode({0}, LetterRecursionType.No);", li)
                .AppendLine("            }")
                .AppendLine("        }")
                .AppendLine();
        }

        static StringBuilder AppendSelectClauses(this StringBuilder builder)
        {

            return builder.AppendFormatedLine("    {0}", GeneratedCodeAttribute)
                .AppendLine("    public class SelectClauseWriter ")
                .AppendLine("    {")
                .AddSelectClauses()
                .AppendLine("    }");
        }

        private static StringBuilder AddSelectClauses(this StringBuilder builder)
        {
            for (var i = 0; i < MaxLetter; i += 1)
            {
                builder = builder.MakeSelectClause(i);
            }
            return builder;
        }

        static StringBuilder MakePredicates(this StringBuilder builder, IEnumerable<string> letters)
        {
            return letters.Aggregate(builder, (currentBuilder, letter) => currentBuilder
                    .AppendFormatedLine("        public static ComputerAlgebraBoolean {0}(params int[] args)", letter)
                    .AppendLine("        {")
                    .AppendLine("            return new ComputerAlgebraBoolean();")
                    .AppendLine("        }"));
        }

        static StringBuilder MakeFunctions(this StringBuilder builder, IEnumerable<string> letters)
        {
            return letters.Aggregate(builder, (currentBuilder, letter) => currentBuilder
                    .AppendFormatedLine("        public static int {0}(params int[] args)", letter)
                    .AppendLine("        {")
                    .AppendLine("            return 1;")
                    .AppendLine("        }"));
        }

        static StringBuilder MakeConstants(this StringBuilder builder, IEnumerable<string> names)
        {
            names.ToList().ForEach((name, index) => builder = builder
                .AppendFormatedLine("        public const int {0} = {1};", name, index));

            return builder;
        }

        static StringBuilder AppendClassLogicExpressions(this StringBuilder builder)
        {
            return builder
                .AppendFormatedLine("    {0}", GeneratedCodeAttribute)
                .AppendLine("    public class LogicExpressions")
                .AppendLine("    {")
                .MakePredicates(NodeElementNames.GetPredicateNames())
                .MakeFunctions(NodeElementNames.GetFunctionNames())
                .MakeConstants(NodeElementNames.GetConstantNames())
                .AppendLine("    }");
        }

        private static string GenerateSourceCode()
        {
            return new StringBuilder()
                .AppendCopyright()
                .AppendNamespaceDeclaration()
                .AppendLine("{")
                .AppendClassesForLetter()
                .AppendSelectClauses()
                .AppendClassLogicExpressions()
                .AppendLine("}")
                .ToString();
        }

        private static StringBuilder AppendClassesForLetter(this StringBuilder builder)
        {
            return builder
                    .AppendTypizedNodeArrayClasses()
                    .AppendTypizedDecorArrayClasses()
                    .AppendSelectRuleClasses()
                    .AppendSelectWhereRuleClasses();
        }

        public static void CompileSourceToDisk(string sourceCode, bool debug)
        {
            var referencedAssemblies = new[]
            {
                "System.dll", 
                "System.Core.dll"
            };

            const string assemblyName = "Generated.dll";

            var compilerParameters = new CompilerParameters(referencedAssemblies, assemblyName, debug)
            {
                GenerateExecutable = false, 
                GenerateInMemory = false
            };

            var compiler = new CSharpCodeProvider();
            compiler.CompileAssemblyFromSource(compilerParameters, sourceCode);
        }

        [STAThread]
        public static void Main()
        {
            var form = new Form();
            var textBox = new TextBox
            {
                Dock = DockStyle.Fill, 
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };

            form.Controls.Add(textBox);
            form.Size = new System.Drawing.Size(800, 600);

            var sourceCode = GenerateSourceCode();
            textBox.Text = sourceCode;
            textBox.Select(0, sourceCode.Length * 2);
            Application.Run(form);

            ////TODO: test compiler 
            // CompileSourceToDisk(sourceCode, debug: true);
        }
    }
}
