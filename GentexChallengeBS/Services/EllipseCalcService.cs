using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Models;
using GentexChallengeBS.Services.Interfaces;

namespace GentexChallengeBS.Services
{
    internal class EllipseCalcService : IEllipseCalcService
    {
        public float GetEllipseArea(Ellipse ellipse)
        {
            double a = Math.PI * ellipse.R1 * ellipse.R2;

            return Convert.ToSingle(a);
        }

        public float GetEllipsePerimeter(Ellipse ellipse)
        {
            double a = ellipse.R1;
            double b = ellipse.R2;

            double p = 2 * Math.PI * Math.Sqrt((a * a + b * b) / (2 * 1.0));

            return Convert.ToSingle(p);
        }

    }
}
