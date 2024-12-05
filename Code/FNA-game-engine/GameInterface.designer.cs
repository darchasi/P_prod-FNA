namespace FNA_game_engine
{
    partial class GameInterface
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PanMaximise = new System.Windows.Forms.Panel();
            this.PanReduce = new System.Windows.Forms.Panel();
            this.PanExit = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.LblMediathequeTitle = new System.Windows.Forms.Label();
            this.PicBoxIcon = new System.Windows.Forms.PictureBox();
            this.LblPhysics = new System.Windows.Forms.Label();
            this.BtnSwitchGravity = new System.Windows.Forms.Button();
            this.TBGravityValueInput = new System.Windows.Forms.TextBox();
            this.LblGravityValue = new System.Windows.Forms.Label();
            this.LblJumpVelocityValue = new System.Windows.Forms.Label();
            this.TBJumpVelocityInput = new System.Windows.Forms.TextBox();
            this.LblAccelValue = new System.Windows.Forms.Label();
            this.TBAccelInput = new System.Windows.Forms.TextBox();
            this.LblDecelValue = new System.Windows.Forms.Label();
            this.TBDecelInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LblVisual = new System.Windows.Forms.Label();
            this.LstCharacter = new System.Windows.Forms.ListBox();
            this.BtnMaximise = new FNA_game_engine.RoundButton();
            this.BtnReduce = new FNA_game_engine.RoundButton();
            this.BtnExit = new FNA_game_engine.RoundButton();
            this.TopPanel.SuspendLayout();
            this.PanMaximise.SuspendLayout();
            this.PanReduce.SuspendLayout();
            this.PanExit.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.AccessibleName = "TopPanel";
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.TopPanel.Controls.Add(this.PanMaximise);
            this.TopPanel.Controls.Add(this.PanReduce);
            this.TopPanel.Controls.Add(this.PanExit);
            this.TopPanel.Controls.Add(this.TitlePanel);
            this.TopPanel.Controls.Add(this.PicBoxIcon);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1024, 52);
            this.TopPanel.TabIndex = 0;
            // 
            // PanMaximise
            // 
            this.PanMaximise.Controls.Add(this.BtnMaximise);
            this.PanMaximise.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanMaximise.Location = new System.Drawing.Point(829, 0);
            this.PanMaximise.Name = "PanMaximise";
            this.PanMaximise.Size = new System.Drawing.Size(65, 52);
            this.PanMaximise.TabIndex = 2;
            // 
            // PanReduce
            // 
            this.PanReduce.Controls.Add(this.BtnReduce);
            this.PanReduce.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanReduce.Location = new System.Drawing.Point(894, 0);
            this.PanReduce.Name = "PanReduce";
            this.PanReduce.Size = new System.Drawing.Size(65, 52);
            this.PanReduce.TabIndex = 1;
            // 
            // PanExit
            // 
            this.PanExit.Controls.Add(this.BtnExit);
            this.PanExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanExit.Location = new System.Drawing.Point(959, 0);
            this.PanExit.Name = "PanExit";
            this.PanExit.Size = new System.Drawing.Size(65, 52);
            this.PanExit.TabIndex = 1;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.LblMediathequeTitle);
            this.TitlePanel.Location = new System.Drawing.Point(339, 7);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(373, 42);
            this.TitlePanel.TabIndex = 20;
            this.TitlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TitlePanel_Paint);
            // 
            // LblMediathequeTitle
            // 
            this.LblMediathequeTitle.AutoSize = true;
            this.LblMediathequeTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblMediathequeTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMediathequeTitle.Location = new System.Drawing.Point(0, -2);
            this.LblMediathequeTitle.Name = "LblMediathequeTitle";
            this.LblMediathequeTitle.Size = new System.Drawing.Size(347, 44);
            this.LblMediathequeTitle.TabIndex = 19;
            this.LblMediathequeTitle.Text = "Editeur de variables";
            this.LblMediathequeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PicBoxIcon
            // 
            this.PicBoxIcon.Image = global::FNA_game_engine.Properties.Resources.InnoWeeksMusiqueIcon;
            this.PicBoxIcon.Location = new System.Drawing.Point(3, 3);
            this.PicBoxIcon.Name = "PicBoxIcon";
            this.PicBoxIcon.Size = new System.Drawing.Size(45, 45);
            this.PicBoxIcon.TabIndex = 18;
            this.PicBoxIcon.TabStop = false;
            this.PicBoxIcon.Click += new System.EventHandler(this.PicBoxIcon_Click);
            // 
            // LblPhysics
            // 
            this.LblPhysics.AutoSize = true;
            this.LblPhysics.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhysics.Location = new System.Drawing.Point(41, 91);
            this.LblPhysics.Name = "LblPhysics";
            this.LblPhysics.Size = new System.Drawing.Size(202, 26);
            this.LblPhysics.TabIndex = 1;
            this.LblPhysics.Text = "Variables Physiques";
            // 
            // BtnSwitchGravity
            // 
            this.BtnSwitchGravity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.BtnSwitchGravity.Location = new System.Drawing.Point(134, 136);
            this.BtnSwitchGravity.Name = "BtnSwitchGravity";
            this.BtnSwitchGravity.Size = new System.Drawing.Size(47, 23);
            this.BtnSwitchGravity.TabIndex = 2;
            this.BtnSwitchGravity.Text = "On";
            this.BtnSwitchGravity.UseVisualStyleBackColor = false;
            this.BtnSwitchGravity.Click += new System.EventHandler(this.BtnSwitchGravity_Click);
            // 
            // TBGravityValueInput
            // 
            this.TBGravityValueInput.Location = new System.Drawing.Point(187, 139);
            this.TBGravityValueInput.MaxLength = 5;
            this.TBGravityValueInput.Name = "TBGravityValueInput";
            this.TBGravityValueInput.Size = new System.Drawing.Size(32, 20);
            this.TBGravityValueInput.TabIndex = 3;
            this.TBGravityValueInput.Text = "1";
            this.TBGravityValueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBGravityValueInput.TextChanged += new System.EventHandler(this.TBGravityValueInput_TextChanged);
            this.TBGravityValueInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBGravityValueInput_KeyPress);
            this.TBGravityValueInput.LostFocus += new System.EventHandler(this.TBGravityValueInput_Leave);
            // 
            // LblGravityValue
            // 
            this.LblGravityValue.AutoSize = true;
            this.LblGravityValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGravityValue.Location = new System.Drawing.Point(42, 137);
            this.LblGravityValue.Name = "LblGravityValue";
            this.LblGravityValue.Size = new System.Drawing.Size(53, 19);
            this.LblGravityValue.TabIndex = 4;
            this.LblGravityValue.Text = "Gravity";
            // 
            // LblJumpVelocityValue
            // 
            this.LblJumpVelocityValue.AutoSize = true;
            this.LblJumpVelocityValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJumpVelocityValue.Location = new System.Drawing.Point(42, 188);
            this.LblJumpVelocityValue.Name = "LblJumpVelocityValue";
            this.LblJumpVelocityValue.Size = new System.Drawing.Size(84, 19);
            this.LblJumpVelocityValue.TabIndex = 6;
            this.LblJumpVelocityValue.Text = "Jump power";
            // 
            // TBJumpVelocityInput
            // 
            this.TBJumpVelocityInput.Location = new System.Drawing.Point(187, 187);
            this.TBJumpVelocityInput.MaxLength = 5;
            this.TBJumpVelocityInput.Name = "TBJumpVelocityInput";
            this.TBJumpVelocityInput.Size = new System.Drawing.Size(32, 20);
            this.TBJumpVelocityInput.TabIndex = 5;
            this.TBJumpVelocityInput.Text = "22";
            this.TBJumpVelocityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBJumpVelocityInput.TextChanged += new System.EventHandler(this.TBJumpVelocityInput_TextChanged);
            this.TBJumpVelocityInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBJumpVelocityInput_KeyPress);
            this.TBJumpVelocityInput.LostFocus += new System.EventHandler(this.TBJumpVelocityInput_Leave);
            // 
            // LblAccelValue
            // 
            this.LblAccelValue.AutoSize = true;
            this.LblAccelValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccelValue.Location = new System.Drawing.Point(42, 231);
            this.LblAccelValue.Name = "LblAccelValue";
            this.LblAccelValue.Size = new System.Drawing.Size(42, 19);
            this.LblAccelValue.TabIndex = 8;
            this.LblAccelValue.Text = "Accel";
            // 
            // TBAccelInput
            // 
            this.TBAccelInput.Location = new System.Drawing.Point(187, 230);
            this.TBAccelInput.MaxLength = 5;
            this.TBAccelInput.Name = "TBAccelInput";
            this.TBAccelInput.Size = new System.Drawing.Size(32, 20);
            this.TBAccelInput.TabIndex = 7;
            this.TBAccelInput.Text = "1";
            this.TBAccelInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBAccelInput.TextChanged += new System.EventHandler(this.TBAccelInput_TextChanged);
            this.TBAccelInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAccelInput_KeyPress);
            this.TBAccelInput.LostFocus += new System.EventHandler(this.TBAccelInput_Leave);
            // 
            // LblDecelValue
            // 
            this.LblDecelValue.AutoSize = true;
            this.LblDecelValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDecelValue.Location = new System.Drawing.Point(42, 274);
            this.LblDecelValue.Name = "LblDecelValue";
            this.LblDecelValue.Size = new System.Drawing.Size(43, 19);
            this.LblDecelValue.TabIndex = 10;
            this.LblDecelValue.Text = "Decel";
            this.LblDecelValue.Click += new System.EventHandler(this.LblDecelValue_Click);
            // 
            // TBDecelInput
            // 
            this.TBDecelInput.Location = new System.Drawing.Point(187, 273);
            this.TBDecelInput.MaxLength = 5;
            this.TBDecelInput.Name = "TBDecelInput";
            this.TBDecelInput.Size = new System.Drawing.Size(32, 20);
            this.TBDecelInput.TabIndex = 9;
            this.TBDecelInput.Text = "0.5";
            this.TBDecelInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBDecelInput.TextChanged += new System.EventHandler(this.TBDecelInput_TextChanged);
            this.TBDecelInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDecelInput_KeyPress);
            this.TBDecelInput.LostFocus += new System.EventHandler(this.TBDecelInput_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Decel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(442, 273);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "0.5";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Accel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(442, 230);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Jump power";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(442, 187);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "22";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gravity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(442, 139);
            this.textBox4.MaxLength = 5;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "1";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.button1.Location = new System.Drawing.Point(389, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "On";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblVisual
            // 
            this.LblVisual.AutoSize = true;
            this.LblVisual.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVisual.Location = new System.Drawing.Point(296, 91);
            this.LblVisual.Name = "LblVisual";
            this.LblVisual.Size = new System.Drawing.Size(202, 26);
            this.LblVisual.TabIndex = 11;
            this.LblVisual.Text = "Variables Physiques";
            this.LblVisual.Click += new System.EventHandler(this.LblVisual_Click);
            // 
            // LstCharacter
            // 
            this.LstCharacter.FormattingEnabled = true;
            this.LstCharacter.Location = new System.Drawing.Point(46, 330);
            this.LstCharacter.Name = "LstCharacter";
            this.LstCharacter.Size = new System.Drawing.Size(182, 95);
            this.LstCharacter.TabIndex = 21;
            this.LstCharacter.SelectedIndexChanged += new System.EventHandler(this.LstCharacter_SelectedIndexChanged);
            // 
            // BtnMaximise
            // 
            this.BtnMaximise.BackColor = System.Drawing.Color.Transparent;
            this.BtnMaximise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMaximise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMaximise.FlatAppearance.BorderSize = 0;
            this.BtnMaximise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMaximise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximise.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Bold);
            this.BtnMaximise.Image = global::FNA_game_engine.Properties.Resources.MinimizeFinalBlue;
            this.BtnMaximise.Location = new System.Drawing.Point(0, 0);
            this.BtnMaximise.Name = "BtnMaximise";
            this.BtnMaximise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMaximise.Size = new System.Drawing.Size(65, 52);
            this.BtnMaximise.TabIndex = 21;
            this.BtnMaximise.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnMaximise.UseVisualStyleBackColor = false;
            this.BtnMaximise.Click += new System.EventHandler(this.BtnMaximise_Click);
            // 
            // BtnReduce
            // 
            this.BtnReduce.BackColor = System.Drawing.Color.Transparent;
            this.BtnReduce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReduce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReduce.FlatAppearance.BorderSize = 0;
            this.BtnReduce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReduce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnReduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReduce.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Bold);
            this.BtnReduce.Image = global::FNA_game_engine.Properties.Resources.MinimizeFinalBlue;
            this.BtnReduce.Location = new System.Drawing.Point(0, 0);
            this.BtnReduce.Name = "BtnReduce";
            this.BtnReduce.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnReduce.Size = new System.Drawing.Size(65, 52);
            this.BtnReduce.TabIndex = 17;
            this.BtnReduce.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnReduce.UseVisualStyleBackColor = false;
            this.BtnReduce.Click += new System.EventHandler(this.BtnReduce_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.AutoEllipsis = true;
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Sitka Heading", 15F, System.Drawing.FontStyle.Bold);
            this.BtnExit.Image = global::FNA_game_engine.Properties.Resources.CloseFinalBlue;
            this.BtnExit.Location = new System.Drawing.Point(0, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnExit.Size = new System.Drawing.Size(65, 52);
            this.BtnExit.TabIndex = 16;
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.LstCharacter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblVisual);
            this.Controls.Add(this.LblDecelValue);
            this.Controls.Add(this.TBDecelInput);
            this.Controls.Add(this.LblAccelValue);
            this.Controls.Add(this.TBAccelInput);
            this.Controls.Add(this.LblJumpVelocityValue);
            this.Controls.Add(this.TBJumpVelocityInput);
            this.Controls.Add(this.LblGravityValue);
            this.Controls.Add(this.TBGravityValueInput);
            this.Controls.Add(this.BtnSwitchGravity);
            this.Controls.Add(this.LblPhysics);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variable Editor";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.TopPanel.ResumeLayout(false);
            this.PanMaximise.ResumeLayout(false);
            this.PanReduce.ResumeLayout(false);
            this.PanExit.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private RoundButton BtnExit;
        private RoundButton BtnReduce;
        private System.Windows.Forms.PictureBox PicBoxIcon;
        private System.Windows.Forms.Label LblMediathequeTitle;
        private System.Windows.Forms.Panel TitlePanel;
        private RoundButton BtnMaximise;
        private System.Windows.Forms.Panel PanMaximise;
        private System.Windows.Forms.Panel PanReduce;
        private System.Windows.Forms.Panel PanExit;
        private System.Windows.Forms.Label LblPhysics;
        private System.Windows.Forms.Button BtnSwitchGravity;
        private System.Windows.Forms.TextBox TBGravityValueInput;
        private System.Windows.Forms.Label LblGravityValue;
        private System.Windows.Forms.Label LblJumpVelocityValue;
        private System.Windows.Forms.TextBox TBJumpVelocityInput;
        private System.Windows.Forms.Label LblAccelValue;
        private System.Windows.Forms.TextBox TBAccelInput;
        private System.Windows.Forms.Label LblDecelValue;
        private System.Windows.Forms.TextBox TBDecelInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblVisual;
        private System.Windows.Forms.ListBox LstCharacter;
    }
}