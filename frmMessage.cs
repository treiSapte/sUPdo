using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sUPdo
{
    public partial class frmMessage : MetroForm
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            if (important.teacherORstudent == 2)
                metroTextBox1.Text = important.filesS[important.varPoz].message;
            else
                metroTextBox1.Text = important.files[important.varPoz].message;
        }
    }
}
