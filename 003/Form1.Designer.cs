namespace _003
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
            list = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 0;
            label1.Text = "Informe um Número:";
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            input.Location = new Point(17, 38);
            input.Name = "input";
            input.Size = new Size(199, 32);
            input.TabIndex = 1;
            // 
            // execute
            // 
            execute.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            execute.Location = new Point(222, 37);
            execute.Name = "execute";
            execute.Size = new Size(115, 32);
            execute.TabIndex = 2;
            execute.Text = "Executar";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // list
            // 
            list.FormattingEnabled = true;
            list.ItemHeight = 15;
            list.Location = new Point(18, 88);
            list.Name = "list";
            list.Size = new Size(319, 94);
            list.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 194);
            Controls.Add(list);
            Controls.Add(execute);
            Controls.Add(input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Double";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input;
        private Button execute;
        private ListBox list;
    }
}