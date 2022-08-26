using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Services.Interfaces;
using GentexChallengeBS.Models;

namespace GentexChallengeBS.Services
{
    internal class CircleCalcService : ICircleCalcService
    {
        public float GetCircleArea(float radius)
        {
            float area = 0;

            area = Convert.ToSingle(Math.PI * (Math.Pow(radius, 2)));

            return area;
        }
        
        public float GetCirclePerimeter(float radius)
        {
            float perimeter = 0;

            perimeter = Convert.ToSingle(2 * Math.PI * radius);

            return perimeter;
        }
    }
}
