using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Generation
    {
        List<Genome> genomes = new List<Genome>();

        List<Point> coords = new List<Point>();

        Random random = new Random();

        public Generation()
        {

        }

        public Generation(int population, int dnaLength)
        {
            //int genSize = 69; //generation size/population size
            //creates a list of list of points = to genSize^^^
            for (int i = 1; i <= population; i++)
            {
                //clears list of coordinates for next generated list of Points
                coords.Clear();

                //adds 131,490 as starting point for all list of points
                coords.Add(new Point(131, 490));

                //creates dnalength x and y points and adds them to a list of points
                for (int j = 1; j < dnaLength; j++)
                {
                    //generates random x and adds it onto previous x coord
                    int x = coords[j - 1].X + random.Next(-10, 10);
                    if (x < 0)
                    {
                        x *= -1;
                    }

                    //generates random y and adds it onto previous y coord
                    int y = coords[j - 1].Y + random.Next(-10, 10);
                    if (y < 0)
                    {
                        y *= -1;
                    }

                    //adds both x and y to coord
                    coords.Add(new Point(x, y));
                }

                //adds list of points to generation
                genomes.Add(new Genome(coords, i));
            }
        }
        
        public List<Genome> returnGenomes()
        {
            return genomes;
        }
    }
}
