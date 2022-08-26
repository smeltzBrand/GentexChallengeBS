using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Models;

namespace GentexChallengeBS.Services.Interfaces
{
    internal interface IShapeDataService
    {
        public List<Shapes> GetAllShapes();

        public List<Polygon> GetPolygons();

        public List<Square> GetSquares();

        public List<Circle> GetCircles();

        public List<Ellipse> GetEllipses();

        public List<EquilateralTriangle> GetEquilateralTriangles();



    }
}
