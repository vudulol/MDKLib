using System;
using System.Collections.Generic;
using Lab.core;

namespace Spesivcev
{
    public class Linear : EquationInterface
    {
        protected List<float> X;
        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                throw new SpesivcevException("Такое уравнение не существует");
            }
            MyLog.Log("Это линейное уровнение");
            return X = new List<float>() { -b / a };
        }
    }
}
