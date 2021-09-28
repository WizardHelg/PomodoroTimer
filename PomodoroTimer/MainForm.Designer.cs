namespace PomodoroTimer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTimer = new System.Windows.Forms.TabPage();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.labelTimer = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBoxIntervals = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxRelax = new System.Windows.Forms.GroupBox();
            this.numericUpDownBigRelax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSmallRelax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownWork = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPomodoroNumber = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPause = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSkip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPageTimer.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTimer.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.groupBoxIntervals.SuspendLayout();
            this.groupBoxRelax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBigRelax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmallRelax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWork)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTimer);
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageTimer
            // 
            this.tabPageTimer.Controls.Add(this.panelButtons);
            this.tabPageTimer.Controls.Add(this.panelTimer);
            this.tabPageTimer.Location = new System.Drawing.Point(4, 24);
            this.tabPageTimer.Name = "tabPageTimer";
            this.tabPageTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimer.Size = new System.Drawing.Size(792, 422);
            this.tabPageTimer.TabIndex = 0;
            this.tabPageTimer.Text = "Таймер";
            this.tabPageTimer.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonReset);
            this.panelButtons.Controls.Add(this.buttonSkip);
            this.panelButtons.Controls.Add(this.buttonPause);
            this.panelButtons.Controls.Add(this.buttonStart);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(3, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(84, 416);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonReset
            // 
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Location = new System.Drawing.Point(0, 69);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(84, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonSkip
            // 
            this.buttonSkip.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSkip.FlatAppearance.BorderSize = 0;
            this.buttonSkip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.buttonSkip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkip.Location = new System.Drawing.Point(0, 46);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(84, 23);
            this.buttonSkip.TabIndex = 2;
            this.buttonSkip.Text = "Пропустить";
            this.buttonSkip.UseVisualStyleBackColor = true;
            // 
            // buttonPause
            // 
            this.buttonPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.buttonPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Location = new System.Drawing.Point(0, 23);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(84, 23);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(0, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(84, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // panelTimer
            // 
            this.panelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTimer.Controls.Add(this.labelTimer);
            this.panelTimer.Location = new System.Drawing.Point(87, 3);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(702, 416);
            this.panelTimer.TabIndex = 1;
            // 
            // labelTimer
            // 
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimer.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimer.Location = new System.Drawing.Point(0, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(702, 416);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.groupBox1);
            this.tabPageSettings.Controls.Add(this.groupBoxIntervals);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 24);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(792, 422);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Настройка";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownAmount);
            this.groupBox1.Location = new System.Drawing.Point(164, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Колличество помидорок";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(6, 22);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(159, 23);
            this.numericUpDownAmount.TabIndex = 0;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxIntervals
            // 
            this.groupBoxIntervals.Controls.Add(this.label4);
            this.groupBoxIntervals.Controls.Add(this.groupBoxRelax);
            this.groupBoxIntervals.Controls.Add(this.numericUpDownWork);
            this.groupBoxIntervals.Controls.Add(this.label1);
            this.groupBoxIntervals.Location = new System.Drawing.Point(8, 6);
            this.groupBoxIntervals.Name = "groupBoxIntervals";
            this.groupBoxIntervals.Size = new System.Drawing.Size(150, 156);
            this.groupBoxIntervals.TabIndex = 0;
            this.groupBoxIntervals.TabStop = false;
            this.groupBoxIntervals.Text = "Интервалы, мин";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(0, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 1);
            this.label4.TabIndex = 3;
            // 
            // groupBoxRelax
            // 
            this.groupBoxRelax.Controls.Add(this.numericUpDownBigRelax);
            this.groupBoxRelax.Controls.Add(this.label3);
            this.groupBoxRelax.Controls.Add(this.numericUpDownSmallRelax);
            this.groupBoxRelax.Controls.Add(this.label2);
            this.groupBoxRelax.Location = new System.Drawing.Point(6, 60);
            this.groupBoxRelax.Name = "groupBoxRelax";
            this.groupBoxRelax.Size = new System.Drawing.Size(137, 88);
            this.groupBoxRelax.TabIndex = 2;
            this.groupBoxRelax.TabStop = false;
            this.groupBoxRelax.Text = "Перерыв";
            // 
            // numericUpDownBigRelax
            // 
            this.numericUpDownBigRelax.Location = new System.Drawing.Point(75, 51);
            this.numericUpDownBigRelax.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownBigRelax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBigRelax.Name = "numericUpDownBigRelax";
            this.numericUpDownBigRelax.Size = new System.Drawing.Size(44, 23);
            this.numericUpDownBigRelax.TabIndex = 5;
            this.numericUpDownBigRelax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Большой";
            // 
            // numericUpDownSmallRelax
            // 
            this.numericUpDownSmallRelax.Location = new System.Drawing.Point(75, 22);
            this.numericUpDownSmallRelax.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSmallRelax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSmallRelax.Name = "numericUpDownSmallRelax";
            this.numericUpDownSmallRelax.Size = new System.Drawing.Size(44, 23);
            this.numericUpDownSmallRelax.TabIndex = 3;
            this.numericUpDownSmallRelax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Малый";
            // 
            // numericUpDownWork
            // 
            this.numericUpDownWork.Location = new System.Drawing.Point(81, 22);
            this.numericUpDownWork.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownWork.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWork.Name = "numericUpDownWork";
            this.numericUpDownWork.Size = new System.Drawing.Size(44, 23);
            this.numericUpDownWork.TabIndex = 1;
            this.numericUpDownWork.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Работа";
            // 
            // labelPomodoroNumber
            // 
            this.labelPomodoroNumber.AutoSize = true;
            this.labelPomodoroNumber.Location = new System.Drawing.Point(130, 5);
            this.labelPomodoroNumber.Name = "labelPomodoroNumber";
            this.labelPomodoroNumber.Size = new System.Drawing.Size(123, 15);
            this.labelPomodoroNumber.TabIndex = 1;
            this.labelPomodoroNumber.Text = "Номер помидорки: 1";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Текст";
            this.notifyIcon.BalloonTipTitle = "Заголовок";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Pomodoro Timer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStart,
            this.tsmiPause,
            this.tsmiSkip,
            this.tsmiReset});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(140, 92);
            this.contextMenuStrip.Text = "Pomodoro Timer";
            // 
            // tsmiStart
            // 
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.Size = new System.Drawing.Size(139, 22);
            this.tsmiStart.Text = "Старт";
            // 
            // tsmiPause
            // 
            this.tsmiPause.Name = "tsmiPause";
            this.tsmiPause.Size = new System.Drawing.Size(139, 22);
            this.tsmiPause.Text = "Пауза";
            // 
            // tsmiSkip
            // 
            this.tsmiSkip.Name = "tsmiSkip";
            this.tsmiSkip.Size = new System.Drawing.Size(139, 22);
            this.tsmiSkip.Text = "Пропустить";
            // 
            // tsmiReset
            // 
            this.tsmiReset.Name = "tsmiReset";
            this.tsmiReset.Size = new System.Drawing.Size(139, 22);
            this.tsmiReset.Text = "Сброс";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPomodoroNumber);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PomodoroTimer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl.ResumeLayout(false);
            this.tabPageTimer.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelTimer.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.groupBoxIntervals.ResumeLayout(false);
            this.groupBoxIntervals.PerformLayout();
            this.groupBoxRelax.ResumeLayout(false);
            this.groupBoxRelax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBigRelax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmallRelax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWork)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTimer;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.GroupBox groupBoxIntervals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxRelax;
        private System.Windows.Forms.NumericUpDown numericUpDownBigRelax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSmallRelax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPomodoroNumber;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiPause;
        private System.Windows.Forms.ToolStripMenuItem tsmiSkip;
        private System.Windows.Forms.ToolStripMenuItem tsmiReset;
    }
}

