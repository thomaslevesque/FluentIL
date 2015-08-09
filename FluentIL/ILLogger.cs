using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using static FluentIL.FormatUtils;

namespace FluentIL
{
    class ILLogger : IILLogger
    {
        private readonly TextWriter _writer;

        public ILLogger(TextWriter writer)
        {
            if (writer == null) throw new ArgumentNullException(nameof(writer));
            _writer = writer;
        }

        public void LogNoOperand(int offset, OpCode opCode, string comment = null)
        {
            LogInternal(offset, opCode, null, comment);
        }

        public void Log(int offset, OpCode opCode, uint operand, string comment = null)
        {
            LogInternal(offset, opCode, FormatHex(operand), comment);
        }

        public void Log(int offset, OpCode opCode, int operand, string comment = null)
        {
            LogInternal(offset, opCode, FormatHex(operand), comment);
        }

        public void Log(int offset, OpCode opCode, long operand, string comment = null)
        {
            LogInternal(offset, opCode, FormatHex(operand), comment);
        }

        public void Log(int offset, OpCode opCode, byte operand, string comment = null)
        {
            LogInternal(offset, opCode, FormatHex(operand), comment);
        }

        public void Log(int offset, OpCode opCode, sbyte operand, string comment = null)
        {
            LogInternal(offset, opCode, FormatHex(operand), comment);
        }

        public void Log(int offset, OpCode opCode, double operand, string comment = null)
        {
            LogInternal(offset, opCode, FormatHex(operand), comment);
        }

        public void Log(int offset, OpCode opCode, float operand, string comment = null)
        {
            LogInternal(offset, opCode, FormatHex(operand), comment);
        }

        public void Log(int offset, OpCode opCode, string operand, string comment = null)
        {
            LogInternal(offset, opCode, $"\"{operand.Replace("\"", "\\\"")}\"", comment);
        }

        public void Log(int offset, OpCode opCode, Type operand, string comment = null)
        {
            LogInternal(offset, opCode, FormatType(operand), comment);
        }

        public void Log(int offset, OpCode opCode, MemberInfo operand, string comment = null)
        {
            LogInternal(offset, opCode, FormatMember(operand), comment);
        }

        public void Log(int offset, OpCode opCode, LocalBuilder operand, string comment = null)
        {
            LogInternal(offset, opCode, FormatHex(operand.LocalIndex), comment);
        }

        public void Log(int offset, OpCode opCode, Label operand, string comment = null)
        {
            // The Label's offset is not exposed (and might not yet be known), so we just show its index
            LogInternal(offset, opCode, FormatLabel(operand), comment);
        }

        public void Log(int offset, OpCode opCode, Label[] operand, string comment = null)
        {
            string offsets = string.Join(", ", operand.Select(lbl => FormatOffset(lbl.GetHashCode())));
            LogInternal(offset, opCode, $"({offsets})", comment);
        }

        public void LogMeta(string text)
        {
            _writer.WriteLine($"  {text}");
        }

        public void Dispose()
        {
            _writer.Dispose();
        }

        private void LogInternal(int offset, OpCode opCode, string operandString, string comment)
        {
            _writer.WriteLine($"    {FormatOffset(offset)}:  {opCode.Name,-12}{operandString}  // {comment}");
        }
    }
}
