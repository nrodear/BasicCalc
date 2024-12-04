using System;
using CalcLib.Engine;
using CalcLib.Types;

namespace BasicCalc.Standard
{
    internal class Methods
    {
        internal static Method<float> Clear()
        {
            return SimpleBase;

            [CalcType(CalcType.None)]
            [LevelType(LevelType.None)]
            [ArgsType(ArgsType.None)]
            float SimpleBase(float[] f)
            {
                Values.Clear();
                Elements.Clear();
                return -1;
            }
        }

        internal static Method<float> Result()
        {
            return SimpleBase;

            [CalcType(CalcType.None)]
            [LevelType(LevelType.None)]
            [ArgsType(ArgsType.None)]
            float SimpleBase(float[] f)
            {
                Values.Process();
                Values.Clear();
                return -1;
            }
        }

        internal static Method<float> Add()
        {
            return SimpleBase;

            [CalcType(CalcType.Func)]
            [LevelType(LevelType.Two)]
            [ArgsType(ArgsType.Two)]
            float SimpleBase(float[] f)
            {
                ValidateArgs(f, ArgsType.Two);
                return f[0] + f[1];
            }
        }

        internal static Method<float> Minus()
        {
            return SimpleBase;

            [CalcType(CalcType.Func)]
            [LevelType(LevelType.Two)]
            [ArgsType(ArgsType.Two)]
            float SimpleBase(float[] f)
            {
                ValidateArgs(f, ArgsType.Two);
                return f[0] - f[1];
            }
        }
        
        private static void ValidateArgs(float[] f, ArgsType  argType)
        {
            if (f != null && f.Length != (int)argType)
            {
                throw new ArgumentException("count args check failed");
            }
        }
    }
}