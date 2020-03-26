using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Bala
    {
        private double alto;
        private double ancho;
        public double xb;
        public double yb;
        public int dirx;
        public int diry;
        public double x { get => xb; set => xb = value; }
        public double y { get => yb; set => yb = value; }
        public bool regresar = false;
        private Image im;
        public Bala(double alto, double ancho, Jugador p)
        {
            Random r = new Random();
            this.ancho = ancho;
            this.alto = alto;
            this.xb = p.x;
            this.yb = p.y;
            this.dirx = 0;
            this.diry = 0;
            im = Image.FromFile(@"..\..\img\boladefuego.png");
        }
        internal void DibujarBala(Graphics graphics)
        {
            graphics.DrawImage(im,
                (int)(xb), (int)(yb),
                (int)(10), (int)(10));
        }
        public void DispararUp()
        {
            if (yb >600)
            {
                regresar = true;
            }
            else
            {
                y += diry;
            }
        }
        public void DispararDrch()
        {
            if (xb > this.ancho+531)
                regresar = true;
            else
            {
                xb -= dirx;
                yb -= diry;
            }


        }
        public void DispararIzq()
        {

            if (xb < (this.ancho-700))
                regresar = true;
            else
            {
                xb -= dirx;
                yb -= diry;
            }

        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)(x), (int)(y),
                (int)(50), (int)(50));
        }
        public void RegresarColision(Jugador p)
        {
            xb = p.x;
            yb = p.y;
        }
        public void CambiarDirxy(int diry, int dirx)
        {
            this.diry = diry;
            this.dirx = dirx;
        }
        public void CambiarDiry(int diry)
        {
            this.diry = diry;
        }
    }
}
