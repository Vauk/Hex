using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hex
{
    public partial class HexGameWindow : Form
    {
        private Map map = new Map();
        private static GEngine gEngine;
        private static int currentMapEditOption = 0;
        private static bool currentMapAddRoad = false;

        public HexGameWindow()
        {
            InitializeComponent();
            map.initMap(10, 60, 15);
            

            this.ClientSize = new Size(Map.screenSizeWidth + mapEditPanel.Width, Map.screenSizeHeight);
            canvas.Width = Map.screenSizeWidth + mapEditPanel.Width; 
            canvas.Height = Map.screenSizeHeight;

            Point mapEditPanelLoc = new Point(Map.screenSizeWidth, 10);
            mapEditPanel.Location = mapEditPanelLoc;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = canvas.CreateGraphics();
            startGraphics(g);
        }

        private void HexGameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopGame();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickPoint = e.Location;
            Point clickHex = Map.getBoardLocation(clickPoint);
            if (currentMapEditOption != 0)
            {
                Map.setHexStyle(clickHex, currentMapEditOption);
            }
            if (currentMapAddRoad)
            {
                Map.setHexStyle(clickHex, currentMapAddRoad);
            }
        }

        public void startGraphics(Graphics g)
        {
            gEngine = new GEngine(g);
            gEngine.init();
        }

        public void stopGame()
        {
            gEngine.stop();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point relativePoint = this.PointToClient(Cursor.Position);
            lblMouseCoor.Text = relativePoint.X + "," + relativePoint.Y;
        }

        private void btnDesert_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("C:\\Users\\rsakowski\\Documents\\Visual Studio 2015\\Projects\\Hex\\Hex\\Images\\MapEditorDragImages\\Desert.cur");
            canvas.Cursor = c;
            currentMapEditOption = (int)Hex.TerrainType.Desert;
        }

        private void btnPlains_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("C:\\Users\\rsakowski\\Documents\\Visual Studio 2015\\Projects\\Hex\\Hex\\Images\\MapEditorDragImages\\Plains.cur");
            canvas.Cursor = c;
            currentMapEditOption = (int)Hex.TerrainType.Plains;
        }

        private void btnSwamp_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("C:\\Users\\rsakowski\\Documents\\Visual Studio 2015\\Projects\\Hex\\Hex\\Images\\MapEditorDragImages\\Swamp.cur");
            canvas.Cursor = c;
            currentMapEditOption = (int)Hex.TerrainType.Swamp;

        }

        private void btnForest_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("C:\\Users\\rsakowski\\Documents\\Visual Studio 2015\\Projects\\Hex\\Hex\\Images\\MapEditorDragImages\\Forest.cur");
            canvas.Cursor = c;
            currentMapEditOption = (int)Hex.TerrainType.Forest;

        }

        private void btnMountain_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("C:\\Users\\rsakowski\\Documents\\Visual Studio 2015\\Projects\\Hex\\Hex\\Images\\MapEditorDragImages\\Mountain.cur");
            canvas.Cursor = c;
            currentMapEditOption = (int)Hex.TerrainType.Mountain;

        }

        private void btnVolcano_Click(object sender, EventArgs e)
        {

        }

        private void btnLava_Click(object sender, EventArgs e)
        {

        }

        private void btnRoad_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("C:\\Users\\rsakowski\\Documents\\Visual Studio 2015\\Projects\\Hex\\Hex\\Images\\MapEditorDragImages\\Road.cur");
            canvas.Cursor = c;
            currentMapEditOption = 0;
            currentMapAddRoad = true;
        }
    }
}
