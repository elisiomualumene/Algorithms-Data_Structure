namespace _018
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
            execute = new Button();
            cleaner = new Button();
            label3 = new Label();
            value = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "Preço do litro de gasolina:";
            // 
            // input1
            // 
            input1.Location = new Point(12, 27);
            input1.Name = "input1";
            input1.Size = new Size(228, 23);
            input1.TabIndex = 1;
            // 
            // input2
            // 
            input2.Location = new Point(12, 81);
            input2.Name = "input2";
            input2.Size = new Size(228, 23);
            input2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor do Pagamento";
            // 
            // execute
            // 
            execute.Location = new Point(259, 27);
            execute.Name = "execute";
            execute.Size = new Size(103, 23);
            execute.TabIndex = 4;
            execute.Text = "Executar";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // cleaner
            // 
            cleaner.Location = new Point(258, 81);
            cleaner.Name = "cleaner";
            cleaner.Size = new Size(103, 23);
            cleaner.TabIndex = 5;
            cleaner.Text = "Limpar";
            cleaner.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 6;
            label3.Text = "Vocé pode comprar:";
            // 
            // value
            // 
            value.AutoSize = true;
            value.Location = new Point(164, 121);
            value.Name = "value";
            value.Size = new Size(0, 15);
            value.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 192);
            Controls.Add(value);
            Controls.Add(label3);
            Controls.Add(cleaner);
            Controls.Add(execute);
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
        private Button execute;
        private Button cleaner;
        private Label label3;
        private Label value;
    }
}