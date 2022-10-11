using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Drawing;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = 15;
            int population = 12;

            Generation generation = new Generation(population, dnaLength);

            Genome genome = new Genome();

            foreach (Genome g in generation.returnGenomes())
            {
                int genomeNumber = g.getGenomeID();
                List<Point> points = g.getCoordinates();

                Console.WriteLine($"Genome Number: {genomeNumber}");

                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine($"X: {points[i].X} Y: {points[i].Y}");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}