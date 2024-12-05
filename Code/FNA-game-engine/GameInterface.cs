using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SDL2;
using Color = Microsoft.Xna.Framework.Color;

namespace FNA_game_engine
{
    //TO ADD NEW GAME OBJECTS TO THE EDITOR FOLLOW THESE INSTRUCTIONS:
    //1. Add the name of the object to the enum ObjectType (make sure it's spelled exactly the same). Make sure you add it BEFORE NumOfObjects.
    //2. Make sure objectsNamespace is correctly set. This should be the namespace that all your classes are under. Go to Player.cs and copy the namespace that's there, it's likely the one you need.

    public partial class GameInterface : Form
    {
        public Game1 game;
        public Character selectedChar;


        string fullPath = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
        private bool isDragging;
        private System.Drawing.Point dragStartPoint;
        public GameInterface(Game1 gameInput)
        {
            game = gameInput;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            game.objects.Where(obj => obj is Character).ToList().ForEach(character => LstCharacter.Items.Add(character));
            TopPanel.MouseDown += PanelTitleBar_MouseDown;
            TopPanel.MouseMove += PanelTitleBar_MouseMove;
            TopPanel.MouseUp += PanelTitleBar_MouseUp;
        }


        private void GameInterface_Load(object sender, EventArgs e)
        {

        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPoint = e.Location;
        }

        private void PanelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                System.Drawing.Point currentPoint = PointToScreen(e.Location);
                this.Location = new System.Drawing.Point(currentPoint.X - dragStartPoint.X, currentPoint.Y - dragStartPoint.Y);
            }
        }
        private void PanelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            /*
            if (MessageBox.Show("êtes-vous sûr de vouloir fermer le programme ?", "fermer le programme", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                 Application.Exit();
            }*/
            Application.Exit();
        }

        private void BtnReduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PicBoxIcon_Click(object sender, EventArgs e)
        {

        }

        private void TitlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnMaximise_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
                WindowState = FormWindowState.Maximized;
        }

        private void TBGravityValueInput_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void TBGravityValueInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBGravityValueInput_Leave(object sender, EventArgs e)
        {
            if (TBGravityValueInput.Text.Last() != '.' && TBGravityValueInput.Text.Last() != '-')
            {
                selectedChar = (Player)game.objects[0];
                selectedChar.gravity = (float)Convert.ToDecimal(TBGravityValueInput.Text);
                selectedChar.maxFallVelocity = 24f + 8f * selectedChar.gravity;
            }
        }

        private void BtnSwitchGravity_Click(object sender, EventArgs e)
        {
            if (Character.applyGravity)
            {
                Character.applyGravity = false;
                BtnSwitchGravity.Text = "Off";
            }
            else
            {
                Character.applyGravity = true;
                BtnSwitchGravity.Text = "On";
            }
        }

        private void TBJumpVelocityInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void TBJumpVelocityInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBJumpVelocityInput_Leave(object sender, EventArgs e)
        {
            if (TBJumpVelocityInput.Text.Last() != '.' && TBJumpVelocityInput.Text.Last() != '-')
            {
                selectedChar.jumpVelocity = (float)Convert.ToDecimal(TBJumpVelocityInput.Text);
            }
        }

        private void TBAccelInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBAccelInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBAccelInput_Leave(object sender, EventArgs e)
        {
            if (TBAccelInput.Text.Last() != '.' && TBAccelInput.Text.Last() != '-')
            {
                selectedChar.accel = (float)Convert.ToDecimal(TBAccelInput.Text);
            }
        }

        private void LblDecelValue_Click(object sender, EventArgs e)
        {

        }

        private void TBDecelInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only allow one minus
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void TBDecelInput_Leave(object sender, EventArgs e)
        {
            if (TBDecelInput.Text.Last() != '.' && TBDecelInput.Text.Last() != '-')
            {
                selectedChar.decel = (float)Convert.ToDecimal(TBDecelInput.Text);
            }
        }

        private void TBDecelInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblVisual_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LstCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedChar = (Character)LstCharacter.SelectedItem;
        }
    }

    // RoundButton class because Windows Forms does not have one by default
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
