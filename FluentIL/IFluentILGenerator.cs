using System;
using System.Diagnostics.SymbolStore;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace FluentIL
{
    public partial interface IFluentILGenerator
    {
        IFluentILGenerator BeginCatchBlock(Type exceptionType);
        IFluentILGenerator BeginExceptFilterBlock();
        IFluentILGenerator BeginFaultBlock();
        IFluentILGenerator BeginFinallyBlock();
        IFluentILGenerator BeginScope();
        IFluentILGenerator EndScope();
        Label BeginExceptionBlock();
        IFluentILGenerator EndExceptionBlock();
        IFluentILGenerator Call(ConstructorInfo ctor);

        IFluentILGenerator Calli(
            CallingConventions callingConvention,
            Type returnType,
            Type[] parameterTypes,
            Type[] optionalParameterTypes);

        IFluentILGenerator Calli(
            CallingConvention callingConvention,
            Type returnType,
            Type[] parameterTypes);

        IFluentILGenerator CallVarargs(MethodInfo method, Type[] optionalParameterTypes);
        IFluentILGenerator CallvirtVarargs(MethodInfo method, Type[] optionalParameterTypes);
        IFluentILGenerator NewobjVarargs(ConstructorInfo ctor, Type[] optionalParameterTypes);
        IFluentILGenerator CallVarargs(ConstructorInfo ctor, Type[] optionalParameterTypes);
        IFluentILGenerator Unaligned(byte alignment);
        IFluentILGenerator Unaligned(Label alignment);
        IFluentILGenerator Ldtoken(Type type);
        IFluentILGenerator Ldtoken(MethodInfo method);
        IFluentILGenerator Ldtoken(FieldInfo field);
        IFluentILGenerator Constrained(Type type);
        int ILOffset { get; }
        IFluentILGenerator UsingNamespace(string usingNamespace);
        IFluentILGenerator MarkLabel(Label label);

        IFluentILGenerator MarkSequencePoint(
            ISymbolDocumentWriter document,
            int startLine,
            int startColumn,
            int endLine,
            int endColumn);

        LocalBuilder DeclareLocal(Type localType);
        LocalBuilder DeclareLocal(Type localType, bool pinned);
        Label DefineLabel();

        // Logging not working properly yet
        //IFluentILGenerator WriteLine(FieldInfo field);
        //IFluentILGenerator WriteLine(LocalBuilder local);
        //IFluentILGenerator WriteLine(string value);
    }
}
