using System.Text;

namespace Codegen
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendFormatedLine(this StringBuilder sb, string format, params object[] args)
        {
            sb.AppendFormat(format, args);
            return sb.AppendLine();
        }
    }
}
