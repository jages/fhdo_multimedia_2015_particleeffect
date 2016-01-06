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
        private float _minPosX;
        private float _minPosY;

        private float _maxPosX;
        private float _maxPosY;

        private float _speed;
        private float _angle;

        private float _wind;
        private float _gravity;

        private int _numParticle;
        private int _life;

        private int _minRed;
        private int _maxRed;

        private int _minGreen;
        private int _maxGreen;

        private int _minBlue;
        private int _maxBlue;

        private int _cycle;
        private int _interval;

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

        /// <summary>
        /// Form initialization
        /// </summary>
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
            

            // region TabPage Option

            // Position components

            PosScrBarMinPosX.Minimum = 1;
            PosScrBarMinPosX.Maximum = DrawBox.Width - 1;
            //PosScrBarMinPosX.Value = 300;
            //_posX = OptScrBarPosX.Value;

            PosScrBarMinPosY.Minimum = 1;
            PosScrBarMinPosY.Maximum = DrawBox.Height - 1;
            //PosScrBarMinPosY.Value = 185;
            //_posY = PosScrBarMinPosY.Value;

            //PosLblMinPosXVal.Text = PosScrBarMinPosX.Value.ToString();
            //PosLblMinPosYVal.Text = PosScrBarMinPosY.Value.ToString();

            PosScrBarMaxPosX.Minimum = 1;
            PosScrBarMaxPosX.Maximum = DrawBox.Width - 1;
            //PosScrBarMaxPosX.Value = 300;

            PosScrBarMaxPosY.Minimum = 1;
            PosScrBarMaxPosY.Maximum = DrawBox.Height - 1;
            //PosScrBarMaxPosY.Value = 185;

            // Velocity components

            OptScrBarSpeed.Minimum = 1;
            OptScrBarSpeed.Maximum = 500;
            //OptScrBarSpeed.Value = 1;
            //_speed = OptScrBarSpeed.Value;

            OptScrBarAgl.Minimum = 1;
            OptScrBarAgl.Maximum = 360;
            //OptScrBarAgl.Value = 90;
            //_angle = OptScrBarAgl.Value;

            //OptLblVeloSpdVal.Text = OptScrBarSpeed.Value.ToString();
            //OptLblVeloAglVal.Text = OptScrBarAgl.Value.ToString();

            // Physic components

            OptScrBarWind.Minimum = -250;
            OptScrBarWind.Maximum = 250;
            //OptScrBarWind.Value = 0;
            //_wind = OptScrBarWind.Value;

            OptScrBarGrvy.Minimum = -250;
            OptScrBarGrvy.Maximum = 250;
            //OptScrBarGrvy.Value = 1;
            //_gravity = OptScrBarGrvy.Value;

            //OptLblWindVal.Text = OptScrBarWind.Value.ToString();
            //OptLblGrvyVal.Text = OptScrBarGrvy.Value.ToString();

            // Particle components

            OptScrBarNumPart.Minimum = 25;
            OptScrBarNumPart.Maximum = 1000;
            //OptScrBarNumPart.Value = 250;
            //_numParticle = OptScrBarNumPart.Value;

            OptScrBarLife.Minimum = 1;
            OptScrBarLife.Maximum = 5;
            //OptScrBarLife.Value = 2;
            //_life = OptScrBarLife.Value;

            //OptLblNumPartVal.Text = OptScrBarNumPart.Value.ToString();
            //OptLblLifeVal.Text = OptScrBarLife.Value.ToString();

            OptScrBarCyle.Minimum = 1;
            OptScrBarCyle.Maximum = 500;

            OptScrBarInter.Minimum = 25;
            OptScrBarInter.Maximum = 500;

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
            ColScrBarMaxR.Value = 255;

            ColLblMaxRVal.Text = ColScrBarMaxR.Value.ToString();
            ColLblMaxR.BackColor = Color.Red;

            ColScrBarMaxG.Minimum = 0;
            ColScrBarMaxG.Maximum = 255;
            ColScrBarMaxG.Value = 255;

            ColLblMaxGVal.Text = ColScrBarMaxG.Value.ToString();
            ColLblMaxG.BackColor = Color.Green;

            ColScrBarMaxB.Minimum = 0;
            ColScrBarMaxB.Maximum = 255;
            ColScrBarMaxB.Value = 255;

            ColLblMaxBVal.Text = ColScrBarMaxB.Value.ToString();
            ColLblMaxB.BackColor = Color.Blue;

            // end region TabPage Color


            // TabPage System

            string[] sItems = { "Firework", "Fontain", "..." };
            SysCbb.DataSource = sItems;

            // end region Initialize TabControl

            DEFAULT_FIREWORK_VALUES();
        }

        private void setdefaultfromGUI()
        {
            _minPosX = PosScrBarMinPosX.Value;
            _maxPosX = PosScrBarMaxPosX.Value;
            _minPosY = PosScrBarMinPosY.Value;
            _maxPosY = PosScrBarMaxPosY.Value;
            _speed = (OptScrBarSpeed.Value / 100f);
            _angle = OptScrBarAgl.Value;
            _wind = (OptScrBarWind.Value / 100f);
            _gravity = (OptScrBarGrvy.Value / 100f);
            _numParticle = OptScrBarNumPart.Value;
            _life = OptScrBarLife.Value;
            _cycle = OptScrBarCyle.Value;
            _interval = OptScrBarInter.Value;
            _minRed = ColScrBarMinR.Value;
            _minGreen = ColScrBarMinG.Value;
            _minBlue = ColScrBarMinB.Value;
            _maxRed = ColScrBarMaxR.Value;
            _maxGreen = ColScrBarMaxG.Value;
            _maxBlue = ColScrBarMaxB.Value;
        }

        private void updateLabels()
        {
            PosLblMinPosXVal.Text = PosScrBarMinPosX.Value.ToString();
            PosLblMinPosYVal.Text = PosScrBarMinPosY.Value.ToString();
            PosLblMaxPosXVal.Text = PosScrBarMaxPosX.Value.ToString();
            PosLblMaxPosYVal.Text = PosScrBarMaxPosY.Value.ToString();
            OptLblVeloSpdVal.Text = (OptScrBarSpeed.Value / 100f).ToString();
            OptLblVeloAglVal.Text = OptScrBarAgl.Value.ToString();
            OptLblWindVal.Text = (OptScrBarWind.Value / 100f).ToString();
            OptLblGrvyVal.Text = (OptScrBarGrvy.Value / 100f).ToString();
            OptLblNumPartVal.Text = OptScrBarNumPart.Value.ToString();
            OptLblLifeVal.Text = OptScrBarLife.Value.ToString();
            OptLblCycleVal.Text = OptScrBarCyle.Value.ToString();
            OptLblCycleVal.Text = OptScrBarInter.Value.ToString();
        }

        private void DEFAULT_FIREWORK_VALUES()
        {
            PosScrBarMinPosX.Value = 1;
            PosScrBarMinPosY.Value = 1;

            PosScrBarMaxPosX.Value = (DrawBox.Width -1);
            PosScrBarMaxPosY.Value = (DrawBox.Height -1);
            
            OptScrBarSpeed.Value = 100;


            OptScrBarAgl.Value = 360;


            OptScrBarWind.Value = 0;

            OptScrBarGrvy.Value = 0;


            OptScrBarNumPart.Value = 500;


            OptScrBarLife.Value = 2;


            OptScrBarCyle.Value = 50;


            OptScrBarInter.Value = 125;

            ColScrBarMaxR.Value = 255;
            ColScrBarMaxG.Value = 255;
            ColScrBarMaxB.Value = 255;

            ColScrBarMinR.Value = 0;
            ColScrBarMinG.Value = 0;
            ColScrBarMinB.Value = 0;

            updateLabels();
            setdefaultfromGUI();

        }

        private void DEFAULT_FONTAIN_VALUES()
        {
            PosScrBarMinPosX.Value = (DrawBox.Width - 1) / 2;
            PosScrBarMinPosY.Value = (DrawBox.Height - 1) / 2;

            PosScrBarMaxPosX.Value = (DrawBox.Width - 1) / 2;
            PosScrBarMaxPosY.Value = (DrawBox.Height - 1) / 2;

            OptScrBarSpeed.Value = 350;


            OptScrBarAgl.Value = 22;


            OptScrBarWind.Value = 0;

            OptScrBarGrvy.Value = 5;

            //number of particles
            OptScrBarNumPart.Value = 25;


            OptScrBarLife.Value = 3;


            OptScrBarCyle.Value = 200;


            OptScrBarInter.Value = 100;

            ColScrBarMaxR.Value = 25;
            ColScrBarMaxG.Value = 75;
            ColScrBarMaxB.Value = 255;

            ColScrBarMinR.Value = 0;
            ColScrBarMinG.Value = 0;
            ColScrBarMinB.Value = 0;

            updateLabels();
            setdefaultfromGUI();
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
            //Random rd = new Random();

            //float x = ((float)(rd.NextDouble() * (double)(_maxPosX - _minPosX)) + _minPosX);
            //float y = ((float)(rd.NextDouble() * (double)(_maxPosY - _minPosY)) + _minPosY);
            //Color col = Color.FromArgb((int)(rd.NextDouble() * 255), (int)(rd.NextDouble() * 255), (int)(rd.NextDouble() * 255));
            //TODO remove depricated
            /*
            Random rd = new Random();
            Color col = Color.FromArgb((int)(rd.NextDouble() * 255), (int)(rd.NextDouble() * 255), (int)(rd.NextDouble() * 255));
            for (int i = 0; i < 500; i++)
                state.addparticle(new Particle((float)e.X, (float)e.Y,0.0f, 0.05f, 5, ((float)rd.NextDouble() * 360), (float)rd.NextDouble() * 1.5f, col, true));
            */
            /*if (SysCbb.Text == "Firework")
            {
                for (int n = 0; n < _cycle; n++) //default was 500 for fountain
                {

                    Thread.Sleep(_interval);//default was 100

                    for (int i = 0; i < _numParticle; i++)
                    {

                        state.addparticle(new Particle(x, y, _wind, _gravity, _life, (float)rd.NextDouble() * _angle, (float)rd.NextDouble() * _speed, col, true));
                    }
                }
            }else if(SysCbb.Text == "Fontain")
            {
                if (!isrunning_fountain)
                {
                    _fountainspawnthread = new Thread(FountainProc);
                    _fountainspawnthread.Start();
                }
            }*/
            if (!isrunning_fountain)
            {
                _fountainspawnthread = new Thread(FountainProc);
                _fountainspawnthread.Start();
            }

        }

        private void FontainButton_Click(object sender, EventArgs e)
        {
            //TODO remove depricated
            if (!isrunning_fountain)
            {
                _fountainspawnthread = new Thread(FountainProc);
                _fountainspawnthread.Start();
            }
        }

        private void FountainProc()
        {
            try {
                Random rd = new Random();
                // anzahl wellen

                for (int i = 0; i < _cycle; i++) //default was 500 for fountain
                {

                    float x = ((float)(rd.NextDouble() * (double)(_maxPosX - _minPosX)) + _minPosX);
                    float y = ((float)(rd.NextDouble() * (double)(_maxPosY - _minPosY)) + _minPosY);

                    Thread.Sleep(_interval);//default was 100
                    Color col = Color.FromArgb((int)(rd.NextDouble() * (_maxRed - _minRed)) + _minRed,
                                               (int)(rd.NextDouble() * (_maxGreen - _minGreen)) + _minGreen,
                                               (int)(rd.NextDouble() * (_maxBlue - _minBlue)) + _minBlue);

                    for (int n = 0; n < _numParticle; n++)
                    {
                        float angle = (float)(rd.NextDouble() * _angle) + (270f - (_angle / 2));
                        state.addparticle(new Particle(x, y, _wind, _gravity, _life, angle, (float)rd.NextDouble() * _speed, col, true));
                    }

                }
            }
            catch (ThreadAbortException ex) {
                Debug.Print("Particle generaton thread has stopped.");
            }
            isrunning_fountain = false;
        }

        // region ScrollBar Eventhandler
        
        /// <summary>
        /// define minimum X position based on scrollbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptScrBarMinPosX_Scroll(object sender, ScrollEventArgs e)
        {
            _minPosX = (float)e.NewValue;
            PosLblMinPosXVal.Text = e.NewValue.ToString();

            PosScrBarMaxPosX.Minimum = e.NewValue;
        }

        /// <summary>
        /// define minimum Y position for emission based on scrollbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptScrBarMinPosY_Scroll(object sender, ScrollEventArgs e)
        {
            _minPosY = (float)e.NewValue;
            PosLblMinPosYVal.Text = e.NewValue.ToString();

            PosScrBarMaxPosY.Minimum = e.NewValue;
        }

        /// <summary>
        /// define maximum X position for emission based on scrollbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PosScrBarMaxPosX_Scroll(object sender, ScrollEventArgs e)
        {
            _maxPosX = (float)e.NewValue;
            PosLblMaxPosXVal.Text = e.NewValue.ToString();

            PosScrBarMinPosX.Maximum = e.NewValue;
        }

        private void PosScrBarMaxPosY_Scroll(object sender, ScrollEventArgs e)
        {
            _maxPosY = (float)e.NewValue;
            PosLblMaxPosYVal.Text = e.NewValue.ToString();

            PosScrBarMinPosY.Maximum = e.NewValue;

        }

        private void OptScrBarSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            _speed = (float)(e.NewValue / 100f);
            OptLblVeloSpdVal.Text = _speed.ToString();
        }

        private void OptScrBarAgl_Scroll(object sender, ScrollEventArgs e)
        {
            _angle = (float)e.NewValue;
            OptLblVeloAglVal.Text = e.NewValue.ToString();
        }

        private void OptScrBarWind_Scroll(object sender, ScrollEventArgs e)
        {
            _wind = (float)(e.NewValue / 100f);
            OptLblWindVal.Text = _wind.ToString();
        }

        private void OptScrBarGrvy_Scroll(object sender, ScrollEventArgs e)
        {
            _gravity = (float)(e.NewValue / 100f);
            OptLblGrvyVal.Text = _gravity.ToString();
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


        private void OptScrBarCyle_Scroll(object sender, ScrollEventArgs e)
        {
            _cycle = e.NewValue;
            OptLblCycleVal.Text = e.NewValue.ToString();
        }

        private void OptScrBarEmission_Scroll(object sender, ScrollEventArgs e)
        {
            _interval = e.NewValue;
            OptLblInterVal.Text = e.NewValue.ToString();
        }

        private void ColScrBarMinR_Scroll(object sender, ScrollEventArgs e)
        {
            _minRed = e.NewValue;
            ColLblMinRVal.Text = e.NewValue.ToString();
            ColScrBarMaxR.Minimum = e.NewValue;
        }

        private void ColScrBarMinG_Scroll(object sender, ScrollEventArgs e)
        {
            _minGreen = e.NewValue;
            ColLblMinGVal.Text = e.NewValue.ToString();
            ColScrBarMaxG.Minimum = e.NewValue;
        }

        private void ColScrBarMinB_Scroll(object sender, ScrollEventArgs e)
        {
            _minBlue = e.NewValue;
            ColLblMinBVal.Text = e.NewValue.ToString();
            ColScrBarMaxB.Minimum = e.NewValue;
        }

        private void ColScrBarMaxR_Scroll(object sender, ScrollEventArgs e)
        {
            _maxRed = e.NewValue;
            ColLblMaxRVal.Text = e.NewValue.ToString();
            ColScrBarMinR.Maximum = e.NewValue;
        }

        private void ColScrBarMaxG_Scroll(object sender, ScrollEventArgs e)
        {
            _maxGreen = e.NewValue;
            ColLblMaxGVal.Text = e.NewValue.ToString();
            ColScrBarMinG.Maximum = e.NewValue;
        }

        private void ColScrBarMaxB_Scroll(object sender, ScrollEventArgs e)
        {
            _maxBlue = e.NewValue;
            ColLblMaxBVal.Text = e.NewValue.ToString();
            ColScrBarMinB.Maximum = e.NewValue;
        }

        // end region ScrollBar Eventhandler

        private void SysCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SysCbb.SelectedItem.ToString())
            {
                case "Firework":
                    DEFAULT_FIREWORK_VALUES();
                    break;
                case "Fontain":
                    DEFAULT_FONTAIN_VALUES();
                    break;

            }
        }

        private void SysBtnStart_Click(object sender, EventArgs e)
        {
            if (!isrunning_fountain)
            {
                _fountainspawnthread = new Thread(FountainProc);
                _fountainspawnthread.Start();
            }
        }

        private void SysBtnStop_Click(object sender, EventArgs e)
        {
            if(isrunning_fountain)
            {
                _fountainspawnthread.Abort();
                isrunning_fountain = !isrunning_fountain;
            }

        }

        private void DrawBox_SizeChanged(object sender, EventArgs e)
        {
            //change x minimum value to fit box size
            if (DrawBox.Width <= PosScrBarMinPosX.Value)
                PosScrBarMinPosX.Value = DrawBox.Width - 1;

            //change X maximum value to fit box size
            if (DrawBox.Width <= PosScrBarMaxPosX.Value)
                PosScrBarMaxPosX.Value = DrawBox.Width - 1;
            //change x maximum slider max value to fit box size
            PosScrBarMaxPosX.Maximum = DrawBox.Width - 1;


            if (DrawBox.Height <= PosScrBarMinPosY.Value)
                PosScrBarMinPosY.Value = DrawBox.Height - 1;

            if (DrawBox.Height <= PosScrBarMaxPosY.Value)
                PosScrBarMaxPosY.Value = DrawBox.Height - 1;

            PosScrBarMaxPosY.Maximum = DrawBox.Height - 1;


        }
    }
}
