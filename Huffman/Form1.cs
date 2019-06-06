using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Huffman
{
    public partial class MainForm : Form
    {
        CompressData CD;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CD = new CompressData();
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            if (TXTInput.Text != "")
                TXTOutput.Text = CD.getStringBitStream(CD.HoffmanCompress(TXTInput.Text), TXTInput.Text);
            else
                errorProvider1.SetError(TXTInput, "Please Enter Some Value...");
        }

        private void BtnTree_Click(object sender, EventArgs e)
        {
            DrawHoffman DH = new DrawHoffman();
            DH.root = CD.Result;
            DH.Show();
        }
    }
}
