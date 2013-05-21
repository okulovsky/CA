// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Windows.Forms;
using AIRLab.CA.Tools;
namespace Codegen
{
    internal static class Program
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRST";
        const int MaxLetter = 10;

        static string Where(int i)
        {
            var res = "";
            for (var j = 0; j < i; j++)
                res += "where T" + j + ": INode ";
            return res;
        }


        private static string G(int i)
        {
            var generic = "";
            for (var j = 0; j < i; j++)
                generic += (j == 0 ? "" : ",") + "T" + j;
            return generic;
        }

        private static string MakeTypizedNodeArray(int i)
        {
            return "TypizedNodeArray<" + G(i) + ">";
        }

        private static string MakeTypized(int i)
        {
            var result = "";
            result += "public class TypizedNodeArray<" + G(i) + "> : WhereOutput "+Where(i)+"{ \n";
            
            for (var j = 0; j < i; j++)
                result += "public T" + j + " " + Letters[j] + " { get; set; }\n";

            result += "override protected ModInput MakeSafeRuleInstance(INode[] c) {\n";
            result += "return new TypizedDecorArray<" + G(i) + ">(c);\n";
            result += "}\n";
            result += "}\n";
            return result;
        }

        private static string MakeDecor(int i)
        {
            var result = "";
            result += "public class TypizedDecorArray<" + G(i) + "> : ModInput "+Where(i)+"{\n";
            for (var j = 0; j < i; j++)
                result += "public NodeDecorator<T" + j + "> " + Letters[j] + " { get; private set; } ";

            result += "public TypizedDecorArray(INode[] c){\n";
            for (var j = 0; j < i; j++)
                result += Letters[j] + "=new NodeDecorator<T" + j + ">(this,(T" + j + ")c[" + j + "]);\n";
            result += "}\n";
            result += "}\n";
            return result;
        }
            


        private static string MakeSelectRule(int i)
        {
            var r = "partial class SelectRule{\n";
            r += "public SelectWhereRule<" + G(i) + "> Where<" + G(i) + ">() "+Where(i)+"{ return Where<" + G(i) + ">(z=>true); }\n";
            r += "public SelectWhereRule<" + G(i) + "> Where<" + G(i) + ">(Func<TypizedNodeArray<" + G(i) + ">,bool> where) " + Where(i) + "{\n";
            r += "return new SelectWhereRule<" + G(i) + ">(this,sel=>{\n";
            r+=  "var tna=Typize<" + G(i) + ">(sel.SelectedNodes);\n";
            r += "if (tna==null) return null;\n";
            r += "tna.SelectResult=sel;\n";
            r += "return where(tna)?tna:null;\n});\n}\n\n";
            r += MakeTypizedNodeArray(i) + " Typize<" + G(i) +
                 ">(INode[] array) " + Where(i) + " { if (array==null) return null; var res=new " + MakeTypizedNodeArray(i) + "();\n";
            for (var j = 0; j < i; j++)
            {
                r += "if (!(array[" + j + "] is T" + j + ")) return null;\n";
                r += "res." + Letters[j] + "=(T" + j + ")array[" + j + "];\n";
            }
            r += "return res;\n}\n}\n";
            return r;
        }

        private static string MakeSelectWhereRule(int i)
        {
            var r = "";
            r += "public class SelectWhereRule<" + G(i) + "> : SelectWhereRule  "+Where(i)+" {\n";
            r += "Func<SelectOutput," + MakeTypizedNodeArray(i) + "> where;\n";
            r += "public SelectWhereRule(SelectRule selectRule, Func<SelectOutput," + MakeTypizedNodeArray(i) + "> where) : base(selectRule) { this.where=where;}\n";
            r += "public Rule Mod(Action<TypizedDecorArray<" + G(i) + ">> replace) {\n";
            r += "return new Rule(this.SelectRule.NewRule.Name,this.SelectRule.NewRule.Tags,this.SelectRule.Selector, z=>where(z),z=>replace((TypizedDecorArray<"+G(i)+">)z));\n}\n";
            r += "}\n\n";
            return r;
        }

        private static string MakeAll(string s)
        {
            return "namespace AIRLab.CA.Rules {\nusing System; \nusing Tree; \nusing Tools;\n" + s + "}";
        }

        private static string MakeCopyright(string text)
        {
            return "// ComputerAlgebra Library\n" +
                   "//\n" +
                   "// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013\n" +
                   "// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com\n" +
                   "//\n\n" + text;
        }

        static void TT(Action<int> make)
        { }

        static string MakeSelectClause(int li)
        {
            return
                "public static SelectClauseNode Any" + Letters[li] + " {  get { return new SelectClauseNode(" + li + ",LetterRecursionType.Subtree); }}\n" +
                "public static SelectClauseNode Child" + Letters[li] + " {  get { return new SelectClauseNode(" + li + ",LetterRecursionType.Children); }}\n" +
                "public static SelectClauseNode " + Letters[li] + " {  get { return new SelectClauseNode(" + li + ",LetterRecursionType.No); }}\n" +
             "";

        }

        static string MakeSelectClauses()
        {
            string res="public class SelectClauseWriter { \n";
            for (int i = 0; i < MaxLetter; i++)
                res += MakeSelectClause(i);
            res += "}\n";
            return res;

        }

        static string MakePredicate(String letter)
        {
            return "public static CABoolean "+letter+"(params int[] args) { return new CABoolean(); }\n";
        }

        static string MakeFunction(String letter)
        {
            return "public static int "+letter+"(params int[] args) { return 1; }\n";
        }

        static string MakeConstant(String letter)
        {
            return "public const int " +letter + "= "+NodeElementNames.GetConstantNames().IndexOf(letter)+";\n";
        }

        static string MakeLogicExpressions()
        {
            string res = "public class LogicExpressions {\n";
            foreach (String letter in NodeElementNames.GetPredicateNames())
            {
                res += MakePredicate(letter);
            }
            foreach (String letter in NodeElementNames.GetFunctionNames())
            {
                res += MakeFunction(letter);
            }
            foreach (String letter in NodeElementNames.GetConstantNames())
            {
                res += MakeConstant(letter);
            }
            res += "}\n";
            return res;
        }

        [STAThread]
        public static void Main()
        {
            TT(Console.WriteLine);
            var form = new Form();
            var tb = new TextBox {Dock = DockStyle.Fill, Multiline = true};
            form.Controls.Add(tb);
            form.Size = new System.Drawing.Size(800, 600);
            var text = "";
            for (var i = 1; i <= MaxLetter; i++)
            {
                text += MakeTypized(i);
                text += MakeDecor(i);
                text += MakeSelectRule(i);
                text += MakeSelectWhereRule(i);
            }
           text += MakeSelectClauses();
           text += MakeLogicExpressions();
            text = MakeAll(text);
            text = MakeCopyright(text);
            tb.Text = text.Replace("\n", "\r\n");
            tb.Select(0, text.Length*2);
            Application.Run(form);
        }
    }
}
