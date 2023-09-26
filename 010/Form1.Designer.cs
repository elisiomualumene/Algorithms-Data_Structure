namespace _010
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
            list = new ListBox();
            execute = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 0;
            label1.Text = "Informe um Angulo";
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            input.Location = new Point(12, 47);
            input.Name = "input";
            input.Size = new Size(257, 32);
            input.TabIndex = 1;
            // 
            // list
            // 
            list.FormattingEnabled = true;
            list.ItemHeight = 15;
            list.Location = new Point(11, 92);
            list.Name = "list";
            list.Size = new Size(258, 124);
            list.TabIndex = 2;
            // 
            // execute
            // 
            execute.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            execute.Location = new Point(275, 47);
            execute.Name = "execute";
            execute.RightToLeft = RightToLeft.Yes;
            execute.Size = new Size(94, 169);
            execute.TabIndex = 3;
            execute.Text = "Calcular";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 238);
            Controls.Add(execute);
            Controls.Add(list);
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
        private ListBox list;
        private Button execute;
    }
}