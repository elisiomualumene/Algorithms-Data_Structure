namespace _005
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
            execute = new Button();
            label2 = new Label();
            value = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(212, 21);
            label1.TabIndex = 0;
            label1.Text = "Digita o valor em Kwanzas";
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input.Location = new Point(12, 60);
            input.Name = "input";
            input.Size = new Size(367, 29);
            input.TabIndex = 1;
            // 
            // execute
            // 
            execute.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            execute.Location = new Point(12, 104);
            execute.Name = "execute";
            execute.Size = new Size(367, 35);
            execute.TabIndex = 2;
            execute.Text = "Executar";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 3;
            label2.Text = "Voce pode comprar";
            // 
            // value
            // 
            value.AutoSize = true;
            value.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            value.Location = new Point(163, 151);
            value.Name = "value";
            value.Size = new Size(0, 21);
            value.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(338, 151);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 5;
            label3.Text = "USD";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 192);
            Controls.Add(label3);
            Controls.Add(value);
            Controls.Add(label2);
            Controls.Add(execute);
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
        private Button execute;
        private Label label2;
        private Label value;
        private Label label3;
    }
}