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

        public Point hexMidPoint;
        public Point nMidPoint;
        public Point neMidPoint;
        public Point seMidPoint;
        public Point sMidPoint;
        public Point swMidPoint;
        public Point nwMidPoint;

        // Points for Road when no surrounding Hexes have roads
        public Point HexLeftMidPoint;
        public Point HexRightMidPoint;

        public Hex(Point[] p, int ttype, bool r, bool h)
        {
            Polygon = p;
            Terrain = ttype;
            Road = r;
            Hill = h;
            getMidpoints();
        }

        public void getMidpoints()
        {
            nMidPoint = getMidPoint(Polygon[0], Polygon[1]);
            neMidPoint = getMidPoint(Polygon[1], Polygon[2]);
            seMidPoint = getMidPoint(Polygon[2], Polygon[3]);
            sMidPoint = getMidPoint(Polygon[3], Polygon[4]);
            swMidPoint = getMidPoint(Polygon[4], Polygon[5]);
            nwMidPoint = getMidPoint(Polygon[5], Polygon[0]);
            hexMidPoint = getMidPoint(Polygon[5], Polygon[2]);

            HexLeftMidPoint = getMidPoint(Polygon[5], hexMidPoint);
            HexRightMidPoint = getMidPoint(hexMidPoint, Polygon[2]);
        }

        public Point getMidPoint(Point firstPoint, Point secondPoint)
        {
            return new Point((firstPoint.X + secondPoint.X) / 2, (firstPoint.Y + secondPoint.Y) / 2);
        }
    }
}
