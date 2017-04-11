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
        private static int currentMapEditOption = 0;
        private static bool currentMapAddRoad = false;

        public HexGameWindow()
        {
            InitializeComponent();
            map.initMap(10, 60, 15);
            

            this.ClientSize = new Size(Map.screenSizeWidth + mapEditPanel.Width, Map.screenSizeHeight);

            Point mapEditPanelLoc = new Point(Map.screenSizeWidth, 10);
            mapEditPanel.Location = mapEditPanelLoc;
        }

        private void HexGameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //stopGame();
        }


        private void btnDesert_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("Images\\MapEditorDragImages\\Desert.cur");
            this.Cursor = c;
            currentMapEditOption = (int)Hex.TerrainType.Desert;
            currentMapAddRoad = false;
        }

        private void btnPlains_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("Images\\MapEditorDragImages\\Plains.cur");
            this.Cursor = c;
            currentMapEditOption = (int)Hex.TerrainType.Plains;
            currentMapAddRoad = false;
        }

        private void btnSwamp_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("Images\\MapEditorDragImages\\Swamp.cur");
            this.Cursor = c;
            currentMapEditOption = (int)Hex.TerrainType.Swamp;
            currentMapAddRoad = false;
        }

        private void btnForest_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("Images\\MapEditorDragImages\\Forest.cur");
            this.Cursor = c;
            currentMapEditOption = (int)Hex.TerrainType.Forest;
            currentMapAddRoad = false;
        }

        private void btnMountain_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("Images\\MapEditorDragImages\\Mountain.cur");
            this.Cursor = c;
            currentMapEditOption = (int)Hex.TerrainType.Mountain;
            currentMapAddRoad = false;
        }

        private void btnVolcano_Click(object sender, EventArgs e)
        {

        }

        private void btnLava_Click(object sender, EventArgs e)
        {

        }

        private void btnRoad_Click(object sender, EventArgs e)
        {
            Cursor c = new Cursor("Images\\MapEditorDragImages\\Road.cur");
            this.Cursor = c;
            currentMapEditOption = 0;
            currentMapAddRoad = true;
        }

        private void HexGameWindow_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            this.Paint += HexGameWindow_Paint;
        }

        private void HexGameWindow_Paint(object sender, PaintEventArgs e)
        {
            Map.drawMap(e.Graphics);
            //throw new NotImplementedException();
        }

        private void tmrAppTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void HexGameWindow_Click(object sender, EventArgs e)
        {

        }

        private void HexGameWindow_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickHex = Map.getBoardLocation(e.Location);

            if (clickHex.X >= 0 && clickHex.X < Map.boardSize && clickHex.Y >= 0 && clickHex.Y < Map.boardSize)
            {
                if (currentMapEditOption != 0)
                {
                    Map.setHexStyle(clickHex, currentMapEditOption);
                }
                if (currentMapAddRoad)
                {
                    Map.setHexStyle(clickHex, currentMapAddRoad);
                }
            }
        }

        private void HexGameWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Point relativePoint = this.PointToClient(Cursor.Position);
            lblMouseCoor.Text = relativePoint.X + "," + relativePoint.Y;
        }
    }
}
