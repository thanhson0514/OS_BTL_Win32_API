
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
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBox3_p2;
        private TextBox textBox2_p2;
        private TextBox textBox1_p2;
        private Label label4;
        private Label label3;
        private Label label2;
        private VerticalProgressBar progressBar1;

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
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.btnKill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3_p2 = new System.Windows.Forms.TextBox();
            this.textBox2_p2 = new System.Windows.Forms.TextBox();
            this.textBox1_p2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new TestProcess.VerticalProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProcesses
            // 
            this.lstProcesses.BackColor = System.Drawing.SystemColors.Info;
            this.lstProcesses.Location = new System.Drawing.Point(17, 70);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(207, 264);
            this.lstProcesses.TabIndex = 0;
            // 
            // btnKill
            // 
            this.btnKill.BackColor = System.Drawing.SystemColors.Control;
            this.btnKill.ForeColor = System.Drawing.Color.Red;
            this.btnKill.Location = new System.Drawing.Point(79, 352);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(75, 24);
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
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Processes List";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(17, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(252, 420);
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
            this.tabPage1.Size = new System.Drawing.Size(244, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tasks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.textBox3_p2);
            this.tabPage2.Controls.Add(this.textBox2_p2);
            this.tabPage2.Controls.Add(this.textBox1_p2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(244, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Memory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3_p2
            // 
            this.textBox3_p2.Enabled = false;
            this.textBox3_p2.Location = new System.Drawing.Point(49, 140);
            this.textBox3_p2.Name = "textBox3_p2";
            this.textBox3_p2.Size = new System.Drawing.Size(49, 20);
            this.textBox3_p2.TabIndex = 4;
            // 
            // textBox2_p2
            // 
            this.textBox2_p2.Enabled = false;
            this.textBox2_p2.Location = new System.Drawing.Point(49, 85);
            this.textBox2_p2.Name = "textBox2_p2";
            this.textBox2_p2.Size = new System.Drawing.Size(49, 20);
            this.textBox2_p2.TabIndex = 4;
            // 
            // textBox1_p2
            // 
            this.textBox1_p2.Enabled = false;
            this.textBox1_p2.Location = new System.Drawing.Point(49, 33);
            this.textBox1_p2.Name = "textBox1_p2";
            this.textBox1_p2.Size = new System.Drawing.Size(49, 20);
            this.textBox1_p2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Space:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(244, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CPU";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(141, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(72, 333);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(252, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

		}
        #endregion

        private Thread threadMemory;

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
			LoadProcesses();

            // Phương thức LoadMemory sẽ sử dụng riêng 1 Thread
            // để cập nhật tình trạng bộ nhớ đang sử dụng
            this.threadMemory = new Thread(LoadMemory);
            threadMemory.Start();
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

			// Cập nhật lại danh sách 
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
                
                progressBar1.Minimum = 0;
                progressBar1.Maximum = totalPlysicalMemory;

                // Xử lý lỗi render khi chạy trong Thread
                if(progressBar1.InvokeRequired)
                    progressBar1.BeginInvoke(new Action(() => {
                        textBox1_p2.Text = totalPlysicalMemory.ToString();
                        textBox2_p2.Text = usageMemory.ToString();
                        textBox3_p2.Text = (totalPlysicalMemory - usageMemory).ToString();
                        progressBar1.Value = usageMemory;
                    }));
                else
                {
                    textBox1_p2.Text = totalPlysicalMemory.ToString();
                    textBox2_p2.Text = usageMemory.ToString();
                    textBox3_p2.Text = (totalPlysicalMemory - usageMemory).ToString();
                    progressBar1.Value = usageMemory;
                }


                Thread.Sleep(500); // Trì hoãn thời gian lặp lại luồng là 500 mili giây
            }
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.threadMemory.Abort();
        }
    }
}
