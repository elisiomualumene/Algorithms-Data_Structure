namespace _015
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
            label1 = new Label();
            input = new TextBox();
            button1 = new Button();
            label2 = new Label();
            value = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 0;
            label1.Text = "Número de Cavalos";
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            input.Location = new Point(12, 45);
            input.Name = "input";
            input.Size = new Size(229, 29);
            input.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(258, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 53);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 3;
            label2.Text = "Numero de Ferraduras";
            // 
            // value
            // 
            value.AutoSize = true;
            value.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            value.Location = new Point(12, 121);
            value.Name = "value";
            value.Size = new Size(0, 21);
            value.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 162);
            Controls.Add(value);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input;
        private Button button1;
        private Label label2;
        private Label value;
    }
}