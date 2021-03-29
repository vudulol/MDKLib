using System;
using System.Collections.Generic;

namespace Spesivcev
{
    public class Quadratic : Linear
    {
        public new List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return base.Solve(b, c, 0);
            }
            float D = discriminant(a, b, c);
            MyLog.Log("Это квадратное уровнение");

            if (D == 0)
            {
                return X = new List<float>() { (float)(-b + Math.Sqrt(D)) / (2 * a) };
            }

            if (D > 0)
            {
                return X = new List<float>()
                {
                    (float)(-b + Math.Sqrt(D)) / (2 * a),
                    (float)(-b - Math.Sqrt(D)) / (2 * a)
                };
            }
            if (D < 0)
            {
                throw new SpesivcevException("Уравнение не имеет решений.");
            }
            return X;
        }
        protected float discriminant(float a, float b, float c)
        {
            return (float)Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
