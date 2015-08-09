using System;
using System.Diagnostics.SymbolStore;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using static FluentIL.FormatUtils;

namespace FluentIL
{
    public partial class FluentILGenerator : IFluentILGenerator
    {
        private readonly ILGenerator _generator;
        private readonly IILLogger _logger;

        public FluentILGenerator(ILGenerator generator, IILLogger logger = null)
        {
            if (generator == null) throw new ArgumentNullException(nameof(generator));
            _generator = generator;
            _logger = logger;
        }

        #region Scope methods

        public IFluentILGenerator BeginCatchBlock(Type exceptionType)
        {
            if (exceptionType == null)
            {
                _logger.LogMeta("{ // handler");
            }
            else
            {
                _logger?.LogMeta($"catch({FormatType(exceptionType)})");
                _logger?.LogMeta("{");
            }
            _generator.BeginCatchBlock(exceptionType);
            return this;
        }

        public IFluentILGenerator BeginExceptFilterBlock()
        {
            _logger?.LogMeta("filter");
            _logger?.LogMeta("{");
            _generator.BeginExceptFilterBlock();
            return this;
        }

        public IFluentILGenerator BeginFaultBlock()
        {
            _logger?.LogMeta("fault");
            _logger?.LogMeta("{");
            _generator.BeginFaultBlock();
            return this;
        }

        public IFluentILGenerator BeginFinallyBlock()
        {
            _logger?.LogMeta("finally");
            _logger?.LogMeta("{");
            _generator.BeginFinallyBlock();
            return this;
        }

        public IFluentILGenerator BeginScope()
        {
            _logger?.LogMeta("{");
            _generator.BeginScope();
            return this;
        }

        public IFluentILGenerator EndScope()
        {
            _logger?.LogMeta("} // end scope");
            _generator.EndScope();
            return this;
        }

        public Label BeginExceptionBlock()
        {
            _logger?.LogMeta(".try");
            _logger?.LogMeta("{");
            return _generator.BeginExceptionBlock();
        }

        public IFluentILGenerator EndExceptionBlock()
        {
            _logger?.LogMeta("} // end .try");
            _generator.EndExceptionBlock();
            return this;
        }

        #endregion

        #region Special case opcodes

        public IFluentILGenerator Call(ConstructorInfo ctor)
        {
            _logger?.Log(ILOffset, OpCodes.Call, ctor);
            _generator.Emit(OpCodes.Call, ctor);
            return this;
        }

