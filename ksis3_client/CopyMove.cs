using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ksis3_client
{
    public partial class CopyMove : Form
    {
        public CopyMove()
        {
            InitializeComponent();
        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не введен URI");
                return;
            }
            try
            {
                if (((Form1)Owner).GetRadio() == "copyButton")
                {
                    await Client.SendCopyAsync(textBox1.Text, textBox2.Text);
                    Close();
                }
                else
                {
                    await Client.SendMoveAsync(textBox1.Text, textBox2.Text);
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

        private void CopyMove_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
