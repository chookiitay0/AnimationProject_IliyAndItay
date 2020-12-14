using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FirstLetter_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SixthLetter.Top <= 125)
            {
                SixthLetter.Top += 5;

                if (SixthLetter.Top == 125)
                {
                    timer1.Stop();
                }
            }

            Random rnd = new Random();
            switch (rnd.Next(1, 5))
            {
                case 1:

                    SixthLetter.ForeColor = Color.Red;
                    break;
                case 2:

                    SixthLetter.ForeColor = Color.Green;
                    break;
                case 3:

                    SixthLetter.ForeColor = Color.Blue;
                    break;
                case 4:

                    SixthLetter.ForeColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }

        private void SeventhLetter_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (SeventhLetter.Top <= 125)
            {
                SeventhLetter.Top += 5;

                if (SeventhLetter.Top == 125)
                {
                    timer2.Stop();
                }
            }

            Random rnd = new Random();
            switch (rnd.Next(1, 5))
            {
                case 1:

                    SeventhLetter.ForeColor = Color.Red;
                    break;
                case 2:

                    SeventhLetter.ForeColor = Color.Green;
                    break;
                case 3:

                    SeventhLetter.ForeColor = Color.Blue;
                    break;
                case 4:

                    SeventhLetter.ForeColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (EighthLetter.Top <= 125)
            {
                EighthLetter.Top += 5;

                if (EighthLetter.Top == 125)
                {
                    timer3.Stop();
                }
            }

            Random rnd = new Random();
            switch (rnd.Next(1, 5))
            {
                case 1:

                    EighthLetter.ForeColor = Color.Red;
                    break;
                case 2:

                    EighthLetter.ForeColor = Color.Green;
                    break;
                case 3:

                    EighthLetter.ForeColor = Color.Blue;
                    break;
                case 4:

                    EighthLetter.ForeColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (NinthLetter.Top <= 125)
            {
                NinthLetter.Top += 5;

                if (NinthLetter.Top == 125)
                {
                    timer4.Stop();
                }
            }

            Random rnd = new Random();
            switch (rnd.Next(1, 5))
            {
                case 1:

                    NinthLetter.ForeColor = Color.Red;
                    break;
                case 2:

                    NinthLetter.ForeColor = Color.Green;
                    break;
                case 3:

                    NinthLetter.ForeColor = Color.Blue;
                    break;
                case 4:

                    NinthLetter.ForeColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {

            if (FirstLetter.Top >= 35)
            {
                FirstLetter.Top -= 5;

                if (FirstLetter.Top == 35)
                {
                    timer5.Stop();
                }
            }

            Random rnd = new Random();
            switch (rnd.Next(1, 5))
            {
                case 1:

                    FirstLetter.ForeColor = Color.Red;
                    break;
                case 2:

                    FirstLetter.ForeColor = Color.Green;
                    break;
                case 3:

                    FirstLetter.ForeColor = Color.Blue;
                    break;
                case 4:

                    FirstLetter.ForeColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (SecondLetter.Top >= 35)
            {
                SecondLetter.Top -= 5;

                if (SecondLetter.Top == 35)
                {
                    timer6.Stop();
                }
            }

            Random rnd = new Random();
            switch (rnd.Next(1, 5))
            {
                case 1:

                    SecondLetter.ForeColor = Color.Red;
                    break;
                case 2:

                    SecondLetter.ForeColor = Color.Green;
                    break;
                case 3:

                    SecondLetter.ForeColor = Color.Blue;
                    break;
                case 4:

                    SecondLetter.ForeColor = Color.Yellow;
                    break;
                default:
                    break;
            }

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (ThirdLetter.Top >= 35)
            {
                ThirdLetter.Top -= 5;

                if (ThirdLetter.Top == 35)
                {
                    timer7.Stop();
                }
            }

            Random rnd = new Random();
            switch (rnd.Next(1, 5))
            {
                case 1:

                    ThirdLetter.ForeColor = Color.Red;
                    break;
                case 2:

                    ThirdLetter.ForeColor = Color.Green;
                    break;
                case 3:

                    ThirdLetter.ForeColor = Color.Blue;
                    break;
                case 4:

                    ThirdLetter.ForeColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (FourthLetter.Top >= 35)
            {
                FourthLetter.Top -= 5;

                if (FourthLetter.Top == 35)
                {
                    timer8.Stop();
                }
            }

            Random rnd = new Random();
            switch (rnd.Next(1, 5))
            {
                case 1:

                    FourthLetter.ForeColor = Color.Red;
                    break;
                case 2:

                    FourthLetter.ForeColor = Color.Green;
                    break;
                case 3:

                    FourthLetter.ForeColor = Color.Blue;
                    break;
                case 4:

                    FourthLetter.ForeColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (roni.Height <= 150)
            {
                roni.Height += 10;
                roni.Top -= 10;
                roni.Width += 10;
                roni.Left -= 10;
            }
            else
            {
                roni.Height = 50;
                roni.Top = 300;
                roni.Width = 50;
                roni.Left = 150;
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            switch (rnd.Next(1, 5))
            {
                case 1:

                    FifthLetter.ForeColor = Color.Red;
                    break;
                case 2:

                    FifthLetter.ForeColor = Color.Green;
                    break;
                case 3:

                    FifthLetter.ForeColor = Color.Blue;
                    break;
                case 4:

                    FifthLetter.ForeColor = Color.Yellow;
                    break;
                default:
                    break;
            }
        }
    }
}
