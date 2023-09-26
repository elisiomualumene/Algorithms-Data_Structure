namespace _008
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
            label3 = new Label();
            value1 = new Label();
            value2 = new Label();
            execute = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 0;
            label1.Text = "Informe um Número";
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            input.Location = new Point(17, 53);
            input.Name = "input";
            input.Size = new Size(364, 32);
            input.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 101);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 2;
            label2.Text = "Parte Inteira";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 140);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 3;
            label3.Text = "Parte Fracionaria";
            // 
            // value1
            // 
            value1.AutoSize = true;
            value1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            value1.Location = new Point(258, 101);
            value1.Name = "value1";
            value1.Size = new Size(0, 25);
            value1.TabIndex = 4;
            // 
            // value2
            // 
            value2.AutoSize = true;
            value2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            value2.Location = new Point(258, 140);
            value2.Name = "value2";
            value2.Size = new Size(0, 25);
            value2.TabIndex = 5;
            // 
            // execute
            // 
            execute.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            execute.Location = new Point(17, 170);
            execute.Name = "execute";
            execute.Size = new Size(364, 40);
            execute.TabIndex = 6;
            execute.Text = "Separar";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 220);
            Controls.Add(execute);
            Controls.Add(value2);
            Controls.Add(value1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input;
        private Label label2;
        private Label label3;
        private Label value1;
        private Label value2;
        private Button execute;
    }
}