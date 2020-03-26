using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Monstruos
    {
        private Monstruo[] monstruos;
        private Random r;
        public bool borrar;
        
        public Monstruos(int n, int ancho, int alto)
        {
            borrar = true;
            monstruos = new Monstruo[n];
            r = new Random();
            for (int i = 0; i < n; i++)
                monstruos[i] = new Monstruo(ancho, alto, r);
        }

        internal void DibujarMn(Graphics graphics)
        {
            if (borrar == true)
            {
                for (int i = 0; i < monstruos.Length; i++)
                    monstruos[i].Dibujar(graphics);
            }
        }

        internal void Mover()
        {
            for (int i = 0; i < monstruos.Length; i++)
                monstruos[i].Mover();
        }
        public bool VerificarColisionMonsJuga(Jugador p)
        {
            bool respuesta = false;
            for (int i = 0; i < monstruos.Length; i++)
                if (monstruos[i].GetRectangle().IntersectsWith(p.GetRectangle()))
                {
                    respuesta = true;
                }
            return respuesta;
        }
        public bool VerificarColisionMonsBal(Bala b)
        {
            bool respuesta = false;
            for (int i = 0; i < monstruos.Length; i++)
                if (monstruos[i].GetRectangle().IntersectsWith(b.GetRectangle()))
                {
                    respuesta = true;
                    monstruos[i].Desaparecer();
                }
            return respuesta;
        }
    }
}
