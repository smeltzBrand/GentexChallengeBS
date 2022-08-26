using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Models;
using GentexChallengeBS.Services.Interfaces;

namespace GentexChallengeBS.Services
{
    internal class PolygonCalcService : IPolygonCalcService
    {

        public float [] GetPolygonCentroid(Polygon poly)
        {
            float summedArea = 0.0f;
            float centerX = 0.0f;
            float centerY = 0.0f;

            for (int i = 0, j = poly.XCoordinates.Length - 1; i < poly.XCoordinates.Length; j = i++)
            {
                float temp = poly.XCoordinates[i] * poly.YCoordinates[j] - poly.XCoordinates[j] * poly.YCoordinates[i];
                summedArea += temp;
                centerX += (poly.XCoordinates[i] + poly.XCoordinates[j]) * temp;
                centerY += (poly.YCoordinates[i] + poly.YCoordinates[j]) * temp;
            }

            summedArea *= 3f;

            float[] centroid = new float[] { centerX / summedArea, centerY / summedArea };

            return centroid;
            
        }

        public float GetPolygonArea(Polygon poly)
        {
            int n = poly.XCoordinates.Length;
            double a = 0.0;
            for (int i = 0; i < n - 1; i++)
            {
                a += poly.XCoordinates[i] * poly.YCoordinates[i + 1] - poly.XCoordinates[i + 1] * poly.YCoordinates[i];
            }
            
            double finalA = Math.Abs(a + poly.XCoordinates[n - 1] * poly.YCoordinates[0] - poly.XCoordinates[0] * poly.YCoordinates[n - 1]) / 2.0;

            return Convert.ToSingle(finalA);
        }

        public float GetPolygonPerimeter(Polygon poly)
        {
            int n = poly.XCoordinates.Length;
            double p = 0.0;
            for(int i = 0; i < n - 1; i++)
            {
                float x1 = poly.XCoordinates[i];
                float x2 = poly.XCoordinates[i + 1];
                float y1 = poly.YCoordinates[i];
                float y2 = poly.YCoordinates[i + 1];

                p += Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            }

                float xN = poly.XCoordinates[n - 1];
                float x0 = poly.XCoordinates[0];
                float yN = poly.YCoordinates[n - 1];
                float y0 = poly.YCoordinates[0];

            double finalP = Math.Sqrt((Math.Pow(xN - x0, 2) + Math.Pow(yN - y0, 2)));

            return Convert.ToSingle(p);
        }
    }
}
