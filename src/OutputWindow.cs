using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using DojoTimer.Helpers;

namespace DojoTimer
{
    public partial class OutputWindow : Form
    {
        string text = "";

        public OutputWindow()
        {
            InitializeComponent();
            OutputTitleBar.BindHandleTo(this);
        }

        public void Clear()
        {
            text = "";
        }

        public void Write(string data)
        {
            text += data + "\r\n";
        }

        public void ShowText(bool result)
        {
            OutputText.Text = text;
            OutputText.SelectionStart = OutputText.TextLength;
            OutputText.ScrollToCaret();
            SetTitleMessages(result);
        }

        private void SetTitleMessages(bool result)
        {
            var scheme = result ? ColorScheme.Green : ColorScheme.Red;
            scheme.ApplyTo(this);
            OutputTitleBar.TitleText = result ? Mono.Unix.Catalog.GetString("SUCCEEDED") : Mono.Unix.Catalog.GetString("FAILED");
            OutputTitleBar.TitleDescription = result ?
                Mono.Unix.Catalog.GetString("Yay, it works!") : Mono.Unix.Catalog.GetString("Gotta fix it. Bad, bad programmer.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
