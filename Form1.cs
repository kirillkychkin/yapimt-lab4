namespace yapimt_lab4
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void ButtonNumbers_Click(object sender, EventArgs e)
        {
            //EnableOperationKeys(sender, e);
            Button button = (Button)sender;
            textMainDisplay.Text += button.Text;
            MessageBox.Show($"Button {button.Text} clicked", caption: "Number clicked");
            //if (textMainDisplay.Text == result.ToString(precisionFormat) && clearFirstTime == false)
            //{
            //    btnClearEntry.PerformClick();
            //    clearFirstTime = true;
            //}

            //if (textMainDisplay.TextLength < 13 + Convert.ToInt32(textMainDisplay.Text.Contains(btnDot.Text)) + Convert.ToInt32(textMainDisplay.Text.Contains("-")))
            //{
            //    if (textMainDisplay.Text.Equals("0"))
            //    {
            //        textMainDisplay.Text = button.Text;
            //    }
            //    else
            //    {
            //        textMainDisplay.Text += button.Text;
            //    }
            //}
        }
    }
}
