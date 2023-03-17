using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Win_NotifyIcon_TXT
{
    public partial class Form1 : Form
    {
        private ContextMenuStrip menuStrip;
        private bool isFlyoutVisible = false;
        private DateTime lastExecutionTime = DateTime.MinValue;
        private bool isFirstExecution = true;
        private Timer timer = null;
        string strFile = "C:\\_OneDrive\\Erhard Rainer\\Computer - Programmierung\\Win_NotifyIcon_TXT\\Test.txt";
        int FontSize = 7;
        public Form1()
        {
            InitializeComponent();
            trayIcon.Visible = true;
        }

        private void NotifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShouldShowFlyout())
            {
                ShowFlyout();
            }
        }

        private bool ShouldShowFlyout()
        {
            if (isFirstExecution)
            {
                lastExecutionTime = DateTime.Now;
                isFirstExecution = false;
                return true;
            }
            else
            {
                TimeSpan timeSinceLastExecution = DateTime.Now - lastExecutionTime;
                if (timeSinceLastExecution.TotalSeconds >= 5)
                {
                    lastExecutionTime = DateTime.Now;
                    return true;
                }
            }

            return false;
        }

        private void ShowFlyout()
        {
            if (isFlyoutVisible) return;

            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }

            trayIcon.ContextMenuStrip = new ContextMenuStrip();
            ToolStripTextBox textBox = CreateToolStripTextBox();
            trayIcon.ContextMenuStrip.Items.Add(textBox);

            trayIcon.ContextMenuStrip.Show(Control.MousePosition);
            isFlyoutVisible = true;
            StartFlyoutClosingTimer();
        }

        private ToolStripTextBox CreateToolStripTextBox()
        {
            ToolStripTextBox textBox = new ToolStripTextBox
            {
                ReadOnly = true,
                AutoSize = false,
                Multiline = true,
                Enabled = false, // Benutzer kann nicht hineinklicken
                Font = new Font(Font.FontFamily, FontSize) // Ändern der Schriftgröße auf 12
            };

            int AnzahlZeilen = 0;
            try
            {
                string[] lines = File.ReadAllLines(strFile, Encoding.GetEncoding("iso-8859-1"));
                AnzahlZeilen = lines.Length;
                string content = "";
                for (int i = 0; i < lines.Length && i < AnzahlZeilen; i++)
                {
                    content += lines[i] + Environment.NewLine;
                }
                textBox.Text = content;
                AnzahlZeilen = File.ReadAllLines(strFile).Length;
            }
            catch (Exception ex)
            {
                textBox.Text = "Fehler beim Lesen der Datei: " + ex.Message;
            }

            // Berechne die TextBox-Höhe basierend auf der Anzahl der Zeilen und der Schriftgröße
            int lineHeight = TextRenderer.MeasureText("A", textBox.Font).Height;
            textBox.Height = (lineHeight * AnzahlZeilen) + (FontSize * 2) ;
            textBox.Width = 800;

            return textBox;
        }

        private void StartFlyoutClosingTimer()
        {
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += (s, args) =>
            {
                trayIcon.ContextMenuStrip.Close();
                isFlyoutVisible = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void trayIcon_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("Closing Application");
            Application.Exit();
        }

        private void cmd_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Path.GetDirectoryName(strFile),
                Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strFile = openFileDialog.FileName;
                txt_Path.Text = strFile;
            }
        }

    }
}