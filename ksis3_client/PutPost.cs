using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ksis3_client
{
    public partial class PutPost : Form
    {
        public PutPost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            if (!openFileDialog1.CheckFileExists)
            {
                MessageBox.Show("Не выбран файл");
                return;
            }
            using (FileStream stream = File.OpenRead(openFileDialog1.FileName))
            {
                try
                {
                    if (((Form1)Owner).GetRadio() == "putButton")
                    {
                        await Client.SendPutAsync(textBox2.Text, stream);
                        Close();
                    }
                    else
                    {
                        await Client.SendPostAsync(textBox2.Text, stream);
                        Close();
                    }
                    if (Client.statusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Файл не найден", "Внимние", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException exception)
                {
                    MessageBox.Show("Неизвестная ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

    }
}
