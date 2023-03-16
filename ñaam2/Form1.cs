using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ñaam2
{
    public partial class Form1 : MaterialForm
    {
        int y;
        int x;
        bool muro1 = false;
        bool muro2 = true;
        int ciclo;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lblEnemy.Text = "XD";
          
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            TmrTimer1.Enabled = false;
        }

        private void tmrFranchesco_Tick(object sender, EventArgs e)
        {

            x = pbxEnemy.Location.X;
            y = pbxEnemy.Location.Y;

            if (muro1 == false)
            {
                pbxEnemy.Location = new Point(x + 16, y);
                if (pbxEnemy.Location.X >= lblWallRigth.Location.X)
                {
                    muro1 = true;
                    muro2 = false;
                    ciclo += 1;

                }

            }

            if (muro1 == true)
            {
                pbxEnemy.Location = new Point(x - 16, y);

                if (pbxEnemy.Location.X <= lblWallLeft.Location.X)
                {
                    muro1 = false;
                    muro2 = true;
                    ciclo += 1;


                }
                if (ciclo % 2 == 0) { pbxEnemy.Location = new Point(x, y + 16); }
                if(ciclo %3 == 0) { x += 3; }

            }

            if (pbxEnemy.Location.Y > pbxHero.Location.Y)
            {
                MaterialMessageBox.Show("Perdiste");
                this.Close();

            }


            /*
            x = lblEnemy.Location.X;
            y = lblEnemy.Location.Y;

            if (muro1 == false)
            {
                lblEnemy.Location = new Point(x + 16, y);
                if (lblEnemy.Location.X >= lblWallRigth.Location.X)
                {
                    muro1 = true;
                    muro2 = false;
                    ciclo += 1;

                }

            }

            if (muro1 == true)
            {
                lblEnemy.Location = new Point(x - 16, y);

                if (lblEnemy.Location.X <= lblWallLeft.Location.X)
                {
                    muro1 = false;
                    muro2 = true;
                    ciclo += 1;


                }
                if (ciclo % 2 == 0) { lblEnemy.Location = new Point(x, y + 16); }

            }

            if(lblEnemy.Location.Y == pbxHero.Location.Y)
            {
                MaterialMessageBox.Show("Manco Hijueputa");
                this.Close();

            }
            */
        }


        private void btnGo_Click_1(object sender, EventArgs e)
        {
            TmrTimer1.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            TmrTimer1.Enabled = true;
        }


        private void btnStop_Click_1(object sender, EventArgs e)
        {
            TmrTimer1.Enabled = false;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int step = 10;
            switch (e.KeyCode)
            {
                case Keys.A:
                    pbxHero.Left -= step;
                    break;
                case Keys.D:
                    pbxHero.Left += step;
                    break;
                case Keys.W:
                    pbxHero.Top -= step;
                    break;
                case Keys.S:
                    pbxHero.Top += step;
                    break;
                case Keys.F:


                    break;
            }
        }

        private void lblEnemy_Click(object sender, EventArgs e)
        {

        }
    }
}
