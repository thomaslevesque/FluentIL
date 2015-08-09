using System;
using System.Reflection;
using System.Reflection.Emit;

namespace FluentIL
{
    public interface IILLogger : IDisposable
    {
        void LogNoOperand(int offset, OpCode opCode, string comment = null);
        void Log(int offset, OpCode opCode, uint operand, string comment = null);
        void Log(int offset, OpCode opCode, int operand, string comment = null);
        void Log(int offset, OpCode opCode, long operand, string comment = null);
        void Log(int offset, OpCode opCode, byte operand, string comment = null);
        void Log(int offset, OpCode opCode, sbyte operand, string comment = null);
        void Log(int offset, OpCode opCode, double operand, string comment = null);
        void Log(int offset, OpCode opCode, float operand, string comment = null);
        void Log(int offset, OpCode opCode, string operand, string comment = null);
        void Log(int offset, OpCode opCode, Type operand, string comment = null);
        void Log(int offset, OpCode opCode, MemberInfo operand, string comment = null);
        void Log(int offset, OpCode opCode, LocalBuilder operand, string comment = null);
        void Log(int offset, OpCode opCode, Label operand, string comment = null);
        void Log(int offset, OpCode opCode, Label[] operand, string comment = null);

        void LogMeta(string text);
    }
}