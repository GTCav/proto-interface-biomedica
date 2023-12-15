using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Gui;
using NAudio.Wave;
using ScottPlot;


namespace AudioPeak
{
    public partial class Form2 : Form
    {
        private OpenFileDialog open;
        private NAudio.Wave.WaveInEvent wvin;

        public Form2(OpenFileDialog open)
        {
            InitializeComponent();
            this.open = open;
            //this.IsMdiContainer = true;
            abrir_arquivo();
        }

        private void novaTela_Load(object sender, EventArgs e)
        {

        }

        private void waveViewer1_Load(object sender, EventArgs e)
        {
            base.OnLoad(e);
        }

        private void AudioMonitorInitialize(string caminhoArquivo, int taxaAmostragem = 8000, int bitsPorAmostra = 16,
    int canais = 1, int bufferMilissegundos = 20, bool iniciar = true)
        {
            if (wvin == null)
            {
                wvin = new NAudio.Wave.WaveInEvent();
                wvin.DeviceNumber = -1; // Usar o dispositivo de entrada de áudio padrão
                wvin.WaveFormat = new NAudio.Wave.WaveFormat(taxaAmostragem, bitsPorAmostra, canais);
                wvin.DataAvailable += OnDataAvailable;
                wvin.BufferMilliseconds = bufferMilissegundos;

                // Carregar o arquivo de áudio e configurar o ScottPlot
                var leitorWaveFile = new NAudio.Wave.WaveFileReader(caminhoArquivo);

                // Verificar se o identificador de janela foi criado antes de chamar Invoke
                if (IsHandleCreated)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        ConfigurarScottPlot(leitorWaveFile);
                        leitorWaveFile.Dispose();
                    });
                }
                else
                {
                    ConfigurarScottPlot(leitorWaveFile);
                    leitorWaveFile.Dispose();
                }
            }
        }

        private void ConfigurarScottPlot(NAudio.Wave.WaveFileReader leitorWaveFile)
        {
            var dadosAudio = new double[leitorWaveFile.SampleCount];
            byte[] buffer = new byte[2]; // Para amostras de 16 bits

            for (int i = 0; i < dadosAudio.Length; i++)
            {
                leitorWaveFile.Read(buffer, 0, 2); // Lê 2 bytes (16 bits)
                short sample = BitConverter.ToInt16(buffer, 0);
                dadosAudio[i] = sample / (double)short.MaxValue; // Normaliza para o intervalo [-1, 1]
            }

            //Criando Gráfico
            scottPlotUC2.plt.Clear();
            scottPlotUC2.plt.PlotSignal(dadosAudio, leitorWaveFile.WaveFormat.SampleRate, markerSize: 0);
            scottPlotUC2.plt.YLabel("Amplitude (%)");
            scottPlotUC2.plt.XLabel("Time (seconds)");
            scottPlotUC2.Render();
        }

        private void OnDataAvailable(object sender, NAudio.Wave.WaveInEventArgs args)
        {
            int bytesPerSample = wvin.WaveFormat.BitsPerSample / 8;
            int samplesRecorded = args.BytesRecorded / bytesPerSample;

            var buffer = new short[samplesRecorded];

            for (int i = 0; i < samplesRecorded; i++)
            {
                buffer[i] = BitConverter.ToInt16(args.Buffer, i * bytesPerSample);
            }
        }

        private void abrir_arquivo()
        {
            //waveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(open.FileName);
            AudioMonitorInitialize(open.FileName);
            this.Text = open.FileName;

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            scottPlotUC2.plt.AxisAuto();
            scottPlotUC2.plt.TightenLayout();
            scottPlotUC2.Render();
        }

        private void btnPng_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Png files | *.png";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            scottPlotUC2.plt.SaveFig(dialog.FileName, true);
        }
    }
}
