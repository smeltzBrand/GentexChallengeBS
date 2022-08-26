using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Models;

namespace GentexChallengeBS.Services.Interfaces
{
    internal interface IEllipseCalcService
    {
        public float GetEllipseArea(Ellipse ellipse);

        public float GetEllipsePerimeter(Ellipse ellipse);

    }
}
