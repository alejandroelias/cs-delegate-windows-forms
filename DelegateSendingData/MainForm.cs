using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateSendingData
{
    public partial class MainForm : Form
    {
        public delegate void SetTextValueCallback(string str1, string str2);
        public SetTextValueCallback SetTextValue;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowForm_Click(object sender, EventArgs e)
        {
            ChildForm frm = new ChildForm();
            this.SetTextValue += new SetTextValueCallback(frm.SetText);
            frm.Show();
        }

        private void bntAppend_Click(object sender, EventArgs e)
        {
            SetTextValue(txtEnterText1.Text, txtEnterText2.Text);
        }
    }
}
