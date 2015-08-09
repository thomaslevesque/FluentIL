using System;
using System.Reflection;
using System.Reflection.Emit;

namespace FluentIL
{
    partial class FluentILGenerator
    {
        public IFluentILGenerator Nop()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Nop);
            _generator.Emit(OpCodes.Nop);
            return this;
        }
        public IFluentILGenerator Break()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Break);
            _generator.Emit(OpCodes.Break);
            return this;
        }
        public IFluentILGenerator Ldarg_0()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldarg_0);
            _generator.Emit(OpCodes.Ldarg_0);
            return this;
        }
        public IFluentILGenerator Ldarg_1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldarg_1);
            _generator.Emit(OpCodes.Ldarg_1);
            return this;
        }
        public IFluentILGenerator Ldarg_2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldarg_2);
            _generator.Emit(OpCodes.Ldarg_2);
            return this;
        }
        public IFluentILGenerator Ldarg_3()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldarg_3);
            _generator.Emit(OpCodes.Ldarg_3);
            return this;
        }
        public IFluentILGenerator Ldloc_0()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldloc_0);
            _generator.Emit(OpCodes.Ldloc_0);
            return this;
        }
        public IFluentILGenerator Ldloc_1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldloc_1);
            _generator.Emit(OpCodes.Ldloc_1);
            return this;
        }
        public IFluentILGenerator Ldloc_2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldloc_2);
            _generator.Emit(OpCodes.Ldloc_2);
            return this;
        }
        public IFluentILGenerator Ldloc_3()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldloc_3);
            _generator.Emit(OpCodes.Ldloc_3);
            return this;
        }
        public IFluentILGenerator Stloc_0()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stloc_0);
            _generator.Emit(OpCodes.Stloc_0);
            return this;
        }
        public IFluentILGenerator Stloc_1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stloc_1);
            _generator.Emit(OpCodes.Stloc_1);
            return this;
        }
        public IFluentILGenerator Stloc_2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stloc_2);
            _generator.Emit(OpCodes.Stloc_2);
            return this;
        }
        public IFluentILGenerator Stloc_3()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stloc_3);
            _generator.Emit(OpCodes.Stloc_3);
            return this;
        }
        public IFluentILGenerator Ldnull()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldnull);
            _generator.Emit(OpCodes.Ldnull);
            return this;
        }
        public IFluentILGenerator Ldc_I4_M1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldc_I4_M1);
            _generator.Emit(OpCodes.Ldc_I4_M1);
            return this;
        }
        public IFluentILGenerator Ldc_I4_0()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldc_I4_0);
            _generator.Emit(OpCodes.Ldc_I4_0);
            return this;
        }
        public IFluentILGenerator Ldc_I4_1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldc_I4_1);
            _generator.Emit(OpCodes.Ldc_I4_1);
            return this;
        }
        public IFluentILGenerator Ldc_I4_2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldc_I4_2);
            _generator.Emit(OpCodes.Ldc_I4_2);
            return this;
        }
        public IFluentILGenerator Ldc_I4_3()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldc_I4_3);
            _generator.Emit(OpCodes.Ldc_I4_3);
            return this;
        }
        public IFluentILGenerator Ldc_I4_4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldc_I4_4);
            _generator.Emit(OpCodes.Ldc_I4_4);
            return this;
        }
        public IFluentILGenerator Ldc_I4_5()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldc_I4_5);
            _generator.Emit(OpCodes.Ldc_I4_5);
            return this;
        }
        public IFluentILGenerator Ldc_I4_6()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldc_I4_6);
            _generator.Emit(OpCodes.Ldc_I4_6);
            return this;
        }
        public IFluentILGenerator Ldc_I4_7()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldc_I4_7);
            _generator.Emit(OpCodes.Ldc_I4_7);
            return this;
        }
        public IFluentILGenerator Ldc_I4_8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldc_I4_8);
            _generator.Emit(OpCodes.Ldc_I4_8);
            return this;
        }
        public IFluentILGenerator Dup()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Dup);
            _generator.Emit(OpCodes.Dup);
            return this;
        }
        public IFluentILGenerator Pop()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Pop);
            _generator.Emit(OpCodes.Pop);
            return this;
        }
        public IFluentILGenerator Ret()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ret);
            _generator.Emit(OpCodes.Ret);
            return this;
        }
        public IFluentILGenerator Ldind_I1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldind_I1);
            _generator.Emit(OpCodes.Ldind_I1);
            return this;
        }
        public IFluentILGenerator Ldind_U1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldind_U1);
            _generator.Emit(OpCodes.Ldind_U1);
            return this;
        }
        public IFluentILGenerator Ldind_I2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldind_I2);
            _generator.Emit(OpCodes.Ldind_I2);
            return this;
        }
        public IFluentILGenerator Ldind_U2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldind_U2);
            _generator.Emit(OpCodes.Ldind_U2);
            return this;
        }
        public IFluentILGenerator Ldind_I4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldind_I4);
            _generator.Emit(OpCodes.Ldind_I4);
            return this;
        }
        public IFluentILGenerator Ldind_U4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldind_U4);
            _generator.Emit(OpCodes.Ldind_U4);
            return this;
        }
        public IFluentILGenerator Ldind_I8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldind_I8);
            _generator.Emit(OpCodes.Ldind_I8);
            return this;
        }
        public IFluentILGenerator Ldind_I()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldind_I);
            _generator.Emit(OpCodes.Ldind_I);
            return this;
        }
        public IFluentILGenerator Ldind_R4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldind_R4);
            _generator.Emit(OpCodes.Ldind_R4);
            return this;
        }
        public IFluentILGenerator Ldind_R8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldind_R8);
            _generator.Emit(OpCodes.Ldind_R8);
            return this;
        }
        public IFluentILGenerator Ldind_Ref()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldind_Ref);
            _generator.Emit(OpCodes.Ldind_Ref);
            return this;
        }
        public IFluentILGenerator Stind_Ref()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stind_Ref);
            _generator.Emit(OpCodes.Stind_Ref);
            return this;
        }
        public IFluentILGenerator Stind_I1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stind_I1);
            _generator.Emit(OpCodes.Stind_I1);
            return this;
        }
        public IFluentILGenerator Stind_I2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stind_I2);
            _generator.Emit(OpCodes.Stind_I2);
            return this;
        }
        public IFluentILGenerator Stind_I4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stind_I4);
            _generator.Emit(OpCodes.Stind_I4);
            return this;
        }
        public IFluentILGenerator Stind_I8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stind_I8);
            _generator.Emit(OpCodes.Stind_I8);
            return this;
        }
        public IFluentILGenerator Stind_R4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stind_R4);
            _generator.Emit(OpCodes.Stind_R4);
            return this;
        }
        public IFluentILGenerator Stind_R8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stind_R8);
            _generator.Emit(OpCodes.Stind_R8);
            return this;
        }
        public IFluentILGenerator Add()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Add);
            _generator.Emit(OpCodes.Add);
            return this;
        }
        public IFluentILGenerator Sub()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Sub);
            _generator.Emit(OpCodes.Sub);
            return this;
        }
        public IFluentILGenerator Mul()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Mul);
            _generator.Emit(OpCodes.Mul);
            return this;
        }
        public IFluentILGenerator Div()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Div);
            _generator.Emit(OpCodes.Div);
            return this;
        }
        public IFluentILGenerator Div_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Div_Un);
            _generator.Emit(OpCodes.Div_Un);
            return this;
        }
        public IFluentILGenerator Rem()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Rem);
            _generator.Emit(OpCodes.Rem);
            return this;
        }
        public IFluentILGenerator Rem_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Rem_Un);
            _generator.Emit(OpCodes.Rem_Un);
            return this;
        }
        public IFluentILGenerator And()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.And);
            _generator.Emit(OpCodes.And);
            return this;
        }
        public IFluentILGenerator Or()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Or);
            _generator.Emit(OpCodes.Or);
            return this;
        }
        public IFluentILGenerator Xor()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Xor);
            _generator.Emit(OpCodes.Xor);
            return this;
        }
        public IFluentILGenerator Shl()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Shl);
            _generator.Emit(OpCodes.Shl);
            return this;
        }
        public IFluentILGenerator Shr()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Shr);
            _generator.Emit(OpCodes.Shr);
            return this;
        }
        public IFluentILGenerator Shr_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Shr_Un);
            _generator.Emit(OpCodes.Shr_Un);
            return this;
        }
        public IFluentILGenerator Neg()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Neg);
            _generator.Emit(OpCodes.Neg);
            return this;
        }
        public IFluentILGenerator Not()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Not);
            _generator.Emit(OpCodes.Not);
            return this;
        }
        public IFluentILGenerator Conv_I1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_I1);
            _generator.Emit(OpCodes.Conv_I1);
            return this;
        }
        public IFluentILGenerator Conv_I2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_I2);
            _generator.Emit(OpCodes.Conv_I2);
            return this;
        }
        public IFluentILGenerator Conv_I4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_I4);
            _generator.Emit(OpCodes.Conv_I4);
            return this;
        }
        public IFluentILGenerator Conv_I8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_I8);
            _generator.Emit(OpCodes.Conv_I8);
            return this;
        }
        public IFluentILGenerator Conv_R4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_R4);
            _generator.Emit(OpCodes.Conv_R4);
            return this;
        }
        public IFluentILGenerator Conv_R8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_R8);
            _generator.Emit(OpCodes.Conv_R8);
            return this;
        }
        public IFluentILGenerator Conv_U4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_U4);
            _generator.Emit(OpCodes.Conv_U4);
            return this;
        }
        public IFluentILGenerator Conv_U8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_U8);
            _generator.Emit(OpCodes.Conv_U8);
            return this;
        }
        public IFluentILGenerator Conv_R_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_R_Un);
            _generator.Emit(OpCodes.Conv_R_Un);
            return this;
        }
        public IFluentILGenerator Throw()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Throw);
            _generator.Emit(OpCodes.Throw);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_I1_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_I1_Un);
            _generator.Emit(OpCodes.Conv_Ovf_I1_Un);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_I2_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_I2_Un);
            _generator.Emit(OpCodes.Conv_Ovf_I2_Un);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_I4_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_I4_Un);
            _generator.Emit(OpCodes.Conv_Ovf_I4_Un);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_I8_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_I8_Un);
            _generator.Emit(OpCodes.Conv_Ovf_I8_Un);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_U1_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_U1_Un);
            _generator.Emit(OpCodes.Conv_Ovf_U1_Un);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_U2_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_U2_Un);
            _generator.Emit(OpCodes.Conv_Ovf_U2_Un);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_U4_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_U4_Un);
            _generator.Emit(OpCodes.Conv_Ovf_U4_Un);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_U8_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_U8_Un);
            _generator.Emit(OpCodes.Conv_Ovf_U8_Un);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_I_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_I_Un);
            _generator.Emit(OpCodes.Conv_Ovf_I_Un);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_U_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_U_Un);
            _generator.Emit(OpCodes.Conv_Ovf_U_Un);
            return this;
        }
        public IFluentILGenerator Ldlen()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldlen);
            _generator.Emit(OpCodes.Ldlen);
            return this;
        }
        public IFluentILGenerator Ldelem_I1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldelem_I1);
            _generator.Emit(OpCodes.Ldelem_I1);
            return this;
        }
        public IFluentILGenerator Ldelem_U1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldelem_U1);
            _generator.Emit(OpCodes.Ldelem_U1);
            return this;
        }
        public IFluentILGenerator Ldelem_I2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldelem_I2);
            _generator.Emit(OpCodes.Ldelem_I2);
            return this;
        }
        public IFluentILGenerator Ldelem_U2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldelem_U2);
            _generator.Emit(OpCodes.Ldelem_U2);
            return this;
        }
        public IFluentILGenerator Ldelem_I4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldelem_I4);
            _generator.Emit(OpCodes.Ldelem_I4);
            return this;
        }
        public IFluentILGenerator Ldelem_U4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldelem_U4);
            _generator.Emit(OpCodes.Ldelem_U4);
            return this;
        }
        public IFluentILGenerator Ldelem_I8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldelem_I8);
            _generator.Emit(OpCodes.Ldelem_I8);
            return this;
        }
        public IFluentILGenerator Ldelem_I()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldelem_I);
            _generator.Emit(OpCodes.Ldelem_I);
            return this;
        }
        public IFluentILGenerator Ldelem_R4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldelem_R4);
            _generator.Emit(OpCodes.Ldelem_R4);
            return this;
        }
        public IFluentILGenerator Ldelem_R8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldelem_R8);
            _generator.Emit(OpCodes.Ldelem_R8);
            return this;
        }
        public IFluentILGenerator Ldelem_Ref()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ldelem_Ref);
            _generator.Emit(OpCodes.Ldelem_Ref);
            return this;
        }
        public IFluentILGenerator Stelem_I()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stelem_I);
            _generator.Emit(OpCodes.Stelem_I);
            return this;
        }
        public IFluentILGenerator Stelem_I1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stelem_I1);
            _generator.Emit(OpCodes.Stelem_I1);
            return this;
        }
        public IFluentILGenerator Stelem_I2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stelem_I2);
            _generator.Emit(OpCodes.Stelem_I2);
            return this;
        }
        public IFluentILGenerator Stelem_I4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stelem_I4);
            _generator.Emit(OpCodes.Stelem_I4);
            return this;
        }
        public IFluentILGenerator Stelem_I8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stelem_I8);
            _generator.Emit(OpCodes.Stelem_I8);
            return this;
        }
        public IFluentILGenerator Stelem_R4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stelem_R4);
            _generator.Emit(OpCodes.Stelem_R4);
            return this;
        }
        public IFluentILGenerator Stelem_R8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stelem_R8);
            _generator.Emit(OpCodes.Stelem_R8);
            return this;
        }
        public IFluentILGenerator Stelem_Ref()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stelem_Ref);
            _generator.Emit(OpCodes.Stelem_Ref);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_I1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_I1);
            _generator.Emit(OpCodes.Conv_Ovf_I1);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_U1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_U1);
            _generator.Emit(OpCodes.Conv_Ovf_U1);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_I2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_I2);
            _generator.Emit(OpCodes.Conv_Ovf_I2);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_U2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_U2);
            _generator.Emit(OpCodes.Conv_Ovf_U2);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_I4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_I4);
            _generator.Emit(OpCodes.Conv_Ovf_I4);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_U4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_U4);
            _generator.Emit(OpCodes.Conv_Ovf_U4);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_I8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_I8);
            _generator.Emit(OpCodes.Conv_Ovf_I8);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_U8()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_U8);
            _generator.Emit(OpCodes.Conv_Ovf_U8);
            return this;
        }
        public IFluentILGenerator Ckfinite()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ckfinite);
            _generator.Emit(OpCodes.Ckfinite);
            return this;
        }
        public IFluentILGenerator Conv_U2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_U2);
            _generator.Emit(OpCodes.Conv_U2);
            return this;
        }
        public IFluentILGenerator Conv_U1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_U1);
            _generator.Emit(OpCodes.Conv_U1);
            return this;
        }
        public IFluentILGenerator Conv_I()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_I);
            _generator.Emit(OpCodes.Conv_I);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_I()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_I);
            _generator.Emit(OpCodes.Conv_Ovf_I);
            return this;
        }
        public IFluentILGenerator Conv_Ovf_U()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_Ovf_U);
            _generator.Emit(OpCodes.Conv_Ovf_U);
            return this;
        }
        public IFluentILGenerator Add_Ovf()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Add_Ovf);
            _generator.Emit(OpCodes.Add_Ovf);
            return this;
        }
        public IFluentILGenerator Add_Ovf_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Add_Ovf_Un);
            _generator.Emit(OpCodes.Add_Ovf_Un);
            return this;
        }
        public IFluentILGenerator Mul_Ovf()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Mul_Ovf);
            _generator.Emit(OpCodes.Mul_Ovf);
            return this;
        }
        public IFluentILGenerator Mul_Ovf_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Mul_Ovf_Un);
            _generator.Emit(OpCodes.Mul_Ovf_Un);
            return this;
        }
        public IFluentILGenerator Sub_Ovf()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Sub_Ovf);
            _generator.Emit(OpCodes.Sub_Ovf);
            return this;
        }
        public IFluentILGenerator Sub_Ovf_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Sub_Ovf_Un);
            _generator.Emit(OpCodes.Sub_Ovf_Un);
            return this;
        }
        public IFluentILGenerator Endfinally()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Endfinally);
            _generator.Emit(OpCodes.Endfinally);
            return this;
        }
        public IFluentILGenerator Stind_I()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Stind_I);
            _generator.Emit(OpCodes.Stind_I);
            return this;
        }
        public IFluentILGenerator Conv_U()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Conv_U);
            _generator.Emit(OpCodes.Conv_U);
            return this;
        }
        public IFluentILGenerator Prefix7()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Prefix7);
            _generator.Emit(OpCodes.Prefix7);
            return this;
        }
        public IFluentILGenerator Prefix6()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Prefix6);
            _generator.Emit(OpCodes.Prefix6);
            return this;
        }
        public IFluentILGenerator Prefix5()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Prefix5);
            _generator.Emit(OpCodes.Prefix5);
            return this;
        }
        public IFluentILGenerator Prefix4()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Prefix4);
            _generator.Emit(OpCodes.Prefix4);
            return this;
        }
        public IFluentILGenerator Prefix3()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Prefix3);
            _generator.Emit(OpCodes.Prefix3);
            return this;
        }
        public IFluentILGenerator Prefix2()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Prefix2);
            _generator.Emit(OpCodes.Prefix2);
            return this;
        }
        public IFluentILGenerator Prefix1()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Prefix1);
            _generator.Emit(OpCodes.Prefix1);
            return this;
        }
        public IFluentILGenerator Prefixref()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Prefixref);
            _generator.Emit(OpCodes.Prefixref);
            return this;
        }
        public IFluentILGenerator Arglist()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Arglist);
            _generator.Emit(OpCodes.Arglist);
            return this;
        }
        public IFluentILGenerator Ceq()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Ceq);
            _generator.Emit(OpCodes.Ceq);
            return this;
        }
        public IFluentILGenerator Cgt()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Cgt);
            _generator.Emit(OpCodes.Cgt);
            return this;
        }
        public IFluentILGenerator Cgt_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Cgt_Un);
            _generator.Emit(OpCodes.Cgt_Un);
            return this;
        }
        public IFluentILGenerator Clt()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Clt);
            _generator.Emit(OpCodes.Clt);
            return this;
        }
        public IFluentILGenerator Clt_Un()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Clt_Un);
            _generator.Emit(OpCodes.Clt_Un);
            return this;
        }
        public IFluentILGenerator Localloc()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Localloc);
            _generator.Emit(OpCodes.Localloc);
            return this;
        }
        public IFluentILGenerator Endfilter()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Endfilter);
            _generator.Emit(OpCodes.Endfilter);
            return this;
        }
        public IFluentILGenerator Volatile()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Volatile);
            _generator.Emit(OpCodes.Volatile);
            return this;
        }
        public IFluentILGenerator Tailcall()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Tailcall);
            _generator.Emit(OpCodes.Tailcall);
            return this;
        }
        public IFluentILGenerator Cpblk()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Cpblk);
            _generator.Emit(OpCodes.Cpblk);
            return this;
        }
        public IFluentILGenerator Initblk()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Initblk);
            _generator.Emit(OpCodes.Initblk);
            return this;
        }
        public IFluentILGenerator Rethrow()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Rethrow);
            _generator.Emit(OpCodes.Rethrow);
            return this;
        }
        public IFluentILGenerator Refanytype()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Refanytype);
            _generator.Emit(OpCodes.Refanytype);
            return this;
        }
        public IFluentILGenerator Readonly()
        {
            _logger?.LogNoOperand(ILOffset, OpCodes.Readonly);
            _generator.Emit(OpCodes.Readonly);
            return this;
        }
        public IFluentILGenerator Ldc_I4(int value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldc_I4, value);
            _generator.Emit(OpCodes.Ldc_I4, value);
            return this;
        }
        public IFluentILGenerator Ldc_I8(long value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldc_I8, value);
            _generator.Emit(OpCodes.Ldc_I8, value);
            return this;
        }
        public IFluentILGenerator Ldc_I4_S(sbyte value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldc_I4_S, value);
            _generator.Emit(OpCodes.Ldc_I4_S, value);
            return this;
        }
        public IFluentILGenerator Ldc_R8(double value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldc_R8, value);
            _generator.Emit(OpCodes.Ldc_R8, value);
            return this;
        }
        public IFluentILGenerator Ldc_R4(float value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldc_R4, value);
            _generator.Emit(OpCodes.Ldc_R4, value);
            return this;
        }
        public IFluentILGenerator Ldarg(uint value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldarg, value);
            _generator.Emit(OpCodes.Ldarg, value);
            return this;
        }
        public IFluentILGenerator Ldarga(uint value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldarga, value);
            _generator.Emit(OpCodes.Ldarga, value);
            return this;
        }
        public IFluentILGenerator Starg(uint value)
        {
            _logger?.Log(ILOffset, OpCodes.Starg, value);
            _generator.Emit(OpCodes.Starg, value);
            return this;
        }
        public IFluentILGenerator Ldloc(uint value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldloc, value);
            _generator.Emit(OpCodes.Ldloc, value);
            return this;
        }
        public IFluentILGenerator Ldloca(uint value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldloca, value);
            _generator.Emit(OpCodes.Ldloca, value);
            return this;
        }
        public IFluentILGenerator Stloc(uint value)
        {
            _logger?.Log(ILOffset, OpCodes.Stloc, value);
            _generator.Emit(OpCodes.Stloc, value);
            return this;
        }
        public IFluentILGenerator Ldarg_S(byte value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldarg_S, value);
            _generator.Emit(OpCodes.Ldarg_S, value);
            return this;
        }
        public IFluentILGenerator Ldarga_S(byte value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldarga_S, value);
            _generator.Emit(OpCodes.Ldarga_S, value);
            return this;
        }
        public IFluentILGenerator Starg_S(byte value)
        {
            _logger?.Log(ILOffset, OpCodes.Starg_S, value);
            _generator.Emit(OpCodes.Starg_S, value);
            return this;
        }
        public IFluentILGenerator Ldloc_S(byte value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldloc_S, value);
            _generator.Emit(OpCodes.Ldloc_S, value);
            return this;
        }
        public IFluentILGenerator Ldloca_S(byte value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldloca_S, value);
            _generator.Emit(OpCodes.Ldloca_S, value);
            return this;
        }
        public IFluentILGenerator Stloc_S(byte value)
        {
            _logger?.Log(ILOffset, OpCodes.Stloc_S, value);
            _generator.Emit(OpCodes.Stloc_S, value);
            return this;
        }
        public IFluentILGenerator Ldarg(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldarg, value);
            _generator.Emit(OpCodes.Ldarg, value);
            return this;
        }
        public IFluentILGenerator Ldarga(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldarga, value);
            _generator.Emit(OpCodes.Ldarga, value);
            return this;
        }
        public IFluentILGenerator Starg(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Starg, value);
            _generator.Emit(OpCodes.Starg, value);
            return this;
        }
        public IFluentILGenerator Ldloc(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldloc, value);
            _generator.Emit(OpCodes.Ldloc, value);
            return this;
        }
        public IFluentILGenerator Ldloca(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldloca, value);
            _generator.Emit(OpCodes.Ldloca, value);
            return this;
        }
        public IFluentILGenerator Stloc(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Stloc, value);
            _generator.Emit(OpCodes.Stloc, value);
            return this;
        }
        public IFluentILGenerator Ldarg_S(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldarg_S, value);
            _generator.Emit(OpCodes.Ldarg_S, value);
            return this;
        }
        public IFluentILGenerator Ldarga_S(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldarga_S, value);
            _generator.Emit(OpCodes.Ldarga_S, value);
            return this;
        }
        public IFluentILGenerator Starg_S(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Starg_S, value);
            _generator.Emit(OpCodes.Starg_S, value);
            return this;
        }
        public IFluentILGenerator Ldloc_S(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldloc_S, value);
            _generator.Emit(OpCodes.Ldloc_S, value);
            return this;
        }
        public IFluentILGenerator Ldloca_S(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldloca_S, value);
            _generator.Emit(OpCodes.Ldloca_S, value);
            return this;
        }
        public IFluentILGenerator Stloc_S(LocalBuilder value)
        {
            _logger?.Log(ILOffset, OpCodes.Stloc_S, value);
            _generator.Emit(OpCodes.Stloc_S, value);
            return this;
        }
        public IFluentILGenerator Br(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Br, value);
            _generator.Emit(OpCodes.Br, value);
            return this;
        }
        public IFluentILGenerator Brfalse(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Brfalse, value);
            _generator.Emit(OpCodes.Brfalse, value);
            return this;
        }
        public IFluentILGenerator Brtrue(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Brtrue, value);
            _generator.Emit(OpCodes.Brtrue, value);
            return this;
        }
        public IFluentILGenerator Beq(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Beq, value);
            _generator.Emit(OpCodes.Beq, value);
            return this;
        }
        public IFluentILGenerator Bge(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Bge, value);
            _generator.Emit(OpCodes.Bge, value);
            return this;
        }
        public IFluentILGenerator Bgt(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Bgt, value);
            _generator.Emit(OpCodes.Bgt, value);
            return this;
        }
        public IFluentILGenerator Ble(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Ble, value);
            _generator.Emit(OpCodes.Ble, value);
            return this;
        }
        public IFluentILGenerator Blt(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Blt, value);
            _generator.Emit(OpCodes.Blt, value);
            return this;
        }
        public IFluentILGenerator Bne_Un(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Bne_Un, value);
            _generator.Emit(OpCodes.Bne_Un, value);
            return this;
        }
        public IFluentILGenerator Bge_Un(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Bge_Un, value);
            _generator.Emit(OpCodes.Bge_Un, value);
            return this;
        }
        public IFluentILGenerator Bgt_Un(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Bgt_Un, value);
            _generator.Emit(OpCodes.Bgt_Un, value);
            return this;
        }
        public IFluentILGenerator Ble_Un(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Ble_Un, value);
            _generator.Emit(OpCodes.Ble_Un, value);
            return this;
        }
        public IFluentILGenerator Blt_Un(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Blt_Un, value);
            _generator.Emit(OpCodes.Blt_Un, value);
            return this;
        }
        public IFluentILGenerator Leave(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Leave, value);
            _generator.Emit(OpCodes.Leave, value);
            return this;
        }
        public IFluentILGenerator Br_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Br_S, value);
            _generator.Emit(OpCodes.Br_S, value);
            return this;
        }
        public IFluentILGenerator Brfalse_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Brfalse_S, value);
            _generator.Emit(OpCodes.Brfalse_S, value);
            return this;
        }
        public IFluentILGenerator Brtrue_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Brtrue_S, value);
            _generator.Emit(OpCodes.Brtrue_S, value);
            return this;
        }
        public IFluentILGenerator Beq_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Beq_S, value);
            _generator.Emit(OpCodes.Beq_S, value);
            return this;
        }
        public IFluentILGenerator Bge_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Bge_S, value);
            _generator.Emit(OpCodes.Bge_S, value);
            return this;
        }
        public IFluentILGenerator Bgt_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Bgt_S, value);
            _generator.Emit(OpCodes.Bgt_S, value);
            return this;
        }
        public IFluentILGenerator Ble_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Ble_S, value);
            _generator.Emit(OpCodes.Ble_S, value);
            return this;
        }
        public IFluentILGenerator Blt_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Blt_S, value);
            _generator.Emit(OpCodes.Blt_S, value);
            return this;
        }
        public IFluentILGenerator Bne_Un_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Bne_Un_S, value);
            _generator.Emit(OpCodes.Bne_Un_S, value);
            return this;
        }
        public IFluentILGenerator Bge_Un_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Bge_Un_S, value);
            _generator.Emit(OpCodes.Bge_Un_S, value);
            return this;
        }
        public IFluentILGenerator Bgt_Un_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Bgt_Un_S, value);
            _generator.Emit(OpCodes.Bgt_Un_S, value);
            return this;
        }
        public IFluentILGenerator Ble_Un_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Ble_Un_S, value);
            _generator.Emit(OpCodes.Ble_Un_S, value);
            return this;
        }
        public IFluentILGenerator Blt_Un_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Blt_Un_S, value);
            _generator.Emit(OpCodes.Blt_Un_S, value);
            return this;
        }
        public IFluentILGenerator Leave_S(Label value)
        {
            _logger?.Log(ILOffset, OpCodes.Leave_S, value);
            _generator.Emit(OpCodes.Leave_S, value);
            return this;
        }
        public IFluentILGenerator Switch(Label[] value)
        {
            _logger?.Log(ILOffset, OpCodes.Switch, value);
            _generator.Emit(OpCodes.Switch, value);
            return this;
        }
        public IFluentILGenerator Unbox(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Unbox, value);
            _generator.Emit(OpCodes.Unbox, value);
            return this;
        }
        public IFluentILGenerator Stobj(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Stobj, value);
            _generator.Emit(OpCodes.Stobj, value);
            return this;
        }
        public IFluentILGenerator Box(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Box, value);
            _generator.Emit(OpCodes.Box, value);
            return this;
        }
        public IFluentILGenerator Refanyval(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Refanyval, value);
            _generator.Emit(OpCodes.Refanyval, value);
            return this;
        }
        public IFluentILGenerator Mkrefany(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Mkrefany, value);
            _generator.Emit(OpCodes.Mkrefany, value);
            return this;
        }
        public IFluentILGenerator Sizeof(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Sizeof, value);
            _generator.Emit(OpCodes.Sizeof, value);
            return this;
        }
        public IFluentILGenerator Jmp(MethodInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Jmp, value);
            _generator.Emit(OpCodes.Jmp, value);
            return this;
        }
        public IFluentILGenerator Call(MethodInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Call, value);
            _generator.Emit(OpCodes.Call, value);
            return this;
        }
        public IFluentILGenerator Ldftn(MethodInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldftn, value);
            _generator.Emit(OpCodes.Ldftn, value);
            return this;
        }
        public IFluentILGenerator Ldvirtftn(MethodInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldvirtftn, value);
            _generator.Emit(OpCodes.Ldvirtftn, value);
            return this;
        }
        public IFluentILGenerator Cpobj(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Cpobj, value);
            _generator.Emit(OpCodes.Cpobj, value);
            return this;
        }
        public IFluentILGenerator Ldobj(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldobj, value);
            _generator.Emit(OpCodes.Ldobj, value);
            return this;
        }
        public IFluentILGenerator Castclass(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Castclass, value);
            _generator.Emit(OpCodes.Castclass, value);
            return this;
        }
        public IFluentILGenerator Isinst(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Isinst, value);
            _generator.Emit(OpCodes.Isinst, value);
            return this;
        }
        public IFluentILGenerator Newarr(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Newarr, value);
            _generator.Emit(OpCodes.Newarr, value);
            return this;
        }
        public IFluentILGenerator Ldelema(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldelema, value);
            _generator.Emit(OpCodes.Ldelema, value);
            return this;
        }
        public IFluentILGenerator Ldelem(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldelem, value);
            _generator.Emit(OpCodes.Ldelem, value);
            return this;
        }
        public IFluentILGenerator Stelem(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Stelem, value);
            _generator.Emit(OpCodes.Stelem, value);
            return this;
        }
        public IFluentILGenerator Unbox_Any(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Unbox_Any, value);
            _generator.Emit(OpCodes.Unbox_Any, value);
            return this;
        }
        public IFluentILGenerator Initobj(Type value)
        {
            _logger?.Log(ILOffset, OpCodes.Initobj, value);
            _generator.Emit(OpCodes.Initobj, value);
            return this;
        }
        public IFluentILGenerator Callvirt(MethodInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Callvirt, value);
            _generator.Emit(OpCodes.Callvirt, value);
            return this;
        }
        public IFluentILGenerator Newobj(MethodInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Newobj, value);
            _generator.Emit(OpCodes.Newobj, value);
            return this;
        }
        public IFluentILGenerator Ldfld(FieldInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldfld, value);
            _generator.Emit(OpCodes.Ldfld, value);
            return this;
        }
        public IFluentILGenerator Ldflda(FieldInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldflda, value);
            _generator.Emit(OpCodes.Ldflda, value);
            return this;
        }
        public IFluentILGenerator Stfld(FieldInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Stfld, value);
            _generator.Emit(OpCodes.Stfld, value);
            return this;
        }
        public IFluentILGenerator Ldsfld(FieldInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldsfld, value);
            _generator.Emit(OpCodes.Ldsfld, value);
            return this;
        }
        public IFluentILGenerator Ldsflda(FieldInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldsflda, value);
            _generator.Emit(OpCodes.Ldsflda, value);
            return this;
        }
        public IFluentILGenerator Stsfld(FieldInfo value)
        {
            _logger?.Log(ILOffset, OpCodes.Stsfld, value);
            _generator.Emit(OpCodes.Stsfld, value);
            return this;
        }
        public IFluentILGenerator Ldstr(string value)
        {
            _logger?.Log(ILOffset, OpCodes.Ldstr, value);
            _generator.Emit(OpCodes.Ldstr, value);
            return this;
        }
    }
}
