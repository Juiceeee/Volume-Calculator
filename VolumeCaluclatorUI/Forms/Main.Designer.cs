namespace VolumeCalculatorUI.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BTN_Calculate = new System.Windows.Forms.Button();
            this.NUD_Height = new System.Windows.Forms.NumericUpDown();
            this.NUD_Width = new System.Windows.Forms.NumericUpDown();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.L_Height = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Width)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Calculate
            // 
            this.BTN_Calculate.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Calculate.Image")));
            this.BTN_Calculate.Location = new System.Drawing.Point(254, 123);
            this.BTN_Calculate.Name = "BTN_Calculate";
            this.BTN_Calculate.Size = new System.Drawing.Size(75, 23);
            this.BTN_Calculate.TabIndex = 0;
            this.BTN_Calculate.Text = "Calculate";
            this.BTN_Calculate.UseVisualStyleBackColor = true;
            this.BTN_Calculate.Click += new System.EventHandler(this.BTN_Calculate_Click);
            // 
            // NUD_Height
            // 
            this.NUD_Height.Location = new System.Drawing.Point(81, 273);
            this.NUD_Height.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_Height.Name = "NUD_Height";
            this.NUD_Height.Size = new System.Drawing.Size(120, 20);
            this.NUD_Height.TabIndex = 1;
            this.NUD_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NUD_Width
            // 
            this.NUD_Width.Location = new System.Drawing.Point(378, 273);
            this.NUD_Width.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_Width.Name = "NUD_Width";
            this.NUD_Width.Size = new System.Drawing.Size(120, 20);
            this.NUD_Width.TabIndex = 2;
            this.NUD_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Result
            // 
            this.TB_Result.Location = new System.Drawing.Point(229, 366);
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ReadOnly = true;
            this.TB_Result.Size = new System.Drawing.Size(100, 20);
            this.TB_Result.TabIndex = 5;
            this.TB_Result.Text = "0";
            // 
            // L_Height
            // 
            this.L_Height.AutoSize = true;
            this.L_Height.BackColor = System.Drawing.Color.CornflowerBlue;
            this.L_Height.ForeColor = System.Drawing.Color.OrangeRed;
            this.L_Height.Location = new System.Drawing.Point(102, 257);
            this.L_Height.Name = "L_Height";
            this.L_Height.Size = new System.Drawing.Size(79, 13);
            this.L_Height.TabIndex = 6;
            this.L_Height.Text = "Enter Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(404, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Width";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Height);
            this.Controls.Add(this.TB_Result);
            this.Controls.Add(this.NUD_Width);
            this.Controls.Add(this.NUD_Height);
            this.Controls.Add(this.BTN_Calculate);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Volume Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Calculate;
        private System.Windows.Forms.NumericUpDown NUD_Height;
        private System.Windows.Forms.NumericUpDown NUD_Width;
        private System.Windows.Forms.Label LBL_1;
        private System.Windows.Forms.Label LBL_2;
        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.Label L_Height;
        private System.Windows.Forms.Label label1;
    }
}

