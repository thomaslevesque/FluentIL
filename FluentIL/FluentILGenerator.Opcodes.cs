using System;
using System.Reflection;
using System.Reflection.Emit;

namespace FluentIL
{
	public partial class FluentILGenerator
	{
		public FluentILGenerator Nop()
		{
			_generator.Emit(OpCodes.Nop);
			return this;
		}
		public FluentILGenerator Break()
		{
			_generator.Emit(OpCodes.Break);
			return this;
		}
		public FluentILGenerator Ldarg_0()
		{
			_generator.Emit(OpCodes.Ldarg_0);
			return this;
		}
		public FluentILGenerator Ldarg_1()
		{
			_generator.Emit(OpCodes.Ldarg_1);
			return this;
		}
		public FluentILGenerator Ldarg_2()
		{
			_generator.Emit(OpCodes.Ldarg_2);
			return this;
		}
		public FluentILGenerator Ldarg_3()
		{
			_generator.Emit(OpCodes.Ldarg_3);
			return this;
		}
		public FluentILGenerator Ldloc_0()
		{
			_generator.Emit(OpCodes.Ldloc_0);
			return this;
		}
		public FluentILGenerator Ldloc_1()
		{
			_generator.Emit(OpCodes.Ldloc_1);
			return this;
		}
		public FluentILGenerator Ldloc_2()
		{
			_generator.Emit(OpCodes.Ldloc_2);
			return this;
		}
		public FluentILGenerator Ldloc_3()
		{
			_generator.Emit(OpCodes.Ldloc_3);
			return this;
		}
		public FluentILGenerator Stloc_0()
		{
			_generator.Emit(OpCodes.Stloc_0);
			return this;
		}
		public FluentILGenerator Stloc_1()
		{
			_generator.Emit(OpCodes.Stloc_1);
			return this;
		}
		public FluentILGenerator Stloc_2()
		{
			_generator.Emit(OpCodes.Stloc_2);
			return this;
		}
		public FluentILGenerator Stloc_3()
		{
			_generator.Emit(OpCodes.Stloc_3);
			return this;
		}
		public FluentILGenerator Ldnull()
		{
			_generator.Emit(OpCodes.Ldnull);
			return this;
		}
		public FluentILGenerator Ldc_I4_M1()
		{
			_generator.Emit(OpCodes.Ldc_I4_M1);
			return this;
		}
		public FluentILGenerator Ldc_I4_0()
		{
			_generator.Emit(OpCodes.Ldc_I4_0);
			return this;
		}
		public FluentILGenerator Ldc_I4_1()
		{
			_generator.Emit(OpCodes.Ldc_I4_1);
			return this;
		}
		public FluentILGenerator Ldc_I4_2()
		{
			_generator.Emit(OpCodes.Ldc_I4_2);
			return this;
		}
		public FluentILGenerator Ldc_I4_3()
		{
			_generator.Emit(OpCodes.Ldc_I4_3);
			return this;
		}
		public FluentILGenerator Ldc_I4_4()
		{
			_generator.Emit(OpCodes.Ldc_I4_4);
			return this;
		}
		public FluentILGenerator Ldc_I4_5()
		{
			_generator.Emit(OpCodes.Ldc_I4_5);
			return this;
		}
		public FluentILGenerator Ldc_I4_6()
		{
			_generator.Emit(OpCodes.Ldc_I4_6);
			return this;
		}
		public FluentILGenerator Ldc_I4_7()
		{
			_generator.Emit(OpCodes.Ldc_I4_7);
			return this;
		}
		public FluentILGenerator Ldc_I4_8()
		{
			_generator.Emit(OpCodes.Ldc_I4_8);
			return this;
		}
		public FluentILGenerator Dup()
		{
			_generator.Emit(OpCodes.Dup);
			return this;
		}
		public FluentILGenerator Pop()
		{
			_generator.Emit(OpCodes.Pop);
			return this;
		}
		public FluentILGenerator Ret()
		{
			_generator.Emit(OpCodes.Ret);
			return this;
		}
		public FluentILGenerator Ldind_I1()
		{
			_generator.Emit(OpCodes.Ldind_I1);
			return this;
		}
		public FluentILGenerator Ldind_U1()
		{
			_generator.Emit(OpCodes.Ldind_U1);
			return this;
		}
		public FluentILGenerator Ldind_I2()
		{
			_generator.Emit(OpCodes.Ldind_I2);
			return this;
		}
		public FluentILGenerator Ldind_U2()
		{
			_generator.Emit(OpCodes.Ldind_U2);
			return this;
		}
		public FluentILGenerator Ldind_I4()
		{
			_generator.Emit(OpCodes.Ldind_I4);
			return this;
		}
		public FluentILGenerator Ldind_U4()
		{
			_generator.Emit(OpCodes.Ldind_U4);
			return this;
		}
		public FluentILGenerator Ldind_I8()
		{
			_generator.Emit(OpCodes.Ldind_I8);
			return this;
		}
		public FluentILGenerator Ldind_I()
		{
			_generator.Emit(OpCodes.Ldind_I);
			return this;
		}
		public FluentILGenerator Ldind_R4()
		{
			_generator.Emit(OpCodes.Ldind_R4);
			return this;
		}
		public FluentILGenerator Ldind_R8()
		{
			_generator.Emit(OpCodes.Ldind_R8);
			return this;
		}
		public FluentILGenerator Ldind_Ref()
		{
			_generator.Emit(OpCodes.Ldind_Ref);
			return this;
		}
		public FluentILGenerator Stind_Ref()
		{
			_generator.Emit(OpCodes.Stind_Ref);
			return this;
		}
		public FluentILGenerator Stind_I1()
		{
			_generator.Emit(OpCodes.Stind_I1);
			return this;
		}
		public FluentILGenerator Stind_I2()
		{
			_generator.Emit(OpCodes.Stind_I2);
			return this;
		}
		public FluentILGenerator Stind_I4()
		{
			_generator.Emit(OpCodes.Stind_I4);
			return this;
		}
		public FluentILGenerator Stind_I8()
		{
			_generator.Emit(OpCodes.Stind_I8);
			return this;
		}
		public FluentILGenerator Stind_R4()
		{
			_generator.Emit(OpCodes.Stind_R4);
			return this;
		}
		public FluentILGenerator Stind_R8()
		{
			_generator.Emit(OpCodes.Stind_R8);
			return this;
		}
		public FluentILGenerator Add()
		{
			_generator.Emit(OpCodes.Add);
			return this;
		}
		public FluentILGenerator Sub()
		{
			_generator.Emit(OpCodes.Sub);
			return this;
		}
		public FluentILGenerator Mul()
		{
			_generator.Emit(OpCodes.Mul);
			return this;
		}
		public FluentILGenerator Div()
		{
			_generator.Emit(OpCodes.Div);
			return this;
		}
		public FluentILGenerator Div_Un()
		{
			_generator.Emit(OpCodes.Div_Un);
			return this;
		}
		public FluentILGenerator Rem()
		{
			_generator.Emit(OpCodes.Rem);
			return this;
		}
		public FluentILGenerator Rem_Un()
		{
			_generator.Emit(OpCodes.Rem_Un);
			return this;
		}
		public FluentILGenerator And()
		{
			_generator.Emit(OpCodes.And);
			return this;
		}
		public FluentILGenerator Or()
		{
			_generator.Emit(OpCodes.Or);
			return this;
		}
		public FluentILGenerator Xor()
		{
			_generator.Emit(OpCodes.Xor);
			return this;
		}
		public FluentILGenerator Shl()
		{
			_generator.Emit(OpCodes.Shl);
			return this;
		}
		public FluentILGenerator Shr()
		{
			_generator.Emit(OpCodes.Shr);
			return this;
		}
		public FluentILGenerator Shr_Un()
		{
			_generator.Emit(OpCodes.Shr_Un);
			return this;
		}
		public FluentILGenerator Neg()
		{
			_generator.Emit(OpCodes.Neg);
			return this;
		}
		public FluentILGenerator Not()
		{
			_generator.Emit(OpCodes.Not);
			return this;
		}
		public FluentILGenerator Conv_I1()
		{
			_generator.Emit(OpCodes.Conv_I1);
			return this;
		}
		public FluentILGenerator Conv_I2()
		{
			_generator.Emit(OpCodes.Conv_I2);
			return this;
		}
		public FluentILGenerator Conv_I4()
		{
			_generator.Emit(OpCodes.Conv_I4);
			return this;
		}
		public FluentILGenerator Conv_I8()
		{
			_generator.Emit(OpCodes.Conv_I8);
			return this;
		}
		public FluentILGenerator Conv_R4()
		{
			_generator.Emit(OpCodes.Conv_R4);
			return this;
		}
		public FluentILGenerator Conv_R8()
		{
			_generator.Emit(OpCodes.Conv_R8);
			return this;
		}
		public FluentILGenerator Conv_U4()
		{
			_generator.Emit(OpCodes.Conv_U4);
			return this;
		}
		public FluentILGenerator Conv_U8()
		{
			_generator.Emit(OpCodes.Conv_U8);
			return this;
		}
		public FluentILGenerator Conv_R_Un()
		{
			_generator.Emit(OpCodes.Conv_R_Un);
			return this;
		}
		public FluentILGenerator Throw()
		{
			_generator.Emit(OpCodes.Throw);
			return this;
		}
		public FluentILGenerator Conv_Ovf_I1_Un()
		{
			_generator.Emit(OpCodes.Conv_Ovf_I1_Un);
			return this;
		}
		public FluentILGenerator Conv_Ovf_I2_Un()
		{
			_generator.Emit(OpCodes.Conv_Ovf_I2_Un);
			return this;
		}
		public FluentILGenerator Conv_Ovf_I4_Un()
		{
			_generator.Emit(OpCodes.Conv_Ovf_I4_Un);
			return this;
		}
		public FluentILGenerator Conv_Ovf_I8_Un()
		{
			_generator.Emit(OpCodes.Conv_Ovf_I8_Un);
			return this;
		}
		public FluentILGenerator Conv_Ovf_U1_Un()
		{
			_generator.Emit(OpCodes.Conv_Ovf_U1_Un);
			return this;
		}
		public FluentILGenerator Conv_Ovf_U2_Un()
		{
			_generator.Emit(OpCodes.Conv_Ovf_U2_Un);
			return this;
		}
		public FluentILGenerator Conv_Ovf_U4_Un()
		{
			_generator.Emit(OpCodes.Conv_Ovf_U4_Un);
			return this;
		}
		public FluentILGenerator Conv_Ovf_U8_Un()
		{
			_generator.Emit(OpCodes.Conv_Ovf_U8_Un);
			return this;
		}
		public FluentILGenerator Conv_Ovf_I_Un()
		{
			_generator.Emit(OpCodes.Conv_Ovf_I_Un);
			return this;
		}
		public FluentILGenerator Conv_Ovf_U_Un()
		{
			_generator.Emit(OpCodes.Conv_Ovf_U_Un);
			return this;
		}
		public FluentILGenerator Ldlen()
		{
			_generator.Emit(OpCodes.Ldlen);
			return this;
		}
		public FluentILGenerator Ldelem_I1()
		{
			_generator.Emit(OpCodes.Ldelem_I1);
			return this;
		}
		public FluentILGenerator Ldelem_U1()
		{
			_generator.Emit(OpCodes.Ldelem_U1);
			return this;
		}
		public FluentILGenerator Ldelem_I2()
		{
			_generator.Emit(OpCodes.Ldelem_I2);
			return this;
		}
		public FluentILGenerator Ldelem_U2()
		{
			_generator.Emit(OpCodes.Ldelem_U2);
			return this;
		}
		public FluentILGenerator Ldelem_I4()
		{
			_generator.Emit(OpCodes.Ldelem_I4);
			return this;
		}
		public FluentILGenerator Ldelem_U4()
		{
			_generator.Emit(OpCodes.Ldelem_U4);
			return this;
		}
		public FluentILGenerator Ldelem_I8()
		{
			_generator.Emit(OpCodes.Ldelem_I8);
			return this;
		}
		public FluentILGenerator Ldelem_I()
		{
			_generator.Emit(OpCodes.Ldelem_I);
			return this;
		}
		public FluentILGenerator Ldelem_R4()
		{
			_generator.Emit(OpCodes.Ldelem_R4);
			return this;
		}
		public FluentILGenerator Ldelem_R8()
		{
			_generator.Emit(OpCodes.Ldelem_R8);
			return this;
		}
		public FluentILGenerator Ldelem_Ref()
		{
			_generator.Emit(OpCodes.Ldelem_Ref);
			return this;
		}
		public FluentILGenerator Stelem_I()
		{
			_generator.Emit(OpCodes.Stelem_I);
			return this;
		}
		public FluentILGenerator Stelem_I1()
		{
			_generator.Emit(OpCodes.Stelem_I1);
			return this;
		}
		public FluentILGenerator Stelem_I2()
		{
			_generator.Emit(OpCodes.Stelem_I2);
			return this;
		}
		public FluentILGenerator Stelem_I4()
		{
			_generator.Emit(OpCodes.Stelem_I4);
			return this;
		}
		public FluentILGenerator Stelem_I8()
		{
			_generator.Emit(OpCodes.Stelem_I8);
			return this;
		}
		public FluentILGenerator Stelem_R4()
		{
			_generator.Emit(OpCodes.Stelem_R4);
			return this;
		}
		public FluentILGenerator Stelem_R8()
		{
			_generator.Emit(OpCodes.Stelem_R8);
			return this;
		}
		public FluentILGenerator Stelem_Ref()
		{
			_generator.Emit(OpCodes.Stelem_Ref);
			return this;
		}
		public FluentILGenerator Conv_Ovf_I1()
		{
			_generator.Emit(OpCodes.Conv_Ovf_I1);
			return this;
		}
		public FluentILGenerator Conv_Ovf_U1()
		{
			_generator.Emit(OpCodes.Conv_Ovf_U1);
			return this;
		}
		public FluentILGenerator Conv_Ovf_I2()
		{
			_generator.Emit(OpCodes.Conv_Ovf_I2);
			return this;
		}
		public FluentILGenerator Conv_Ovf_U2()
		{
			_generator.Emit(OpCodes.Conv_Ovf_U2);
			return this;
		}
		public FluentILGenerator Conv_Ovf_I4()
		{
			_generator.Emit(OpCodes.Conv_Ovf_I4);
			return this;
		}
		public FluentILGenerator Conv_Ovf_U4()
		{
			_generator.Emit(OpCodes.Conv_Ovf_U4);
			return this;
		}
		public FluentILGenerator Conv_Ovf_I8()
		{
			_generator.Emit(OpCodes.Conv_Ovf_I8);
			return this;
		}
		public FluentILGenerator Conv_Ovf_U8()
		{
			_generator.Emit(OpCodes.Conv_Ovf_U8);
			return this;
		}
		public FluentILGenerator Ckfinite()
		{
			_generator.Emit(OpCodes.Ckfinite);
			return this;
		}
		public FluentILGenerator Conv_U2()
		{
			_generator.Emit(OpCodes.Conv_U2);
			return this;
		}
		public FluentILGenerator Conv_U1()
		{
			_generator.Emit(OpCodes.Conv_U1);
			return this;
		}
		public FluentILGenerator Conv_I()
		{
			_generator.Emit(OpCodes.Conv_I);
			return this;
		}
		public FluentILGenerator Conv_Ovf_I()
		{
			_generator.Emit(OpCodes.Conv_Ovf_I);
			return this;
		}
		public FluentILGenerator Conv_Ovf_U()
		{
			_generator.Emit(OpCodes.Conv_Ovf_U);
			return this;
		}
		public FluentILGenerator Add_Ovf()
		{
			_generator.Emit(OpCodes.Add_Ovf);
			return this;
		}
		public FluentILGenerator Add_Ovf_Un()
		{
			_generator.Emit(OpCodes.Add_Ovf_Un);
			return this;
		}
		public FluentILGenerator Mul_Ovf()
		{
			_generator.Emit(OpCodes.Mul_Ovf);
			return this;
		}
		public FluentILGenerator Mul_Ovf_Un()
		{
			_generator.Emit(OpCodes.Mul_Ovf_Un);
			return this;
		}
		public FluentILGenerator Sub_Ovf()
		{
			_generator.Emit(OpCodes.Sub_Ovf);
			return this;
		}
		public FluentILGenerator Sub_Ovf_Un()
		{
			_generator.Emit(OpCodes.Sub_Ovf_Un);
			return this;
		}
		public FluentILGenerator Endfinally()
		{
			_generator.Emit(OpCodes.Endfinally);
			return this;
		}
		public FluentILGenerator Stind_I()
		{
			_generator.Emit(OpCodes.Stind_I);
			return this;
		}
		public FluentILGenerator Conv_U()
		{
			_generator.Emit(OpCodes.Conv_U);
			return this;
		}
		public FluentILGenerator Prefix7()
		{
			_generator.Emit(OpCodes.Prefix7);
			return this;
		}
		public FluentILGenerator Prefix6()
		{
			_generator.Emit(OpCodes.Prefix6);
			return this;
		}
		public FluentILGenerator Prefix5()
		{
			_generator.Emit(OpCodes.Prefix5);
			return this;
		}
		public FluentILGenerator Prefix4()
		{
			_generator.Emit(OpCodes.Prefix4);
			return this;
		}
		public FluentILGenerator Prefix3()
		{
			_generator.Emit(OpCodes.Prefix3);
			return this;
		}
		public FluentILGenerator Prefix2()
		{
			_generator.Emit(OpCodes.Prefix2);
			return this;
		}
		public FluentILGenerator Prefix1()
		{
			_generator.Emit(OpCodes.Prefix1);
			return this;
		}
		public FluentILGenerator Prefixref()
		{
			_generator.Emit(OpCodes.Prefixref);
			return this;
		}
		public FluentILGenerator Arglist()
		{
			_generator.Emit(OpCodes.Arglist);
			return this;
		}
		public FluentILGenerator Ceq()
		{
			_generator.Emit(OpCodes.Ceq);
			return this;
		}
		public FluentILGenerator Cgt()
		{
			_generator.Emit(OpCodes.Cgt);
			return this;
		}
		public FluentILGenerator Cgt_Un()
		{
			_generator.Emit(OpCodes.Cgt_Un);
			return this;
		}
		public FluentILGenerator Clt()
		{
			_generator.Emit(OpCodes.Clt);
			return this;
		}
		public FluentILGenerator Clt_Un()
		{
			_generator.Emit(OpCodes.Clt_Un);
			return this;
		}
		public FluentILGenerator Localloc()
		{
			_generator.Emit(OpCodes.Localloc);
			return this;
		}
		public FluentILGenerator Endfilter()
		{
			_generator.Emit(OpCodes.Endfilter);
			return this;
		}
		public FluentILGenerator Volatile()
		{
			_generator.Emit(OpCodes.Volatile);
			return this;
		}
		public FluentILGenerator Tailcall()
		{
			_generator.Emit(OpCodes.Tailcall);
			return this;
		}
		public FluentILGenerator Cpblk()
		{
			_generator.Emit(OpCodes.Cpblk);
			return this;
		}
		public FluentILGenerator Initblk()
		{
			_generator.Emit(OpCodes.Initblk);
			return this;
		}
		public FluentILGenerator Rethrow()
		{
			_generator.Emit(OpCodes.Rethrow);
			return this;
		}
		public FluentILGenerator Refanytype()
		{
			_generator.Emit(OpCodes.Refanytype);
			return this;
		}
		public FluentILGenerator Readonly()
		{
			_generator.Emit(OpCodes.Readonly);
			return this;
		}

