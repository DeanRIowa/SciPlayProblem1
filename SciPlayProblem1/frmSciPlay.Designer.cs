namespace SciPlayProblem1
{
    partial class frmSciPlay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chtMostAliveYears = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMostAliveYearsDescription = new System.Windows.Forms.Label();
            this.lblMostAliveYearsList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtMostAliveYears)).BeginInit();
            this.SuspendLayout();
            // 
            // chtMostAliveYears
            // 
            chartArea1.Name = "ChartArea1";
            this.chtMostAliveYears.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtMostAliveYears.Legends.Add(legend1);
            this.chtMostAliveYears.Location = new System.Drawing.Point(12, 12);
            this.chtMostAliveYears.Name = "chtMostAliveYears";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtMostAliveYears.Series.Add(series1);
            this.chtMostAliveYears.Size = new System.Drawing.Size(998, 645);
            this.chtMostAliveYears.TabIndex = 2;
            this.chtMostAliveYears.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "SciPlay People Alive";
            this.chtMostAliveYears.Titles.Add(title1);
            // 
            // lblMostAliveYearsDescription
            // 
            this.lblMostAliveYearsDescription.BackColor = System.Drawing.Color.White;
            this.lblMostAliveYearsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostAliveYearsDescription.Location = new System.Drawing.Point(12, 660);
            this.lblMostAliveYearsDescription.Name = "lblMostAliveYearsDescription";
            this.lblMostAliveYearsDescription.Size = new System.Drawing.Size(136, 79);
            this.lblMostAliveYearsDescription.TabIndex = 3;
            this.lblMostAliveYearsDescription.Text = "Max Alive Year(s) :";
            // 
            // lblMostAliveYearsList
            // 
            this.lblMostAliveYearsList.BackColor = System.Drawing.Color.White;
            this.lblMostAliveYearsList.Location = new System.Drawing.Point(154, 660);
            this.lblMostAliveYearsList.Name = "lblMostAliveYearsList";
            this.lblMostAliveYearsList.Size = new System.Drawing.Size(855, 79);
            this.lblMostAliveYearsList.TabIndex = 4;
            this.lblMostAliveYearsList.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 748);
            this.Controls.Add(this.lblMostAliveYearsList);
            this.Controls.Add(this.lblMostAliveYearsDescription);
            this.Controls.Add(this.chtMostAliveYears);
            this.Name = "Form1";
            this.Text = "SciPlay";
            ((System.ComponentModel.ISupportInitialize)(this.chtMostAliveYears)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMostAliveYears;
        private System.Windows.Forms.Label lblMostAliveYearsDescription;
        private System.Windows.Forms.Label lblMostAliveYearsList;
    }
}

