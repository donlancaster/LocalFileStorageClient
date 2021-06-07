using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ksis3_client
{
    public partial class Form1 : Form
    {
        Form getDeleteForm, putPostForm, copyMoveForm;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(GetRadio())
            {
                case "getButton":
                case "deleteButton":
                    getDeleteForm = new GetDelete();
                    getDeleteForm.Owner = this;
                    getDeleteForm.Show();
                    break;
                case "putButton":
                case "postButton":
                    putPostForm = new PutPost();
                    putPostForm.Owner = this;
                    putPostForm.Show();
                    break;
                case "copyButton":
                case "moveButton":
                    copyMoveForm = new CopyMove();
                    copyMoveForm.Owner = this;
                    copyMoveForm.Show();
                    break;

            }
        }

        public String GetRadio()
        {
            return Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Name;
        }
    }
}
