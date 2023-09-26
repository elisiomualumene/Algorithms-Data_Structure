namespace _006
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
            label4 = new Label();
            execute = new Button();
            value1 = new Label();
            value2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(213, 21);
            label1.TabIndex = 0;
            label1.Text = "Insira a temperatura em Cº";
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input.Location = new Point(19, 60);
            input.Name = "input";
            input.Size = new Size(314, 29);
            input.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(339, 60);
            label2.Name = "label2";
            label2.Size = new Size(40, 32);
            label2.TabIndex = 2;
            label2.Text = "Cº";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 105);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 3;
            label3.Text = "Kelvin K :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 140);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 4;
            label4.Text = "Fahrenheit: Fº :";
            // 
            // execute
            // 
            execute.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            execute.Location = new Point(19, 178);
            execute.Name = "execute";
            execute.Size = new Size(360, 37);
            execute.TabIndex = 5;
            execute.Text = "Executar";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // value1
            // 
            value1.AutoSize = true;
            value1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            value1.Location = new Point(226, 113);
            value1.Name = "value1";
            value1.Size = new Size(0, 21);
            value1.TabIndex = 6;
            // 
            // value2
            // 
            value2.AutoSize = true;
            value2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            value2.Location = new Point(226, 143);
            value2.Name = "value2";
            value2.Size = new Size(0, 21);
            value2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 239);
            Controls.Add(value2);
            Controls.Add(value1);
            Controls.Add(execute);
            Controls.Add(label4);
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
        private Label label4;
        private Button execute;
        private Label value1;
        private Label value2;
    }
}