        public IFluentILGenerator Calli(
            CallingConventions callingConvention,
            Type returnType,
            Type[] parameterTypes,
            Type[] optionalParameterTypes)
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Calli, "indirect");
            _generator.EmitCalli(OpCodes.Calli, callingConvention, returnType, parameterTypes, optionalParameterTypes);
            return this;
        }

        public IFluentILGenerator Calli(
            CallingConvention callingConvention,
            Type returnType,
            Type[] parameterTypes)
        {
            _logger?.Log(ILOffset, OpCodes.Calli, "indirect");
            _generator.EmitCalli(OpCodes.Calli, callingConvention, returnType, parameterTypes);
            return this;
        }

        public IFluentILGenerator CallVarargs(MethodInfo method, Type[] optionalParameterTypes)
        {
            _logger?.Log(ILOffset, OpCodes.Call, method, "varargs");
            _generator.EmitCall(OpCodes.Call, method, optionalParameterTypes);
            return this;
        }

        public IFluentILGenerator CallvirtVarargs(MethodInfo method, Type[] optionalParameterTypes)
        {
            _logger?.Log(ILOffset, OpCodes.Callvirt, method, "varargs");
            _generator.EmitCall(OpCodes.Callvirt, method, optionalParameterTypes);
            return this;
        }

        public IFluentILGenerator NewobjVarargs(ConstructorInfo ctor, Type[] optionalParameterTypes)
        {
            var module = (ModuleBuilder) ctor.Module;
            var token = module.GetConstructorToken(ctor, optionalParameterTypes);
            _logger?.Log(ILOffset, OpCodes.Newobj, ctor, "varargs");
            _generator.Emit(OpCodes.Newobj, token.Token);
            return this;
        }

        public IFluentILGenerator CallVarargs(ConstructorInfo ctor, Type[] optionalParameterTypes)
        {
            var module = (ModuleBuilder)ctor.Module;
            var token = module.GetConstructorToken(ctor, optionalParameterTypes);
            _logger?.Log(ILOffset, OpCodes.Call, ctor, "varargs");
            _generator.Emit(OpCodes.Call, token.Token);
            return this;
        }

        public IFluentILGenerator Unaligned(byte alignment)
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Unaligned);
            _generator.Emit(OpCodes.Unaligned, alignment);
            return this;
        }

        public IFluentILGenerator Unaligned(Label alignment)
        {
            _logger?.Log(ILOffset, OpCodes.Unaligned, alignment);
            _generator.Emit(OpCodes.Unaligned, alignment);
            return this;
        }

        public IFluentILGenerator Ldtoken(Type type)
        {
            _logger?.Log(ILOffset, OpCodes.Ldtoken, type);
            _generator.Emit(OpCodes.Ldtoken, type);
            return this;
        }

        public IFluentILGenerator Ldtoken(MethodInfo method)
        {
            _logger?.Log(ILOffset, OpCodes.Ldtoken, method);
            _generator.Emit(OpCodes.Ldtoken, method);
            return this;
        }

        public IFluentILGenerator Ldtoken(FieldInfo field)
        {
            _logger?.Log(ILOffset, OpCodes.Ldtoken, field);
            _generator.Emit(OpCodes.Ldtoken, field);
            return this;
        }

        public IFluentILGenerator Constrained(Type type)
        {
            _logger?.Log(ILOffset, OpCodes.Constrained, type);
            _generator.Emit(OpCodes.Constrained, type);
            return this;
        }

        #endregion

        #region Misc

        public int ILOffset => _generator.ILOffset;
       

        public IFluentILGenerator UsingNamespace(string usingNamespace)
        {
            _logger?.LogMeta($"// using {usingNamespace}");
            _generator.UsingNamespace(usingNamespace);
            return this;
        }

        public IFluentILGenerator MarkLabel(Label label)
        {
            _logger.LogMeta($"// label {FormatLabel(label)}");
            _generator.MarkLabel(label);
            return this;
        }

        public IFluentILGenerator MarkSequencePoint(
            ISymbolDocumentWriter document,
            int startLine,
            int startColumn,
            int endLine,
            int endColumn)
        {
            _logger.LogMeta($"// ({startLine}, {startColumn}) - ({endLine}-{endColumn})");
            _generator.MarkSequencePoint(document, startLine, startColumn, endLine, endColumn);
            return this;
        }

        public LocalBuilder DeclareLocal(Type localType)
        {
            var local = _generator.DeclareLocal(localType);
            _logger?.LogMeta($"// {FormatLocal(local)}");
            return local;
        }

        public LocalBuilder DeclareLocal(Type localType, bool pinned)
        {
            var local = _generator.DeclareLocal(localType, pinned);
            _logger?.LogMeta($"// {FormatLocal(local)}");
            return local;
        }

        public Label DefineLabel()
        {
            return _generator.DefineLabel();
        }

        // TODO: improve logging for WriteLine
        // The actual EmitWriteLine is probably smarter than that and uses ldloc.<n> when possible
        // So this will show an incorrect offset

        //public IFluentILGenerator WriteLine(FieldInfo field)
        //{
        //    _logger.Log(ILOffset, OpCodes.Ldfld, field);
        //    LogConsoleWriteLine(OpCodes.Ldfld, field.FieldType);
        //    _generator.EmitWriteLine(field);
        //    return this;
        //}

        //public IFluentILGenerator WriteLine(LocalBuilder local)
        //{
        //    _logger.Log(ILOffset, OpCodes.Ldloc, local);
        //    LogConsoleWriteLine(OpCodes.Ldloc, local.LocalType);
        //    _generator.EmitWriteLine(local);
        //    return this;
        //}

        //public IFluentILGenerator WriteLine(string value)
        //{
        //    _logger.Log(ILOffset, OpCodes.Ldstr, value);
        //    LogConsoleWriteLine(OpCodes.Ldstr, typeof(string));
        //    _generator.EmitWriteLine(value);
        //    return this;
        //}

        //private void LogConsoleWriteLine(OpCode previousOpCode, Type argumentType)
        //{
        //    _logger.Log(ILOffset + previousOpCode.Size, OpCodes.Call, ConsoleWriteLineCache.GetMethodForType(argumentType));
        //}

        //static class ConsoleWriteLineCache
        //{
        //    private static readonly Dictionary<Type, MethodInfo> _cache;
        //    static ConsoleWriteLineCache()
        //    {
        //        var methods =
        //            from m in typeof (Console).GetMethods()
        //            where m.IsStatic && m.IsPublic
        //            let parameters = m.GetParameters()
        //            where parameters.Length == 1
        //            select new {parameters[0].ParameterType, Method = m};
        //        _cache = methods.ToDictionary(m => m.ParameterType, m => m.Method);
        //    }

        //    public static MethodInfo GetMethodForType(Type type)
        //    {
        //        while (type != null)
        //        {
        //            MethodInfo method;
        //            if (_cache.TryGetValue(type, out method))
        //                return method;
        //            type = type.BaseType;
        //        }
        //        return null; // will never happen, since there is an overload that takes an Object
        //    }
        //}

        #endregion
    }
}
