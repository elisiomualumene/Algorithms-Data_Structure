namespace _017
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
            label2 = new Label();
            execute = new Button();
            cleaner = new Button();
            value = new Label();
            age = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // input
            // 
            input.BorderStyle = BorderStyle.None;
            input.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            input.Location = new Point(16, 37);
            input.Name = "input";
            input.Size = new Size(325, 25);
            input.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 2;
            label2.Text = "Idade";
            // 
            // execute
            // 
            execute.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            execute.Location = new Point(362, 37);
            execute.Name = "execute";
            execute.Size = new Size(128, 25);
            execute.TabIndex = 4;
            execute.Text = "Calcular";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // cleaner
            // 
            cleaner.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cleaner.Location = new Point(362, 100);
            cleaner.Name = "cleaner";
            cleaner.Size = new Size(128, 25);
            cleaner.TabIndex = 5;
            cleaner.Text = "Limpar";
            cleaner.UseVisualStyleBackColor = true;
            cleaner.Click += cleaner_Click;
            // 
            // value
            // 
            value.AutoSize = true;
            value.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            value.Location = new Point(115, 141);
            value.Name = "value";
            value.Size = new Size(0, 21);
            value.TabIndex = 6;
            value.TextAlign = ContentAlignment.TopCenter;
            // 
            // age
            // 
            age.BorderStyle = BorderStyle.None;
            age.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            age.Location = new Point(16, 98);
            age.Name = "age";
            age.Size = new Size(325, 25);
            age.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-13, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 28);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 3);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 0;
            label3.Text = "Cap I | Exercicio 18";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 257);
            Controls.Add(panel1);
            Controls.Add(age);
            Controls.Add(value);
            Controls.Add(cleaner);
            Controls.Add(execute);
            Controls.Add(label2);
            Controls.Add(input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input;
        private Label label2;
        private Button execute;
        private Button cleaner;
        private Label value;
        private TextBox age;
        private Panel panel1;
        private Label label3;
    }
}