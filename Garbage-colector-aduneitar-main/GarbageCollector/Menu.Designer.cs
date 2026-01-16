namespace GarbageCollector
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.btnCredits = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTutorial
            // 
            this.btnTutorial.BackColor = System.Drawing.Color.Honeydew;
            this.btnTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTutorial.Location = new System.Drawing.Point(35, 571);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(427, 36);
            this.btnTutorial.TabIndex = 2;
            this.btnTutorial.Text = "Tutorial";
            this.btnTutorial.UseVisualStyleBackColor = false;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // btPlay
            // 
            this.btPlay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btPlay.BackColor = System.Drawing.Color.Honeydew;
            this.btPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPlay.Location = new System.Drawing.Point(35, 511);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(427, 34);
            this.btPlay.TabIndex = 3;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Honeydew;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(520, 632);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.Transparent;
            this.pbMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMenu.BackgroundImage")));
            this.pbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(485, 367);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(237, 226);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 5;
            this.pbMenu.TabStop = false;
            // 
            // btnCredits
            // 
            this.btnCredits.BackColor = System.Drawing.Color.Honeydew;
            this.btnCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCredits.Location = new System.Drawing.Point(35, 632);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(427, 36);
            this.btnCredits.TabIndex = 7;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = false;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 495);
            this.panel1.TabIndex = 8;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}