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
            this.FontainButton = new System.Windows.Forms.Button();
            this.DrawBox = new System.Windows.Forms.PictureBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SysTab = new System.Windows.Forms.TabPage();
            this.BscTab = new System.Windows.Forms.TabPage();
            this.SysCbb = new System.Windows.Forms.ComboBox();
            this.SysLbl = new System.Windows.Forms.Label();
            this.OptLblPos = new System.Windows.Forms.Label();
            this.OptScrBarPosX = new System.Windows.Forms.HScrollBar();
            this.OptLblPosX = new System.Windows.Forms.Label();
            this.OptLblPosXVal = new System.Windows.Forms.Label();
            this.OptLblPosY = new System.Windows.Forms.Label();
            this.OptLblPosYVal = new System.Windows.Forms.Label();
            this.OptLblVeloX = new System.Windows.Forms.Label();
            this.OptScrBarPosY = new System.Windows.Forms.HScrollBar();
            this.OptLblVeloY = new System.Windows.Forms.Label();
            this.OptLblVelo = new System.Windows.Forms.Label();
            this.OptScrBarVeloX = new System.Windows.Forms.HScrollBar();
            this.OptScrBarVeloY = new System.Windows.Forms.HScrollBar();
            this.OptLblVeloXVal = new System.Windows.Forms.Label();
            this.OptLblVeloYVal = new System.Windows.Forms.Label();
            this.OptLblPart = new System.Windows.Forms.Label();
            this.OptLblNumPart = new System.Windows.Forms.Label();
            this.OptLblLife = new System.Windows.Forms.Label();
            this.OptScrBarNumPart = new System.Windows.Forms.HScrollBar();
            this.OptScrBarLife = new System.Windows.Forms.HScrollBar();
            this.OptLblNumPartVal = new System.Windows.Forms.Label();
            this.OptLblLifeVal = new System.Windows.Forms.Label();
            this.OptLblGrvy = new System.Windows.Forms.Label();
            this.OptLblGrvyX = new System.Windows.Forms.Label();
            this.OptLblGrvyY = new System.Windows.Forms.Label();
            this.OptLblGrvyXVal = new System.Windows.Forms.Label();
            this.OptLblGrvyYVal = new System.Windows.Forms.Label();
            this.OptScrBarGrvyX = new System.Windows.Forms.HScrollBar();
            this.OptScrBarGrvyY = new System.Windows.Forms.HScrollBar();
            this.ColorTab = new System.Windows.Forms.TabPage();
            this.ColLblMin = new System.Windows.Forms.Label();
            this.ColLblMinR = new System.Windows.Forms.Label();
            this.ColLblMinG = new System.Windows.Forms.Label();
            this.ColLblMinB = new System.Windows.Forms.Label();
            this.ColLblMinGVal = new System.Windows.Forms.Label();
            this.ColLblMinRVal = new System.Windows.Forms.Label();
            this.ColLblMinBVal = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.ColLblMax = new System.Windows.Forms.Label();
            this.ColLblMaxR = new System.Windows.Forms.Label();
            this.ColLblMaxG = new System.Windows.Forms.Label();
            this.ColLblMaxB = new System.Windows.Forms.Label();
            this.ColLblMaxRVal = new System.Windows.Forms.Label();
            this.ColLblMaxGVal = new System.Windows.Forms.Label();
            this.ColLblMaxBVal = new System.Windows.Forms.Label();
            this.hScrollBar4 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar5 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar6 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).BeginInit();
            this.TabControl.SuspendLayout();
            this.SysTab.SuspendLayout();
            this.BscTab.SuspendLayout();
            this.ColorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontainButton
            // 
            this.FontainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FontainButton.Location = new System.Drawing.Point(431, 69);
            this.FontainButton.Name = "FontainButton";
            this.FontainButton.Size = new System.Drawing.Size(75, 24);
            this.FontainButton.TabIndex = 1;
            this.FontainButton.Text = "Fountain";
            this.FontainButton.UseVisualStyleBackColor = true;
            this.FontainButton.Click += new System.EventHandler(this.FontainButton_Click);
            // 
            // DrawBox
            // 
            this.DrawBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrawBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DrawBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DrawBox.Location = new System.Drawing.Point(0, 0);
            this.DrawBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(616, 375);
            this.DrawBox.TabIndex = 3;
            this.DrawBox.TabStop = false;
            this.DrawBox.Click += new System.EventHandler(this.DrawBox_Click);
            this.DrawBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBox_Paint);
            this.DrawBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseClick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.SysTab);
            this.TabControl.Controls.Add(this.BscTab);
            this.TabControl.Controls.Add(this.ColorTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControl.Location = new System.Drawing.Point(0, 380);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(616, 125);
            this.TabControl.TabIndex = 4;
            // 
            // SysTab
            // 
            this.SysTab.Controls.Add(this.SysLbl);
            this.SysTab.Controls.Add(this.SysCbb);
            this.SysTab.Controls.Add(this.FontainButton);
            this.SysTab.Location = new System.Drawing.Point(4, 22);
            this.SysTab.Name = "SysTab";
            this.SysTab.Padding = new System.Windows.Forms.Padding(3);
            this.SysTab.Size = new System.Drawing.Size(608, 99);
            this.SysTab.TabIndex = 0;
            this.SysTab.Text = "System";
            this.SysTab.UseVisualStyleBackColor = true;
            // 
            // BscTab
            // 
            this.BscTab.Controls.Add(this.OptScrBarGrvyY);
            this.BscTab.Controls.Add(this.OptScrBarGrvyX);
            this.BscTab.Controls.Add(this.OptLblGrvyYVal);
            this.BscTab.Controls.Add(this.OptLblGrvyXVal);
            this.BscTab.Controls.Add(this.OptLblGrvyY);
            this.BscTab.Controls.Add(this.OptLblGrvyX);
            this.BscTab.Controls.Add(this.OptLblGrvy);
            this.BscTab.Controls.Add(this.OptLblLifeVal);
            this.BscTab.Controls.Add(this.OptLblNumPartVal);
            this.BscTab.Controls.Add(this.OptScrBarLife);
            this.BscTab.Controls.Add(this.OptScrBarNumPart);
            this.BscTab.Controls.Add(this.OptLblLife);
            this.BscTab.Controls.Add(this.OptLblNumPart);
            this.BscTab.Controls.Add(this.OptLblPart);
            this.BscTab.Controls.Add(this.OptLblVeloYVal);
            this.BscTab.Controls.Add(this.OptLblVeloXVal);
            this.BscTab.Controls.Add(this.OptScrBarVeloY);
            this.BscTab.Controls.Add(this.OptScrBarVeloX);
            this.BscTab.Controls.Add(this.OptLblVelo);
            this.BscTab.Controls.Add(this.OptLblVeloY);
            this.BscTab.Controls.Add(this.OptScrBarPosY);
            this.BscTab.Controls.Add(this.OptLblVeloX);
            this.BscTab.Controls.Add(this.OptLblPosYVal);
            this.BscTab.Controls.Add(this.OptLblPosY);
            this.BscTab.Controls.Add(this.OptLblPosXVal);
            this.BscTab.Controls.Add(this.OptLblPosX);
            this.BscTab.Controls.Add(this.OptScrBarPosX);
            this.BscTab.Controls.Add(this.OptLblPos);
            this.BscTab.Location = new System.Drawing.Point(4, 22);
            this.BscTab.Name = "BscTab";
            this.BscTab.Padding = new System.Windows.Forms.Padding(3);
            this.BscTab.Size = new System.Drawing.Size(608, 99);
            this.BscTab.TabIndex = 1;
            this.BscTab.Text = "Option";
            this.BscTab.UseVisualStyleBackColor = true;
            // 
            // SysCbb
            // 
            this.SysCbb.FormattingEnabled = true;
            this.SysCbb.Items.AddRange(new object[] {
            "Firework",
            "Fontain",
            "..."});
            this.SysCbb.Location = new System.Drawing.Point(6, 19);
            this.SysCbb.Name = "SysCbb";
            this.SysCbb.Size = new System.Drawing.Size(121, 21);
            this.SysCbb.TabIndex = 2;
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
            // OptLblPos
            // 
            this.OptLblPos.AutoSize = true;
            this.OptLblPos.Location = new System.Drawing.Point(6, 3);
            this.OptLblPos.Name = "OptLblPos";
            this.OptLblPos.Size = new System.Drawing.Size(44, 13);
            this.OptLblPos.TabIndex = 0;
            this.OptLblPos.Text = "Position";
            // 
            // OptScrBarPosX
            // 
            this.OptScrBarPosX.Location = new System.Drawing.Point(26, 22);
            this.OptScrBarPosX.Name = "OptScrBarPosX";
            this.OptScrBarPosX.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarPosX.TabIndex = 1;
            // 
            // OptLblPosX
            // 
            this.OptLblPosX.AutoSize = true;
            this.OptLblPosX.Location = new System.Drawing.Point(6, 26);
            this.OptLblPosX.Name = "OptLblPosX";
            this.OptLblPosX.Size = new System.Drawing.Size(17, 13);
            this.OptLblPosX.TabIndex = 2;
            this.OptLblPosX.Text = "X:";
            // 
            // OptLblPosXVal
            // 
            this.OptLblPosXVal.AutoSize = true;
            this.OptLblPosXVal.Location = new System.Drawing.Point(109, 26);
            this.OptLblPosXVal.Name = "OptLblPosXVal";
            this.OptLblPosXVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblPosXVal.TabIndex = 3;
            this.OptLblPosXVal.Text = "0";
            // 
            // OptLblPosY
            // 
            this.OptLblPosY.AutoSize = true;
            this.OptLblPosY.Location = new System.Drawing.Point(6, 43);
            this.OptLblPosY.Name = "OptLblPosY";
            this.OptLblPosY.Size = new System.Drawing.Size(17, 13);
            this.OptLblPosY.TabIndex = 4;
            this.OptLblPosY.Text = "Y:";
            // 
            // OptLblPosYVal
            // 
            this.OptLblPosYVal.AutoSize = true;
            this.OptLblPosYVal.Location = new System.Drawing.Point(109, 43);
            this.OptLblPosYVal.Name = "OptLblPosYVal";
            this.OptLblPosYVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblPosYVal.TabIndex = 5;
            this.OptLblPosYVal.Text = "0";
            // 
            // OptLblVeloX
            // 
            this.OptLblVeloX.AutoSize = true;
            this.OptLblVeloX.Location = new System.Drawing.Point(143, 26);
            this.OptLblVeloX.Name = "OptLblVeloX";
            this.OptLblVeloX.Size = new System.Drawing.Size(17, 13);
            this.OptLblVeloX.TabIndex = 6;
            this.OptLblVeloX.Text = "X:";
            // 
            // OptScrBarPosY
            // 
            this.OptScrBarPosY.Location = new System.Drawing.Point(26, 39);
            this.OptScrBarPosY.Name = "OptScrBarPosY";
            this.OptScrBarPosY.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarPosY.TabIndex = 7;
            // 
            // OptLblVeloY
            // 
            this.OptLblVeloY.AutoSize = true;
            this.OptLblVeloY.Location = new System.Drawing.Point(143, 43);
            this.OptLblVeloY.Name = "OptLblVeloY";
            this.OptLblVeloY.Size = new System.Drawing.Size(17, 13);
            this.OptLblVeloY.TabIndex = 8;
            this.OptLblVeloY.Text = "Y:";
            // 
            // OptLblVelo
            // 
            this.OptLblVelo.AutoSize = true;
            this.OptLblVelo.Location = new System.Drawing.Point(143, 3);
            this.OptLblVelo.Name = "OptLblVelo";
            this.OptLblVelo.Size = new System.Drawing.Size(44, 13);
            this.OptLblVelo.TabIndex = 9;
            this.OptLblVelo.Text = "Velocity";
            // 
            // OptScrBarVeloX
            // 
            this.OptScrBarVeloX.Location = new System.Drawing.Point(163, 22);
            this.OptScrBarVeloX.Name = "OptScrBarVeloX";
            this.OptScrBarVeloX.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarVeloX.TabIndex = 10;
            // 
            // OptScrBarVeloY
            // 
            this.OptScrBarVeloY.Location = new System.Drawing.Point(163, 39);
            this.OptScrBarVeloY.Name = "OptScrBarVeloY";
            this.OptScrBarVeloY.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarVeloY.TabIndex = 11;
            // 
            // OptLblVeloXVal
            // 
            this.OptLblVeloXVal.AutoSize = true;
            this.OptLblVeloXVal.Location = new System.Drawing.Point(246, 26);
            this.OptLblVeloXVal.Name = "OptLblVeloXVal";
            this.OptLblVeloXVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblVeloXVal.TabIndex = 12;
            this.OptLblVeloXVal.Text = "0";
            // 
            // OptLblVeloYVal
            // 
            this.OptLblVeloYVal.AutoSize = true;
            this.OptLblVeloYVal.Location = new System.Drawing.Point(246, 43);
            this.OptLblVeloYVal.Name = "OptLblVeloYVal";
            this.OptLblVeloYVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblVeloYVal.TabIndex = 13;
            this.OptLblVeloYVal.Text = "0";
            // 
            // OptLblPart
            // 
            this.OptLblPart.AutoSize = true;
            this.OptLblPart.Location = new System.Drawing.Point(412, 3);
            this.OptLblPart.Name = "OptLblPart";
            this.OptLblPart.Size = new System.Drawing.Size(42, 13);
            this.OptLblPart.TabIndex = 14;
            this.OptLblPart.Text = "Particle";
            // 
            // OptLblNumPart
            // 
            this.OptLblNumPart.AutoSize = true;
            this.OptLblNumPart.Location = new System.Drawing.Point(412, 22);
            this.OptLblNumPart.Name = "OptLblNumPart";
            this.OptLblNumPart.Size = new System.Drawing.Size(50, 13);
            this.OptLblNumPart.TabIndex = 15;
            this.OptLblNumPart.Text = "Particles:";
            // 
            // OptLblLife
            // 
            this.OptLblLife.AutoSize = true;
            this.OptLblLife.Location = new System.Drawing.Point(412, 43);
            this.OptLblLife.Name = "OptLblLife";
            this.OptLblLife.Size = new System.Drawing.Size(27, 13);
            this.OptLblLife.TabIndex = 16;
            this.OptLblLife.Text = "Life:";
            // 
            // OptScrBarNumPart
            // 
            this.OptScrBarNumPart.Location = new System.Drawing.Point(465, 22);
            this.OptScrBarNumPart.Name = "OptScrBarNumPart";
            this.OptScrBarNumPart.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarNumPart.TabIndex = 17;
            // 
            // OptScrBarLife
            // 
            this.OptScrBarLife.Location = new System.Drawing.Point(465, 39);
            this.OptScrBarLife.Name = "OptScrBarLife";
            this.OptScrBarLife.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarLife.TabIndex = 18;
            // 
            // OptLblNumPartVal
            // 
            this.OptLblNumPartVal.AutoSize = true;
            this.OptLblNumPartVal.Location = new System.Drawing.Point(548, 22);
            this.OptLblNumPartVal.Name = "OptLblNumPartVal";
            this.OptLblNumPartVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblNumPartVal.TabIndex = 19;
            this.OptLblNumPartVal.Text = "0";
            // 
            // OptLblLifeVal
            // 
            this.OptLblLifeVal.AutoSize = true;
            this.OptLblLifeVal.Location = new System.Drawing.Point(548, 43);
            this.OptLblLifeVal.Name = "OptLblLifeVal";
            this.OptLblLifeVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblLifeVal.TabIndex = 20;
            this.OptLblLifeVal.Text = "0";
            // 
            // OptLblGrvy
            // 
            this.OptLblGrvy.AutoSize = true;
            this.OptLblGrvy.Location = new System.Drawing.Point(278, 3);
            this.OptLblGrvy.Name = "OptLblGrvy";
            this.OptLblGrvy.Size = new System.Drawing.Size(40, 13);
            this.OptLblGrvy.TabIndex = 21;
            this.OptLblGrvy.Text = "Gravity";
            // 
            // OptLblGrvyX
            // 
            this.OptLblGrvyX.AutoSize = true;
            this.OptLblGrvyX.Location = new System.Drawing.Point(278, 26);
            this.OptLblGrvyX.Name = "OptLblGrvyX";
            this.OptLblGrvyX.Size = new System.Drawing.Size(17, 13);
            this.OptLblGrvyX.TabIndex = 22;
            this.OptLblGrvyX.Text = "X:";
            // 
            // OptLblGrvyY
            // 
            this.OptLblGrvyY.AutoSize = true;
            this.OptLblGrvyY.Location = new System.Drawing.Point(278, 43);
            this.OptLblGrvyY.Name = "OptLblGrvyY";
            this.OptLblGrvyY.Size = new System.Drawing.Size(17, 13);
            this.OptLblGrvyY.TabIndex = 23;
            this.OptLblGrvyY.Text = "Y:";
            // 
            // OptLblGrvyXVal
            // 
            this.OptLblGrvyXVal.AutoSize = true;
            this.OptLblGrvyXVal.Location = new System.Drawing.Point(381, 26);
            this.OptLblGrvyXVal.Name = "OptLblGrvyXVal";
            this.OptLblGrvyXVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblGrvyXVal.TabIndex = 24;
            this.OptLblGrvyXVal.Text = "0";
            // 
            // OptLblGrvyYVal
            // 
            this.OptLblGrvyYVal.AutoSize = true;
            this.OptLblGrvyYVal.Location = new System.Drawing.Point(381, 43);
            this.OptLblGrvyYVal.Name = "OptLblGrvyYVal";
            this.OptLblGrvyYVal.Size = new System.Drawing.Size(13, 13);
            this.OptLblGrvyYVal.TabIndex = 25;
            this.OptLblGrvyYVal.Text = "0";
            // 
            // OptScrBarGrvyX
            // 
            this.OptScrBarGrvyX.Location = new System.Drawing.Point(298, 22);
            this.OptScrBarGrvyX.Name = "OptScrBarGrvyX";
            this.OptScrBarGrvyX.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarGrvyX.TabIndex = 26;
            // 
            // OptScrBarGrvyY
            // 
            this.OptScrBarGrvyY.Location = new System.Drawing.Point(298, 39);
            this.OptScrBarGrvyY.Name = "OptScrBarGrvyY";
            this.OptScrBarGrvyY.Size = new System.Drawing.Size(80, 17);
            this.OptScrBarGrvyY.TabIndex = 27;
            // 
            // ColorTab
            // 
            this.ColorTab.Controls.Add(this.hScrollBar6);
            this.ColorTab.Controls.Add(this.hScrollBar5);
            this.ColorTab.Controls.Add(this.hScrollBar4);
            this.ColorTab.Controls.Add(this.ColLblMaxBVal);
            this.ColorTab.Controls.Add(this.ColLblMaxGVal);
            this.ColorTab.Controls.Add(this.ColLblMaxRVal);
            this.ColorTab.Controls.Add(this.ColLblMaxB);
            this.ColorTab.Controls.Add(this.ColLblMaxG);
            this.ColorTab.Controls.Add(this.ColLblMaxR);
            this.ColorTab.Controls.Add(this.ColLblMax);
            this.ColorTab.Controls.Add(this.hScrollBar1);
            this.ColorTab.Controls.Add(this.hScrollBar2);
            this.ColorTab.Controls.Add(this.hScrollBar3);
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
            this.ColorTab.Size = new System.Drawing.Size(608, 99);
            this.ColorTab.TabIndex = 2;
            this.ColorTab.Text = "Color";
            this.ColorTab.UseVisualStyleBackColor = true;
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
            // ColLblMinR
            // 
            this.ColLblMinR.AutoSize = true;
            this.ColLblMinR.Location = new System.Drawing.Point(6, 31);
            this.ColLblMinR.Name = "ColLblMinR";
            this.ColLblMinR.Size = new System.Drawing.Size(18, 13);
            this.ColLblMinR.TabIndex = 1;
            this.ColLblMinR.Text = "R:";
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
            // ColLblMinB
            // 
            this.ColLblMinB.AutoSize = true;
            this.ColLblMinB.Location = new System.Drawing.Point(6, 74);
            this.ColLblMinB.Name = "ColLblMinB";
            this.ColLblMinB.Size = new System.Drawing.Size(17, 13);
            this.ColLblMinB.TabIndex = 3;
            this.ColLblMinB.Text = "B:";
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
            // ColLblMinRVal
            // 
            this.ColLblMinRVal.AutoSize = true;
            this.ColLblMinRVal.Location = new System.Drawing.Point(110, 31);
            this.ColLblMinRVal.Name = "ColLblMinRVal";
            this.ColLblMinRVal.Size = new System.Drawing.Size(13, 13);
            this.ColLblMinRVal.TabIndex = 5;
            this.ColLblMinRVal.Text = "0";
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
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(27, 27);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar1.TabIndex = 5;
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(27, 49);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar2.TabIndex = 6;
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(26, 70);
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar3.TabIndex = 7;
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
            // ColLblMaxR
            // 
            this.ColLblMaxR.AutoSize = true;
            this.ColLblMaxR.Location = new System.Drawing.Point(151, 31);
            this.ColLblMaxR.Name = "ColLblMaxR";
            this.ColLblMaxR.Size = new System.Drawing.Size(18, 13);
            this.ColLblMaxR.TabIndex = 9;
            this.ColLblMaxR.Text = "R:";
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
            // ColLblMaxB
            // 
            this.ColLblMaxB.AutoSize = true;
            this.ColLblMaxB.Location = new System.Drawing.Point(151, 74);
            this.ColLblMaxB.Name = "ColLblMaxB";
            this.ColLblMaxB.Size = new System.Drawing.Size(17, 13);
            this.ColLblMaxB.TabIndex = 11;
            this.ColLblMaxB.Text = "B:";
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
            // ColLblMaxGVal
            // 
            this.ColLblMaxGVal.AutoSize = true;
            this.ColLblMaxGVal.Location = new System.Drawing.Point(255, 53);
            this.ColLblMaxGVal.Name = "ColLblMaxGVal";
            this.ColLblMaxGVal.Size = new System.Drawing.Size(13, 13);
            this.ColLblMaxGVal.TabIndex = 13;
            this.ColLblMaxGVal.Text = "0";
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
            // hScrollBar4
            // 
            this.hScrollBar4.Location = new System.Drawing.Point(172, 27);
            this.hScrollBar4.Name = "hScrollBar4";
            this.hScrollBar4.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar4.TabIndex = 15;
            // 
            // hScrollBar5
            // 
            this.hScrollBar5.Location = new System.Drawing.Point(172, 49);
            this.hScrollBar5.Name = "hScrollBar5";
            this.hScrollBar5.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar5.TabIndex = 16;
            // 
            // hScrollBar6
            // 
            this.hScrollBar6.Location = new System.Drawing.Point(172, 70);
            this.hScrollBar6.Name = "hScrollBar6";
            this.hScrollBar6.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar6.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 505);
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
            this.BscTab.ResumeLayout(false);
            this.BscTab.PerformLayout();
            this.ColorTab.ResumeLayout(false);
            this.ColorTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FontainButton;
        private System.Windows.Forms.PictureBox DrawBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SysTab;
        private System.Windows.Forms.Label SysLbl;
        private System.Windows.Forms.ComboBox SysCbb;
        private System.Windows.Forms.TabPage BscTab;
        private System.Windows.Forms.Label OptLblVeloYVal;
        private System.Windows.Forms.Label OptLblVeloXVal;
        private System.Windows.Forms.HScrollBar OptScrBarVeloY;
        private System.Windows.Forms.HScrollBar OptScrBarVeloX;
        private System.Windows.Forms.Label OptLblVelo;
        private System.Windows.Forms.Label OptLblVeloY;
        private System.Windows.Forms.HScrollBar OptScrBarPosY;
        private System.Windows.Forms.Label OptLblVeloX;
        private System.Windows.Forms.Label OptLblPosYVal;
        private System.Windows.Forms.Label OptLblPosY;
        private System.Windows.Forms.Label OptLblPosXVal;
        private System.Windows.Forms.Label OptLblPosX;
        private System.Windows.Forms.HScrollBar OptScrBarPosX;
        private System.Windows.Forms.Label OptLblPos;
        private System.Windows.Forms.Label OptLblLifeVal;
        private System.Windows.Forms.Label OptLblNumPartVal;
        private System.Windows.Forms.HScrollBar OptScrBarLife;
        private System.Windows.Forms.HScrollBar OptScrBarNumPart;
        private System.Windows.Forms.Label OptLblLife;
        private System.Windows.Forms.Label OptLblNumPart;
        private System.Windows.Forms.Label OptLblPart;
        private System.Windows.Forms.HScrollBar OptScrBarGrvyY;
        private System.Windows.Forms.HScrollBar OptScrBarGrvyX;
        private System.Windows.Forms.Label OptLblGrvyYVal;
        private System.Windows.Forms.Label OptLblGrvyXVal;
        private System.Windows.Forms.Label OptLblGrvyY;
        private System.Windows.Forms.Label OptLblGrvyX;
        private System.Windows.Forms.Label OptLblGrvy;
        private System.Windows.Forms.TabPage ColorTab;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.Label ColLblMinBVal;
        private System.Windows.Forms.Label ColLblMinRVal;
        private System.Windows.Forms.Label ColLblMinGVal;
        private System.Windows.Forms.Label ColLblMinB;
        private System.Windows.Forms.Label ColLblMinG;
        private System.Windows.Forms.Label ColLblMinR;
        private System.Windows.Forms.Label ColLblMin;
        private System.Windows.Forms.HScrollBar hScrollBar6;
        private System.Windows.Forms.HScrollBar hScrollBar5;
        private System.Windows.Forms.HScrollBar hScrollBar4;
        private System.Windows.Forms.Label ColLblMaxBVal;
        private System.Windows.Forms.Label ColLblMaxGVal;
        private System.Windows.Forms.Label ColLblMaxRVal;
        private System.Windows.Forms.Label ColLblMaxB;
        private System.Windows.Forms.Label ColLblMaxG;
        private System.Windows.Forms.Label ColLblMaxR;
        private System.Windows.Forms.Label ColLblMax;
    }
}

