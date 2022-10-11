using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Genome
    {
        public List<Point> Coords = new List<Point>();

        public int nextX, nextY;

        public int genomeID;


        public int nextXCoord(Random r)
        {
            nextX = r.Next(-10, 10);

            return nextX;
        }

        public int nextYCoord(Random r)
        {
            nextY = r.Next(-10, 10);

            return nextY;
        }

        //returns the list of points
        public List<Point> getCoordinates()
        {
            return Coords;
        }
        //returns the GenomeID
        public int getGenomeID()
        {
            return genomeID;
        }

        //constructor class
        public Genome()
        {

        }

        //overloading constructor class
        public Genome(List<Point> p, int id)
        {
            this.Coords = p;
            this.genomeID = id;
        }
    }
}
