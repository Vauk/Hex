using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Hex
{
    class Hex
    {

        public enum TerrainType
        {
            Desert = 1,     //Clear
            Plains = 2,     //Clear
            Swamp = 3,      //Rough
            Forest = 4,     //Rough
            Mountain = 5,   //Extreme
            Volcano = 6,    //Extreme
            Lava = 7        //Extreme
        }

        /* ------------ Members ------------ */
        public Point[] Polygon;
        public int Terrain;
        public bool Road;
        public bool Hill;
        public GameUnit LandUnit;
        public GameUnit AirUnit;

        public Hex(Point[] p, int ttype, bool r, bool h)
        {
            Polygon = p;
            Terrain = ttype;
            Road = r;
            Hill = h;
        }
    }
}
