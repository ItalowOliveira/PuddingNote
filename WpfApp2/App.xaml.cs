using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using WpfApp2.Models;

namespace WpfApp2
{
    public partial class App : System.Windows.Application
    {
        private NotifyIcon notifyIcon;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            InitializeNotifyIcon();
        }

        private void InitializeNotifyIcon()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon(@"C:\Users\italo\source\repos\ItalowOliveira\PuddingNote\WpfApp2\Style\Icons\temporario.ico");
            notifyIcon.Visible = true;
            notifyIcon.Text = "Pudding Note";

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Abrir PuddingNote");
            menu.Items.Add("Sair", null, OnExit);
            notifyIcon.ContextMenuStrip = menu;
            notifyIcon.Click += Notify_Click;

        }


        private void Notify_Click(object sender, EventArgs e)
        {
            MainWindow.Show();
            System.Diagnostics.Debug.WriteLine("Dep");
        }



        private void OnExit(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
            Shutdown();
        }
    }
}