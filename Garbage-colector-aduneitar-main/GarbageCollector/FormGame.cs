using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Image = System.Drawing.Image;

namespace GarbageCollector
{
    public partial class FormGame : Form
    {
        private int carSpeed = 50, rows = 15, cols = 21, brokenWalls = 20;
        private int[,] grid = new int[50, 50];
        private bool[,] visited = new bool[50, 50];
        private int[] di = { -2, 0, 2, 0 };
        private int[] dj = { 0, 2, 0, -2 };
        private Random random = new Random();
        private int gunoaieAD = 0;
        private double punctajTotal = 0;
        private bool miscpos = false;

        //private int[40] x ;
        //private int[40] y;

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            InitializeMaze();
            StartLocation();
            BreakRandomWalls(rows, cols, brokenWalls);
            PlaceBuildings();
            PlaceRoad();
            lblPunctaj.Visible = false;
            lblTimpRămas.Visible = false;
        }

        private void VerifyGarbage()
        {
            if(pictureBoxGarbage.Location.X ==  pictureBoxCar.Location.X && pictureBoxCar.Location.Y == pictureBoxGarbage.Location.Y)
            {
                gunoaieAD++;
                GarbageTelportor();

                PointCalculator();

                lblPunctaj.Text = ("Gunoaie colectate: " + punctajTotal).ToString();
                lblPunctaj.Visible = true;
            }
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (miscpos == true)
            {
                int x = pictureBoxCar.Location.Y / 50;
                int y = pictureBoxCar.Location.X / 50;

                if (e.KeyCode == Keys.Left && pictureBoxCar.Left > 10)
                {
                    if (grid[x, y - 1] == 1)
                    {
                        pictureBoxCar.Image = Image.FromFile("Images\\car4.png");
                        pictureBoxCar.Left -= carSpeed;

                        VerifyGarbage();
                    }

                }

                if (e.KeyCode == Keys.Right && pictureBoxCar.Left < 1000)
                {
                    if (grid[x, y + 1] == 1)
                    {
                        pictureBoxCar.Image = Image.FromFile("Images\\car2.png");
                        pictureBoxCar.Left += carSpeed;

                        VerifyGarbage();
                    }
                }

                if (e.KeyCode == Keys.Up && pictureBoxCar.Top > 10)
                {
                    if (grid[x - 1, y] == 1)
                    {
                        pictureBoxCar.Image = Image.FromFile("Images\\car1.png");
                        pictureBoxCar.Top -= carSpeed;

                        VerifyGarbage();
                    }
                }

                if (e.KeyCode == Keys.Down && pictureBoxCar.Top < 700)
                {
                    if (grid[x + 1, y] == 1)
                    {
                        pictureBoxCar.Image = Image.FromFile("Images\\car3.png");
                        pictureBoxCar.Top += carSpeed;

                        VerifyGarbage();
                    }
                }
            }
        }
        private void PlaceBuildings()
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
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
        private void PlaceRoad()
        {
            //int cx = 1;
            //int cy = 1;

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        PictureBox picture = new PictureBox();
                        picture.BackColor = Color.Tan;
                        picture.SizeMode = PictureBoxSizeMode.StretchImage;
                        picture.Size = new Size(50, 50);
                        picture.Location = new Point(j * 50, i * 50);
                        this.Controls.Add(picture);

                        //adaugarea coordonatelor in vectori
                        //x[cx] = 1;
                        //y[cy] = 1;

                        //cx++;
                        //cy++;
                    }
                }
            }
        }

        private void InitializeMaze()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = -1;
                    visited[i, j] = false;
                }
            }

            Random random = new Random();

            int startX = 1 + 2 * random.Next((rows-1) / 2);
            int startY = 1 + 2 * random.Next((cols - 1) / 2);

            GenerateMaze(startX, startY, rows, cols);
        }

        private void nsbtnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txtNume.Text != "")
            {
                punctajTotal = 0;
                lblTimpRămas.Visible = true;
                lblTimpRămas.Text = "";
                btnStart.Hide();
                TimerPrepare.Start();
            }
            else
            {
                MessageBox.Show("Introduceți un nume!");
            }
        }

        int prepareTimeleft = 4;
        int time = 90;

        private void TimerPrepare_Tick(object sender, EventArgs e)
        {
            if(prepareTimeleft > 0)
            {
                string s = lblTimpRămas.Text;
                lblTimpRămas.Text =s + (prepareTimeleft - 1).ToString() + " secunde\n";
                prepareTimeleft--;
            }
            if(prepareTimeleft == 0)
            {
                string s = "";
                lblTimpRămas.Text = s + "Start!";

                miscpos = true;

                GarbageGenerator();

                TimerPrepare.Stop();

                TimerCollectGarbage.Start();
                
            }
        }

        private void PointCalculator()
        {
            punctajTotal +=  1;
        }

        private void TimerCollectGarbage_Tick(object sender, EventArgs e)
        {
            time--;
            if(time > 0 && time <= 88)
            {
                string s = "Timp rămas: ";
                if(time != 1)
                {
                    lblTimpRămas.Text = s + "\n" + (time - 1).ToString() + " secunde";
                }
                else
                {
                    lblTimpRămas.Text = s + "\n" + (time - 1).ToString() + " secundă";
                }
            }
            if(time == 0)
            {
                lblTimpRămas.Text = "S-a terminat \n timpul!";

                TimerCollectGarbage.Stop();

                miscpos = false;
                pictureBoxCar.Location = new Point(0, 0);
                pictureBoxCar.Image = Image.FromFile("Images\\car3.png");
                btnStart.Show();

                // lista punctaje

                string nume;
                nume = txtNume.Text;

                lstPunctaje.Items.Add(nume + " " + punctajTotal);
                prepareTimeleft = 4;
                time = 90;
                txtNume.Text = "";

            }
        }

        private void GenerateMaze(int x, int y, int rows, int cols)
        {
            visited[x, y] = true;
            grid[x, y] = 1;

            List<int> directions = new List<int>() { 0, 1, 2, 3 };

            for(int i = 0; i < directions.Count; i++)
            {
                int j = random.Next(i, directions.Count);
                int aux = directions[i];
                directions[i] = directions[j];
                directions[j] = aux;
            }


            foreach(int direction in directions)
            {
                int nexti = x + di[direction];
                int nextj = y + dj[direction];

                if (nexti >= 0 && nexti < rows && nextj >= 0 && nextj < cols)
                {
                    if (!visited[nexti, nextj])
                    {
                        int wallX = x + di[direction] / 2;
                        int wallY = y + dj[direction] / 2;
                        grid[wallX, wallY] = 1;

                        GenerateMaze(nexti, nextj, rows, cols);
                    }
                }
            }
        }

        private void BreakRandomWalls(int rows, int cols, int count)
        {
            int broken = 0;

            while(broken < count)
            {
                int x = random.Next(rows);
                int y = random.Next(cols);

                if (grid[x, y] == -1)
                {
                    if (x > 0 && x < rows - 1 && y > 0 && y < cols - 1)
                    {
                        grid[x, y] = 1;
                        broken++;
                    }
                }
            }
        }

        private void StartLocation()
        {
            grid[0, 0] = grid[0, 1] = grid[1, 0] = grid[1, 1] = 1;
        }

        private void lblTimpRămas_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPunctaj_Click(object sender, EventArgs e)
        {

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        Random r = new Random();

        private void GarbageGenerator()
        {
            pictureBoxGarbage.Size = new Size(50, 50);
            pictureBoxGarbage.Image = Image.FromFile( "Images\\trashCan.png");
            pictureBoxGarbage.Visible = true;
            pictureBoxGarbage.BringToFront();

            GarbageTelportor();
        }

        //private void GarbageTelportor()
        //{
        //        int randx;
        //        int randy;

        //        Point p = new Point();

        //        p = pictureBoxGarbage.Location;

        //        do
        //        {
        //            randx = r.Next(2, 20);
        //            randy = r.Next(2, 14);
        //            pictureBoxGarbage.Location = new Point(randx * 50, randy * 50);
        //        }
        //        while (!(grid[randx, randy] == 1 && p != pictureBoxGarbage.Location));
        //        pictureBoxGarbage.Visible = true;
        //        pictureBoxGarbage.BringToFront();

        private void GarbageTelportor()
        {
            int randx, randy;

            Point p = new Point();

            p = pictureBoxGarbage.Location;

            randx = r.Next(2, 20);
            randy = r.Next(2, 14);


            if (grid[randx, randy] == 1)
            {
                pictureBoxGarbage.Location = new Point(randy * 50, randx * 50);

                if(pictureBoxGarbage.Location == p)
                {
                    GarbageTelportor();
                }
            }
            else
            {
                GarbageTelportor();
            }
        }
    }
}
