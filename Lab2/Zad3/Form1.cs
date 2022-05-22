using System;
using System.Windows.Forms;

namespace Zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MessageBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show (this, "MessageBox1", 
                "Help", MessageBoxButtons.OK, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1, 0, 
                "mspaint.chm", 
                "mspaint.chm::/paint_brush.htm");
        }

        private void MessageBox2_Click(object sender, EventArgs e)
        {
            const string message = "You did not enter a server name. Cancel this operation?";
            const string caption = "No Server Name Specified";
            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 
                MessageBoxOptions.RightAlign);

            if(result == DialogResult.Yes)
            {

                // Closes the parent form.

                this.Close();
            }
        }
    }
}