using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Models;
using GentexChallengeBS.Services.Interfaces;

namespace GentexChallengeBS.Services
{
    internal class CalcToFileService : ICalcToFileService
    {
        private readonly IShapeDataService shapeDataService;
        private readonly ISquareCalcService squareCalcService;
        private readonly ICircleCalcService circleCalcService;
        private readonly IEquilateralTriangleCalcService triangleService;
        private readonly IEllipseCalcService ellipseCalcService;
        private readonly IPolygonCalcService polygonCalcService;

        private readonly string filePath = "c:\\temp\\ShapeCalcs.csv";

        public CalcToFileService(IShapeDataService shapeDataService, ISquareCalcService squareCalcService, ICircleCalcService circleCalcService, IEquilateralTriangleCalcService triangleService, IEllipseCalcService ellipseCalcService, IPolygonCalcService polygonCalcService)
        {
            this.shapeDataService = shapeDataService;
            this.squareCalcService = squareCalcService;
            this.circleCalcService = circleCalcService;
            this.triangleService = triangleService;
            this.ellipseCalcService = ellipseCalcService;
            this.polygonCalcService = polygonCalcService;
        }

        public void AllCalcToFileDrive()
        {
            StringBuilder csvZero = new StringBuilder();

            var first = "Id";
            var second = "Area";
            var third = "Perimeter";
            var fourth = "CentroidX";
            var fifth = "CentroidX";
            var newLine = string.Format("{0},{1},{2},{3},{4}", first, second, third, fourth, fifth);
            csvZero.AppendLine(newLine);

           

            List<String> csv = new List<String>();

            SquareCalcToFile(csv);
            CircleCalcToFile(csv);
            EquilateralTriangleCalcToFile(csv);
            EllipseCalcToFile(csv);
            PolygonCalcToFile(csv);

            csv = csv.OrderBy(q => int.Parse(q.Split(',')[0])).ToList(); 

            for(int i = 0; i < 10; i++)
            {
            
                Console.WriteLine("{0}", csv[i]);
            }

            if (!File.Exists(filePath))
            {

                File.WriteAllText(filePath, csvZero.ToString());
                File.AppendAllLines(filePath, csv);

            }
            Console.ReadLine();
        }

        public List<String> SquareCalcToFile(List<String> csv)
        {
            List<Square> squares = shapeDataService.GetSquares();

            foreach (Square square in squares)
            {
                var first = square.Id.ToString();
                var second = squareCalcService.GetSquareArea(square).ToString();
                var third = squareCalcService.GetSquarePerimeter(square).ToString();
                var fourth = square.CenterX.ToString();
                var fifth = square.CenterY.ToString();
                var newLine = string.Format("{0},{1},{2},{3},{4}", first, second, third, fourth, fifth);
                csv.Add(newLine);

            }

            return csv;
        }

        public List<String> CircleCalcToFile(List<String> csv)
        {
            List<Circle> circles = shapeDataService.GetCircles();

            foreach (Circle circle in circles)
            {
                var first = circle.Id.ToString();
                var second = circleCalcService.GetCircleArea(circle.Radius).ToString();
                var third = circleCalcService.GetCirclePerimeter(circle.Radius).ToString();
                var fourth = circle.CenterX.ToString();
                var fifth = circle.CenterY.ToString();
                var newLine = string.Format("{0},{1},{2},{3},{4}", first, second, third, fourth, fifth);
                csv.Add(newLine);

            }

            return csv;
        }

        public List<String> EquilateralTriangleCalcToFile(List<String> csv)
        {
            List<EquilateralTriangle> triangles = shapeDataService.GetEquilateralTriangles();

            foreach (EquilateralTriangle triangle in triangles)
            {
                var first = triangle.Id.ToString();
                var second = triangleService.GetTriangleArea(triangle).ToString();
                var third = triangleService.GetTrianglePerimeter(triangle).ToString();
                var fourth = triangle.CenterX.ToString();
                var fifth = triangle.CenterY.ToString();
                var newLine = string.Format("{0},{1},{2},{3},{4}", first, second, third, fourth, fifth);
                csv.Add(newLine);

            }

            return csv;
        }

        public List<String> EllipseCalcToFile(List<String> csv)
        {
            List<Ellipse> ellipses = shapeDataService.GetEllipses();

            foreach (Ellipse ellipse in ellipses)
            {
                var first = ellipse.Id.ToString();
                var second = ellipseCalcService.GetEllipseArea(ellipse).ToString();
                var third = ellipseCalcService.GetEllipsePerimeter(ellipse).ToString();
                var fourth = ellipse.CenterX.ToString();
                var fifth = ellipse.CenterY.ToString();
                var newLine = string.Format("{0},{1},{2},{3},{4}", first, second, third, fourth, fifth);
                csv.Add(newLine);

            }

            return csv;
        }

        public List<String> PolygonCalcToFile(List<String> csv)
        {
            List<Polygon> polygons = shapeDataService.GetPolygons();

            foreach (Polygon polygon in polygons)
            {
                var first = polygon.Id.ToString();
                var second = polygonCalcService.GetPolygonArea(polygon).ToString();
                var third = polygonCalcService.GetPolygonPerimeter(polygon).ToString();
                var fourth = polygonCalcService.GetPolygonCentroid(polygon)[0].ToString();
                var fifth = polygonCalcService.GetPolygonCentroid(polygon)[1].ToString();
                var newLine = string.Format("{0},{1},{2},{3},{4}", first, second, third, fourth, fifth);
                csv.Add(newLine);

            }

            return csv;
        }
    }
}
