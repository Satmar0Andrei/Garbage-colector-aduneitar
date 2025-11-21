namespace GarbageCollector
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.timerGenerateGarbage = new System.Windows.Forms.Timer(this.components);
            this.labelBar = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxCar.Image = global::GarbageCollector.Properties.Resources.car3;
            this.pictureBoxCar.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelScore.Location = new System.Drawing.Point(1048, -6);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(199, 771);
            this.labelScore.TabIndex = 1;
            // 
            // labelBar
            // 
            this.labelBar.BackColor = System.Drawing.Color.Sienna;
            this.labelBar.ForeColor = System.Drawing.Color.Black;
            this.labelBar.Location = new System.Drawing.Point(1048, 1);
            this.labelBar.Name = "labelBar";
            this.labelBar.Size = new System.Drawing.Size(13, 751);
            this.labelBar.TabIndex = 2;
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.LightGreen;
            this.lblMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMenu.Location = new System.Drawing.Point(1067, 704);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(166, 37);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "Back to Menu";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 750);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.labelBar);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.labelScore);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timerGenerateGarbage;
        private System.Windows.Forms.Label labelBar;
        private System.Windows.Forms.Label lblMenu;
    }
}

