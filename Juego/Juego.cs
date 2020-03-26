using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Juego
{
    public partial class Juego : Form
    {
        private Jugador p;
        private Monstruos m;
        private Plataformas pl;
        private Bala b;
        public bool balaUp=false;
        public bool balaDrc = false;
        public bool balaIzq = false;
        public bool colision = true;
        public Juego()
        {
            InitializeComponent();
            p = new Jugador(pbCancha.Width, pbCancha.Height);
            m = new Monstruos(5,pbCancha.Width, pbCancha.Height);
            pl = new Plataformas(90,pbCancha.Width, pbCancha.Height);
            
            b = new Bala(pbCancha.Width, pbCancha.Height, p);
            pbCancha.BackgroundImage = Image.FromFile("..\\..\\img\\volcan.png");
            SoundPlayer player = new SoundPlayer("..\\..\\sound\\sonido.wav");
            if (colision == false || p.estado == false)
            {
                player.Stop();
            }
            else
            {
                player.Play();
            }
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                case Keys.I:
                    p.Saltar();
                    pbCancha.Invalidate();
                    return true;
                case Keys.Left:
                case Keys.J:
                    p.Mover(-30, 0);
                    pbCancha.Invalidate();
                    return true;
                case Keys.Right:
                case Keys.L:
                    p.Mover(30, 0);
                    pbCancha.Invalidate();
                    return true;
               case Keys.Z:
                    balaIzq = true;
                    
                    pbCancha.Invalidate();
                    return true;
                case Keys.X:

                    balaUp = true;
                    
                    pbCancha.Invalidate();
                    return true;
                case Keys.C:
                    balaDrc = true;
                    
                    pbCancha.Invalidate();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void pbCancha_Paint(object sender, PaintEventArgs e)
        {
            if (colision == true) //Mientras no se choque el juego seguira funcionando
            {
                pl.Dibujarpiso(e.Graphics);
                pl.Dibujarpisolava(e.Graphics);
                m.DibujarMn(e.Graphics);
                p.DibujarPersonaje(e.Graphics);
                pl.Dibujar(e.Graphics);
                
               
                if (balaUp == true) //Si apreta boton de disparo hacia arriba recien dibuja la bala
                {
                    b.DibujarBala(e.Graphics);
                    if (m.VerificarColisionMonsBal(b) == true)
                    {
                        b.RegresarColision(p);            //Bala deja de moverse si choca con monstruo
                        p.PuntajeBala();              //Aumenta la puntuacion si golpea a un mosntruo
                    }
                    else
                    {
                        b.CambiarDiry(15);
                        if (b.regresar == true)
                        {
                            b.RegresarColision(p);
                            b.regresar = false;
                        }
                       
                    }
                    balaUp = false;
                }
                if (balaDrc == true) //Si apreta boton de disparo hacia la derecha recien dibuja la bala
                {
                    b.DibujarBala(e.Graphics);
                    if (m.VerificarColisionMonsBal(b) == true)
                    {
                        b.RegresarColision(p);          //Bala deja de moverse si choca con monstruo

                        p.PuntajeBala();                 //Aumenta la puntuacion si golpea a un mosntruo
                    }
                    else
                    {
                        b.CambiarDirxy(15,-15);
                        if (b.regresar == true)
                        {
                            b.RegresarColision(p);
                            b.regresar = false;
                        }
                        
                    }
                    balaDrc = false;
                }
                if (balaIzq == true) //Si apreta boton de disparo hacia la izquierda recien dibuja la bala
                {
                    b.DibujarBala(e.Graphics);
                    if (m.VerificarColisionMonsBal(b) == true)
                    {
                        b.RegresarColision(p);    //Bala deja de moverse si choca con monstruo
                        p.PuntajeBala();         //Aumenta la puntuacion si golpea a un mosntruo
                    }
                    else
                    {
                        b.CambiarDirxy(15,15);
                        if (b.regresar == true)
                        {
                            b.RegresarColision(p);
                            b.regresar = false;
                        }
                    }
                    balaIzq = false;
                }
                if (pl.VerificarColisionPlatJuga(p) == true)
                {
                    p.Puntaje();
                    p.Saltar();          //Si se choca con la plataforma salta
                }
                
                if (m.VerificarColisionMonsJuga(p) == true)
                {
                    colision = false;     //Si se choca con un monstruo deja de generar
                    m.borrar = false;
                }
            }
            if(colision==false)
            {
                p.estado = false;
                    puntos.Text = "Te chocaste " + "tu puntuacion fue:" + p.Getpuntos();
                
                pbCancha.Invalidate();
            }

   
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (p.GetRectangle().IntersectsWith(pl.GetRectangle()))
            {
                p.Saltar();
            }
            pl.Mover();
            pbCancha.Invalidate();
            m.Mover();
            pbCancha.Invalidate();
            puntos.Text = "Puntuacion= " + p.Getpuntos();
            if (p.estado == false)
            {
                puntos.Text = "Te caiste " + "tu puntuacion fue:" + p.Getpuntos();
            }

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

            p.Caer();
            
            b.DispararDrch();
            
                b.DispararIzq();
            
                b.DispararUp();
            pbCancha.Invalidate();

        }

        
    }
}
