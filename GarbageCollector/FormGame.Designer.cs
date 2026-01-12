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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelBar = new System.Windows.Forms.Label();
            this.TimerCollectGarbage = new System.Windows.Forms.Timer(this.components);
            this.lblTimpRămas = new System.Windows.Forms.Label();
            this.TimerPrepare = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new YourNamespace.NonSelectableButton();
            this.nsbtnBackToMenu = new YourNamespace.NonSelectableButton();
            this.pictureBoxGarbage = new System.Windows.Forms.PictureBox();
            this.lblPunctaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarbage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxCar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.Image")));
            this.pictureBoxCar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelScore.Location = new System.Drawing.Point(1048, -19);
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
            // TimerCollectGarbage
            // 
            this.TimerCollectGarbage.Interval = 1000;
            this.TimerCollectGarbage.Tick += new System.EventHandler(this.TimerCollectGarbage_Tick);
            // 
            // lblTimpRămas
            // 
            this.lblTimpRămas.AutoSize = true;
            this.lblTimpRămas.BackColor = System.Drawing.Color.LightYellow;
            this.lblTimpRămas.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimpRămas.Location = new System.Drawing.Point(1066, 12);
            this.lblTimpRămas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimpRămas.Name = "lblTimpRămas";
            this.lblTimpRămas.Size = new System.Drawing.Size(176, 31);
            this.lblTimpRămas.TabIndex = 6;
            this.lblTimpRămas.Text = "Timp rămas:";
            // 
            // TimerPrepare
            // 
            this.TimerPrepare.Interval = 1000;
            this.TimerPrepare.Tick += new System.EventHandler(this.TimerPrepare_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1066, 636);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(171, 48);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start joc";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nsbtnBackToMenu
            // 
            this.nsbtnBackToMenu.BackColor = System.Drawing.Color.LightGreen;
            this.nsbtnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nsbtnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsbtnBackToMenu.Location = new System.Drawing.Point(1066, 694);
            this.nsbtnBackToMenu.Margin = new System.Windows.Forms.Padding(2);
            this.nsbtnBackToMenu.Name = "nsbtnBackToMenu";
            this.nsbtnBackToMenu.Size = new System.Drawing.Size(171, 48);
            this.nsbtnBackToMenu.TabIndex = 4;
            this.nsbtnBackToMenu.Text = "Back to Menu";
            this.nsbtnBackToMenu.UseVisualStyleBackColor = false;
            this.nsbtnBackToMenu.Click += new System.EventHandler(this.nsbtnBackToMenu_Click);
            // 
            // pictureBoxGarbage
            // 
            this.pictureBoxGarbage.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxGarbage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGarbage.Image")));
            this.pictureBoxGarbage.Location = new System.Drawing.Point(227, 0);
            this.pictureBoxGarbage.Name = "pictureBoxGarbage";
            this.pictureBoxGarbage.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxGarbage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGarbage.TabIndex = 7;
            this.pictureBoxGarbage.TabStop = false;
            this.pictureBoxGarbage.Visible = false;
            // 
            // lblPunctaj
            // 
            this.lblPunctaj.BackColor = System.Drawing.Color.LightYellow;
            this.lblPunctaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPunctaj.Location = new System.Drawing.Point(1077, 400);
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Size = new System.Drawing.Size(160, 85);
            this.lblPunctaj.TabIndex = 8;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 749);
            this.Controls.Add(this.lblPunctaj);
            this.Controls.Add(this.pictureBoxGarbage);
            this.Controls.Add(this.lblTimpRămas);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nsbtnBackToMenu);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarbage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelBar;
        private YourNamespace.NonSelectableButton nsbtnBackToMenu;
        private YourNamespace.NonSelectableButton btnStart;
        private System.Windows.Forms.Timer TimerCollectGarbage;
        private System.Windows.Forms.Label lblTimpRămas;
        private System.Windows.Forms.Timer TimerPrepare;
        private System.Windows.Forms.PictureBox pictureBoxGarbage;
        private System.Windows.Forms.Label lblPunctaj;
    }
}

