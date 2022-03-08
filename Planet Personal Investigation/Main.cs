using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Planet_Personal_Investigation
{
    public partial class Main : Form
    {
        public int fps = 144;
        public double timePerSecond = 1;
        public PlanetManager planetManager;
        public Planet centrePlanet;
        public System.Timers.Timer timer;
        string readPath;
        string writeDirectory;
        string excelPath;
        int fileCount = 0;

        public Main(string _readPath, string _writeDirectory, string _excelPath)
        {
            readPath = _readPath;
            writeDirectory = _writeDirectory;
            excelPath = _excelPath;
            Start();
            InitializeComponent();
        }

        public void Start()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            planetManager = new PlanetManager(excelPath);

            planetManager.ReadFromFile(readPath);
            if (planetManager.centrePlanet != null) centrePlanet = planetManager.centrePlanet;

            SetTimer();
        }

        public void SetTimer()
        {
            timer = new System.Timers.Timer(1000/fps);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            planetManager.Update(fps, timePerSecond);

            canvas.Invalidate();
        }

        private void CanvasPaint(object sender, PaintEventArgs e)
        {
            if (centrePlanet == null) planetManager.Draw(sender, e, this.Width / 2, this.Height / 2);
            else planetManager.Draw(sender, e, (int)centrePlanet.positionX + this.Width/2, (int)centrePlanet.positionY + this.Height/2);
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "S")
            {
                planetManager.WriteToFile(writeDirectory + $"\\{fileCount}.txt");
                fileCount++;
            }
            if (e.KeyData.ToString() == "E")
            {
                planetManager.WriteToExcel(excelPath);
            }
            if (e.KeyData.ToString() == "OemMinus")
            {
                planetManager.increaseScale();
            }
            if (e.KeyData.ToString() == "Oemplus")
            {
                planetManager.decreaseScale();
            }
        }
    }
}
