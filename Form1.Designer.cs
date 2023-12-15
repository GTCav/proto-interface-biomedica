namespace Proto
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.scottPlotUC1 = new ScottPlot.ScottPlotUC();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbAutoAxis = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarGravaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDevice
            // 
            this.cbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(448, 15);
            this.cbDevice.Margin = new System.Windows.Forms.Padding(4);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(227, 24);
            this.cbDevice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dispositivo de entrada de áudio:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(707, 15);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(815, 15);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 28);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // scottPlotUC1
            // 
            this.scottPlotUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scottPlotUC1.Location = new System.Drawing.Point(16, 49);
            this.scottPlotUC1.Margin = new System.Windows.Forms.Padding(5);
            this.scottPlotUC1.Name = "scottPlotUC1";
            this.scottPlotUC1.Size = new System.Drawing.Size(1035, 490);
            this.scottPlotUC1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // cbAutoAxis
            // 
            this.cbAutoAxis.AutoSize = true;
            this.cbAutoAxis.Checked = true;
            this.cbAutoAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoAxis.Location = new System.Drawing.Point(923, 17);
            this.cbAutoAxis.Margin = new System.Windows.Forms.Padding(4);
            this.cbAutoAxis.Name = "cbAutoAxis";
            this.cbAutoAxis.Size = new System.Drawing.Size(84, 20);
            this.cbAutoAxis.TabIndex = 5;
            this.cbAutoAxis.Text = "Auto-axis";
            this.cbAutoAxis.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.gravarToolStripMenuItem,
            this.encerrarGravaçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.arquivoToolStripMenuItem.Text = "Menu";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // gravarToolStripMenuItem
            // 
            this.gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            this.gravarToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.gravarToolStripMenuItem.Text = "Gravar";
            this.gravarToolStripMenuItem.Click += new System.EventHandler(this.gravarToolStripMenuItem_Click);
            // 
            // encerrarGravaçãoToolStripMenuItem
            // 
            this.encerrarGravaçãoToolStripMenuItem.Enabled = false;
            this.encerrarGravaçãoToolStripMenuItem.Name = "encerrarGravaçãoToolStripMenuItem";
            this.encerrarGravaçãoToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.encerrarGravaçãoToolStripMenuItem.Text = "Encerrar gravação";
            this.encerrarGravaçãoToolStripMenuItem.Click += new System.EventHandler(this.encerrarGravaçãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // recLabel
            // 
            this.recLabel.AutoSize = true;
            this.recLabel.ForeColor = System.Drawing.Color.Red;
            this.recLabel.Location = new System.Drawing.Point(49, 49);
            this.recLabel.Name = "recLabel";
            this.recLabel.Size = new System.Drawing.Size(44, 16);
            this.recLabel.TabIndex = 7;
            this.recLabel.Text = "label2";
            this.recLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.recLabel);
            this.Controls.Add(this.cbAutoAxis);
            this.Controls.Add(this.scottPlotUC1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDevice);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Proto Interface Biomédica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private ScottPlot.ScottPlotUC scottPlotUC1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbAutoAxis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarGravaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label recLabel;
    }
}

