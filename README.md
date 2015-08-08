FluentIL
========

A thin fluent wrapper around `System.Reflection.Emit.ILGenerator` for generating IL code dynamically.

`ILGenerator` has a pretty basic API; aside from a few helper methods, all you have to work with is a number of overloads of the `Emit` method, where you pass the opcode and the operand. There is no indication of which type of operand you should pass for which opcode, you have to look at the documentation.

Also, the code is pretty verbose. For instance, if you want to generate the body for very basic constructor that just stores its parameter in a field, you end up with this code:

    var il = ctor.GetILGenerator();
    il.Emit(OpCodes.Ldarg_0);
    il.Emit(OpCodes.Call, typeof(object).GetConstructor(Type.EmptyTypes));
    il.Emit(OpCodes.Ldarg_0);
    il.Emit(OpCodes.Ldarg_1);
    il.Emit(OpCodes.Stfld, field);
    il.Emit(OpCodes.Ret);
    
FluentIL lets you write this instead:

    ctor.GetILGenerator().Fluent()
        .Ldarg_0().Call(typeof(object).GetConstructor(Type.EmptyTypes))
        .Ldarg_0().Ldarg_1().Stfld(field)
        .Ret();

