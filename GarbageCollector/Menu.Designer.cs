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
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pbWhite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.Black;
            this.lblTitlu.Location = new System.Drawing.Point(-9, -4);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(750, 116);
            this.lblTitlu.TabIndex = 1;
            this.lblTitlu.Text = "Garbage Colector";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTutorial
            // 
            this.btnTutorial.BackColor = System.Drawing.Color.Honeydew;
            this.btnTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTutorial.Location = new System.Drawing.Point(290, 601);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(149, 67);
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
            this.btPlay.Location = new System.Drawing.Point(61, 601);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(149, 67);
            this.btPlay.TabIndex = 3;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Honeydew;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(519, 601);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 67);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMenu.BackgroundImage")));
            this.pbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMenu.Location = new System.Drawing.Point(61, 139);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(607, 400);
            this.pbMenu.TabIndex = 5;
            this.pbMenu.TabStop = false;
            // 
            // pbWhite
            // 
            this.pbWhite.BackColor = System.Drawing.Color.DarkGray;
            this.pbWhite.Location = new System.Drawing.Point(52, 128);
            this.pbWhite.Name = "pbWhite";
            this.pbWhite.Size = new System.Drawing.Size(624, 422);
            this.pbWhite.TabIndex = 6;
            this.pbWhite.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.pbWhite);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.PictureBox pbWhite;
    }
}