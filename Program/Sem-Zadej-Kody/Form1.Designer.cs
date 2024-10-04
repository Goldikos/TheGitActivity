namespace Sem_Zadej_Kody
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxKody = new TextBox();
            buttonSifrovat = new Button();
            labelTitle = new Label();
            SuspendLayout();
            // 
            // textBoxKody
            // 
            textBoxKody.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxKody.Location = new Point(12, 110);
            textBoxKody.Name = "textBoxKody";
            textBoxKody.Size = new Size(225, 35);
            textBoxKody.TabIndex = 0;
            // 
            // buttonSifrovat
            // 
            buttonSifrovat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonSifrovat.Location = new Point(12, 151);
            buttonSifrovat.Name = "buttonSifrovat";
            buttonSifrovat.Size = new Size(225, 38);
            buttonSifrovat.TabIndex = 1;
            buttonSifrovat.Text = "Zadat";
            buttonSifrovat.UseVisualStyleBackColor = true;
            buttonSifrovat.Click += buttonSifrovat_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTitle.Location = new Point(41, 34);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(170, 40);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Dekódovač";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 203);
            Controls.Add(labelTitle);
            Controls.Add(buttonSifrovat);
            Controls.Add(textBoxKody);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxKody;
        private Button buttonSifrovat;
        private Label labelTitle;
    }
}
