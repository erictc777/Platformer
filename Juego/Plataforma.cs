using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Plataforma
    {
        private int xpt;
        private int ypt;
        private int radio;
        public Jugador p;
        private int retraso;
        private Random r;

        private int alto;
        private int ancho;

        private Image i;

        public Plataforma(int ancho, int alto, Random r)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.r = r;
            Inicializar();
            p = new Jugador(this.ancho, this.alto);
            i = Image.FromFile(@"..\..\img\plataforma.png");

        }

        public void Dibujar(Graphics g)
        {
            g.DrawImage(i, xpt - radio, ypt - radio, radio+20, radio);
        }

        public void Mover()
        {
            if (retraso <= 0)
            {
                if (ypt - radio >= alto)
                    Inicializar();
                else
                    ypt +=5;
            }
            else
                retraso--;
        }

        private void Inicializar()
        {
            radio = 20;
            xpt = r.Next(radio, ancho - radio);
            ypt = -radio;
            retraso = r.Next(100, 700);
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)(xpt-radio), (int)(ypt - radio),
                (int)(radio + 20), (int)(radio));
        }
        
    }
}
