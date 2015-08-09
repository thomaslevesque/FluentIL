using System;
using System.Diagnostics.SymbolStore;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace FluentIL
{
    public partial interface IFluentILGenerator
    {
        FluentILGenerator BeginCatchBlock(Type exceptionType);
        FluentILGenerator BeginExceptFilterBlock();
        FluentILGenerator BeginFaultBlock();
        FluentILGenerator BeginFinallyBlock();
        FluentILGenerator BeginScope();
        FluentILGenerator EndScope();
        Label BeginExceptionBlock();
        FluentILGenerator EndExceptionBlock();
        FluentILGenerator Call(ConstructorInfo ctor);

        FluentILGenerator Calli(
            CallingConventions callingConvention,
            Type returnType,
            Type[] parameterTypes,
            Type[] optionalParameterTypes);

        FluentILGenerator Calli(
            CallingConvention callingConvention,
            Type returnType,
            Type[] parameterTypes);

        FluentILGenerator CallVarargs(MethodInfo method, Type[] optionalParameterTypes);
        FluentILGenerator CallvirtVarargs(MethodInfo method, Type[] optionalParameterTypes);
        FluentILGenerator NewobjVarargs(ConstructorInfo ctor, Type[] optionalParameterTypes);
        FluentILGenerator CallVarargs(ConstructorInfo ctor, Type[] optionalParameterTypes);
        FluentILGenerator Unaligned(byte alignment);
        FluentILGenerator Unaligned(Label alignment);
        FluentILGenerator Ldtoken(Type type);
        FluentILGenerator Ldtoken(MethodInfo method);
        FluentILGenerator Ldtoken(FieldInfo field);
        FluentILGenerator Constrained(Type type);
        int ILOffset();
        FluentILGenerator UsingNamespace(string usingNamespace);
        FluentILGenerator MarkLabel(Label label);

        FluentILGenerator MarkSequencePoint(
            ISymbolDocumentWriter document,
            int startLine,
            int startColumn,
            int endLine,
            int endColumn);

        LocalBuilder DeclareLocal(Type localType);
        LocalBuilder DeclareLocal(Type localType, bool pinned);
        Label DefineLabel();
        FluentILGenerator WriteLine(FieldInfo field);
        FluentILGenerator WriteLine(LocalBuilder local);
        FluentILGenerator WriteLine(string value);
    }
}
