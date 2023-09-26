namespace _016
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
            list = new ListBox();
            cleaner = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Broas";
            // 
            // input1
            // 
            input1.Location = new Point(11, 38);
            input1.Name = "input1";
            input1.Size = new Size(237, 23);
            input1.TabIndex = 1;
            // 
            // input2
            // 
            input2.Location = new Point(11, 87);
            input2.Name = "input2";
            input2.Size = new Size(237, 23);
            input2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Pães";
            // 
            // execute
            // 
            execute.Location = new Point(281, 35);
            execute.Name = "execute";
            execute.Size = new Size(137, 75);
            execute.TabIndex = 4;
            execute.Text = "Calcular";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // list
            // 
            list.FormattingEnabled = true;
            list.ItemHeight = 15;
            list.Location = new Point(13, 123);
            list.Name = "list";
            list.Size = new Size(235, 94);
            list.TabIndex = 5;
            // 
            // cleaner
            // 
            cleaner.Location = new Point(281, 123);
            cleaner.Name = "cleaner";
            cleaner.Size = new Size(137, 94);
            cleaner.TabIndex = 6;
            cleaner.Text = "Limpar";
            cleaner.UseVisualStyleBackColor = true;
            cleaner.Click += cleaner_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 230);
            Controls.Add(cleaner);
            Controls.Add(list);
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
        private ListBox list;
        private Button cleaner;
    }
}