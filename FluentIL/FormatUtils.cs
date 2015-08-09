using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace FluentIL
{
    static class FormatUtils
    {
        public static string FormatHex(byte value) => $"{value:X2}";
        public static string FormatHex(sbyte value) => $"{value:X2}";
        public static string FormatHex(int value) => string.Join(" ", BitConverter.GetBytes(value).Select(b => $"{b:X2}"));
        public static string FormatHex(uint value) => string.Join(" ", BitConverter.GetBytes(value).Select(b => $"{b:X2}"));
        public static string FormatHex(long value) => string.Join(" ", BitConverter.GetBytes(value).Select(b => $"{b:X2}"));
        public static string FormatHex(float value) => $"{value:X2}";
        public static string FormatHex(double value) => $"{value:X2}";

        public static string FormatOffset(int offset) => $"IL_{offset:X4}";

        public static string FormatType(Type type)
        {
            string shortAssemblyName = type.Assembly.GetName().Name;
            return $"[{shortAssemblyName}]{type.FullName}";
        }

        public static string FormatMember(MemberInfo member)
        {
            string declaringType =
                member.DeclaringType != null
                    ? FormatType(member.DeclaringType)
                    : "(dynamic)";
            return $"{FormatType(member.DeclaringType)}.{member.Name}}}";
        }

        public static string FormatLabel(Label label) => $"#{label.GetHashCode()}";

        public static string FormatLocal(LocalBuilder local)
            => $"local {local.LocalIndex}: {local.LocalType.FullName}{(local.IsPinned ? " (pinned)" : "")}";
    }
}
