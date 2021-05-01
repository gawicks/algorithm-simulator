namespace Simulator
{
    partial class MainFrom
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
            this.btnSetValues = new System.Windows.Forms.Button();
            this.txtValues = new System.Windows.Forms.TextBox();
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.RobotContainer = new System.Windows.Forms.Panel();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.rbtnDescending = new System.Windows.Forms.RadioButton();
            this.rbtnAscending = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.btnQSort = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSort = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetValues
            // 
            this.btnSetValues.Location = new System.Drawing.Point(6, 156);
            this.btnSetValues.Name = "btnSetValues";
            this.btnSetValues.Size = new System.Drawing.Size(82, 23);
            this.btnSetValues.TabIndex = 3;
            this.btnSetValues.Text = "Set values";
            this.btnSetValues.UseVisualStyleBackColor = true;
            this.btnSetValues.Click += new System.EventHandler(this.btnSetValues_Click);
            // 
            // txtValues
            // 
            this.txtValues.Location = new System.Drawing.Point(6, 49);
            this.txtValues.Multiline = true;
            this.txtValues.Name = "txtValues";
            this.txtValues.Size = new System.Drawing.Size(225, 74);
            this.txtValues.TabIndex = 4;
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Location = new System.Drawing.Point(230, 42);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(108, 23);
            this.btnPauseResume.TabIndex = 5;
            this.btnPauseResume.Text = "Pause/Resume";
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // RobotContainer
            // 
            this.RobotContainer.AutoScroll = true;
            this.RobotContainer.BackColor = System.Drawing.Color.Azure;
            this.RobotContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RobotContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RobotContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotContainer.Location = new System.Drawing.Point(3, 23);
            this.RobotContainer.Name = "RobotContainer";
            this.RobotContainer.Size = new System.Drawing.Size(1030, 345);
            this.RobotContainer.TabIndex = 1;
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(38, 22);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(98, 23);
            this.btnBubbleSort.TabIndex = 9;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(38, 74);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(98, 23);
            this.btnInsertionSort.TabIndex = 10;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(38, 48);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(98, 23);
            this.btnSelectionSort.TabIndex = 11;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // rbtnDescending
            // 
            this.rbtnDescending.AutoSize = true;
            this.rbtnDescending.Location = new System.Drawing.Point(22, 74);
            this.rbtnDescending.Name = "rbtnDescending";
            this.rbtnDescending.Size = new System.Drawing.Size(91, 19);
            this.rbtnDescending.TabIndex = 13;
            this.rbtnDescending.Text = "Descending";
            this.rbtnDescending.UseVisualStyleBackColor = true;
            // 
            // rbtnAscending
            // 
            this.rbtnAscending.AutoSize = true;
            this.rbtnAscending.Checked = true;
            this.rbtnAscending.Location = new System.Drawing.Point(22, 44);
            this.rbtnAscending.Name = "rbtnAscending";
            this.rbtnAscending.Size = new System.Drawing.Size(82, 19);
            this.rbtnAscending.TabIndex = 12;
            this.rbtnAscending.TabStop = true;
            this.rbtnAscending.Text = "Ascending";
            this.rbtnAscending.UseVisualStyleBackColor = true;
            this.rbtnAscending.CheckedChanged += new System.EventHandler(this.rbtnAscending_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAscending);
            this.groupBox1.Controls.Add(this.rbtnDescending);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(286, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 188);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort order";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(94, 156);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(81, 23);
            this.btnRandom.TabIndex = 18;
            this.btnRandom.Text = "Randomize";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(260, 77);
            this.tbSpeed.Maximum = 2000;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(286, 45);
            this.tbSpeed.TabIndex = 19;
            this.tbSpeed.Value = 1500;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // btnQSort
            // 
            this.btnQSort.Location = new System.Drawing.Point(38, 103);
            this.btnQSort.Name = "btnQSort";
            this.btnQSort.Size = new System.Drawing.Size(98, 23);
            this.btnQSort.TabIndex = 20;
            this.btnQSort.Text = "Quick Sort";
            this.btnQSort.UseVisualStyleBackColor = true;
            this.btnQSort.Click += new System.EventHandler(this.btnQSort_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RobotContainer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.59853F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.40147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 602);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 204);
            this.panel2.TabIndex = 22;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.btnStep);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbSpeed);
            this.groupBox4.Controls.Add(this.btnPauseResume);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(418, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 188);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBubbleSort);
            this.groupBox2.Controls.Add(this.btnSelectionSort);
            this.groupBox2.Controls.Add(this.btnInsertionSort);
            this.groupBox2.Controls.Add(this.btnQSort);
            this.groupBox2.Location = new System.Drawing.Point(18, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 151);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Play algorithm";
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(344, 42);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(95, 23);
            this.btnStep.TabIndex = 22;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Speed";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRandom);
            this.groupBox3.Controls.Add(this.btnSetValues);
            this.groupBox3.Controls.Add(this.txtValues);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 191);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Values";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSort,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1036, 20);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSort
            // 
            this.lblSort.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(0, 15);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel3.Image = global::Simulator.Properties.Resources.exclamation_blue;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(16, 15);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(974, 15);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 602);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainFrom";
            this.Text = "Algorithm Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetValues;
        private System.Windows.Forms.TextBox txtValues;
        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.Panel RobotContainer;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.RadioButton rbtnDescending;
        private System.Windows.Forms.RadioButton rbtnAscending;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Button btnQSort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

    }
}

