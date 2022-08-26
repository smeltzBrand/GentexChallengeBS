using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Models;

namespace GentexChallengeBS.Services.Interfaces
{
    internal interface IEquilateralTriangleCalcService
    {
        public float GetTriangleArea(EquilateralTriangle equilateralTriangle);

        public float GetTrianglePerimeter(EquilateralTriangle equilateralTriangle);

    }
}
