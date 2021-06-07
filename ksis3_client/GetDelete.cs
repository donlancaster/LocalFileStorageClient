using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ksis3_client
{
    public partial class GetDelete : Form
    {
        Stream stream;
        public GetDelete()
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
                if (((Form1)Owner).GetRadio() == "getButton")
                {
                    stream = await Client.SendGetAsync(textBox1.Text);

                    saveFileDialog1.ShowDialog();
                    Close();
                }
                else
                {
                    await Client.SendDeleteAsync(textBox1.Text);
                    Close();
                }
            }
            catch (HttpRequestException exception)
            {
                if (Client.statusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Файл не найден", "Внимние", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Неизвестная ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (FileStream fileStream = File.OpenWrite(saveFileDialog1.FileName))
            {
                stream.CopyTo(fileStream);
            }
        }
    }
}
