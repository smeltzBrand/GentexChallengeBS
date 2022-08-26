using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using GentexChallengeBS.Models;
using GentexChallengeBS.Services;
using GentexChallengeBS.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GentexChallengeBS
{
    internal class Program
    {
        
        
        public static void Main(string[] args)
        {
            var container = Startup.ConfigureService();

        
            //string shapes = File.ReadAllText(@"c:\temp\Shapes-49464.json");

            //Shapes allShapes = JsonSerializer.Deserialize<Shapes>(shapes);

            //List<Shapes> finalShapes = new List<Shapes>();
            //finalShapes.Add(allShapes);

            //List<Circle> circles = new List<Circle>();

            //circles = finalShapes.SelectMany(c => c.Circles).ToList();

            var shapeService = container.GetRequiredService<ICalcToFileService>();

            shapeService.AllCalcToFileDrive();

        }
    }
}
