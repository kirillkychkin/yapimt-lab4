using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapimt_lab4
{
    public partial class VariableWindow : Form
    {
        public char selectedVar;
        Calculator parent;

        public VariableWindow(Calculator parent)
        {
            InitializeComponent();

            this.parent = parent;
            VarBox.Items.Add(' ');
            selectedVar = ' ';

            for (char i = 'A'; i <= 'Z'; i++)
            {
                VarBox.Items.Add(i);
            }
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            parent.SetVariable((char)VarBox.SelectedItem);
        }
    }
}
