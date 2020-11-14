using MordoOnline.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MordoOnline
{
    public partial class StartMenu : Form
    {
        private CultureInfo _culture;
        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            _culture = CultureInfo.CurrentCulture;
            if (_culture.ToString() == "ru-RU")
            {
                buttonStart.Text = Russian.Start;
                buttonRegistration.Text = Russian.Registration;
                buttonDataBaseLeft.Text = Russian.DataBase;
                buttonDataBaseRight.Text = Russian.DataBase;
                linkLabel.Text = Russian.LinkLabel;
            }
            else
            {
                buttonStart.Text = English.Start;
                buttonRegistration.Text = English.Registration;
                buttonDataBaseLeft.Text = English.DataBase;
                buttonDataBaseRight.Text = English.DataBase;
                linkLabel.Text = English.LinkLabel;
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mordo.ru/");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_culture.ToString() == "ru-RU")
            {
                StartGame("scripts_ru");
            }
            else
            {
                StartGame("scripts_en");
            }
            this.Close();
        }

        private void StartGame(string nameScripts)
        {
            try
            {
                int tries = 10;
                this.WindowState = FormWindowState.Minimized;
                StartCommandWaitForExit($"rename {nameScripts} scripts");
                string path = Directory.GetCurrentDirectory();
                int countTries = 0;
                while (Directory.GetDirectories(path).Any(d => d.Split('\\').Any(name => name == "scripts")) == false && countTries <= tries)
                {
                    Thread.Sleep(1000);
                    countTries++;
                }
                if (countTries > tries)
                {
                    throw new Exception("Программа не нашла папку scripts\n");
                }

                Process.Start("system\\Game.exe", "startgame");
                countTries = 0;
                while (Process.GetProcesses().Any( p => p.MainWindowTitle == "Mordo Online") == false && countTries <= tries)
                {
                    Thread.Sleep(1000);
                    countTries++;
                }
                if (countTries > tries)
                {
                    throw new Exception("Игра не запустилась.\n");
                }
                StartCommandWaitForExit($"rename scripts {nameScripts}");
            }
            catch (Exception exc)
            {
                this.WindowState = FormWindowState.Normal;
                StartCommandWaitForExit($"rename scripts {nameScripts}");
                MessageBox.Show(exc.Message);
            }
        }

        private void StartCommandWaitForExit(string command)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = $"cmd",
                Arguments = $"/c {command}",
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }
    }
}
