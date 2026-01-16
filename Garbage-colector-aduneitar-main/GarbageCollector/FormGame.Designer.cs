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
            this.pictureBoxGarbage = new System.Windows.Forms.PictureBox();
            this.lblPunctaj = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lstPunctaje = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new YourNamespace.NonSelectableButton();
            this.nsbtnBackToMenu = new YourNamespace.NonSelectableButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarbage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackColor = System.Drawing.Color.Wheat;
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
            this.labelScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(203)))), ((int)(((byte)(71)))));
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
            this.lblTimpRămas.Location = new System.Drawing.Point(1066, 308);
            this.lblTimpRămas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimpRămas.Name = "lblTimpRămas";
            this.lblTimpRămas.Size = new System.Drawing.Size(176, 31);
            this.lblTimpRămas.TabIndex = 6;
            this.lblTimpRămas.Text = "Timp rămas:";
            this.lblTimpRămas.Click += new System.EventHandler(this.lblTimpRămas_Click);
            // 
            // TimerPrepare
            // 
            this.TimerPrepare.Interval = 1000;
            this.TimerPrepare.Tick += new System.EventHandler(this.TimerPrepare_Tick);
            // 
            // pictureBoxGarbage
            // 
            this.pictureBoxGarbage.BackColor = System.Drawing.Color.Wheat;
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
            this.lblPunctaj.Location = new System.Drawing.Point(1067, 528);
            this.lblPunctaj.Name = "lblPunctaj";
            this.lblPunctaj.Size = new System.Drawing.Size(170, 85);
            this.lblPunctaj.TabIndex = 8;
            this.lblPunctaj.Click += new System.EventHandler(this.lblPunctaj_Click);
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.Color.Beige;
            this.txtNume.Location = new System.Drawing.Point(1077, 30);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(155, 20);
            this.txtNume.TabIndex = 10;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // lstPunctaje
            // 
            this.lstPunctaje.BackColor = System.Drawing.Color.Beige;
            this.lstPunctaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstPunctaje.FormattingEnabled = true;
            this.lstPunctaje.ItemHeight = 20;
            this.lstPunctaje.Location = new System.Drawing.Point(1077, 74);
            this.lstPunctaje.Name = "lstPunctaje";
            this.lstPunctaje.Size = new System.Drawing.Size(155, 204);
            this.lstPunctaje.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(203)))), ((int)(((byte)(71)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1074, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(203)))), ((int)(((byte)(71)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1074, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lista punctaje";
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
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPunctaje);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblPunctaj);
            this.Controls.Add(this.pictureBoxGarbage);
            this.Controls.Add(this.lblTimpRămas);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nsbtnBackToMenu);
            this.Controls.Add(this.labelBar);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.labelScore);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.ListBox lstPunctaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

