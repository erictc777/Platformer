using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Jugador
    {
       
        private double alto;
        private double ancho; 
        public double x;
        public double y;
        public int xpt1;
        public int ypt1;
        private Image i;
        public double puntaje;
        public bool estado;
        public Jugador(double alto, double ancho)
        {

            this.ancho = ancho;
            this.alto = alto;
            puntaje = 0;
            this.x = (ancho/3) ;
            this.y = (alto);
            estado = true;
            i = Image.FromFile(@"..\..\img\jugador1.png");
        }
        public void Mover(int dx, int dy)
        {

            if (x <= 75)
                x = 75;
            else x += dx;
            y += dy;
            if (x >= (500-75)) 
                x = (500 - 100);
            else x += dx;
            y += dy;
            if (x == xpt1 && y == ypt1)
            {
                x = xpt1;
                y = xpt1;
            }
        }
      
        public void Saltar()
        {
            if(estado==true)
            y -= 30; ;
        }
        public void Caer()
        {

            y += 90; ;
            if (this.y > 700)
            {
                estado = false;
            }
            else
                estado = true;
        }

        internal void DibujarPersonaje(Graphics graphics)
        {
           graphics.DrawImage(i,
                (int)(x-40), (int)(y-90),
                (int)(50), (int)(50));
        }
        public void Puntaje()
        {
            if(estado==true)
            puntaje+=20;
        }
        public void PuntajeBala()
        {
            if (estado == true)
                puntaje += 5;
        }
        public double Getpuntos()
        {
            return puntaje;
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)(x - 40), (int)(y - 90),
                (int)(50), (int)(45));
        }
    }
}
