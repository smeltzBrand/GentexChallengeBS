using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Models;

namespace GentexChallengeBS.Services.Interfaces
{
    internal interface IPolygonCalcService
    {
        public float[] GetPolygonCentroid(Polygon poly);

        public float GetPolygonArea(Polygon poly);

        public float GetPolygonPerimeter(Polygon poly);

    }
}
