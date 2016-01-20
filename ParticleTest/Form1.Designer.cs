namespace ParticleTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawBox = new System.Windows.Forms.PictureBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SysTab = new System.Windows.Forms.TabPage();
            this.SysBtnStart = new System.Windows.Forms.Button();
            this.SysLbl = new System.Windows.Forms.Label();
            this.SysCbb = new System.Windows.Forms.ComboBox();
            this.PosTab = new System.Windows.Forms.TabPage();
            this.PosLblMaxPosYVal = new System.Windows.Forms.Label();
            this.PosLblMaxPosXVal = new System.Windows.Forms.Label();
            this.PosLblMaxPosY = new System.Windows.Forms.Label();
            this.PosLblMaxPosX = new System.Windows.Forms.Label();
            this.PosLblPosMax = new System.Windows.Forms.Label();
            this.PosScrBarMaxPosY = new System.Windows.Forms.HScrollBar();
            this.PosScrBarMaxPosX = new System.Windows.Forms.HScrollBar();
            this.PosScrBarMinPosY = new System.Windows.Forms.HScrollBar();
            this.PosLblMinPosYVal = new System.Windows.Forms.Label();
            this.PosLblMinPosY = new System.Windows.Forms.Label();
            this.PosLblMinPosXVal = new System.Windows.Forms.Label();
            this.PosLblMinPosX = new System.Windows.Forms.Label();
            this.PosScrBarMinPosX = new System.Windows.Forms.HScrollBar();
            this.PosLblPosMin = new System.Windows.Forms.Label();
            this.BscTab = new System.Windows.Forms.TabPage();
            this.OptScrBarInter = new System.Windows.Forms.HScrollBar();
            this.OptScrBarCyle = new System.Windows.Forms.HScrollBar();
            this.OptLblInterVal = new System.Windows.Forms.Label();
            this.OptLblCycleVal = new System.Windows.Forms.Label();
            this.OptLblCycle = new System.Windows.Forms.Label();
            this.OptLblInter = new System.Windows.Forms.Label();
            this.OptLblEmission = new System.Windows.Forms.Label();
            this.OptLblVeloAglVal = new System.Windows.Forms.Label();
            this.OptLblVeloSpdVal = new System.Windows.Forms.Label();
            this.OptScrBarAgl = new System.Windows.Forms.HScrollBar();
            this.OptScrBarSpeed = new System.Windows.Forms.HScrollBar();
            this.OptLblVelo = new System.Windows.Forms.Label();
            this.OptLblVeloAgl = new System.Windows.Forms.Label();
            this.OptLblVeloSpd = new System.Windows.Forms.Label();
            this.OptScrBarGrvy = new System.Windows.Forms.HScrollBar();
            this.OptScrBarWind = new System.Windows.Forms.HScrollBar();
            this.OptLblGrvyVal = new System.Windows.Forms.Label();
            this.OptLblWindVal = new System.Windows.Forms.Label();
            this.OptLblGrvy = new System.Windows.Forms.Label();
            this.OptLblWind = new System.Windows.Forms.Label();
            this.OptLblPhy = new System.Windows.Forms.Label();
            this.OptLblLifeVal = new System.Windows.Forms.Label();
            this.OptLblNumPartVal = new System.Windows.Forms.Label();
            this.OptScrBarLife = new System.Windows.Forms.HScrollBar();
            this.OptScrBarNumPart = new System.Windows.Forms.HScrollBar();
            this.OptLblLife = new System.Windows.Forms.Label();
            this.OptLblNumPart = new System.Windows.Forms.Label();
            this.OptLblPart = new System.Windows.Forms.Label();
            this.ColorTab = new System.Windows.Forms.TabPage();
            this.ColScrBarMaxB = new System.Windows.Forms.HScrollBar();
            this.ColScrBarMaxG = new System.Windows.Forms.HScrollBar();
            this.ColScrBarMaxR = new System.Windows.Forms.HScrollBar();
            this.ColLblMaxBVal = new System.Windows.Forms.Label();
            this.ColLblMaxGVal = new System.Windows.Forms.Label();
            this.ColLblMaxRVal = new System.Windows.Forms.Label();
            this.ColLblMaxB = new System.Windows.Forms.Label();
            this.ColLblMaxG = new System.Windows.Forms.Label();
            this.ColLblMaxR = new System.Windows.Forms.Label();
            this.ColLblMax = new System.Windows.Forms.Label();
            this.ColScrBarMinR = new System.Windows.Forms.HScrollBar();
            this.ColScrBarMinG = new System.Windows.Forms.HScrollBar();
            this.ColScrBarMinB = new System.Windows.Forms.HScrollBar();
            this.ColLblMinBVal = new System.Windows.Forms.Label();
            this.ColLblMinRVal = new System.Windows.Forms.Label();
            this.ColLblMinGVal = new System.Windows.Forms.Label();
            this.ColLblMinB = new System.Windows.Forms.Label();
            this.ColLblMinG = new System.Windows.Forms.Label();
            this.ColLblMinR = new System.Windows.Forms.Label();
            this.ColLblMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).BeginInit();
            this.TabControl.SuspendLayout();
            this.SysTab.SuspendLayout();
            this.PosTab.SuspendLayout();
            this.BscTab.SuspendLayout();
            this.ColorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawBox
            // 
            this.DrawBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrawBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DrawBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DrawBox.Location = new System.Drawing.Point(0, 0);
            this.DrawBox.Margin = new System.Windows.Forms.Padding(2);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(616, 375);
            this.DrawBox.TabIndex = 3;
            this.DrawBox.TabStop = false;
            this.DrawBox.SizeChanged += new System.EventHandler(this.DrawBox_SizeChanged);
            this.DrawBox.Click += new System.EventHandler(this.DrawBox_Click);
            this.DrawBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBox_Paint);
            this.DrawBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseClick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.SysTab);
            this.TabControl.Controls.Add(this.PosTab);
            this.TabControl.Controls.Add(this.BscTab);
            this.TabControl.Controls.Add(this.ColorTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControl.Location = new System.Drawing.Point(0, 380);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(616, 165);
            this.TabControl.TabIndex = 4;
            // 
            // SysTab
            // 
            this.SysTab.Controls.Add(this.SysBtnStart);
            this.SysTab.Controls.Add(this.SysLbl);
            this.SysTab.Controls.Add(this.SysCbb);
            this.SysTab.Location = new System.Drawing.Point(4, 22);
            this.SysTab.Name = "SysTab";
            this.SysTab.Padding = new System.Windows.Forms.Padding(3);
            this.SysTab.Size = new System.Drawing.Size(608, 139);
            this.SysTab.TabIndex = 0;
            this.SysTab.Text = "System";
            this.SysTab.UseVisualStyleBackColor = true;
            // 
            // SysBtnStart
            // 
            this.SysBtnStart.Location = new System.Drawing.Point(525, 113);
            this.SysBtnStart.Name = "SysBtnStart";
            this.SysBtnStart.Size = new System.Drawing.Size(75, 23);
            this.SysBtnStart.TabIndex = 4;
            this.SysBtnStart.Text = "Start";
            this.SysBtnStart.UseVisualStyleBackColor = true;
            this.SysBtnStart.Click += new System.EventHandler(this.SysBtnStart_Click);
            // 
            // SysLbl
            // 
            this.SysLbl.AutoSize = true;
            this.SysLbl.Location = new System.Drawing.Point(6, 3);
            this.SysLbl.Name = "SysLbl";
            this.SysLbl.Size = new System.Drawing.Size(79, 13);
            this.SysLbl.TabIndex = 3;
            this.SysLbl.Text = "Particle System";
            // 
            // SysCbb
            // 
            this.SysCbb.FormattingEnabled = true;
            this.SysCbb.Location = new System.Drawing.Point(6, 19);
            this.SysCbb.Name = "SysCbb";
            this.SysCbb.Size = new System.Drawing.Size(121, 21);
            this.SysCbb.TabIndex = 2;
            this.SysCbb.SelectedIndexChanged += new System.EventHandler(this.SysCbb_SelectedIndexChanged);
            // 
            // PosTab
            // 
            this.PosTab.Controls.Add(this.PosLblMaxPosYVal);
            this.PosTab.Controls.Add(this.PosLblMaxPosXVal);
            this.PosTab.Controls.Add(this.PosLblMaxPosY);
            this.PosTab.Controls.Add(this.PosLblMaxPosX);
            this.PosTab.Controls.Add(this.PosLblPosMax);
            this.PosTab.Controls.Add(this.PosScrBarMaxPosY);
            this.PosTab.Controls.Add(this.PosScrBarMaxPosX);
            this.PosTab.Controls.Add(this.PosScrBarMinPosY);
            this.PosTab.Controls.Add(this.PosLblMinPosYVal);
            this.PosTab.Controls.Add(this.PosLblMinPosY);
            this.PosTab.Controls.Add(this.PosLblMinPosXVal);
            this.PosTab.Controls.Add(this.PosLblMinPosX);
            this.PosTab.Controls.Add(this.PosScrBarMinPosX);
            this.PosTab.Controls.Add(this.PosLblPosMin);
            this.PosTab.Location = new System.Drawing.Point(4, 22);
            this.PosTab.Name = "PosTab";
            this.PosTab.Padding = new System.Windows.Forms.Padding(3);
            this.PosTab.Size = new System.Drawing.Size(608, 139);
            this.PosTab.TabIndex = 3;
            this.PosTab.Text = "Position";
            this.PosTab.UseVisualStyleBackColor = true;
            // 
            // PosLblMaxPosYVal
            // 
            this.PosLblMaxPosYVal.AutoSize = true;
            this.PosLblMaxPosYVal.Location = new System.Drawing.Point(256, 52);
            this.PosLblMaxPosYVal.Name = "PosLblMaxPosYVal";
            this.PosLblMaxPosYVal.Size = new System.Drawing.Size(13, 13);
            this.PosLblMaxPosYVal.TabIndex = 20;
            this.PosLblMaxPosYVal.Text = "0";
            // 
            // PosLblMaxPosXVal
            // 
            this.PosLblMaxPosXVal.AutoSize = true;
            this.PosLblMaxPosXVal.Location = new System.Drawing.Point(256, 31);
            this.PosLblMaxPosXVal.Name = "PosLblMaxPosXVal";
            this.PosLblMaxPosXVal.Size = new System.Drawing.Size(13, 13);
            this.PosLblMaxPosXVal.TabIndex = 19;
            this.PosLblMaxPosXVal.Text = "0";
            // 
            // PosLblMaxPosY
            // 
            this.PosLblMaxPosY.AutoSize = true;
            this.PosLblMaxPosY.Location = new System.Drawing.Point(153, 48);
            this.PosLblMaxPosY.Name = "PosLblMaxPosY";
            this.PosLblMaxPosY.Size = new System.Drawing.Size(17, 13);
            this.PosLblMaxPosY.TabIndex = 18;
            this.PosLblMaxPosY.Text = "Y:";
            // 
            // PosLblMaxPosX
            // 
            this.PosLblMaxPosX.AutoSize = true;
            this.PosLblMaxPosX.Location = new System.Drawing.Point(153, 31);
            this.PosLblMaxPosX.Name = "PosLblMaxPosX";
            this.PosLblMaxPosX.Size = new System.Drawing.Size(17, 13);
            this.PosLblMaxPosX.TabIndex = 17;
            this.PosLblMaxPosX.Text = "X:";
            // 
            // PosLblPosMax
            // 
            this.PosLblPosMax.AutoSize = true;
            this.PosLblPosMax.Location = new System.Drawing.Point(153, 0);
            this.PosLblPosMax.Name = "PosLblPosMax";
            this.PosLblPosMax.Size = new System.Drawing.Size(91, 13);
            this.PosLblPosMax.TabIndex = 16;
            this.PosLblPosMax.Text = "Position Maximum";
            // 
            // PosScrBarMaxPosY
            // 
            this.PosScrBarMaxPosY.LargeChange = 1;
            this.PosScrBarMaxPosY.Location = new System.Drawing.Point(173, 48);
            this.PosScrBarMaxPosY.Name = "PosScrBarMaxPosY";
            this.PosScrBarMaxPosY.Size = new System.Drawing.Size(80, 17);
            this.PosScrBarMaxPosY.TabIndex = 15;
            this.PosScrBarMaxPosY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PosScrBarMaxPosY_Scroll);
            // 
            // PosScrBarMaxPosX
            // 
            this.PosScrBarMaxPosX.LargeChange = 1;
            this.PosScrBarMaxPosX.Location = new System.Drawing.Point(173, 27);
            this.PosScrBarMaxPosX.Name = "PosScrBarMaxPosX";
            this.PosScrBarMaxPosX.Size = new System.Drawing.Size(80, 17);
            this.PosScrBarMaxPosX.TabIndex = 14;
            this.PosScrBarMaxPosX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PosScrBarMaxPosX_Scroll);
            // 
            // PosScrBarMinPosY
            // 
            this.PosScrBarMinPosY.LargeChange = 1;
            this.PosScrBarMinPosY.Location = new System.Drawing.Point(25, 48);
            this.PosScrBarMinPosY.Name = "PosScrBarMinPosY";
            this.PosScrBarMinPosY.Size = new System.Drawing.Size(80, 17);
            this.PosScrBarMinPosY.TabIndex = 13;
            this.PosScrBarMinPosY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OptScrBarMinPosY_Scroll);
            // 
            // PosLblMinPosYVal
            // 
            this.PosLblMinPosYVal.AutoSize = true;
            this.PosLblMinPosYVal.Location = new System.Drawing.Point(108, 52);
            this.PosLblMinPosYVal.Name = "PosLblMinPosYVal";
            this.PosLblMinPosYVal.Size = new System.Drawing.Size(13, 13);
            this.PosLblMinPosYVal.TabIndex = 12;
            this.PosLblMinPosYVal.Text = "0";
            // 
            // PosLblMinPosY
            // 
            this.PosLblMinPosY.AutoSize = true;
            this.PosLblMinPosY.Location = new System.Drawing.Point(5, 48);
            this.PosLblMinPosY.Name = "PosLblMinPosY";
            this.PosLblMinPosY.Size = new System.Drawing.Size(17, 13);
            this.PosLblMinPosY.TabIndex = 11;
            this.PosLblMinPosY.Text = "Y:";
            // 
            // PosLblMinPosXVal
            // 
            this.PosLblMinPosXVal.AutoSize = true;
            this.PosLblMinPosXVal.Location = new System.Drawing.Point(108, 31);
            this.PosLblMinPosXVal.Name = "PosLblMinPosXVal";
            this.PosLblMinPosXVal.Size = new System.Drawing.Size(13, 13);
            this.PosLblMinPosXVal.TabIndex = 10;
            this.PosLblMinPosXVal.Text = "0";
            // 
            // PosLblMinPosX
            // 
            this.PosLblMinPosX.AutoSize = true;
            this.PosLblMinPosX.Location = new System.Drawing.Point(5, 31);
            this.PosLblMinPosX.Name = "PosLblMinPosX";
            this.PosLblMinPosX.Size = new System.Drawing.Size(17, 13);
            this.PosLblMinPosX.TabIndex = 9;
            this.PosLblMinPosX.Text = "X:";
            // 
            // PosScrBarMinPosX
            // 
            this.PosScrBarMinPosX.LargeChange = 1;
            this.PosScrBarMinPosX.Location = new System.Drawing.Point(25, 27);
            this.PosScrBarMinPosX.Name = "PosScrBarMinPosX";
            this.PosScrBarMinPosX.Size = new System.Drawing.Size(80, 17);
            this.PosScrBarMinPosX.TabIndex = 8;
            this.PosScrBarMinPosX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OptScrBarMinPosX_Scroll);
            // 
            // PosLblPosMin
            // 
            this.PosLblPosMin.AutoSize = true;
            this.PosLblPosMin.Location = new System.Drawing.Point(6, 3);
            this.PosLblPosMin.Name = "PosLblPosMin";
            this.PosLblPosMin.Size = new System.Drawing.Size(88, 13);
            this.PosLblPosMin.TabIndex = 1;
            this.PosLblPosMin.Text = "Position Minimum";
            // 
            // BscTab
            // 
            this.BscTab.Controls.Add(this.OptScrBarInter);
            this.BscTab.Controls.Add(this.OptScrBarCyle);
            this.BscTab.Controls.Add(this.OptLblInterVal);
            this.BscTab.Controls.Add(this.OptLblCycleVal);
            this.BscTab.Controls.Add(this.OptLblCycle);
            this.BscTab.Controls.Add(this.OptLblInter);
            this.BscTab.Controls.Add(this.OptLblEmission);
            this.BscTab.Controls.Add(this.OptLblVeloAglVal);
            this.BscTab.Controls.Add(this.OptLblVeloSpdVal);
            this.BscTab.Controls.Add(this.OptScrBarAgl);
            this.BscTab.Controls.Add(this.OptScrBarSpeed);
            this.BscTab.Controls.Add(this.OptLblVelo);
            this.BscTab.Controls.Add(this.OptLblVeloAgl);
            this.BscTab.Controls.Add(this.OptLblVeloSpd);
            this.BscTab.Controls.Add(this.OptScrBarGrvy);
            this.BscTab.Controls.Add(this.OptScrBarWind);
            this.BscTab.Controls.Add(this.OptLblGrvyVal);
            this.BscTab.Controls.Add(this.OptLblWindVal);
            this.BscTab.Controls.Add(this.OptLblGrvy);
            this.BscTab.Controls.Add(this.OptLblWind);
            this.BscTab.Controls.Add(this.OptLblPhy);
            this.BscTab.Controls.Add(this.OptLblLifeVal);
            this.BscTab.Controls.Add(this.OptLblNumPartVal);
            this.BscTab.Controls.Add(this.OptScrBarLife);
            this.BscTab.Controls.Add(this.OptScrBarNumPart);
            this.BscTab.Controls.Add(this.OptLblLife);
            this.BscTab.Controls.Add(this.OptLblNumPart);
            this.BscTab.Controls.Add(this.OptLblPart);
            this.BscTab.Location = new System.Drawing.Point(4, 22);
            this.BscTab.Name = "BscTab";
            this.BscTab.Padding = new System.Windows.Forms.Padding(3);
            this.BscTab.Size = new System.Drawing.Size(608, 139);
            this.BscTab.TabIndex = 1;
            this.BscTab.Text = "Option";
            this.BscTab.UseVisualStyleBackColor = true;
            // 
            // OptScrBarInter
            // 
            this.OptScrBarInter.LargeChange = 1;
            this.OptScrBarInter.Location = new System.Drawing.Point(227, 110);
            this.OptScrBarInter.Name = "OptScrBarInter";
            this.OptScrBarInter.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarInter.TabIndex = 41;
            this.OptScrBarInter.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OptScrBarEmission_Scroll);
            // 
            // OptScrBarCyle
            // 
            this.OptScrBarCyle.LargeChange = 1;
            this.OptScrBarCyle.Location = new System.Drawing.Point(227, 93);
            this.OptScrBarCyle.Name = "OptScrBarCyle";
            this.OptScrBarCyle.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarCyle.TabIndex = 40;
            this.OptScrBarCyle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OptScrBarCyle_Scroll);
            // 
            // OptLblInterVal
            // 
            this.OptLblInterVal.AutoSize = true;
            this.OptLblInterVal.Location = new System.Drawing.Point(310, 114);
            this.OptLblInterVal.Name = "OptLblInterVal";
            this.OptLblInterVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblInterVal.TabIndex = 39;
            this.OptLblInterVal.Text = "0";
            // 
            // OptLblCycleVal
            // 
            this.OptLblCycleVal.AutoSize = true;
            this.OptLblCycleVal.Location = new System.Drawing.Point(310, 97);
            this.OptLblCycleVal.Name = "OptLblCycleVal";
            this.OptLblCycleVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblCycleVal.TabIndex = 38;
            this.OptLblCycleVal.Text = "0";
            // 
            // OptLblCycle
            // 
            this.OptLblCycle.AutoSize = true;
            this.OptLblCycle.Location = new System.Drawing.Point(182, 97);
            this.OptLblCycle.Name = "OptLblCycle";
            this.OptLblCycle.Size = new System.Drawing.Size(36, 13);
            this.OptLblCycle.TabIndex = 37;
            this.OptLblCycle.Text = "Cycle:";
            // 
            // OptLblInter
            // 
            this.OptLblInter.AutoSize = true;
            this.OptLblInter.Location = new System.Drawing.Point(182, 114);
            this.OptLblInter.Name = "OptLblInter";
            this.OptLblInter.Size = new System.Drawing.Size(45, 13);
            this.OptLblInter.TabIndex = 36;
            this.OptLblInter.Text = "Interval:";
            // 
            // OptLblEmission
            // 
            this.OptLblEmission.AutoSize = true;
            this.OptLblEmission.Location = new System.Drawing.Point(182, 71);
            this.OptLblEmission.Name = "OptLblEmission";
            this.OptLblEmission.Size = new System.Drawing.Size(48, 13);
            this.OptLblEmission.TabIndex = 35;
            this.OptLblEmission.Text = "Emission";
            // 
            // OptLblVeloAglVal
            // 
            this.OptLblVeloAglVal.AutoSize = true;
            this.OptLblVeloAglVal.Location = new System.Drawing.Point(146, 43);
            this.OptLblVeloAglVal.Name = "OptLblVeloAglVal";
            this.OptLblVeloAglVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblVeloAglVal.TabIndex = 34;
            this.OptLblVeloAglVal.Text = "0";
            // 
            // OptLblVeloSpdVal
            // 
            this.OptLblVeloSpdVal.AutoSize = true;
            this.OptLblVeloSpdVal.Location = new System.Drawing.Point(146, 26);
            this.OptLblVeloSpdVal.Name = "OptLblVeloSpdVal";
            this.OptLblVeloSpdVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblVeloSpdVal.TabIndex = 33;
            this.OptLblVeloSpdVal.Text = "0";
            // 
            // OptScrBarAgl
            // 
            this.OptScrBarAgl.LargeChange = 1;
            this.OptScrBarAgl.Location = new System.Drawing.Point(63, 39);
            this.OptScrBarAgl.Name = "OptScrBarAgl";
            this.OptScrBarAgl.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarAgl.TabIndex = 32;
            this.OptScrBarAgl.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OptScrBarAgl_Scroll);
            // 
            // OptScrBarSpeed
            // 
            this.OptScrBarSpeed.LargeChange = 1;
            this.OptScrBarSpeed.Location = new System.Drawing.Point(63, 22);
            this.OptScrBarSpeed.Name = "OptScrBarSpeed";
            this.OptScrBarSpeed.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarSpeed.TabIndex = 31;
            this.OptScrBarSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OptScrBarSpeed_Scroll);
            // 
            // OptLblVelo
            // 
            this.OptLblVelo.AutoSize = true;
            this.OptLblVelo.Location = new System.Drawing.Point(8, 3);
            this.OptLblVelo.Name = "OptLblVelo";
            this.OptLblVelo.Size = new System.Drawing.Size(44, 13);
            this.OptLblVelo.TabIndex = 30;
            this.OptLblVelo.Text = "Velocity";
            // 
            // OptLblVeloAgl
            // 
            this.OptLblVeloAgl.AutoSize = true;
            this.OptLblVeloAgl.Location = new System.Drawing.Point(10, 43);
            this.OptLblVeloAgl.Name = "OptLblVeloAgl";
            this.OptLblVeloAgl.Size = new System.Drawing.Size(37, 13);
            this.OptLblVeloAgl.TabIndex = 29;
            this.OptLblVeloAgl.Text = "Angle:";
            // 
            // OptLblVeloSpd
            // 
            this.OptLblVeloSpd.AutoSize = true;
            this.OptLblVeloSpd.Location = new System.Drawing.Point(10, 26);
            this.OptLblVeloSpd.Name = "OptLblVeloSpd";
            this.OptLblVeloSpd.Size = new System.Drawing.Size(41, 13);
            this.OptLblVeloSpd.TabIndex = 28;
            this.OptLblVeloSpd.Text = "Speed:";
            // 
            // OptScrBarGrvy
            // 
            this.OptScrBarGrvy.LargeChange = 1;
            this.OptScrBarGrvy.Location = new System.Drawing.Point(227, 42);
            this.OptScrBarGrvy.Name = "OptScrBarGrvy";
            this.OptScrBarGrvy.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarGrvy.TabIndex = 27;
            this.OptScrBarGrvy.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OptScrBarGrvy_Scroll);
            // 
            // OptScrBarWind
            // 
            this.OptScrBarWind.LargeChange = 1;
            this.OptScrBarWind.Location = new System.Drawing.Point(227, 25);
            this.OptScrBarWind.Name = "OptScrBarWind";
            this.OptScrBarWind.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarWind.TabIndex = 26;
            this.OptScrBarWind.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OptScrBarWind_Scroll);
            // 
            // OptLblGrvyVal
            // 
            this.OptLblGrvyVal.AutoSize = true;
            this.OptLblGrvyVal.Location = new System.Drawing.Point(310, 46);
            this.OptLblGrvyVal.Name = "OptLblGrvyVal";
            this.OptLblGrvyVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblGrvyVal.TabIndex = 25;
            this.OptLblGrvyVal.Text = "0";
            // 
            // OptLblWindVal
            // 
            this.OptLblWindVal.AutoSize = true;
            this.OptLblWindVal.Location = new System.Drawing.Point(310, 29);
            this.OptLblWindVal.Name = "OptLblWindVal";
            this.OptLblWindVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblWindVal.TabIndex = 24;
            this.OptLblWindVal.Text = "0";
            // 
            // OptLblGrvy
            // 
            this.OptLblGrvy.AutoSize = true;
            this.OptLblGrvy.Location = new System.Drawing.Point(184, 46);
            this.OptLblGrvy.Name = "OptLblGrvy";
            this.OptLblGrvy.Size = new System.Drawing.Size(43, 13);
            this.OptLblGrvy.TabIndex = 23;
            this.OptLblGrvy.Text = "Gravity:";
            // 
            // OptLblWind
            // 
            this.OptLblWind.AutoSize = true;
            this.OptLblWind.Location = new System.Drawing.Point(184, 29);
            this.OptLblWind.Name = "OptLblWind";
            this.OptLblWind.Size = new System.Drawing.Size(35, 13);
            this.OptLblWind.TabIndex = 22;
            this.OptLblWind.Text = "Wind:";
            // 
            // OptLblPhy
            // 
            this.OptLblPhy.AutoSize = true;
            this.OptLblPhy.Location = new System.Drawing.Point(182, 3);
            this.OptLblPhy.Name = "OptLblPhy";
            this.OptLblPhy.Size = new System.Drawing.Size(38, 13);
            this.OptLblPhy.TabIndex = 21;
            this.OptLblPhy.Text = "Physic";
            // 
            // OptLblLifeVal
            // 
            this.OptLblLifeVal.AutoSize = true;
            this.OptLblLifeVal.Location = new System.Drawing.Point(146, 114);
            this.OptLblLifeVal.Name = "OptLblLifeVal";
            this.OptLblLifeVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblLifeVal.TabIndex = 20;
            this.OptLblLifeVal.Text = "0";
            // 
            // OptLblNumPartVal
            // 
            this.OptLblNumPartVal.AutoSize = true;
            this.OptLblNumPartVal.Location = new System.Drawing.Point(146, 97);
            this.OptLblNumPartVal.Name = "OptLblNumPartVal";
            this.OptLblNumPartVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblNumPartVal.TabIndex = 19;
            this.OptLblNumPartVal.Text = "0";
            // 
            // OptScrBarLife
            // 
            this.OptScrBarLife.LargeChange = 1;
            this.OptScrBarLife.Location = new System.Drawing.Point(61, 110);
            this.OptScrBarLife.Name = "OptScrBarLife";
            this.OptScrBarLife.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarLife.TabIndex = 18;
            this.OptScrBarLife.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OptScrBarLife_Scroll);
            // 
            // OptScrBarNumPart
            // 
            this.OptScrBarNumPart.LargeChange = 1;
            this.OptScrBarNumPart.Location = new System.Drawing.Point(61, 93);
            this.OptScrBarNumPart.Name = "OptScrBarNumPart";
            this.OptScrBarNumPart.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarNumPart.TabIndex = 17;
            this.OptScrBarNumPart.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OptScrBarNumPart_Scroll);
            // 
            // OptLblLife
            // 
            this.OptLblLife.AutoSize = true;
            this.OptLblLife.Location = new System.Drawing.Point(8, 114);
            this.OptLblLife.Name = "OptLblLife";
            this.OptLblLife.Size = new System.Drawing.Size(27, 13);
            this.OptLblLife.TabIndex = 16;
            this.OptLblLife.Text = "Life:";
            // 
            // OptLblNumPart
            // 
            this.OptLblNumPart.AutoSize = true;
            this.OptLblNumPart.Location = new System.Drawing.Point(8, 97);
            this.OptLblNumPart.Name = "OptLblNumPart";
            this.OptLblNumPart.Size = new System.Drawing.Size(50, 13);
            this.OptLblNumPart.TabIndex = 15;
            this.OptLblNumPart.Text = "Particles:";
            // 
            // OptLblPart
            // 
            this.OptLblPart.AutoSize = true;
            this.OptLblPart.Location = new System.Drawing.Point(8, 71);
            this.OptLblPart.Name = "OptLblPart";
            this.OptLblPart.Size = new System.Drawing.Size(42, 13);
            this.OptLblPart.TabIndex = 14;
            this.OptLblPart.Text = "Particle";
            // 
            // ColorTab
            // 
            this.ColorTab.Controls.Add(this.ColScrBarMaxB);
            this.ColorTab.Controls.Add(this.ColScrBarMaxG);
            this.ColorTab.Controls.Add(this.ColScrBarMaxR);
            this.ColorTab.Controls.Add(this.ColLblMaxBVal);
            this.ColorTab.Controls.Add(this.ColLblMaxGVal);
            this.ColorTab.Controls.Add(this.ColLblMaxRVal);
            this.ColorTab.Controls.Add(this.ColLblMaxB);
            this.ColorTab.Controls.Add(this.ColLblMaxG);
            this.ColorTab.Controls.Add(this.ColLblMaxR);
            this.ColorTab.Controls.Add(this.ColLblMax);
            this.ColorTab.Controls.Add(this.ColScrBarMinR);
            this.ColorTab.Controls.Add(this.ColScrBarMinG);
            this.ColorTab.Controls.Add(this.ColScrBarMinB);
            this.ColorTab.Controls.Add(this.ColLblMinBVal);
            this.ColorTab.Controls.Add(this.ColLblMinRVal);
            this.ColorTab.Controls.Add(this.ColLblMinGVal);
            this.ColorTab.Controls.Add(this.ColLblMinB);
            this.ColorTab.Controls.Add(this.ColLblMinG);
            this.ColorTab.Controls.Add(this.ColLblMinR);
            this.ColorTab.Controls.Add(this.ColLblMin);
            this.ColorTab.Location = new System.Drawing.Point(4, 22);
            this.ColorTab.Name = "ColorTab";
            this.ColorTab.Padding = new System.Windows.Forms.Padding(3);
            this.ColorTab.Size = new System.Drawing.Size(608, 139);
            this.ColorTab.TabIndex = 2;
            this.ColorTab.Text = "Color";
            this.ColorTab.UseVisualStyleBackColor = true;
            // 
            // ColScrBarMaxB
            // 
            this.ColScrBarMaxB.LargeChange = 1;
            this.ColScrBarMaxB.Location = new System.Drawing.Point(172, 70);
            this.ColScrBarMaxB.Name = "ColScrBarMaxB";
            this.ColScrBarMaxB.Size = new System.Drawing.Size(80, 17);
            this.ColScrBarMaxB.TabIndex = 17;
            this.ColScrBarMaxB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColScrBarMaxB_Scroll);
            // 
            // ColScrBarMaxG
            // 
            this.ColScrBarMaxG.LargeChange = 1;
            this.ColScrBarMaxG.Location = new System.Drawing.Point(172, 49);
            this.ColScrBarMaxG.Name = "ColScrBarMaxG";
            this.ColScrBarMaxG.Size = new System.Drawing.Size(80, 17);
            this.ColScrBarMaxG.TabIndex = 16;
            this.ColScrBarMaxG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColScrBarMaxG_Scroll);
            // 
            // ColScrBarMaxR
            // 
            this.ColScrBarMaxR.LargeChange = 1;
            this.ColScrBarMaxR.Location = new System.Drawing.Point(172, 27);
            this.ColScrBarMaxR.Name = "ColScrBarMaxR";
            this.ColScrBarMaxR.Size = new System.Drawing.Size(80, 17);
            this.ColScrBarMaxR.TabIndex = 15;
            this.ColScrBarMaxR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColScrBarMaxR_Scroll);
            // 
            // ColLblMaxBVal
            // 
            this.ColLblMaxBVal.AutoSize = true;
            this.ColLblMaxBVal.Location = new System.Drawing.Point(255, 74);
            this.ColLblMaxBVal.Name = "ColLblMaxBVal";
            this.ColLblMaxBVal.Size = new System.Drawing.Size(13, 13);
            this.ColLblMaxBVal.TabIndex = 14;
            this.ColLblMaxBVal.Text = "0";
            // 
            // ColLblMaxGVal
            // 
            this.ColLblMaxGVal.AutoSize = true;
            this.ColLblMaxGVal.Location = new System.Drawing.Point(255, 53);
            this.ColLblMaxGVal.Name = "ColLblMaxGVal";
            this.ColLblMaxGVal.Size = new System.Drawing.Size(13, 13);
            this.ColLblMaxGVal.TabIndex = 13;
            this.ColLblMaxGVal.Text = "0";
            // 
            // ColLblMaxRVal
            // 
            this.ColLblMaxRVal.AutoSize = true;
            this.ColLblMaxRVal.Location = new System.Drawing.Point(255, 31);
            this.ColLblMaxRVal.Name = "ColLblMaxRVal";
            this.ColLblMaxRVal.Size = new System.Drawing.Size(13, 13);
            this.ColLblMaxRVal.TabIndex = 12;
            this.ColLblMaxRVal.Text = "0";
            // 
            // ColLblMaxB
            // 
            this.ColLblMaxB.AutoSize = true;
            this.ColLblMaxB.Location = new System.Drawing.Point(151, 74);
            this.ColLblMaxB.Name = "ColLblMaxB";
            this.ColLblMaxB.Size = new System.Drawing.Size(17, 13);
            this.ColLblMaxB.TabIndex = 11;
            this.ColLblMaxB.Text = "B:";
            // 
            // ColLblMaxG
            // 
            this.ColLblMaxG.AutoSize = true;
            this.ColLblMaxG.Location = new System.Drawing.Point(151, 53);
            this.ColLblMaxG.Name = "ColLblMaxG";
            this.ColLblMaxG.Size = new System.Drawing.Size(18, 13);
            this.ColLblMaxG.TabIndex = 10;
            this.ColLblMaxG.Text = "G:";
            // 
            // ColLblMaxR
            // 
            this.ColLblMaxR.AutoSize = true;
            this.ColLblMaxR.Location = new System.Drawing.Point(151, 31);
            this.ColLblMaxR.Name = "ColLblMaxR";
            this.ColLblMaxR.Size = new System.Drawing.Size(18, 13);
            this.ColLblMaxR.TabIndex = 9;
            this.ColLblMaxR.Text = "R:";
            // 
            // ColLblMax
            // 
            this.ColLblMax.AutoSize = true;
            this.ColLblMax.Location = new System.Drawing.Point(151, 3);
            this.ColLblMax.Name = "ColLblMax";
            this.ColLblMax.Size = new System.Drawing.Size(78, 13);
            this.ColLblMax.TabIndex = 8;
            this.ColLblMax.Text = "Color Maximum";
            // 
            // ColScrBarMinR
            // 
            this.ColScrBarMinR.LargeChange = 1;
            this.ColScrBarMinR.Location = new System.Drawing.Point(27, 27);
            this.ColScrBarMinR.Name = "ColScrBarMinR";
            this.ColScrBarMinR.Size = new System.Drawing.Size(80, 17);
            this.ColScrBarMinR.TabIndex = 5;
            this.ColScrBarMinR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColScrBarMinR_Scroll);
            // 
            // ColScrBarMinG
            // 
            this.ColScrBarMinG.LargeChange = 1;
            this.ColScrBarMinG.Location = new System.Drawing.Point(27, 49);
            this.ColScrBarMinG.Name = "ColScrBarMinG";
            this.ColScrBarMinG.Size = new System.Drawing.Size(80, 17);
            this.ColScrBarMinG.TabIndex = 6;
            this.ColScrBarMinG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColScrBarMinG_Scroll);
            // 
            // ColScrBarMinB
            // 
            this.ColScrBarMinB.LargeChange = 1;
            this.ColScrBarMinB.Location = new System.Drawing.Point(26, 70);
            this.ColScrBarMinB.Name = "ColScrBarMinB";
            this.ColScrBarMinB.Size = new System.Drawing.Size(80, 17);
            this.ColScrBarMinB.TabIndex = 7;
            this.ColScrBarMinB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColScrBarMinB_Scroll);
            // 
            // ColLblMinBVal
            // 
            this.ColLblMinBVal.AutoSize = true;
            this.ColLblMinBVal.Location = new System.Drawing.Point(110, 74);
            this.ColLblMinBVal.Name = "ColLblMinBVal";
            this.ColLblMinBVal.Size = new System.Drawing.Size(13, 13);
            this.ColLblMinBVal.TabIndex = 6;
            this.ColLblMinBVal.Text = "0";
            // 
            // ColLblMinRVal
            // 
            this.ColLblMinRVal.AutoSize = true;
            this.ColLblMinRVal.Location = new System.Drawing.Point(110, 31);
            this.ColLblMinRVal.Name = "ColLblMinRVal";
            this.ColLblMinRVal.Size = new System.Drawing.Size(13, 13);
            this.ColLblMinRVal.TabIndex = 5;
            this.ColLblMinRVal.Text = "0";
            // 
            // ColLblMinGVal
            // 
            this.ColLblMinGVal.AutoSize = true;
            this.ColLblMinGVal.Location = new System.Drawing.Point(110, 53);
            this.ColLblMinGVal.Name = "ColLblMinGVal";
            this.ColLblMinGVal.Size = new System.Drawing.Size(13, 13);
            this.ColLblMinGVal.TabIndex = 4;
            this.ColLblMinGVal.Text = "0";
            // 
            // ColLblMinB
            // 
            this.ColLblMinB.AutoSize = true;
            this.ColLblMinB.Location = new System.Drawing.Point(6, 74);
            this.ColLblMinB.Name = "ColLblMinB";
            this.ColLblMinB.Size = new System.Drawing.Size(17, 13);
            this.ColLblMinB.TabIndex = 3;
            this.ColLblMinB.Text = "B:";
            // 
            // ColLblMinG
            // 
            this.ColLblMinG.AutoSize = true;
            this.ColLblMinG.Location = new System.Drawing.Point(6, 53);
            this.ColLblMinG.Name = "ColLblMinG";
            this.ColLblMinG.Size = new System.Drawing.Size(18, 13);
            this.ColLblMinG.TabIndex = 2;
            this.ColLblMinG.Text = "G:";
            // 
            // ColLblMinR
            // 
            this.ColLblMinR.AutoSize = true;
            this.ColLblMinR.Location = new System.Drawing.Point(6, 31);
            this.ColLblMinR.Name = "ColLblMinR";
            this.ColLblMinR.Size = new System.Drawing.Size(18, 13);
            this.ColLblMinR.TabIndex = 1;
            this.ColLblMinR.Text = "R:";
            // 
            // ColLblMin
            // 
            this.ColLblMin.AutoSize = true;
            this.ColLblMin.Location = new System.Drawing.Point(6, 3);
            this.ColLblMin.Name = "ColLblMin";
            this.ColLblMin.Size = new System.Drawing.Size(75, 13);
            this.ColLblMin.TabIndex = 0;
            this.ColLblMin.Text = "Color Minimum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 545);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.DrawBox);
            this.MinimumSize = new System.Drawing.Size(632, 544);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParticleTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.SysTab.ResumeLayout(false);
            this.SysTab.PerformLayout();
            this.PosTab.ResumeLayout(false);
            this.PosTab.PerformLayout();
            this.BscTab.ResumeLayout(false);
            this.BscTab.PerformLayout();
            this.ColorTab.ResumeLayout(false);
            this.ColorTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox DrawBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SysTab;
        private System.Windows.Forms.Label SysLbl;
        private System.Windows.Forms.ComboBox SysCbb;
        private System.Windows.Forms.TabPage BscTab;
        private System.Windows.Forms.Label OptLblLifeVal;
        private System.Windows.Forms.Label OptLblNumPartVal;
        private System.Windows.Forms.HScrollBar OptScrBarLife;
        private System.Windows.Forms.HScrollBar OptScrBarNumPart;
        private System.Windows.Forms.Label OptLblLife;
        private System.Windows.Forms.Label OptLblNumPart;
        private System.Windows.Forms.Label OptLblPart;
        private System.Windows.Forms.HScrollBar OptScrBarGrvy;
        private System.Windows.Forms.HScrollBar OptScrBarWind;
        private System.Windows.Forms.Label OptLblGrvyVal;
        private System.Windows.Forms.Label OptLblWindVal;
        private System.Windows.Forms.Label OptLblGrvy;
        private System.Windows.Forms.Label OptLblWind;
        private System.Windows.Forms.Label OptLblPhy;
        private System.Windows.Forms.TabPage ColorTab;
        private System.Windows.Forms.HScrollBar ColScrBarMinR;
        private System.Windows.Forms.HScrollBar ColScrBarMinG;
        private System.Windows.Forms.HScrollBar ColScrBarMinB;
        private System.Windows.Forms.Label ColLblMinBVal;
        private System.Windows.Forms.Label ColLblMinRVal;
        private System.Windows.Forms.Label ColLblMinGVal;
        private System.Windows.Forms.Label ColLblMinB;
        private System.Windows.Forms.Label ColLblMinG;
        private System.Windows.Forms.Label ColLblMinR;
        private System.Windows.Forms.Label ColLblMin;
        private System.Windows.Forms.HScrollBar ColScrBarMaxB;
        private System.Windows.Forms.HScrollBar ColScrBarMaxG;
        private System.Windows.Forms.HScrollBar ColScrBarMaxR;
        private System.Windows.Forms.Label ColLblMaxBVal;
        private System.Windows.Forms.Label ColLblMaxGVal;
        private System.Windows.Forms.Label ColLblMaxRVal;
        private System.Windows.Forms.Label ColLblMaxB;
        private System.Windows.Forms.Label ColLblMaxG;
        private System.Windows.Forms.Label ColLblMaxR;
        private System.Windows.Forms.Label ColLblMax;
        private System.Windows.Forms.TabPage PosTab;
        private System.Windows.Forms.Button SysBtnStart;
        private System.Windows.Forms.HScrollBar PosScrBarMinPosY;
        private System.Windows.Forms.Label PosLblMinPosYVal;
        private System.Windows.Forms.Label PosLblMinPosY;
        private System.Windows.Forms.Label PosLblMinPosXVal;
        private System.Windows.Forms.Label PosLblMinPosX;
        private System.Windows.Forms.HScrollBar PosScrBarMinPosX;
        private System.Windows.Forms.Label PosLblPosMin;
        private System.Windows.Forms.Label OptLblVeloAglVal;
        private System.Windows.Forms.Label OptLblVeloSpdVal;
        private System.Windows.Forms.HScrollBar OptScrBarAgl;
        private System.Windows.Forms.HScrollBar OptScrBarSpeed;
        private System.Windows.Forms.Label OptLblVelo;
        private System.Windows.Forms.Label OptLblVeloAgl;
        private System.Windows.Forms.Label OptLblVeloSpd;
        private System.Windows.Forms.Label PosLblMaxPosYVal;
        private System.Windows.Forms.Label PosLblMaxPosXVal;
        private System.Windows.Forms.Label PosLblMaxPosY;
        private System.Windows.Forms.Label PosLblMaxPosX;
        private System.Windows.Forms.Label PosLblPosMax;
        private System.Windows.Forms.HScrollBar PosScrBarMaxPosY;
        private System.Windows.Forms.HScrollBar PosScrBarMaxPosX;
        private System.Windows.Forms.HScrollBar OptScrBarInter;
        private System.Windows.Forms.HScrollBar OptScrBarCyle;
        private System.Windows.Forms.Label OptLblInterVal;
        private System.Windows.Forms.Label OptLblCycleVal;
        private System.Windows.Forms.Label OptLblCycle;
        private System.Windows.Forms.Label OptLblInter;
        private System.Windows.Forms.Label OptLblEmission;
    }
}

