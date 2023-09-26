namespace _007
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
            value1 = new TextBox();
            value2 = new TextBox();
            label2 = new Label();
            value4 = new TextBox();
            label3 = new Label();
            value3 = new TextBox();
            label4 = new Label();
            execute = new Button();
            label5 = new Label();
            value = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Nota 1";
            // 
            // value1
            // 
            value1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            value1.Location = new Point(27, 44);
            value1.Name = "value1";
            value1.Size = new Size(188, 32);
            value1.TabIndex = 1;
            // 
            // value2
            // 
            value2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            value2.Location = new Point(264, 44);
            value2.Name = "value2";
            value2.Size = new Size(188, 32);
            value2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(264, 20);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 2;
            label2.Text = "Nota 2";
            // 
            // value4
            // 
            value4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            value4.Location = new Point(264, 116);
            value4.Name = "value4";
            value4.Size = new Size(188, 32);
            value4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(264, 92);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 6;
            label3.Text = "Nota 4";
            // 
            // value3
            // 
            value3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            value3.Location = new Point(27, 116);
            value3.Name = "value3";
            value3.Size = new Size(188, 32);
            value3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 92);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 4;
            label4.Text = "Nota 3";
            // 
            // execute
            // 
            execute.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            execute.Location = new Point(27, 168);
            execute.Name = "execute";
            execute.Size = new Size(424, 38);
            execute.TabIndex = 8;
            execute.Text = "Calcular Média";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 218);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 9;
            label5.Text = "Resultado";
            // 
            // value
            // 
            value.AutoSize = true;
            value.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            value.Location = new Point(317, 226);
            value.Name = "value";
            value.Size = new Size(0, 25);
            value.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 261);
            Controls.Add(value);
            Controls.Add(label5);
            Controls.Add(execute);
            Controls.Add(value4);
            Controls.Add(label3);
            Controls.Add(value3);
            Controls.Add(label4);
            Controls.Add(value2);
            Controls.Add(label2);
            Controls.Add(value1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox value1;
        private TextBox value2;
        private Label label2;
        private TextBox value4;
        private Label label3;
        private TextBox value3;
        private Label label4;
        private Button execute;
        private Label label5;
        private Label value;
    }
}