using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Models;
using GentexChallengeBS.Services.Interfaces;

namespace GentexChallengeBS.Services
{
    internal class EquilateralTriangleCalcService : IEquilateralTriangleCalcService
    {
        public float GetTriangleArea(EquilateralTriangle equilateralTriangle)
        {
            double a = ((Math.Sqrt(3)) / 4) * Math.Pow(equilateralTriangle.SideLength, 2);

            return Convert.ToSingle(a);
        }

        public float GetTrianglePerimeter(EquilateralTriangle equilateralTriangle)
        {
            float p = equilateralTriangle.SideLength * 3;

            return p;
        }

    }
}
