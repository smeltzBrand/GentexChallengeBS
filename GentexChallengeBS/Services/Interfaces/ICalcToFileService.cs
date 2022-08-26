using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Models;

namespace GentexChallengeBS.Services.Interfaces
{
    internal interface ICalcToFileService
    {

        public void AllCalcToFileDrive();
        public List<String> SquareCalcToFile(List<String> csv);
        public List<String> CircleCalcToFile(List<String> csv);
        public List<String> EquilateralTriangleCalcToFile(List<String> csv);
        public List<String> EllipseCalcToFile(List<String> csv);
        public List<String> PolygonCalcToFile(List<String> csv);


    }
}
