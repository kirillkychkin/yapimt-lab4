namespace yapimt_lab4
{
    partial class InsertVariableWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            existingVarBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // existingVarBox
            // 
            existingVarBox.FormattingEnabled = true;
            existingVarBox.Location = new Point(21, 30);
            existingVarBox.Name = "existingVarBox";
            existingVarBox.Size = new Size(121, 23);
            existingVarBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(45, 355);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Выбрать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InsertVariableWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(168, 450);
            Controls.Add(button1);
            Controls.Add(existingVarBox);
            Name = "InsertVariableWindow";
            Text = "InsertVariableWindow";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox existingVarBox;
        private Button button1;
    }
}