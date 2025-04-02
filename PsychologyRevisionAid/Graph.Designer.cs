namespace PsychologyRevisionAid
{
    partial class Graph
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
            this.LineGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.LineGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // LineGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.LineGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.LineGraph.Legends.Add(legend1);
            this.LineGraph.Location = new System.Drawing.Point(137, 34);
            this.LineGraph.Name = "LineGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Topic";
            this.LineGraph.Series.Add(series1);
            this.LineGraph.Size = new System.Drawing.Size(845, 382);
            this.LineGraph.TabIndex = 0;
            this.LineGraph.Text = "chart2";
            // 
            // Graph
            // 
            this.ClientSize = new System.Drawing.Size(1158, 513);
            this.Controls.Add(this.LineGraph);
            this.Name = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.LineGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart LineGraph;
    }
}