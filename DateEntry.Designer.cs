namespace LunarCalendar
{
    partial class DateEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSolarDate = new System.Windows.Forms.Label();
            this.lblLunarDate = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblSolarDate
            // 
            this.lblSolarDate.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolarDate.Location = new System.Drawing.Point(3, 0);
            this.lblSolarDate.Name = "lblSolarDate";
            this.lblSolarDate.Size = new System.Drawing.Size(53, 37);
            this.lblSolarDate.TabIndex = 0;
            this.lblSolarDate.Text = "11";
            this.lblSolarDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLunarDate
            // 
            this.lblLunarDate.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunarDate.Location = new System.Drawing.Point(47, 25);
            this.lblLunarDate.Name = "lblLunarDate";
            this.lblLunarDate.Size = new System.Drawing.Size(38, 23);
            this.lblLunarDate.TabIndex = 0;
            this.lblLunarDate.Text = "11";
            this.lblLunarDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // DateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblLunarDate);
            this.Controls.Add(this.lblSolarDate);
            this.DoubleBuffered = true;
            this.Name = "DateEntry";
            this.Size = new System.Drawing.Size(88, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSolarDate;
        private System.Windows.Forms.Label lblLunarDate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
