﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Hex
{
    class Map
    {
        public static int boardSize = 0;               // Number of hexes along length and width
        private static int hexSize = 0;                 // hex size in pixels
        private static int hexBorder = 0;
        private static int side = 0;                    // length of one side
        private static int t = 0;                       // short side of 30 degree triangle outside of each hex
        private static int radius = 0;                  // radius of inscribed circle (centre to middle of each side). r= h/2
        private static int height = 0;                  // height. Distance between centres of two adjacent hexes. Distance between two opposite sides in a hex.

        public static int screenSizeHeight = 0;        // screensize vertical dimension
        public static int screenSizeWidth = 0;         // screensize horizontal dimension

        public static Hex[,] gameMap = null;

        public void initMap(int boardSize, int hexSize, int hexBorder)
        {
            Map.boardSize = boardSize;
            Map.hexSize = hexSize;
            Map.hexBorder = hexBorder;
            Map.gameMap = new Hex[boardSize, boardSize];

            Map.screenSizeHeight = (int)(Map.hexSize * (Map.boardSize + 0.5)) + Map.hexBorder * 2 + 3; // Have to add 3 pixels for some reason
            setHexSize(hexSize);
            Map.screenSizeWidth = (Map.side * Map.boardSize) + (Map.t * (Map.boardSize + 1)) + Map.hexBorder * 2 + 3; // Have to add 3 pixels for some reason

            createMap();
        }

        private void setHexSize(int heightToSet)
        {
            height = heightToSet;                       // h = basic dimension: height (distance between two adj centresr aka size)
            radius = height / 2;                        // r = radius of inscribed circle
            side = (int)(height / 1.73205);            // s = (h/2)/cos(30)= (h/2) / (sqrt(3)/2) = h / sqrt(3)
            t = (int)(radius / 1.73205);	            // t = (h/2) tan30 = (h/2) 1/sqrt(3) = h / (2 sqrt(3)) = r / sqrt(3)
        }

        private void createMap()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    gameMap[i, j] = new Hex(calcHex(i, j), (int)Hex.TerrainType.Desert, false, false);
                }
            }
        }

        private Point[] calcHex(int i, int j)
        {
            int x0 = i * (side + t);
            int y0 = j * height + (i % 2) * height / 2;

            int y = y0 + hexBorder;
            int x = x0 + hexBorder;

            Point[] polyPoints = new Point[6];

            if (side == 0 || height == 0)
            {
                System.Diagnostics.Debug.WriteLine("ERROR: size of hex has not been set");
                return polyPoints;
            }

            polyPoints[0] = new Point(x + t, y);
            polyPoints[1] = new Point(x + side + t, y);
            polyPoints[2] = new Point(x + side + t + t, y + radius);
            polyPoints[3] = new Point(x + side + t, y + radius + radius);
            polyPoints[4] = new Point(x + t, y + radius + radius);
            polyPoints[5] = new Point(x, y + radius);

            return polyPoints;
        }

        public static void drawMap(Graphics g)
        {
            for (int i = 0; i < Map.boardSize; i++)
            {
                for (int j = 0; j < Map.boardSize; j++)
                {
                    Point[] poly = Map.gameMap[i, j].Polygon;
                    int TerrainType = Map.gameMap[i, j].Terrain;
                    bool hasRoad = Map.gameMap[i, j].Road;
                    Color color = Color.Black;

                    // This needs to be taken care of somewhere else in future with assets
                    switch (TerrainType)
                    {
                        case (int)Hex.TerrainType.Desert:
                            color = Color.Tan;
                            break;
                        case (int)Hex.TerrainType.Plains:
                            color = Color.LightGreen;
                            break;
                        case (int)Hex.TerrainType.Swamp:
                            color = Color.DarkGray;
                            break;
                        case (int)Hex.TerrainType.Forest:
                            color = Color.DarkGreen;
                            break;
                        case (int)Hex.TerrainType.Mountain:
                            color = Color.LightGray;
                            break;
                    }

                    g.FillPolygon(new SolidBrush(color), poly);
                    g.DrawPolygon(new Pen(Color.Black), poly);

                    // This needs to be taken care of somewhere else in future with assets
                    if (hasRoad)
                    {
                        bool nHasRoad = false;
                        bool neHasRoad = false;
                        bool seHasRoad = false;
                        bool sHasRoad = false;
                        bool swHasRoad = false;
                        bool nwHasRoad = false;

                        //North
                        if (j - 1 >= 0)
                            nHasRoad = Map.gameMap[i, j - 1].Road;
                        //South
                        if (j + 1 < boardSize)
                            sHasRoad = Map.gameMap[i, j + 1].Road;
                        if (i % 2 == 0)
                        {
                            //NorthEast
                            if (i + 1 < boardSize && j - 1 >= 0)
                                neHasRoad = Map.gameMap[i + 1, j - 1].Road;
                            //SouthEast
                            if (i + 1 < boardSize)
                                seHasRoad = Map.gameMap[i + 1, j].Road;
                            //SouthWest
                            if (i - 1 >= 0)
                                swHasRoad = Map.gameMap[i - 1, j].Road;
                            //NorthWest
                            if (i - 1 >= 0 && j - 1 >= 0)
                                nwHasRoad = Map.gameMap[i - 1, j - 1].Road;
                        }
                        else
                        {
                            //NorthEast
                            if (i + 1 < boardSize)
                                neHasRoad = Map.gameMap[i + 1, j].Road;
                            //SouthEast
                            if (i + 1 < boardSize && j + 1 < boardSize)
                                seHasRoad = Map.gameMap[i + 1, j + 1].Road;
                            //SouthWest
                            if (i - 1 >= 0 && j + 1 < boardSize)
                                swHasRoad = Map.gameMap[i - 1, j + 1].Road;
                            //NorthWest
                            if (i - 1 >= 0)
                                nwHasRoad = Map.gameMap[i - 1, j].Road;
                        }
                        
                        if (!nHasRoad && !neHasRoad && !seHasRoad && !sHasRoad && !swHasRoad && !nwHasRoad)
                            g.DrawLine(new Pen(Color.Brown, 2), Map.gameMap[i,j].HexLeftMidPoint, Map.gameMap[i, j].HexRightMidPoint);

                        if (nHasRoad)
                            g.DrawLine(new Pen(Color.Brown, 2), Map.gameMap[i, j].hexMidPoint, Map.gameMap[i, j].nMidPoint);
                        if (neHasRoad)
                            g.DrawLine(new Pen(Color.Brown, 2), Map.gameMap[i, j].hexMidPoint, Map.gameMap[i, j].neMidPoint);
                        if (seHasRoad)
                            g.DrawLine(new Pen(Color.Brown, 2), Map.gameMap[i, j].hexMidPoint, Map.gameMap[i, j].seMidPoint);
                        if (sHasRoad)
                            g.DrawLine(new Pen(Color.Brown, 2), Map.gameMap[i, j].hexMidPoint, Map.gameMap[i, j].sMidPoint);
                        if (swHasRoad)
                            g.DrawLine(new Pen(Color.Brown, 2), Map.gameMap[i, j].hexMidPoint, Map.gameMap[i, j].swMidPoint);
                        if (nwHasRoad)
                            g.DrawLine(new Pen(Color.Brown, 2), Map.gameMap[i, j].hexMidPoint, Map.gameMap[i, j].nwMidPoint);
                    }
                }
            }
        }

        public static Point getBoardLocation(Point point)
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    Point[] poly = Map.gameMap[i, j].Polygon;

                    var coef = poly.Skip(1).Select((p, x) =>
                                                                (point.Y - poly[x].Y) * (p.X - poly[x].X)
                                                                - (point.X - poly[x].X) * (p.Y - poly[x].Y)).ToList();

                    bool isInHex = true;

                    for (int k = 1; k < coef.Count(); k++)
                    {
                        if (coef[k] * coef[k - 1] < 0)
                        {
                            isInHex = false;
                            break;
                        }
                    }

                    if (isInHex)
                        return new Point(i, j);
                }
            }
            return new Point(-1, -1);
        }

        public static void setHexStyle(Point p, int terrain)
        {
            gameMap[p.X, p.Y].Terrain = terrain;
        }

        public static void setHexStyle(Point p, bool road)
        {
            gameMap[p.X, p.Y].Road = !gameMap[p.X, p.Y].Road;
        }
    }
}
