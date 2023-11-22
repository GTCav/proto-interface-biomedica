using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;


namespace AudioPeak
{
    public partial class Form2 : Form
    {
        private OpenFileDialog open;
        public Form2(OpenFileDialog open)
        {
            InitializeComponent();
            this.open = open;
            abrir_arquivo();
        }

        private void novaTela_Load(object sender, EventArgs e)
        {

        }

        private void waveViewer1_Load(object sender, EventArgs e)
        {

        }

        private void abrir_arquivo()
        {
            waveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(open.FileName);
            this.Text = open.FileName;

        }
    }
}
