using System;
using System.Reflection;
using System.Reflection.Emit;

namespace FluentIL
{
    partial interface IFluentILGenerator
    {
        IFluentILGenerator Nop();
        IFluentILGenerator Break();
        IFluentILGenerator Ldarg_0();
        IFluentILGenerator Ldarg_1();
        IFluentILGenerator Ldarg_2();
        IFluentILGenerator Ldarg_3();
        IFluentILGenerator Ldloc_0();
        IFluentILGenerator Ldloc_1();
        IFluentILGenerator Ldloc_2();
        IFluentILGenerator Ldloc_3();
        IFluentILGenerator Stloc_0();
        IFluentILGenerator Stloc_1();
        IFluentILGenerator Stloc_2();
        IFluentILGenerator Stloc_3();
        IFluentILGenerator Ldnull();
        IFluentILGenerator Ldc_I4_M1();
        IFluentILGenerator Ldc_I4_0();
        IFluentILGenerator Ldc_I4_1();
        IFluentILGenerator Ldc_I4_2();
        IFluentILGenerator Ldc_I4_3();
        IFluentILGenerator Ldc_I4_4();
        IFluentILGenerator Ldc_I4_5();
        IFluentILGenerator Ldc_I4_6();
        IFluentILGenerator Ldc_I4_7();
        IFluentILGenerator Ldc_I4_8();
        IFluentILGenerator Dup();
        IFluentILGenerator Pop();
        IFluentILGenerator Ret();
        IFluentILGenerator Ldind_I1();
        IFluentILGenerator Ldind_U1();
        IFluentILGenerator Ldind_I2();
        IFluentILGenerator Ldind_U2();
        IFluentILGenerator Ldind_I4();
        IFluentILGenerator Ldind_U4();
        IFluentILGenerator Ldind_I8();
        IFluentILGenerator Ldind_I();
        IFluentILGenerator Ldind_R4();
        IFluentILGenerator Ldind_R8();
        IFluentILGenerator Ldind_Ref();
        IFluentILGenerator Stind_Ref();
        IFluentILGenerator Stind_I1();
        IFluentILGenerator Stind_I2();
        IFluentILGenerator Stind_I4();
        IFluentILGenerator Stind_I8();
        IFluentILGenerator Stind_R4();
        IFluentILGenerator Stind_R8();
        IFluentILGenerator Add();
        IFluentILGenerator Sub();
        IFluentILGenerator Mul();
        IFluentILGenerator Div();
        IFluentILGenerator Div_Un();
        IFluentILGenerator Rem();
        IFluentILGenerator Rem_Un();
        IFluentILGenerator And();
        IFluentILGenerator Or();
        IFluentILGenerator Xor();
        IFluentILGenerator Shl();
        IFluentILGenerator Shr();
        IFluentILGenerator Shr_Un();
        IFluentILGenerator Neg();
        IFluentILGenerator Not();
        IFluentILGenerator Conv_I1();
        IFluentILGenerator Conv_I2();
        IFluentILGenerator Conv_I4();
        IFluentILGenerator Conv_I8();
        IFluentILGenerator Conv_R4();
        IFluentILGenerator Conv_R8();
        IFluentILGenerator Conv_U4();
        IFluentILGenerator Conv_U8();
        IFluentILGenerator Conv_R_Un();
        IFluentILGenerator Throw();
        IFluentILGenerator Conv_Ovf_I1_Un();
        IFluentILGenerator Conv_Ovf_I2_Un();
        IFluentILGenerator Conv_Ovf_I4_Un();
        IFluentILGenerator Conv_Ovf_I8_Un();
        IFluentILGenerator Conv_Ovf_U1_Un();
        IFluentILGenerator Conv_Ovf_U2_Un();
        IFluentILGenerator Conv_Ovf_U4_Un();
        IFluentILGenerator Conv_Ovf_U8_Un();
        IFluentILGenerator Conv_Ovf_I_Un();
        IFluentILGenerator Conv_Ovf_U_Un();
        IFluentILGenerator Ldlen();
        IFluentILGenerator Ldelem_I1();
        IFluentILGenerator Ldelem_U1();
        IFluentILGenerator Ldelem_I2();
        IFluentILGenerator Ldelem_U2();
        IFluentILGenerator Ldelem_I4();
        IFluentILGenerator Ldelem_U4();
        IFluentILGenerator Ldelem_I8();
        IFluentILGenerator Ldelem_I();
        IFluentILGenerator Ldelem_R4();
        IFluentILGenerator Ldelem_R8();
        IFluentILGenerator Ldelem_Ref();
        IFluentILGenerator Stelem_I();
        IFluentILGenerator Stelem_I1();
        IFluentILGenerator Stelem_I2();
        IFluentILGenerator Stelem_I4();
        IFluentILGenerator Stelem_I8();
        IFluentILGenerator Stelem_R4();
        IFluentILGenerator Stelem_R8();
        IFluentILGenerator Stelem_Ref();
        IFluentILGenerator Conv_Ovf_I1();
        IFluentILGenerator Conv_Ovf_U1();
        IFluentILGenerator Conv_Ovf_I2();
        IFluentILGenerator Conv_Ovf_U2();
        IFluentILGenerator Conv_Ovf_I4();
        IFluentILGenerator Conv_Ovf_U4();
        IFluentILGenerator Conv_Ovf_I8();
        IFluentILGenerator Conv_Ovf_U8();
        IFluentILGenerator Ckfinite();
        IFluentILGenerator Conv_U2();
        IFluentILGenerator Conv_U1();
        IFluentILGenerator Conv_I();
        IFluentILGenerator Conv_Ovf_I();
        IFluentILGenerator Conv_Ovf_U();
        IFluentILGenerator Add_Ovf();
        IFluentILGenerator Add_Ovf_Un();
        IFluentILGenerator Mul_Ovf();
        IFluentILGenerator Mul_Ovf_Un();
        IFluentILGenerator Sub_Ovf();
        IFluentILGenerator Sub_Ovf_Un();
        IFluentILGenerator Endfinally();
        IFluentILGenerator Stind_I();
        IFluentILGenerator Conv_U();
        IFluentILGenerator Prefix7();
        IFluentILGenerator Prefix6();
        IFluentILGenerator Prefix5();
        IFluentILGenerator Prefix4();
        IFluentILGenerator Prefix3();
        IFluentILGenerator Prefix2();
        IFluentILGenerator Prefix1();
        IFluentILGenerator Prefixref();
        IFluentILGenerator Arglist();
        IFluentILGenerator Ceq();
        IFluentILGenerator Cgt();
        IFluentILGenerator Cgt_Un();
        IFluentILGenerator Clt();
        IFluentILGenerator Clt_Un();
        IFluentILGenerator Localloc();
        IFluentILGenerator Endfilter();
        IFluentILGenerator Volatile();
        IFluentILGenerator Tailcall();
        IFluentILGenerator Cpblk();
        IFluentILGenerator Initblk();
        IFluentILGenerator Rethrow();
        IFluentILGenerator Refanytype();
        IFluentILGenerator Readonly();
        IFluentILGenerator Ldc_I4(int value);
        IFluentILGenerator Ldc_I8(long value);
        IFluentILGenerator Ldc_I4_S(sbyte value);
        IFluentILGenerator Ldc_R8(double value);
        IFluentILGenerator Ldc_R4(float value);
        IFluentILGenerator Ldarg(uint value);
        IFluentILGenerator Ldarga(uint value);
        IFluentILGenerator Starg(uint value);
        IFluentILGenerator Ldloc(uint value);
        IFluentILGenerator Ldloca(uint value);
        IFluentILGenerator Stloc(uint value);
        IFluentILGenerator Ldarg_S(byte value);
        IFluentILGenerator Ldarga_S(byte value);
        IFluentILGenerator Starg_S(byte value);
        IFluentILGenerator Ldloc_S(byte value);
        IFluentILGenerator Ldloca_S(byte value);
        IFluentILGenerator Stloc_S(byte value);
        IFluentILGenerator Ldarg(LocalBuilder value);
        IFluentILGenerator Ldarga(LocalBuilder value);
        IFluentILGenerator Starg(LocalBuilder value);
        IFluentILGenerator Ldloc(LocalBuilder value);
        IFluentILGenerator Ldloca(LocalBuilder value);
        IFluentILGenerator Stloc(LocalBuilder value);
        IFluentILGenerator Ldarg_S(LocalBuilder value);
        IFluentILGenerator Ldarga_S(LocalBuilder value);
        IFluentILGenerator Starg_S(LocalBuilder value);
        IFluentILGenerator Ldloc_S(LocalBuilder value);
        IFluentILGenerator Ldloca_S(LocalBuilder value);
        IFluentILGenerator Stloc_S(LocalBuilder value);
        IFluentILGenerator Br(Label value);
        IFluentILGenerator Brfalse(Label value);
        IFluentILGenerator Brtrue(Label value);
        IFluentILGenerator Beq(Label value);
        IFluentILGenerator Bge(Label value);
        IFluentILGenerator Bgt(Label value);
        IFluentILGenerator Ble(Label value);
        IFluentILGenerator Blt(Label value);
        IFluentILGenerator Bne_Un(Label value);
        IFluentILGenerator Bge_Un(Label value);
        IFluentILGenerator Bgt_Un(Label value);
        IFluentILGenerator Ble_Un(Label value);
        IFluentILGenerator Blt_Un(Label value);
        IFluentILGenerator Leave(Label value);
        IFluentILGenerator Br_S(Label value);
        IFluentILGenerator Brfalse_S(Label value);
        IFluentILGenerator Brtrue_S(Label value);
        IFluentILGenerator Beq_S(Label value);
        IFluentILGenerator Bge_S(Label value);
        IFluentILGenerator Bgt_S(Label value);
        IFluentILGenerator Ble_S(Label value);
        IFluentILGenerator Blt_S(Label value);
        IFluentILGenerator Bne_Un_S(Label value);
        IFluentILGenerator Bge_Un_S(Label value);
        IFluentILGenerator Bgt_Un_S(Label value);
        IFluentILGenerator Ble_Un_S(Label value);
        IFluentILGenerator Blt_Un_S(Label value);
        IFluentILGenerator Leave_S(Label value);
        IFluentILGenerator Switch(Label[] value);
        IFluentILGenerator Unbox(Type value);
        IFluentILGenerator Stobj(Type value);
        IFluentILGenerator Box(Type value);
        IFluentILGenerator Refanyval(Type value);
        IFluentILGenerator Mkrefany(Type value);
        IFluentILGenerator Sizeof(Type value);
        IFluentILGenerator Jmp(MethodInfo value);
        IFluentILGenerator Call(MethodInfo value);
        IFluentILGenerator Ldftn(MethodInfo value);
        IFluentILGenerator Ldvirtftn(MethodInfo value);
        IFluentILGenerator Cpobj(Type value);
        IFluentILGenerator Ldobj(Type value);
        IFluentILGenerator Castclass(Type value);
        IFluentILGenerator Isinst(Type value);
        IFluentILGenerator Newarr(Type value);
        IFluentILGenerator Ldelema(Type value);
        IFluentILGenerator Ldelem(Type value);
        IFluentILGenerator Stelem(Type value);
        IFluentILGenerator Unbox_Any(Type value);
        IFluentILGenerator Initobj(Type value);
        IFluentILGenerator Callvirt(MethodInfo value);
        IFluentILGenerator Newobj(MethodInfo value);
        IFluentILGenerator Ldfld(FieldInfo value);
        IFluentILGenerator Ldflda(FieldInfo value);
        IFluentILGenerator Stfld(FieldInfo value);
        IFluentILGenerator Ldsfld(FieldInfo value);
        IFluentILGenerator Ldsflda(FieldInfo value);
        IFluentILGenerator Stsfld(FieldInfo value);
        IFluentILGenerator Ldstr(string value);
    }
}
