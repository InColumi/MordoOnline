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

                StartCommandWaitForExit("rename \"%CD%\\scripts_ru\" \"scripts\"");
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

        private void StartMenu_Shown(object sender, EventArgs e)
        {

        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mordo.ru/");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_culture.ToString() == "ru-RU")
            {
                //StartCommandWaitForExit("rename \"%CD%\\scripts_ru\" \"scripts\"");
               // StartCommandWaitForExit("TIMEOUT /T 4 /NOBREAK");
                StartCommand("start system\\ru\\Game.exe startgame");
                StartCommandWaitForExit("rename \"%CD%\\scripts\" \"scripts_ru\"");
            }
            else
            {
                StartCommandWaitForExit("rename \"%CD%\\scripts_en\" \"scripts\"");
                StartCommand("start system\\ru\\Game.exe startgame");
                StartCommandWaitForExit("rename \"%CD%\\scripts\" \"scripts_en\"");
            }
            this.Close();
        }

        private void StartCommand(string command)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = $"cmd",
                Arguments = $"/c {command}",
                WindowStyle = ProcessWindowStyle.Normal
            });
        }

        private void StartCommandWaitForExit(string command)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = $"cmd",
                Arguments = $"/c {command}",
                WindowStyle = ProcessWindowStyle.Normal
            }).WaitForExit();
        }
    }
}
