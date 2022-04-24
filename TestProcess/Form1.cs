
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Management;
using System.Threading;
using Microsoft.VisualBasic.Devices;

namespace TestProcess
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	///

	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lstProcesses;
		private System.Windows.Forms.Button btnKill;
		private System.Windows.Forms.Label label1;
        private TextBox txtSearch;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.btnKill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProcesses
            // 
            this.lstProcesses.BackColor = System.Drawing.SystemColors.Info;
            this.lstProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProcesses.ItemHeight = 18;
            this.lstProcesses.Location = new System.Drawing.Point(29, 80);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(357, 256);
            this.lstProcesses.TabIndex = 0;
            // 
            // btnKill
            // 
            this.btnKill.BackColor = System.Drawing.SystemColors.Control;
            this.btnKill.ForeColor = System.Drawing.Color.Red;
            this.btnKill.Location = new System.Drawing.Point(308, 372);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(96, 28);
            this.btnKill.TabIndex = 1;
            this.btnKill.Text = "KILL";
            this.btnKill.UseVisualStyleBackColor = false;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Processes List";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(29, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(251, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 444);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstProcesses);
            this.tabPage1.Controls.Add(this.btnKill);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tasks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(421, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Performance";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBorderWidth = 5;
            series1.Legend = "Legend1";
            series1.LegendText = "RAM";
            series1.Name = "series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.LegendText = "CPU";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(421, 418);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

		}
        #endregion

        private Thread threadMemory;
        private Thread threadCpu;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Title = "Percent";

            chart1.Series[0].BorderWidth = 2;

            chart1.Series[1].BorderWidth = 2;
            chart1.Series[1].BorderColor = Color.Red;


            LoadProcesses();

            // Phương thức LoadMemory sẽ sử dụng riêng 1 Thread
            // để cập nhật tình trạng bộ nhớ đang sử dụng
            this.threadMemory = new Thread(LoadMemory);
            this.threadCpu = new Thread(LoadCpuUsage);

            this.threadMemory.Start();
            this.threadCpu.Start();
		}

		private void LoadProcesses()
		{
			// Lấy tất cả các tiến trình hiện có trên hệ thống
			Process[] processes = Process.GetProcesses();
			
			lstProcesses.Items.Clear();

			// Thêm tiến trình vào ListBox để hiện thị ra màn hình
			Array.ForEach(processes, (process) =>
			{
				lstProcesses.Items.Add(process.ProcessName);
			});
		}

		private void btnKill_Click(object sender, System.EventArgs e)
		{
			// Lấy ra tên tiến trình và loại bỏ đuôi .exe
			string strProcessName = System.IO.Path.GetFileNameWithoutExtension(lstProcesses.SelectedItem.ToString());

			// Xóa tất cả những tiến trình có tên đã chọn
			foreach (var process in Process.GetProcessesByName(strProcessName))
            {
				process.Kill();
            }

			// Sau khi xóa sẽ cập nhật lại danh sách 
			LoadProcesses();
		}

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
			String textSearch = txtSearch.Text;
			int lenTextSearch = textSearch.Length;
			Process[] processes = Process.GetProcesses();

			if (lenTextSearch == 0) LoadProcesses();
			else
            {
				lstProcesses.Items.Clear();
				Array.ForEach(processes, (process) =>
				{
					string processName = process.ProcessName;

					if (processName.Length - lenTextSearch >= 0)
                    {
						// So sánh chuỗi con với chuỗi đã nhập để tìm kiếm
						if (processName.Substring(0, lenTextSearch) == textSearch)
						{
							lstProcesses.Items.Add(processName);
						}
                    }
				});
            }

		}
        private delegate void EventHandle();
        private void LoadMemory()
        {

            // Dùng vòng lặp vô hạn để liên tục cập nhật trạng thái bộ nhớ
            while (true)
            {
                // Sử dụng framework có sẵn của Visual Studio code
                // Tham khảo: https://stackoverflow.com/questions/60095454/get-memory-usage-of-process-in
                var computerInfo = new ComputerInfo();
                Process[] processes = Process.GetProcesses();

                int totalPlysicalMemory = Convert.ToInt32(computerInfo.TotalPhysicalMemory / 1048576);
                int usageMemory = 0;

                Array.ForEach(processes, (process) =>
                {
                    // Lấy bộ nhớ của các tiến trình
                    int totalUsageCurrentProcess = (int)process.PrivateMemorySize64 / 1048576;
                    usageMemory += totalUsageCurrentProcess;
                });

                int freeMemory = totalPlysicalMemory - usageMemory;

                // Giới hạn số điểm trên đồ thị tránh việc
                // có quá nhiều điểm được thêm vào làm đồ thị
                // bị co nhỏ lại
                if (chart1.Series[0].Points.Count > 40)
                    this.removeFirstPoint(0);

                // Tính phần trăm bộ nhớ đã sài / bộ nhớ có sẵn
                this.point(0, (usageMemory * 100) / totalPlysicalMemory);

                Thread.Sleep(500); // Trì hoãn thời gian lặp lại luồng là 500 mili giây
            }
        }

        private void LoadCpuUsage()
        {
            // Tham khảo: https://stackoverflow.com/questions/278071/how-to-get-the-cpu-usage-in-c
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            while (true)
            {
                // Giới hạn số điểm trên đồ thị tránh việc
                // có quá nhiều điểm được thêm vào làm đồ thị
                // bị co nhỏ lại
                if (chart1.Series[0].Points.Count > 40)
                    this.removeFirstPoint(1);

                // Giá trị % sử dụng của CPU 
                this.point(1, Convert.ToInt32(cpuCounter.NextValue()));

                Thread.Sleep(500);
            }
        }

        private int point(int index, int point)
        {
            // index là chỉ số của những đường line hiện có trên winform (0: RAM, 1: CPU)
            // point là điểm được xác định dựa theo trục y
            if (chart1.InvokeRequired)
                chart1.BeginInvoke(new Action(() =>
                {
                    chart1.Series[index].Points.Add(point);
                }));
            else
                chart1.Series[index].Points.Add(point);
            return point;
        }

        private void removeFirstPoint(int index)
        {
            // index là chỉ số của những đường line hiện có trên winform (0: RAM, 1: CPU)
            if (chart1.InvokeRequired)
                chart1.BeginInvoke(new Action(() =>
                {
                    chart1.Series[index].Points.RemoveAt(0);
                }));
            else
                chart1.Series[index].Points.Add(0);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.threadMemory.Abort();
            this.threadCpu.Abort();
        }
    }
}
