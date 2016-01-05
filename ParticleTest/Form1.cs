using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleTest
{
    public partial class Form1 : Form
    {
        public bool isrunning_fountain;
        public ParticleState state;

        private Thread _particlethread;
        private Thread _fountainspawnthread;

        public void ParticleProc()
        {
            try {
                for (;;)
                {
                    Thread.Sleep(20);
                    List<int> remove = new List<int>();
                    for (int i = 0; i < state.particlecount-1;i++)
                    {
                        if (state.particles[i].update())
                            remove.Add(i);
                    }
                    /*foreach (Particle p in state.particles)
                    {
                        if (p.update())
                            remove.Add(p);
                    }*/
                    foreach (int i in remove)
                        state.removeparticle(i);

                    //remove.Clear();
                    //Invoke((MethodInvoker)(() => { DrawPanel.Invalidate(); DrawPanel.Update(); }));
                    Invoke((MethodInvoker)(() => { DrawBox.Invalidate(); DrawBox.Update(); }));
                }
            }
            catch (ThreadAbortException ex)
            {
                Debug.Print("Particle progress Thread aborted.");
            }
        }

        public Form1()
        {
            state = new ParticleState();
            InitializeComponent();
            init_Gui();

            _particlethread = new Thread(ParticleProc);
            _particlethread.Start();
            isrunning_fountain = false;
            
            //DrawPanel.Paint += new PaintEventHandler(DrawPanelPaint);
        }

        private void init_Gui()
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //depricated
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _particlethread.Abort();
        }

        private void DrawBox_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < state.particlecount -1; i++)
            {
                state.particles[i].Draw(e.Graphics);
            }
        }

        private void DrawBox_Click(object sender, EventArgs e)
        {
            //depricated
        }

        private void DrawBox_MouseClick(object sender, MouseEventArgs e)
        {
            Random rd = new Random();
            Color col = Color.FromArgb((int)(rd.NextDouble() * 255), (int)(rd.NextDouble() * 255), (int)(rd.NextDouble() * 255));
            for (int i = 0; i < 500; i++)
                state.addparticle(new Particle((float)e.X, (float)e.Y, 5, ((float)rd.NextDouble() * 360), (float)rd.NextDouble() * 1.5f, col));
        }

        private void FontainButton_Click(object sender, EventArgs e)
        {
            if (!isrunning_fountain)
            {
                _fountainspawnthread = new Thread(FountainProc);
                _fountainspawnthread.Start();
            }
        }

        private void FountainProc()
        {
            Random rd = new Random();
            for (int i = 0; i < 500; i++)
            {
                Thread.Sleep(100);
                Color col = Color.FromArgb((int)(rd.NextDouble() * 30), (int)(rd.NextDouble() * 120),(int)(rd.NextDouble() * 255));
                for (int n = 0; n < 11; n++)
                {
                    float x = (float)(DrawBox.Width / 2);
                    float y = (float)(DrawBox.Height - 1);
                    state.addparticle(new Particle(x, y, 3, (float)(rd.NextDouble() * 22.5d) + 259f, (float)rd.NextDouble() * 3.5f, col));
                }

            }
            isrunning_fountain = false;
        }
    }
}
