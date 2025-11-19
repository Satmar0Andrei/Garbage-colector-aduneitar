using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GarbageCollector
{
    public partial class FormGame : Form
    {
        private int carSpeed = 50, trashCans = 20;
        private int[,] grid = new int[1000, 1000];
        public FormGame()
        {
            InitializeComponent();
            pictureBoxCar.Size = new Size(49, 49);
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBoxCar.Location.Y / 50; 
            int y = pictureBoxCar.Location.X / 50;



            if (e.KeyCode == Keys.Left && pictureBoxCar.Left > 10)
            {
                if (grid[x, y-1] == 1)
                {
                    pictureBoxCar.Image = Image.FromFile("Images\\car4.png");
                    pictureBoxCar.Left -= carSpeed;
                }
                
            }

            if (e.KeyCode == Keys.Right && pictureBoxCar.Left < 1000)
            {
                if (grid[x, y+1] == 1)
                {
                    pictureBoxCar.Image = Image.FromFile("Images\\car2.png");
                    pictureBoxCar.Left += carSpeed;
                }
            }

            if (e.KeyCode == Keys.Up && pictureBoxCar.Top > 10)
            {
                if (grid[x-1, y] == 1)
                {
                    pictureBoxCar.Image = Image.FromFile("Images\\car1.png");
                    pictureBoxCar.Top -= carSpeed;
                }
            }

            if (e.KeyCode == Keys.Down && pictureBoxCar.Top < 700)
            {
                if (grid[x+1, y] == 1)
                {
                    pictureBoxCar.Image = Image.FromFile("Images\\car3.png");
                    pictureBoxCar.Top += carSpeed;
                }
            }
        }

        private void FormGame_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black);
            //float x11 = 0, y11 = 0, x12 = 1060;
            //float x22 = 0, y22 = 0, y23 = 760;

            //for (int i = 1; i <= 16; i++)
            //{
            //    e.Graphics.DrawLine(blackPen, x11, y11, x12, y11);
            //    y11 += carSpeed;
            //}

            //for (int i = 1; i <= 22; i++)
            //{
            //    e.Graphics.DrawLine(blackPen, x22, y22, x22, y23);
            //    x22 += carSpeed;
            //}
        }

        private void GenerateCity()
        {
            for(int i = 0; i < 15; i++)
            {
                for(int j = 0; j < 22; j++)
                {
                    if (grid[i, j] != 1)
                    {
                        Random random = new Random();
                        int number = random.Next(1, 13);
                        PictureBox building = new PictureBox();
                        building.BackColor = Color.DarkSeaGreen;
                        building.SizeMode = PictureBoxSizeMode.Zoom;
                        building.Size = new Size(50, 50);
                        building.Location = new Point(j * 50, i * 50);
                        building.Image = Image.FromFile("Images\\house"+number.ToString()+".png");
                        this.Controls.Add(building);
                    }
                }
            }
        }

        private void GenerateRoad()
        {
            for(int i = 0; i < 16; i++)
            {
                for(int j = 0; j < 22; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        PictureBox picture = new PictureBox();
                        picture.BackColor = Color.Tan;
                        picture.SizeMode = PictureBoxSizeMode.StretchImage;
                        picture.Size = new Size(50, 50);
                        picture.Location = new Point(j * 50, i * 50);

                        this.Controls.Add(picture);
                    }
                }
            }
        }

        private void FillMap()
        {
            grid[0, 0] = grid[0, 1] = grid[0, 3] = grid[0, 7] = grid[0, 8] = grid[0, 9] = grid[0, 10] = grid[0, 14] = grid[0, 17] = 1;
            grid[1, 0] = grid[1, 1] = grid[1, 2] = grid[1, 3] = grid[1, 6] = grid[1, 7] = grid[1, 10] = grid[1, 11] = grid[1, 12] = grid[1, 14] = grid[1, 15] = grid[1, 16] = grid[1, 17] = grid[1, 18] = grid[1, 19] = grid[1, 20] = 1;
            grid[2, 0] = grid[2, 3] = grid[2, 4] = grid[2, 5] = grid[2, 6] = grid[2, 10] = grid[2, 12] = grid[2, 14] = grid[2, 17] = 1;
            grid[3, 0] = grid[3, 1] = grid[3, 3] = grid[3, 6] = grid[3, 8] = grid[3, 9] = grid[3, 10] = grid[3, 11] = grid[3, 12] = grid[3, 13] = grid[3, 14] = grid[3, 17] = grid[3, 18] = grid[3, 19] = grid[3, 20] = 1;
            grid[4, 1] = grid[4, 2] = grid[4, 3] = grid[4, 4] = grid[4, 6] = grid[4, 8] = grid[4, 14] = grid[4, 17] = 1;
            grid[5, 4] = grid[5, 6] = grid[5, 8] = grid[5, 11] = grid[5, 12] = grid[5, 13] = grid[5, 14] = grid[5, 15] = grid[5, 16] = grid[5, 17] = grid[5, 18] = grid[5, 19] = grid[5, 20] = 1;
            grid[6, 0] = grid[6, 1] = grid[6, 2] = grid[6, 3] = grid[6, 4] = grid[6, 5] = grid[6, 6] = grid[6, 7] = grid[6, 8] = grid[6, 9] = grid[6, 10] = grid[6, 11] = grid[6, 14] = grid[6, 18] = 1;
            grid[7, 1] = grid[7, 4] = grid[7, 7] = grid[7, 11] = grid[7, 14] = grid[7, 18] = 1;
            grid[8, 1] = grid[8, 2] = grid[8, 4] = grid[8, 7] = grid[8, 11] = grid[8, 12] = grid[8, 13] = grid[8, 14] = grid[8, 15] = grid[8, 16] = grid[8, 17] = grid[8, 18] = grid[8, 19] = grid[8, 20] = 1;
            grid[9, 0] = grid[9, 2] = grid[9, 4] = grid[9, 6] = grid[9, 7] = grid[9, 8] = grid[9, 9] = grid[9, 10] = grid[9, 11] = grid[9, 14] = grid[9, 17] = 1;
            grid[10, 0] = grid[10, 2] = grid[10, 4] = grid[10, 6] = grid[10, 9] = grid[10, 11] = grid[10, 14] = grid[10, 15] = grid[10, 16] = grid[10, 17] = grid[10, 18] = grid[10, 19] = grid[10, 20] = 1;
            grid[11, 0] = grid[11, 2] = grid[11, 3] = grid[11, 4] = grid[11, 5] = grid[11, 6] = grid[11, 8] = grid[11, 9] = grid[11, 11] = grid[11, 15] = 1;
            grid[12, 0] = grid[12, 1] = grid[12, 2] = grid[12, 8] = grid[12, 11] = grid[12, 12] = grid[12, 13] = grid[12, 14] = grid[12, 15] = grid[12, 16] = grid[12, 17] = grid[12, 18] = 1;
            grid[13, 2] = grid[13, 3] = grid[13, 4] = grid[13, 5] = grid[13, 6] = grid[13, 7] = grid[13, 8] = grid[13, 9] = grid[13, 10] = grid[13, 11] = grid[13, 15] = grid[13, 18] = grid[13, 19] = grid[13, 20] = 1;
            grid[14, 2] = grid[14, 11] = grid[14, 15] = grid[14, 18] = 1;
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            FillMap();
            GenerateRoad();
            GenerateCity();
        }


        //private void Generate()
        //{
        //    Random random = new Random();

        //    int number1 = random.Next(0, 15);
        //    int number2 = random.Next(0, 21);


        //    if (grid[number2, number1] == 1)
        //    {
        //        PictureBox garbage = new PictureBox();
        //        garbage.BackColor = Color.Transparent;
        //        garbage.SizeMode = PictureBoxSizeMode.StretchImage;
        //        garbage.Size = new Size(35, 35);
        //        garbage.Location = new Point(number2 * 50 + 7, number1 * 50 + 7);
        //        garbage.Image = Image.FromFile("Images\\trashCan.png");

        //        this.Controls.Add(garbage);
        //    }

        //}
    }
}
