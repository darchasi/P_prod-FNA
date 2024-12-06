namespace FNA_game_engine
{
    public partial class GameInterface
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
            this.LblHitBoxOffSetValue = new System.Windows.Forms.Label();
            this.TBHitBoxOffSetX = new System.Windows.Forms.TextBox();
            this.LblRotationValue = new System.Windows.Forms.Label();
            this.TBRotationInput = new System.Windows.Forms.TextBox();
            this.LblScaleValue = new System.Windows.Forms.Label();
            this.TBScaleInput = new System.Windows.Forms.TextBox();
            this.LblLayerDepthValue = new System.Windows.Forms.Label();
            this.TBLayerDepthInput = new System.Windows.Forms.TextBox();
            this.LblVisual = new System.Windows.Forms.Label();
            this.LstCharacter = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMaximise = new System.Windows.Forms.Button();
            this.BtnReduce = new System.Windows.Forms.Button();
            this.PicBoxIcon = new System.Windows.Forms.PictureBox();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.LblMediathequeTitle = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PanMaximise = new System.Windows.Forms.Panel();
            this.PanReduce = new System.Windows.Forms.Panel();
            this.PanExit = new System.Windows.Forms.Panel();
            this.LblCharSelect = new System.Windows.Forms.Label();
            this.LblGameObjSelect = new System.Windows.Forms.Label();
            this.LstGameObject = new System.Windows.Forms.ListBox();
            this.TBHitBoxOffSetY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxIcon)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPhysics
            // 
            this.LblPhysics.AutoSize = true;
            this.LblPhysics.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhysics.Location = new System.Drawing.Point(41, 214);
            this.LblPhysics.Name = "LblPhysics";
            this.LblPhysics.Size = new System.Drawing.Size(202, 26);
            this.LblPhysics.TabIndex = 1;
            this.LblPhysics.Text = "Variables Physiques";
            // 
            // BtnSwitchGravity
            // 
            this.BtnSwitchGravity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.BtnSwitchGravity.Location = new System.Drawing.Point(134, 259);
            this.BtnSwitchGravity.Name = "BtnSwitchGravity";
            this.BtnSwitchGravity.Size = new System.Drawing.Size(47, 23);
            this.BtnSwitchGravity.TabIndex = 2;
            this.BtnSwitchGravity.Text = "On";
            this.BtnSwitchGravity.UseVisualStyleBackColor = false;
            this.BtnSwitchGravity.Click += new System.EventHandler(this.BtnSwitchGravity_Click);
            // 
            // TBGravityValueInput
            // 
            this.TBGravityValueInput.Location = new System.Drawing.Point(187, 262);
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
            this.LblGravityValue.Location = new System.Drawing.Point(42, 260);
            this.LblGravityValue.Name = "LblGravityValue";
            this.LblGravityValue.Size = new System.Drawing.Size(53, 19);
            this.LblGravityValue.TabIndex = 4;
            this.LblGravityValue.Text = "Gravity";
            // 
            // LblJumpVelocityValue
            // 
            this.LblJumpVelocityValue.AutoSize = true;
            this.LblJumpVelocityValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJumpVelocityValue.Location = new System.Drawing.Point(42, 311);
            this.LblJumpVelocityValue.Name = "LblJumpVelocityValue";
            this.LblJumpVelocityValue.Size = new System.Drawing.Size(84, 19);
            this.LblJumpVelocityValue.TabIndex = 6;
            this.LblJumpVelocityValue.Text = "Jump power";
            // 
            // TBJumpVelocityInput
            // 
            this.TBJumpVelocityInput.Location = new System.Drawing.Point(187, 310);
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
            this.LblAccelValue.Location = new System.Drawing.Point(42, 354);
            this.LblAccelValue.Name = "LblAccelValue";
            this.LblAccelValue.Size = new System.Drawing.Size(42, 19);
            this.LblAccelValue.TabIndex = 8;
            this.LblAccelValue.Text = "Accel";
            // 
            // TBAccelInput
            // 
            this.TBAccelInput.Location = new System.Drawing.Point(187, 353);
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
            this.LblDecelValue.Location = new System.Drawing.Point(42, 397);
            this.LblDecelValue.Name = "LblDecelValue";
            this.LblDecelValue.Size = new System.Drawing.Size(43, 19);
            this.LblDecelValue.TabIndex = 10;
            this.LblDecelValue.Text = "Decel";
            this.LblDecelValue.Click += new System.EventHandler(this.LblDecelValue_Click);
            // 
            // TBDecelInput
            // 
            this.TBDecelInput.Location = new System.Drawing.Point(187, 396);
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
            // LblHitBoxOffSetValue
            // 
            this.LblHitBoxOffSetValue.AutoSize = true;
            this.LblHitBoxOffSetValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHitBoxOffSetValue.Location = new System.Drawing.Point(298, 397);
            this.LblHitBoxOffSetValue.Name = "LblHitBoxOffSetValue";
            this.LblHitBoxOffSetValue.Size = new System.Drawing.Size(93, 19);
            this.LblHitBoxOffSetValue.TabIndex = 20;
            this.LblHitBoxOffSetValue.Text = "HitBox Offset";
            this.LblHitBoxOffSetValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBHitBoxOffSetX
            // 
            this.TBHitBoxOffSetX.Location = new System.Drawing.Point(443, 396);
            this.TBHitBoxOffSetX.MaxLength = 5;
            this.TBHitBoxOffSetX.Name = "TBHitBoxOffSetX";
            this.TBHitBoxOffSetX.Size = new System.Drawing.Size(32, 20);
            this.TBHitBoxOffSetX.TabIndex = 19;
            this.TBHitBoxOffSetX.Text = "0";
            this.TBHitBoxOffSetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBHitBoxOffSetX.TextChanged += new System.EventHandler(this.TBHitBoxOffSetX_TextChanged);
            this.TBHitBoxOffSetX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBHitBoxOffSetX_KeyPress);
            this.TBHitBoxOffSetX.LostFocus += new System.EventHandler(this.TBHitBoxOffSetX_Leave);
            // 
            // LblRotationValue
            // 
            this.LblRotationValue.AutoSize = true;
            this.LblRotationValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRotationValue.Location = new System.Drawing.Point(298, 354);
            this.LblRotationValue.Name = "LblRotationValue";
            this.LblRotationValue.Size = new System.Drawing.Size(61, 19);
            this.LblRotationValue.TabIndex = 18;
            this.LblRotationValue.Text = "Rotation";
            this.LblRotationValue.Click += new System.EventHandler(this.LblRotationValue_Click);
            // 
            // TBRotationInput
            // 
            this.TBRotationInput.Location = new System.Drawing.Point(443, 353);
            this.TBRotationInput.MaxLength = 5;
            this.TBRotationInput.Name = "TBRotationInput";
            this.TBRotationInput.Size = new System.Drawing.Size(32, 20);
            this.TBRotationInput.TabIndex = 17;
            this.TBRotationInput.Text = "1";
            this.TBRotationInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBRotationInput.TextChanged += new System.EventHandler(this.TBRotationInput_TextChanged);
            this.TBRotationInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBRotationInput_KeyPress);
            this.TBRotationInput.LostFocus += new System.EventHandler(this.TBRotationInput_Leave);
            // 
            // LblScaleValue
            // 
            this.LblScaleValue.AutoSize = true;
            this.LblScaleValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScaleValue.Location = new System.Drawing.Point(298, 311);
            this.LblScaleValue.Name = "LblScaleValue";
            this.LblScaleValue.Size = new System.Drawing.Size(41, 19);
            this.LblScaleValue.TabIndex = 16;
            this.LblScaleValue.Text = "Scale";
            this.LblScaleValue.Click += new System.EventHandler(this.LblScaleValue_Click);
            // 
            // TBScaleInput
            // 
            this.TBScaleInput.Location = new System.Drawing.Point(443, 310);
            this.TBScaleInput.MaxLength = 5;
            this.TBScaleInput.Name = "TBScaleInput";
            this.TBScaleInput.Size = new System.Drawing.Size(32, 20);
            this.TBScaleInput.TabIndex = 15;
            this.TBScaleInput.Text = "1";
            this.TBScaleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBScaleInput.TextChanged += new System.EventHandler(this.TBScaleInput_TextChanged);
            this.TBScaleInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBScaleInput_KeyPress);
            this.TBScaleInput.LostFocus += new System.EventHandler(this.TBScaleInput_Leave);
            // 
            // LblLayerDepthValue
            // 
            this.LblLayerDepthValue.AutoSize = true;
            this.LblLayerDepthValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLayerDepthValue.Location = new System.Drawing.Point(298, 260);
            this.LblLayerDepthValue.Name = "LblLayerDepthValue";
            this.LblLayerDepthValue.Size = new System.Drawing.Size(84, 19);
            this.LblLayerDepthValue.TabIndex = 14;
            this.LblLayerDepthValue.Text = "Layer Depth";
            this.LblLayerDepthValue.Click += new System.EventHandler(this.LblLayerDepthValue_Click);
            // 
            // TBLayerDepthInput
            // 
            this.TBLayerDepthInput.Location = new System.Drawing.Point(443, 262);
            this.TBLayerDepthInput.MaxLength = 5;
            this.TBLayerDepthInput.Name = "TBLayerDepthInput";
            this.TBLayerDepthInput.Size = new System.Drawing.Size(32, 20);
            this.TBLayerDepthInput.TabIndex = 13;
            this.TBLayerDepthInput.Text = "1";
            this.TBLayerDepthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBLayerDepthInput.TextChanged += new System.EventHandler(this.TBLayerDepthInput_TextChanged);
            this.TBLayerDepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBLayerDepthInput_KeyPress);
            this.TBLayerDepthInput.LostFocus += new System.EventHandler(this.TBLayerDepthInput_Leave);
            // 
            // LblVisual
            // 
            this.LblVisual.AutoSize = true;
            this.LblVisual.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVisual.Location = new System.Drawing.Point(297, 214);
            this.LblVisual.Name = "LblVisual";
            this.LblVisual.Size = new System.Drawing.Size(174, 26);
            this.LblVisual.TabIndex = 11;
            this.LblVisual.Text = "Variables Visuels";
            this.LblVisual.Click += new System.EventHandler(this.LblVisual_Click);
            // 
            // LstCharacter
            // 
            this.LstCharacter.DisplayMember = "name";
            this.LstCharacter.FormattingEnabled = true;
            this.LstCharacter.Location = new System.Drawing.Point(37, 91);
            this.LstCharacter.Name = "LstCharacter";
            this.LstCharacter.Size = new System.Drawing.Size(206, 95);
            this.LstCharacter.TabIndex = 21;
            this.LstCharacter.SelectedIndexChanged += new System.EventHandler(this.LstCharacter_SelectedIndexChanged);
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
            this.PanMaximise.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanMaximise.Location = new System.Drawing.Point(829, 0);
            this.PanMaximise.Name = "PanMaximise";
            this.PanMaximise.Size = new System.Drawing.Size(65, 52);
            this.PanMaximise.TabIndex = 2;
            this.PanMaximise.Paint += new System.Windows.Forms.PaintEventHandler(this.PanMaximise_Paint);
            // 
            // PanReduce
            // 
            this.PanReduce.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanReduce.Location = new System.Drawing.Point(894, 0);
            this.PanReduce.Name = "PanReduce";
            this.PanReduce.Size = new System.Drawing.Size(65, 52);
            this.PanReduce.TabIndex = 1;
            // 
            // PanExit
            // 
            this.PanExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanExit.Location = new System.Drawing.Point(959, 0);
            this.PanExit.Name = "PanExit";
            this.PanExit.Size = new System.Drawing.Size(65, 52);
            this.PanExit.TabIndex = 1;
            // 
            // LblCharSelect
            // 
            this.LblCharSelect.AutoSize = true;
            this.LblCharSelect.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCharSelect.Location = new System.Drawing.Point(41, 62);
            this.LblCharSelect.Name = "LblCharSelect";
            this.LblCharSelect.Size = new System.Drawing.Size(167, 26);
            this.LblCharSelect.TabIndex = 22;
            this.LblCharSelect.Text = "Select Character";
            // 
            // LblGameObjSelect
            // 
            this.LblGameObjSelect.AutoSize = true;
            this.LblGameObjSelect.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGameObjSelect.Location = new System.Drawing.Point(297, 62);
            this.LblGameObjSelect.Name = "LblGameObjSelect";
            this.LblGameObjSelect.Size = new System.Drawing.Size(201, 26);
            this.LblGameObjSelect.TabIndex = 24;
            this.LblGameObjSelect.Text = "Select Game Object";
            // 
            // LstGameObject
            // 
            this.LstGameObject.DisplayMember = "name";
            this.LstGameObject.FormattingEnabled = true;
            this.LstGameObject.Location = new System.Drawing.Point(293, 91);
            this.LstGameObject.Name = "LstGameObject";
            this.LstGameObject.Size = new System.Drawing.Size(206, 95);
            this.LstGameObject.TabIndex = 23;
            this.LstGameObject.SelectedIndexChanged += new System.EventHandler(this.LstGameObject_SelectedIndexChanged);
            // 
            // TBHitBoxOffSetY
            // 
            this.TBHitBoxOffSetY.Location = new System.Drawing.Point(397, 397);
            this.TBHitBoxOffSetY.MaxLength = 5;
            this.TBHitBoxOffSetY.Name = "TBHitBoxOffSetY";
            this.TBHitBoxOffSetY.Size = new System.Drawing.Size(32, 20);
            this.TBHitBoxOffSetY.TabIndex = 25;
            this.TBHitBoxOffSetY.Text = "0";
            this.TBHitBoxOffSetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBHitBoxOffSetY.TextChanged += new System.EventHandler(this.TBHitBoxOffSetY_TextChanged);
            this.TBHitBoxOffSetY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBHitBoxOffSetY_KeyPress);
            this.TBHitBoxOffSetY.LostFocus += new System.EventHandler(this.TBHitBoxOffSetY_Leave);
            // 
            // GameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.TBHitBoxOffSetY);
            this.Controls.Add(this.LblGameObjSelect);
            this.Controls.Add(this.LstGameObject);
            this.Controls.Add(this.LblCharSelect);
            this.Controls.Add(this.LstCharacter);
            this.Controls.Add(this.LblHitBoxOffSetValue);
            this.Controls.Add(this.TBHitBoxOffSetX);
            this.Controls.Add(this.LblRotationValue);
            this.Controls.Add(this.TBRotationInput);
            this.Controls.Add(this.LblScaleValue);
            this.Controls.Add(this.TBScaleInput);
            this.Controls.Add(this.LblLayerDepthValue);
            this.Controls.Add(this.TBLayerDepthInput);
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
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxIcon)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnReduce;
        private System.Windows.Forms.Button BtnMaximise;
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
        private System.Windows.Forms.Label LblHitBoxOffSetValue;
        private System.Windows.Forms.TextBox TBHitBoxOffSetX;
        private System.Windows.Forms.Label LblRotationValue;
        private System.Windows.Forms.TextBox TBRotationInput;
        private System.Windows.Forms.Label LblScaleValue;
        private System.Windows.Forms.TextBox TBScaleInput;
        private System.Windows.Forms.Label LblLayerDepthValue;
        private System.Windows.Forms.TextBox TBLayerDepthInput;
        private System.Windows.Forms.Label LblVisual;
        private System.Windows.Forms.ListBox LstCharacter;
        private System.Windows.Forms.PictureBox PicBoxIcon;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label LblMediathequeTitle;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel PanMaximise;
        private System.Windows.Forms.Panel PanReduce;
        private System.Windows.Forms.Panel PanExit;
        private System.Windows.Forms.Label LblCharSelect;
        private System.Windows.Forms.Label LblGameObjSelect;
        private System.Windows.Forms.ListBox LstGameObject;
        private System.Windows.Forms.TextBox TBHitBoxOffSetY;
    }
}