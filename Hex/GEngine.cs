using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Hex
{
    class GEngine
    {
        /* ------------ Members ------------ */
        private Graphics drawHandle;
        private Thread renderThread;

        public GEngine(Graphics g)
        {
            drawHandle = g;
        }

        /* ------------ Functions ------------ */
        public void init()
        {
            renderThread = new Thread(new ThreadStart(render));
            renderThread.Start();
        }

        public void stop()
        {
            //renderThread.Abort();
        }

        public void render()
        {
            //while (true)
            //{
                Map.drawMap(drawHandle);
            //}
        }
    }
}
