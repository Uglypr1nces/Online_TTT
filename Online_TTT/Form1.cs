using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_TTT
{
    public partial class Form1 : Form
    {
        //variables:
        int counter = 1;
        string x = Path.Combine(Application.StartupPath, "x.png");
        string o = Path.Combine(Application.StartupPath, "o.png");
        string nothing = Path.Combine(Application.StartupPath, "nothing.png");
        
        public Form1()
        {
            InitializeComponent();
            gamereset();
        }

        public void gamereset()
        {
            List<PictureBox> list = new List<PictureBox>() {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8,pictureBox9};
            foreach (PictureBox pictureBox in list)
            {
                pictureBox.Load(nothing);
                pictureBox.Tag = "";
            }
            
        }
        private bool fullboard()
        {
            List<PictureBox> list = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
            int pictures = 0;
            foreach (PictureBox pictureBox in list)
            {
                if (pictureBox.Tag != "")
                {
                    pictures++;
                }
            }
            if (pictures == 9)
            {
                return true;
            }
            return false;
        }
        private void checker()
        {

            if ((pictureBox1.Tag == x && pictureBox2.Tag == x && pictureBox3.Tag == x) ||
                (pictureBox4.Tag == x && pictureBox5.Tag == x && pictureBox6.Tag == x) ||
                (pictureBox7.Tag == x && pictureBox8.Tag == x && pictureBox9.Tag == x))
            {
                MessageBox.Show("Player one won");
                gamereset();
            }
            else if ((pictureBox1.Tag == o && pictureBox2.Tag == o && pictureBox3.Tag == o) ||
                     (pictureBox4.Tag == o && pictureBox5.Tag == o && pictureBox6.Tag == o) ||
                     (pictureBox7.Tag == o && pictureBox8.Tag == o && pictureBox9.Tag == o))
            {
                MessageBox.Show("Player two won");
                gamereset();
            }
            else if ((pictureBox1.Tag == x && pictureBox4.Tag == x && pictureBox7.Tag == x) ||
                     (pictureBox2.Tag == x && pictureBox5.Tag == x && pictureBox8.Tag == x) ||
                     (pictureBox3.Tag == x && pictureBox6.Tag == x && pictureBox9.Tag == x))
            {
                MessageBox.Show("Player one won");
                gamereset();
            }
            else if ((pictureBox1.Tag == o && pictureBox4.Tag == o && pictureBox7.Tag == o) ||
                     (pictureBox2.Tag == o && pictureBox5.Tag == o && pictureBox8.Tag == o) ||
                     (pictureBox3.Tag == o && pictureBox6.Tag == o && pictureBox9.Tag == o))
            {
                MessageBox.Show("Player two won");
                gamereset();
            }

            else if ((pictureBox1.Tag == x && pictureBox5.Tag == x && pictureBox9.Tag == x) ||
                     (pictureBox3.Tag == x && pictureBox5.Tag == x && pictureBox7.Tag == x))
            {
                MessageBox.Show("Player one won");
                gamereset();
            }
            else if ((pictureBox1.Tag == o && pictureBox5.Tag == o && pictureBox9.Tag == o) ||
                     (pictureBox3.Tag == o && pictureBox5.Tag == o && pictureBox7.Tag == o))
            {
                MessageBox.Show("Player two won");
                gamereset();
            }

            else if(fullboard() == true)
            {
                gamereset();
            }

        }
        private bool playerturn(int num)
        {
            if(num % 2 == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag == "")
            {
                if (playerturn(counter))
                {
                    pictureBox1.Load(x);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Tag = x;

                }
                else
                {
                    pictureBox1.Load(o);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Tag = o;
                }
                counter++;
                checker();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Tag == "")
            {
                if (playerturn(counter))
                {
                    pictureBox2.Load(x);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Tag = x;
                }
                else
                {
                    pictureBox2.Load(o);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Tag = o;
                }
                counter++;
                checker();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Tag == "")
            {
                if (playerturn(counter))
                {
                    pictureBox3.Load(x);
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Tag = x;
                }
                else
                {
                    pictureBox3.Load(o);
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Tag = o;
                }
                counter++;
                checker();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Tag == "")
            {
                if (playerturn(counter))
                {
                    pictureBox4.Load(x);
                    pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox4.Tag = x;
                }
                else
                {
                    pictureBox4.Load(o);
                    pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox4.Tag = o;
                }
                counter++;
                checker();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Tag == "")
            {
                if (playerturn(counter))
                {
                    pictureBox5.Load(x);
                    pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox5.Tag = x;
                }
                else
                {
                    pictureBox5.Load(o);
                    pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox5.Tag = o;
                }
                counter++;
                checker();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Tag == "")
            {
                if (playerturn(counter))
                {
                    pictureBox6.Load(x);
                    pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox6.Tag = x;
                }
                else
                {
                    pictureBox6.Load(o);
                    pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox6.Tag = o;
                }
                counter++;
                checker();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Tag == "")
            {
                if (playerturn(counter))
                {
                    pictureBox7.Load(x);
                    pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox7.Tag = x;
                }
                else
                {
                    pictureBox7.Load(o);
                    pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox7.Tag = o;
                }
                counter++;
                checker();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Tag == "")
            {
                if (playerturn(counter))
                {
                    pictureBox8.Load(x);
                    pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox8.Tag = x;
                }
                else
                {
                    pictureBox8.Load(o);
                    pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox8.Tag = o;
                }
                counter++;
                checker();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Tag == "")
            {
                if (playerturn(counter))
                {
                    pictureBox9.Load(x);
                    pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox9.Tag = x;
                }
                else
                {
                    pictureBox9.Load(o);
                    pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox9.Tag = o;
                }
                counter++;
                checker();
            }
        }
    }
}