using System;
using System.Diagnostics.SymbolStore;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace FluentIL
{
    public partial class FluentILGenerator : IFluentILGenerator
    {
        private readonly ILGenerator _generator;

        public FluentILGenerator(ILGenerator generator)
        {
            _generator = generator;
        }

        #region Scope methods

        public FluentILGenerator BeginCatchBlock(Type exceptionType)
        {
            _generator.BeginCatchBlock(exceptionType);
            return this;
        }

        public FluentILGenerator BeginExceptFilterBlock()
        {
            _generator.BeginExceptFilterBlock();
            return this;
        }

        public FluentILGenerator BeginFaultBlock()
        {
            _generator.BeginFaultBlock();
            return this;
        }

        public FluentILGenerator BeginFinallyBlock()
        {
            _generator.BeginFinallyBlock();
            return this;
        }

        public FluentILGenerator BeginScope()
        {
            _generator.BeginScope();
            return this;
        }

        public FluentILGenerator EndScope()
        {
            _generator.EndScope();
            return this;
        }

        public Label BeginExceptionBlock()
        {
            return _generator.BeginExceptionBlock();
        }

        public FluentILGenerator EndExceptionBlock()
        {
            _generator.EndExceptionBlock();
            return this;
        }

        #endregion

        #region Special case opcodes

        public FluentILGenerator Call(ConstructorInfo ctor)
        {
            _generator.Emit(OpCodes.Call, ctor);
            return this;
        }

        public FluentILGenerator Calli(
            CallingConventions callingConvention,
            Type returnType,
            Type[] parameterTypes,
            Type[] optionalParameterTypes)
        {
            _generator.EmitCalli(OpCodes.Calli, callingConvention, returnType, parameterTypes, optionalParameterTypes);
            return this;
        }

        public FluentILGenerator Calli(
            CallingConvention callingConvention,
            Type returnType,
            Type[] parameterTypes)
        {
            _generator.EmitCalli(OpCodes.Calli, callingConvention, returnType, parameterTypes);
            return this;
        }

        public FluentILGenerator CallVarargs(MethodInfo method, Type[] optionalParameterTypes)
        {
            _generator.EmitCall(OpCodes.Call, method, optionalParameterTypes);
            return this;
        }

        public FluentILGenerator CallvirtVarargs(MethodInfo method, Type[] optionalParameterTypes)
        {
            _generator.EmitCall(OpCodes.Callvirt, method, optionalParameterTypes);
            return this;
        }

        public FluentILGenerator NewobjVarargs(ConstructorInfo ctor, Type[] optionalParameterTypes)
        {
            var module = (ModuleBuilder) ctor.Module;
            var token = module.GetConstructorToken(ctor, optionalParameterTypes);
            _generator.Emit(OpCodes.Newobj, token.Token);
            return this;
        }

        public FluentILGenerator CallVarargs(ConstructorInfo ctor, Type[] optionalParameterTypes)
        {
            var module = (ModuleBuilder)ctor.Module;
            var token = module.GetConstructorToken(ctor, optionalParameterTypes);
            _generator.Emit(OpCodes.Call, token.Token);
            return this;
        }

        public FluentILGenerator Unaligned(byte alignment)
        {
            _generator.Emit(OpCodes.Unaligned, alignment);
            return this;
        }

        public FluentILGenerator Unaligned(Label alignment)
        {
            _generator.Emit(OpCodes.Unaligned, alignment);
            return this;
        }

        public FluentILGenerator Ldtoken(Type type)
        {
            _generator.Emit(OpCodes.Ldtoken, type);
            return this;
        }

        public FluentILGenerator Ldtoken(MethodInfo method)
        {
            _generator.Emit(OpCodes.Ldtoken, method);
            return this;
        }

        public FluentILGenerator Ldtoken(FieldInfo field)
        {
            _generator.Emit(OpCodes.Ldtoken, field);
            return this;
        }

        public FluentILGenerator Constrained(Type type)
        {
            _generator.Emit(OpCodes.Constrained, type);
            return this;
        }

        #endregion

        #region Misc

        public int ILOffset()
        {
            return _generator.ILOffset;
        }

        public FluentILGenerator UsingNamespace(string usingNamespace)
        {
            _generator.UsingNamespace(usingNamespace);
            return this;
        }

        public FluentILGenerator MarkLabel(Label label)
        {
            _generator.MarkLabel(label);
            return this;
        }

        public FluentILGenerator MarkSequencePoint(
            ISymbolDocumentWriter document,
            int startLine,
            int startColumn,
            int endLine,
            int endColumn)
        {
            _generator.MarkSequencePoint(document, startLine, startColumn, endLine, endColumn);
            return this;
        }

        public LocalBuilder DeclareLocal(Type localType)
        {
            return _generator.DeclareLocal(localType);
        }

        public LocalBuilder DeclareLocal(Type localType, bool pinned)
        {
            return _generator.DeclareLocal(localType, pinned);
        }

        public Label DefineLabel()
        {
            return _generator.DefineLabel();
        }

        public FluentILGenerator WriteLine(FieldInfo field)
        {
            _generator.EmitWriteLine(field);
            return this;
        }

        public FluentILGenerator WriteLine(LocalBuilder local)
        {
            _generator.EmitWriteLine(local);
            return this;
        }

        public FluentILGenerator WriteLine(string value)
        {
            _generator.EmitWriteLine(value);
            return this;
        }

        #endregion
    }
}
