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
    public partial class InsertVariableWindow : Form
    {
        Calculator parent;
        public InsertVariableWindow(Calculator parent)
        {
            InitializeComponent();
            this.parent = parent;

            Decimal?[] values = GetVars();
            existingVarBox.Items.Add(' ');

            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)('A' + i);
                if (values[i] != null)
                {
                    existingVarBox.Items.Add(alphabet[i]);
                }
            }

        }
        public Decimal?[] GetVars()
        {
            return parent.GetVars();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char res = (char)existingVarBox.SelectedItem;
            MessageBox.Show(res.ToString());
        }
    }
}
