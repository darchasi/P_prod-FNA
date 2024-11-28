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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.decorRadioButton = new System.Windows.Forms.RadioButton();
            this.objectsRadioButton = new System.Windows.Forms.RadioButton();
            this.wallsRadioButton = new System.Windows.Forms.RadioButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.xPosition = new System.Windows.Forms.NumericUpDown();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.yPosition = new System.Windows.Forms.NumericUpDown();
            this.wLabel = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.hLabel = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.objectTypes = new System.Windows.Forms.ListBox();
            this.imagePathLabel = new System.Windows.Forms.Label();
            this.imagePath = new System.Windows.Forms.TextBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.layerDepthLabel = new System.Windows.Forms.Label();
            this.layerDepth = new System.Windows.Forms.NumericUpDown();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.drawSelected = new System.Windows.Forms.CheckBox();
            this.resetNPC = new System.Windows.Forms.Button();
            this.paused = new System.Windows.Forms.CheckBox();
            this.mapSizeGroup = new System.Windows.Forms.GroupBox();
            this.drawGridCheckBox = new System.Windows.Forms.CheckBox();
            this.mapHeight = new System.Windows.Forms.NumericUpDown();
            this.mapWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.decorSourceHeightLabel = new System.Windows.Forms.Label();
            this.decorSourceHeight = new System.Windows.Forms.NumericUpDown();
            this.decorSourceWidthLabel = new System.Windows.Forms.Label();
            this.decorSourceWidth = new System.Windows.Forms.NumericUpDown();
            this.decorSourceYLabel = new System.Windows.Forms.Label();
            this.decorSourceY = new System.Windows.Forms.NumericUpDown();
            this.decorSourceXLabel = new System.Windows.Forms.Label();
            this.decorSourceX = new System.Windows.Forms.NumericUpDown();
            this.sourceRectangleLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layerDepth)).BeginInit();
            this.gameGroupBox.SuspendLayout();
            this.mapSizeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorSourceHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorSourceWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorSourceY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decorSourceX)).BeginInit();
            this.SuspendLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton decorRadioButton;
        private System.Windows.Forms.RadioButton objectsRadioButton;
        private System.Windows.Forms.RadioButton wallsRadioButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.NumericUpDown xPosition;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.NumericUpDown yPosition;
        private System.Windows.Forms.Label wLabel;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.ListBox objectTypes;
        private System.Windows.Forms.Label imagePathLabel;
        private System.Windows.Forms.TextBox imagePath;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Label layerDepthLabel;
        private System.Windows.Forms.NumericUpDown layerDepth;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gameGroupBox;
        private System.Windows.Forms.Button resetNPC;
        private System.Windows.Forms.GroupBox mapSizeGroup;
        private System.Windows.Forms.CheckBox drawGridCheckBox;
        public System.Windows.Forms.NumericUpDown mapHeight;
        public System.Windows.Forms.NumericUpDown mapWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox paused;
        private System.Windows.Forms.Label decorSourceHeightLabel;
        private System.Windows.Forms.NumericUpDown decorSourceHeight;
        private System.Windows.Forms.Label decorSourceWidthLabel;
        private System.Windows.Forms.NumericUpDown decorSourceWidth;
        private System.Windows.Forms.Label decorSourceYLabel;
        private System.Windows.Forms.NumericUpDown decorSourceY;
        private System.Windows.Forms.Label decorSourceXLabel;
        private System.Windows.Forms.NumericUpDown decorSourceX;
        private System.Windows.Forms.Label sourceRectangleLabel;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.Windows.Forms.CheckBox drawSelected;
    }
}