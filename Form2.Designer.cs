namespace AudioPeak
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.scottPlotUC2 = new ScottPlot.ScottPlotUC();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnPng = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // waveViewer1
            // 
            this.waveViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waveViewer1.Location = new System.Drawing.Point(0, 28);
            this.waveViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.Size = new System.Drawing.Size(1067, 526);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 0;
            this.waveViewer1.WaveStream = null;
            // 
            // scottPlotUC2
            // 
            this.scottPlotUC2.Location = new System.Drawing.Point(174, 66);
            this.scottPlotUC2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scottPlotUC2.Name = "scottPlotUC2";
            this.scottPlotUC2.Size = new System.Drawing.Size(667, 431);
            this.scottPlotUC2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(12, 28);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAuto.TabIndex = 3;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnPng
            // 
            this.btnPng.Location = new System.Drawing.Point(93, 28);
            this.btnPng.Name = "btnPng";
            this.btnPng.Size = new System.Drawing.Size(75, 23);
            this.btnPng.TabIndex = 4;
            this.btnPng.Text = "PNG";
            this.btnPng.UseVisualStyleBackColor = true;
            this.btnPng.Click += new System.EventHandler(this.btnPng_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPng);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.scottPlotUC2);
            this.Controls.Add(this.waveViewer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Gráfico";
            this.Load += new System.EventHandler(this.novaTela_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NAudio.Gui.WaveViewer waveViewer1;
        private ScottPlot.ScottPlotUC scottPlotUC2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnPng;
    }
}