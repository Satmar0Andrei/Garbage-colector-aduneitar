namespace GarbageCollector
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.pnlFundal = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlFundal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundal
            // 
            this.pnlFundal.BackColor = System.Drawing.Color.Honeydew;
            this.pnlFundal.Controls.Add(this.lblText);
            this.pnlFundal.Controls.Add(this.lblTitlu);
            this.pnlFundal.Location = new System.Drawing.Point(29, 35);
            this.pnlFundal.Name = "pnlFundal";
            this.pnlFundal.Size = new System.Drawing.Size(562, 486);
            this.pnlFundal.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblText.Location = new System.Drawing.Point(25, 92);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(520, 340);
            this.lblText.TabIndex = 1;
            this.lblText.Text = resources.GetString("lblText.Text");
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Trebuchet MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlu.Location = new System.Drawing.Point(23, 35);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(134, 40);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Tutorial";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Honeydew;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(239, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 67);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlFundal);
            this.DoubleBuffered = true;
            this.Name = "Tutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
            this.pnlFundal.ResumeLayout(false);
            this.pnlFundal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundal;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnExit;
    }
}