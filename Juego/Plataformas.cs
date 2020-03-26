using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Plataformas
    {
        private Plataforma[] plataformas;
        private Random r;
        private Image p;
        private int px;
        private int py;
        public Plataformas(int n, int ancho, int alto)
        {
            plataformas = new Plataforma[n];
            r = new Random();
            for (int i = 0; i < n; i++)
                plataformas[i] = new Plataforma(ancho, alto, r);
        }

        internal void Dibujar(Graphics graphics)
        {

            for (int i = 0; i < plataformas.Length; i++)
                plataformas[i].Dibujar(graphics);
        }

        internal void Mover()
        {
            for (int i = 0; i < plataformas.Length; i++)
                plataformas[i].Mover();
        }

        internal void Dibujarpisolava(Graphics graphics)
        {
            p = Image.FromFile(@"..\..\img\fire.png");
            graphics.DrawImage(p,
                (int)(px), (int)(py + 370),
                (int)(500), (int)(250));
        }
        public bool VerificarColisionPlatJuga(Jugador p)
        {
            bool respuesta = false;
            for (int i = 0; i < plataformas.Length; i++)
                if(plataformas[i].GetRectangle().IntersectsWith(p.GetRectangle()))
            {
                    respuesta = true;
            }
            return respuesta;
        }

        internal void Dibujarpiso(Graphics graphics)
        {
            p = Image.FromFile(@"..\..\img\plataforma.png");
            graphics.DrawImage(p, px+170, py+500, 40, 20);
        }
        public Rectangle GetRectangle()
        {
            return new Rectangle((int)(px+170), (int)(py + 500),
                (int)(40), (int)(20));
        }
        

    }
}
