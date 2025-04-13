
namespace yapimt_lab4
{
    partial class VariableWindow
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
            this.VarBox = new System.Windows.Forms.ComboBox();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VarBox
            // 
            this.VarBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VarBox.FormattingEnabled = true;
            this.VarBox.Location = new System.Drawing.Point(12, 12);
            this.VarBox.Name = "VarBox";
            this.VarBox.Size = new System.Drawing.Size(127, 23);
            this.VarBox.TabIndex = 0;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(13, 42);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(126, 23);
            this.ChooseButton.TabIndex = 1;
            this.ChooseButton.Text = "Выбрать";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // VariableWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 76);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.VarBox);
            this.Name = "VariableWindow";
            this.Text = "Переменные";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox VarBox;
        private System.Windows.Forms.Button ChooseButton;
    }
}