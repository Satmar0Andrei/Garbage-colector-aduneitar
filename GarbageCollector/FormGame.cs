using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
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

        public FormGame()
        {
            InitializeComponent();
            pictureBoxCar.Size = new Size(49, 49);
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            InitializeMaze();
            StartLocation();
            BreakRandomWalls(rows, cols, brokenWalls);
            PlaceBuildings();
            PlaceRoad();
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
            for(int i = 0; i < rows; i++)
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


        private void lblMenu_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
