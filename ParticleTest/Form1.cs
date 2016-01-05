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

        // Gui members
        private float _posX;
        private float _posY;

        private float _speed;
        private float _angle;

        private float _wind;
        private float _gravity;

        private int _numParticle;
        private int _life;

        private Color _color;

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

        /// <summary>
        /// Initialize all gui components 
        /// </summary>
        private void init_Gui()
        {
            // region Initialize TabControl
            
            // TabPage System

            string[] sItems = { "Firework", "Fontain", "..." };
            SysCbb.DataSource = sItems;

            // region TabPage Option

            // Position components

            OptScrBarPosX.Minimum = 1;
            OptScrBarPosX.Maximum = 600;
            OptScrBarPosX.Value = 300;
            _posX = OptScrBarPosX.Value;

            OptScrBarPosY.Minimum = 1;
            OptScrBarPosY.Maximum = 375;
            OptScrBarPosY.Value = 185;
            _posY = OptScrBarPosY.Value;

            OptLblPosXVal.Text = OptScrBarPosX.Value.ToString();
            OptLblPosYVal.Text = OptScrBarPosY.Value.ToString();

            // Velocity components

            OptScrBarSpeed.Minimum = 1;
            OptScrBarSpeed.Maximum = 100;
            OptScrBarSpeed.Value = 1;
            _speed = OptScrBarSpeed.Value;

            OptScrBarAgl.Minimum = 1;
            OptScrBarAgl.Maximum = 360;
            OptScrBarAgl.Value = 90;
            _angle = OptScrBarAgl.Value;

            OptLblVeloSpdVal.Text = OptScrBarSpeed.Value.ToString();
            OptLblVeloAglVal.Text = OptScrBarAgl.Value.ToString();

            // Physic components

            OptScrBarWind.Minimum = 1;
            OptScrBarWind.Maximum = 100;
            OptScrBarWind.Value = 1;
            _wind = OptScrBarWind.Value;

            OptScrBarGrvy.Minimum = 1;
            OptScrBarGrvy.Maximum = 100;
            OptScrBarGrvy.Value = 1;
            _gravity = OptScrBarGrvy.Value;

            OptLblWindVal.Text = OptScrBarWind.Value.ToString();
            OptLblGrvyVal.Text = OptScrBarGrvy.Value.ToString();

            // Particle components

            OptScrBarNumPart.Minimum = 50;
            OptScrBarNumPart.Maximum = 1000;
            OptScrBarNumPart.Value = 250;
            _numParticle = OptScrBarNumPart.Value;

            OptScrBarLife.Minimum = 1;
            OptScrBarLife.Maximum = 5;
            OptScrBarLife.Value = 2;
            _life = OptScrBarLife.Value;

            OptLblNumPartVal.Text = OptScrBarNumPart.Value.ToString();
            OptLblLifeVal.Text = OptScrBarLife.Value.ToString();

            // end region TabPage Option

            // region TabPage Color

            // Color min components

            ColScrBarMinR.Minimum = 0;
            ColScrBarMinR.Maximum = 255;
            ColScrBarMinR.Value = 0;

            ColLblMinRVal.Text = ColScrBarMinR.Value.ToString();
            ColLblMinR.BackColor = Color.Red;

            ColScrBarMinG.Minimum = 0;
            ColScrBarMinG.Maximum = 255;
            ColScrBarMinG.Value = 0;

            ColLblMinGVal.Text = ColScrBarMinG.Value.ToString();
            ColLblMinG.BackColor = Color.Green;

            ColScrBarMinB.Minimum = 0;
            ColScrBarMinB.Maximum = 255;
            ColScrBarMinB.Value = 0;

            ColLblMinBVal.Text = ColScrBarMinB.Value.ToString();
            ColLblMinB.BackColor = Color.Blue;

            // Color max components

            ColScrBarMaxR.Minimum = 0;
            ColScrBarMaxR.Maximum = 255;
            ColScrBarMaxR.Value = 0;

            ColLblMaxRVal.Text = ColScrBarMaxR.Value.ToString();
            ColLblMaxR.BackColor = Color.Red;

            ColScrBarMaxG.Minimum = 0;
            ColScrBarMaxG.Maximum = 255;
            ColScrBarMaxG.Value = 0;

            ColLblMaxGVal.Text = ColScrBarMaxG.Value.ToString();
            ColLblMaxG.BackColor = Color.Green;

            ColScrBarMaxB.Minimum = 0;
            ColScrBarMaxB.Maximum = 255;
            ColScrBarMaxB.Value = 0;

            ColLblMaxBVal.Text = ColScrBarMaxB.Value.ToString();
            ColLblMaxB.BackColor = Color.Blue;

            // end region TabPage Color

            // end region Initialize TabControl

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
            /*
            Random rd = new Random();
            Color col = Color.FromArgb((int)(rd.NextDouble() * 255), (int)(rd.NextDouble() * 255), (int)(rd.NextDouble() * 255));
            for (int i = 0; i < 500; i++)
                state.addparticle(new Particle((float)e.X, (float)e.Y,0.0f, 0.05f, 5, ((float)rd.NextDouble() * 360), (float)rd.NextDouble() * 1.5f, col, true));
            */

            Random rd = new Random();
            Color col = Color.FromArgb((int)(rd.NextDouble() * 255), (int)(rd.NextDouble() * 255), (int)(rd.NextDouble() * 255));
            for(int i = 0; i < _numParticle; i++)
            {
                state.addparticle(new Particle(_posX, _posY, 0.0f, 0.05f, _life, (float)rd.NextDouble() * _angle, (float)rd.NextDouble() * _speed, col, true));
            }
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
                    state.addparticle(new Particle(x, y,0.0f,0.05f, 3, (float)(rd.NextDouble() * 22.5d) + 259f, (float)rd.NextDouble() * 3.5f, col, true));
                }

            }
            isrunning_fountain = false;
        }

        // region ScrollBar Eventhandler

        private void OptScrBarPosX_Scroll(object sender, ScrollEventArgs e)
        {
            _posX = (float)e.NewValue;
            OptLblPosXVal.Text = e.NewValue.ToString();
        }

        private void OptScrBarPosY_Scroll(object sender, ScrollEventArgs e)
        {
            _posY = (float)e.NewValue;
            OptLblPosYVal.Text = e.NewValue.ToString();
        }

        private void OptScrBarSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            _speed = (float)e.NewValue;
            OptLblVeloSpdVal.Text = e.NewValue.ToString();
        }

        private void OptScrBarAgl_Scroll(object sender, ScrollEventArgs e)
        {
            _angle = (float)e.NewValue;
            OptLblVeloAglVal.Text = e.NewValue.ToString();
        }

        private void OptScrBarWind_Scroll(object sender, ScrollEventArgs e)
        {
            _wind = (float)e.NewValue;
            OptLblWindVal.Text = e.NewValue.ToString();
        }

        private void OptScrBarGrvy_Scroll(object sender, ScrollEventArgs e)
        {
            _gravity = (float)e.NewValue;
            OptLblGrvyVal.Text = e.NewValue.ToString();
        }

        private void OptScrBarNumPart_Scroll(object sender, ScrollEventArgs e)
        {
            _numParticle = e.NewValue;
            OptLblNumPartVal.Text = e.NewValue.ToString();
        }

        private void OptScrBarLife_Scroll(object sender, ScrollEventArgs e)
        {
            _life = e.NewValue;
            OptLblLifeVal.Text = e.NewValue.ToString();
        }

        private void ColScrBarMinR_Scroll(object sender, ScrollEventArgs e)
        {
            ColLblMinRVal.Text = e.NewValue.ToString();
            ColScrBarMaxR.Minimum = e.NewValue;
        }

        private void ColScrBarMinG_Scroll(object sender, ScrollEventArgs e)
        {
            ColLblMinGVal.Text = e.NewValue.ToString();
            ColScrBarMaxG.Minimum = e.NewValue;
        }

        private void ColScrBarMinB_Scroll(object sender, ScrollEventArgs e)
        {
            ColLblMinBVal.Text = e.NewValue.ToString();
            ColScrBarMaxB.Minimum = e.NewValue;
        }

        private void ColScrBarMaxR_Scroll(object sender, ScrollEventArgs e)
        {
            ColLblMaxRVal.Text = e.NewValue.ToString();
            ColScrBarMinR.Maximum = e.NewValue;
        }

        private void ColScrBarMaxG_Scroll(object sender, ScrollEventArgs e)
        {
            ColLblMaxGVal.Text = e.NewValue.ToString();
            ColScrBarMinG.Maximum = e.NewValue;
        }

        private void ColScrBarMaxB_Scroll(object sender, ScrollEventArgs e)
        {
            ColLblMaxBVal.Text = e.NewValue.ToString();
            ColScrBarMaxB.Maximum = e.NewValue;
        }

        // end region ScrollBar Eventhandler
    }
}
