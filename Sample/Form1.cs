using ErrorCodeReader;
using System;
using System.Windows.Forms;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var errorCode = ErrorCodes.Get(int.Parse(textBox1.Text));
            dataGridView1.Rows.Add(new object[] {errorCode.Code,errorCode.Title,errorCode.Description });
        }
    }
}
