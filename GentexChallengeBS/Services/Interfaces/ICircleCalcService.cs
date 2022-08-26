using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentexChallengeBS.Services.Interfaces
{
    internal interface ICircleCalcService
    {
        public float GetCircleArea(float radius);

        public float GetCirclePerimeter(float radius);

    }
}
