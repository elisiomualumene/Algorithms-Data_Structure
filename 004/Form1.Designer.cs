namespace _004
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(237, 21);
            label1.TabIndex = 0;
            label1.Text = "Insira uma médida em metros";
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input.Location = new Point(12, 42);
            input.Name = "input";
            input.Size = new Size(290, 29);
            input.TabIndex = 1;
            // 
            // list
            // 
            list.FormattingEnabled = true;
            list.ItemHeight = 15;
            list.Location = new Point(10, 79);
            list.Name = "list";
            list.Size = new Size(292, 124);
            list.TabIndex = 2;
            // 
            // execute
            // 
            execute.Location = new Point(308, 42);
            execute.Name = "execute";
            execute.Size = new Size(75, 161);
            execute.TabIndex = 3;
            execute.Text = "Executar";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 229);
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