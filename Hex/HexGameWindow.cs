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
            Map.getBoardLocation(clickPoint);
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

        private void mapEditPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point relativePoint = this.PointToClient(Cursor.Position);
            lblMouseCoor.Text = relativePoint.X + "," + relativePoint.Y;

        }
    }
}
