namespace _014
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
            value = new Label();
            execute = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "Dimensão";
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            input.Location = new Point(14, 44);
            input.Name = "input";
            input.Size = new Size(340, 29);
            input.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 92);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 2;
            label2.Text = "Área";
            // 
            // value
            // 
            value.AutoSize = true;
            value.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            value.Location = new Point(101, 92);
            value.Name = "value";
            value.Size = new Size(0, 21);
            value.TabIndex = 3;
            // 
            // execute
            // 
            execute.Location = new Point(17, 130);
            execute.Name = "execute";
            execute.Size = new Size(337, 36);
            execute.TabIndex = 4;
            execute.Text = "Executar";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 188);
            Controls.Add(execute);
            Controls.Add(value);
            Controls.Add(label2);
            Controls.Add(input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "IMOBILIS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input;
        private Label label2;
        private Label value;
        private Button execute;
    }
}