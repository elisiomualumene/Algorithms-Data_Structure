namespace _009
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
            input1 = new TextBox();
            input2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            value = new Label();
            execute = new Button();
            new_execute = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(265, 21);
            label1.TabIndex = 0;
            label1.Text = "Informe o valor do Cateto Oposto";
            // 
            // input1
            // 
            input1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            input1.Location = new Point(12, 51);
            input1.Name = "input1";
            input1.Size = new Size(354, 32);
            input1.TabIndex = 1;
            // 
            // input2
            // 
            input2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            input2.Location = new Point(12, 110);
            input2.Name = "input2";
            input2.Size = new Size(354, 32);
            input2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(287, 21);
            label2.TabIndex = 2;
            label2.Text = "Informe o valor do Cateto Adjacente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(251, 19);
            label3.TabIndex = 4;
            label3.Text = "O valor do comprimento da hipotenusa";
            // 
            // value
            // 
            value.AutoSize = true;
            value.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            value.Location = new Point(277, 154);
            value.Name = "value";
            value.Size = new Size(0, 19);
            value.TabIndex = 5;
            // 
            // execute
            // 
            execute.Location = new Point(12, 186);
            execute.Name = "execute";
            execute.Size = new Size(162, 39);
            execute.TabIndex = 6;
            execute.Text = "Executar";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // new_execute
            // 
            new_execute.Location = new Point(204, 186);
            new_execute.Name = "new_execute";
            new_execute.Size = new Size(162, 39);
            new_execute.TabIndex = 7;
            new_execute.Text = "Novo Calculo";
            new_execute.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 237);
            Controls.Add(new_execute);
            Controls.Add(execute);
            Controls.Add(value);
            Controls.Add(label3);
            Controls.Add(input2);
            Controls.Add(label2);
            Controls.Add(input1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input1;
        private TextBox input2;
        private Label label2;
        private Label label3;
        private Label value;
        private Button execute;
        private Button new_execute;
    }
}