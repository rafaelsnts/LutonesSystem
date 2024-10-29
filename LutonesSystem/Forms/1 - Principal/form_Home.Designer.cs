namespace LutonesSystem.Forms._1___Principal
{
    partial class form_Home
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
            this.chartGrafico = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGrafico
            // 
            this.chartGrafico.Legend.LegendID = -1;
            this.chartGrafico.Location = new System.Drawing.Point(-1, 0);
            this.chartGrafico.Name = "chartGrafico";
            this.chartGrafico.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartGrafico.Size = new System.Drawing.Size(1228, 688);
            this.chartGrafico.TabIndex = 0;
            // 
            // form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 688);
            this.Controls.Add(this.chartGrafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Home";
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartGrafico;
    }
}