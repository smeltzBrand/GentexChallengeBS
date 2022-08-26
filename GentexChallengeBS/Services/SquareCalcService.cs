using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Models;
using GentexChallengeBS.Services.Interfaces;

namespace GentexChallengeBS.Services
{
    internal class SquareCalcService : ISquareCalcService
    {
        public float GetSquareArea(Square square)
        {
            double a = Math.Pow(square.SideLength, 2);

            return Convert.ToSingle(a);
        }

        public float GetSquarePerimeter(Square square)
        {
            float p = square.SideLength * 4;

            return p;
        }
    }
}
