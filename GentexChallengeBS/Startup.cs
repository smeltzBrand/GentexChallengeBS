using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GentexChallengeBS.Services;
using GentexChallengeBS.Services.Interfaces;

namespace GentexChallengeBS
{
    public class Startup
    {
        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                    .AddSingleton<IShapeDataService, ShapeDataService>()
                    .AddSingleton<ICalcToFileService, CalcToFileService>()
                    .AddSingleton<ISquareCalcService, SquareCalcService>()
                    .AddSingleton<ICircleCalcService, CircleCalcService>()
                    .AddSingleton<IEquilateralTriangleCalcService, EquilateralTriangleCalcService>()
                    .AddSingleton<IEllipseCalcService, EllipseCalcService>()
                    .AddSingleton<IPolygonCalcService, PolygonCalcService>()
                    .BuildServiceProvider();
            return provider;


        }
    }
}
