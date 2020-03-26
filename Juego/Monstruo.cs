using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Monstruo
    {
        private int x;
        private int y;
        private int radio;
        
        private int retraso;
        private Random r;

        private int alto;
        private int ancho;

        private Image i;

        public Monstruo(int ancho, int alto, Random r)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.r = r;
            Inicializar();
            
            i = Image.FromFile(@"..\..\img\monstruo2.png");

        }

        public void Dibujar(Graphics g)
        {
            // g.FillRectangle(color, x - radio, y - radio, radio + 17, radio);
            g.DrawImage(i, x - radio, y - radio, 25, 25);
        }

        public void Mover()
        {
            if (retraso <= 0)
            {
                if (y - radio >= alto)
                    Inicializar();
                else
                    y += 3;
            }
            else
                retraso--;
        }

        private void Inicializar()
        {
            radio = 20;
            x = r.Next(radio, ancho - radio);
            y = -radio;
            retraso = r.Next(100, 250);
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)(x - radio), (int)(y - radio),
                (int)(25), (int)(25));
        }
        public void Desaparecer()
        {
            x = 1000;
            y = 1000;
        }

    }
}