		public FluentILGenerator Ldc_I4(int value)
		{
			_generator.Emit(OpCodes.Ldc_I4, value);
			return this;
		}
		public FluentILGenerator Ldc_I8(long value)
		{
			_generator.Emit(OpCodes.Ldc_I8, value);
			return this;
		}
		public FluentILGenerator Ldc_I4_S(sbyte value)
		{
			_generator.Emit(OpCodes.Ldc_I4_S, value);
			return this;
		}
		public FluentILGenerator Ldc_R8(double value)
		{
			_generator.Emit(OpCodes.Ldc_R8, value);
			return this;
		}
		public FluentILGenerator Ldc_R4(float value)
		{
			_generator.Emit(OpCodes.Ldc_R4, value);
			return this;
		}
		public FluentILGenerator Ldarg(uint value)
		{
			_generator.Emit(OpCodes.Ldarg, value);
			return this;
		}
		public FluentILGenerator Ldarga(uint value)
		{
			_generator.Emit(OpCodes.Ldarga, value);
			return this;
		}
		public FluentILGenerator Starg(uint value)
		{
			_generator.Emit(OpCodes.Starg, value);
			return this;
		}
		public FluentILGenerator Ldloc(uint value)
		{
			_generator.Emit(OpCodes.Ldloc, value);
			return this;
		}
		public FluentILGenerator Ldloca(uint value)
		{
			_generator.Emit(OpCodes.Ldloca, value);
			return this;
		}
		public FluentILGenerator Stloc(uint value)
		{
			_generator.Emit(OpCodes.Stloc, value);
			return this;
		}
		public FluentILGenerator Ldarg_S(byte value)
		{
			_generator.Emit(OpCodes.Ldarg_S, value);
			return this;
		}
		public FluentILGenerator Ldarga_S(byte value)
		{
			_generator.Emit(OpCodes.Ldarga_S, value);
			return this;
		}
		public FluentILGenerator Starg_S(byte value)
		{
			_generator.Emit(OpCodes.Starg_S, value);
			return this;
		}
		public FluentILGenerator Ldloc_S(byte value)
		{
			_generator.Emit(OpCodes.Ldloc_S, value);
			return this;
		}
		public FluentILGenerator Ldloca_S(byte value)
		{
			_generator.Emit(OpCodes.Ldloca_S, value);
			return this;
		}
		public FluentILGenerator Stloc_S(byte value)
		{
			_generator.Emit(OpCodes.Stloc_S, value);
			return this;
		}
		public FluentILGenerator Ldarg(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Ldarg, value);
			return this;
		}
		public FluentILGenerator Ldarga(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Ldarga, value);
			return this;
		}
		public FluentILGenerator Starg(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Starg, value);
			return this;
		}
		public FluentILGenerator Ldloc(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Ldloc, value);
			return this;
		}
		public FluentILGenerator Ldloca(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Ldloca, value);
			return this;
		}
		public FluentILGenerator Stloc(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Stloc, value);
			return this;
		}
		public FluentILGenerator Ldarg_S(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Ldarg_S, value);
			return this;
		}
		public FluentILGenerator Ldarga_S(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Ldarga_S, value);
			return this;
		}
		public FluentILGenerator Starg_S(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Starg_S, value);
			return this;
		}
		public FluentILGenerator Ldloc_S(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Ldloc_S, value);
			return this;
		}
		public FluentILGenerator Ldloca_S(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Ldloca_S, value);
			return this;
		}
		public FluentILGenerator Stloc_S(LocalBuilder value)
		{
			_generator.Emit(OpCodes.Stloc_S, value);
			return this;
		}
		public FluentILGenerator Br(Label value)
		{
			_generator.Emit(OpCodes.Br, value);
			return this;
		}
		public FluentILGenerator Brfalse(Label value)
		{
			_generator.Emit(OpCodes.Brfalse, value);
			return this;
		}
		public FluentILGenerator Brtrue(Label value)
		{
			_generator.Emit(OpCodes.Brtrue, value);
			return this;
		}
		public FluentILGenerator Beq(Label value)
		{
			_generator.Emit(OpCodes.Beq, value);
			return this;
		}
		public FluentILGenerator Bge(Label value)
		{
			_generator.Emit(OpCodes.Bge, value);
			return this;
		}
		public FluentILGenerator Bgt(Label value)
		{
			_generator.Emit(OpCodes.Bgt, value);
			return this;
		}
		public FluentILGenerator Ble(Label value)
		{
			_generator.Emit(OpCodes.Ble, value);
			return this;
		}
		public FluentILGenerator Blt(Label value)
		{
			_generator.Emit(OpCodes.Blt, value);
			return this;
		}
		public FluentILGenerator Bne_Un(Label value)
		{
			_generator.Emit(OpCodes.Bne_Un, value);
			return this;
		}
		public FluentILGenerator Bge_Un(Label value)
		{
			_generator.Emit(OpCodes.Bge_Un, value);
			return this;
		}
		public FluentILGenerator Bgt_Un(Label value)
		{
			_generator.Emit(OpCodes.Bgt_Un, value);
			return this;
		}
		public FluentILGenerator Ble_Un(Label value)
		{
			_generator.Emit(OpCodes.Ble_Un, value);
			return this;
		}
		public FluentILGenerator Blt_Un(Label value)
		{
			_generator.Emit(OpCodes.Blt_Un, value);
			return this;
		}
		public FluentILGenerator Leave(Label value)
		{
			_generator.Emit(OpCodes.Leave, value);
			return this;
		}
		public FluentILGenerator Br_S(Label value)
		{
			_generator.Emit(OpCodes.Br_S, value);
			return this;
		}
		public FluentILGenerator Brfalse_S(Label value)
		{
			_generator.Emit(OpCodes.Brfalse_S, value);
			return this;
		}
		public FluentILGenerator Brtrue_S(Label value)
		{
			_generator.Emit(OpCodes.Brtrue_S, value);
			return this;
		}
		public FluentILGenerator Beq_S(Label value)
		{
			_generator.Emit(OpCodes.Beq_S, value);
			return this;
		}
		public FluentILGenerator Bge_S(Label value)
		{
			_generator.Emit(OpCodes.Bge_S, value);
			return this;
		}
		public FluentILGenerator Bgt_S(Label value)
		{
			_generator.Emit(OpCodes.Bgt_S, value);
			return this;
		}
		public FluentILGenerator Ble_S(Label value)
		{
			_generator.Emit(OpCodes.Ble_S, value);
			return this;
		}
		public FluentILGenerator Blt_S(Label value)
		{
			_generator.Emit(OpCodes.Blt_S, value);
			return this;
		}
		public FluentILGenerator Bne_Un_S(Label value)
		{
			_generator.Emit(OpCodes.Bne_Un_S, value);
			return this;
		}
		public FluentILGenerator Bge_Un_S(Label value)
		{
			_generator.Emit(OpCodes.Bge_Un_S, value);
			return this;
		}
		public FluentILGenerator Bgt_Un_S(Label value)
		{
			_generator.Emit(OpCodes.Bgt_Un_S, value);
			return this;
		}
		public FluentILGenerator Ble_Un_S(Label value)
		{
			_generator.Emit(OpCodes.Ble_Un_S, value);
			return this;
		}
		public FluentILGenerator Blt_Un_S(Label value)
		{
			_generator.Emit(OpCodes.Blt_Un_S, value);
			return this;
		}
		public FluentILGenerator Leave_S(Label value)
		{
			_generator.Emit(OpCodes.Leave_S, value);
			return this;
		}
		public FluentILGenerator Switch(Label[] value)
		{
			_generator.Emit(OpCodes.Switch, value);
			return this;
		}
		public FluentILGenerator Unbox(Type value)
		{
			_generator.Emit(OpCodes.Unbox, value);
			return this;
		}
		public FluentILGenerator Stobj(Type value)
		{
			_generator.Emit(OpCodes.Stobj, value);
			return this;
		}
		public FluentILGenerator Box(Type value)
		{
			_generator.Emit(OpCodes.Box, value);
			return this;
		}
		public FluentILGenerator Refanyval(Type value)
		{
			_generator.Emit(OpCodes.Refanyval, value);
			return this;
		}
		public FluentILGenerator Mkrefany(Type value)
		{
			_generator.Emit(OpCodes.Mkrefany, value);
			return this;
		}
		public FluentILGenerator Sizeof(Type value)
		{
			_generator.Emit(OpCodes.Sizeof, value);
			return this;
		}
		public FluentILGenerator Jmp(MethodInfo value)
		{
			_generator.Emit(OpCodes.Jmp, value);
			return this;
		}
		public FluentILGenerator Call(MethodInfo value)
		{
			_generator.Emit(OpCodes.Call, value);
			return this;
		}
		public FluentILGenerator Ldftn(MethodInfo value)
		{
			_generator.Emit(OpCodes.Ldftn, value);
			return this;
		}
		public FluentILGenerator Ldvirtftn(MethodInfo value)
		{
			_generator.Emit(OpCodes.Ldvirtftn, value);
			return this;
		}

		public FluentILGenerator Cpobj(Type value)
		{
			_generator.Emit(OpCodes.Cpobj, value);
			return this;
		}
		public FluentILGenerator Ldobj(Type value)
		{
			_generator.Emit(OpCodes.Ldobj, value);
			return this;
		}
		public FluentILGenerator Castclass(Type value)
		{
			_generator.Emit(OpCodes.Castclass, value);
			return this;
		}
		public FluentILGenerator Isinst(Type value)
		{
			_generator.Emit(OpCodes.Isinst, value);
			return this;
		}
		public FluentILGenerator Newarr(Type value)
		{
			_generator.Emit(OpCodes.Newarr, value);
			return this;
		}
		public FluentILGenerator Ldelema(Type value)
		{
			_generator.Emit(OpCodes.Ldelema, value);
			return this;
		}
		public FluentILGenerator Ldelem(Type value)
		{
			_generator.Emit(OpCodes.Ldelem, value);
			return this;
		}
		public FluentILGenerator Stelem(Type value)
		{
			_generator.Emit(OpCodes.Stelem, value);
			return this;
		}
		public FluentILGenerator Unbox_Any(Type value)
		{
			_generator.Emit(OpCodes.Unbox_Any, value);
			return this;
		}
		public FluentILGenerator Initobj(Type value)
		{
			_generator.Emit(OpCodes.Initobj, value);
			return this;
		}
		public FluentILGenerator Callvirt(MethodInfo value)
		{
			_generator.Emit(OpCodes.Callvirt, value);
			return this;
		}
		public FluentILGenerator Newobj(MethodInfo value)
		{
			_generator.Emit(OpCodes.Newobj, value);
			return this;
		}
		public FluentILGenerator Ldfld(FieldInfo value)
		{
			_generator.Emit(OpCodes.Ldfld, value);
			return this;
		}
		public FluentILGenerator Ldflda(FieldInfo value)
		{
			_generator.Emit(OpCodes.Ldflda, value);
			return this;
		}
		public FluentILGenerator Stfld(FieldInfo value)
		{
			_generator.Emit(OpCodes.Stfld, value);
			return this;
		}
		public FluentILGenerator Ldsfld(FieldInfo value)
		{
			_generator.Emit(OpCodes.Ldsfld, value);
			return this;
		}
		public FluentILGenerator Ldsflda(FieldInfo value)
		{
			_generator.Emit(OpCodes.Ldsflda, value);
			return this;
		}
		public FluentILGenerator Stsfld(FieldInfo value)
		{
			_generator.Emit(OpCodes.Stsfld, value);
			return this;
		}
		public FluentILGenerator Ldstr(string value)
		{
			_generator.Emit(OpCodes.Ldstr, value);
			return this;
		}
		
	}
}

