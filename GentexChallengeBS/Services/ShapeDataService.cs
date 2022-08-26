using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using GentexChallengeBS.Services.Interfaces;
using GentexChallengeBS.Models;

namespace GentexChallengeBS.Services
{
    internal class ShapeDataService : IShapeDataService
    {
        public List<Shapes> GetAllShapes()
        {
            List<Shapes> finalShapes = null;

            try
            {
                string shapes = File.ReadAllText(@"c:\temp\Shapes-49464.json");

                finalShapes = new List<Shapes>();
                //Shapes allShapes = new Shapes();

                var allShapes = JsonSerializer.Deserialize<Shapes>(shapes);
                finalShapes.Add(allShapes);

                return finalShapes;
            }
            catch (Exception)
            {

                throw;
            }
            
         
        }

        public List<Circle> GetCircles()
        {
            List<Circle> circles = new List<Circle>();

            circles = GetAllShapes().SelectMany(c => c.Circles).ToList();

            return circles;
        }

        public List<Ellipse> GetEllipses()
        {
            List<Ellipse> ellipses = new List<Ellipse>();

            ellipses = GetAllShapes().SelectMany(c => c.Ellipses).ToList();

            return ellipses;
        }

        public List<EquilateralTriangle> GetEquilateralTriangles()
        {
            List<EquilateralTriangle> eqTriangles = new List<EquilateralTriangle>();

            eqTriangles = GetAllShapes().SelectMany(c => c.EquilateralTriangles).ToList();

            return eqTriangles;
        }

        public List<Polygon> GetPolygons()
        {
            List<Polygon> polygons = new List<Polygon>();

            polygons = GetAllShapes().SelectMany(c => c.Polygons).ToList();

            return polygons;
        }

        public List<Square> GetSquares()
        {
            List<Square> squares = new List<Square>();

            squares = GetAllShapes().SelectMany(c => c.Squares).ToList();

            return squares;
        }

        //public List<T> GetCertainShape<T>()
        //{
        //    List<T> typeShapes = new List<T>();

        //    List<Shapes> tempShapes = new List<Shapes>();
        //    tempShapes = GetAllShapes();

        //    typeShapes = tempShapes.Select(c => c.GetType() == typeof(List<T>)).OfType<List<T>>().ToList();
        //    typeShapes = typeShapes.Where(c => c.GetType() == typeof(T)).ToList();

        //    return typeShapes;
        //}

    }
}
