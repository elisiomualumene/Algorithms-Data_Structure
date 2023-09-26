namespace _001
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
            first_label = new Label();
            second_label = new Label();
            first_input = new TextBox();
            second_input = new TextBox();
            start_button = new Button();
            new_calc = new Button();
            label1 = new Label();
            result = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // first_label
            // 
            first_label.AutoSize = true;
            first_label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            first_label.Location = new Point(28, 25);
            first_label.Name = "first_label";
            first_label.Size = new Size(162, 25);
            first_label.TabIndex = 0;
            first_label.Text = "Primeiro Número:";
            first_label.Click += label1_Click;
            // 
            // second_label
            // 
            second_label.AutoSize = true;
            second_label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            second_label.Location = new Point(237, 25);
            second_label.Name = "second_label";
            second_label.Size = new Size(165, 25);
            second_label.TabIndex = 1;
            second_label.Text = "Segundo Número:";
            // 
            // first_input
            // 
            first_input.Location = new Point(32, 56);
            first_input.Name = "first_input";
            first_input.Size = new Size(156, 23);
            first_input.TabIndex = 2;
            // 
            // second_input
            // 
            second_input.Location = new Point(241, 55);
            second_input.Name = "second_input";
            second_input.Size = new Size(161, 23);
            second_input.TabIndex = 3;
            // 
            // start_button
            // 
            start_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            start_button.Location = new Point(32, 94);
            start_button.Name = "start_button";
            start_button.Size = new Size(156, 33);
            start_button.TabIndex = 4;
            start_button.Text = "Executar";
            start_button.UseVisualStyleBackColor = true;
            start_button.Click += start_button_Click;
            // 
            // new_calc
            // 
            new_calc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            new_calc.Location = new Point(241, 94);
            new_calc.Name = "new_calc";
            new_calc.Size = new Size(161, 33);
            new_calc.TabIndex = 5;
            new_calc.Text = "Novo Calculo";
            new_calc.UseVisualStyleBackColor = true;
            new_calc.Click += new_calc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 150);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 6;
            label1.Text = "Resultado";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(136, 155);
            result.Name = "result";
            result.Size = new Size(0, 15);
            result.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(205, 58);
            label2.Name = "label2";
            label2.Size = new Size(21, 21);
            label2.TabIndex = 8;
            label2.Text = "+";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 202);
            Controls.Add(label2);
            Controls.Add(result);
            Controls.Add(label1);
            Controls.Add(new_calc);
            Controls.Add(start_button);
            Controls.Add(second_input);
            Controls.Add(first_input);
            Controls.Add(second_label);
            Controls.Add(first_label);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label first_label;
        private Label second_label;
        private TextBox first_input;
        private TextBox second_input;
        private Button start_button;
        private Button new_calc;
        private Label label1;
        private Label result;
        private Label label2;
    }
}