namespace _013
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
            date = new DateTimePicker();
            label1 = new Label();
            list = new ListBox();
            execute = new Button();
            cleaner = new Button();
            SuspendLayout();
            // 
            // date
            // 
            date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(12, 36);
            date.Name = "date";
            date.Size = new Size(374, 29);
            date.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Informe a data";
            // 
            // list
            // 
            list.FormattingEnabled = true;
            list.ItemHeight = 15;
            list.Location = new Point(14, 79);
            list.Name = "list";
            list.Size = new Size(378, 79);
            list.TabIndex = 2;
            // 
            // execute
            // 
            execute.Location = new Point(12, 164);
            execute.Name = "execute";
            execute.Size = new Size(159, 36);
            execute.TabIndex = 3;
            execute.Text = "Executar";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // cleaner
            // 
            cleaner.Location = new Point(233, 164);
            cleaner.Name = "cleaner";
            cleaner.Size = new Size(159, 36);
            cleaner.TabIndex = 4;
            cleaner.Text = "Limpar";
            cleaner.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 218);
            Controls.Add(cleaner);
            Controls.Add(execute);
            Controls.Add(list);
            Controls.Add(label1);
            Controls.Add(date);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker date;
        private Label label1;
        private ListBox list;
        private Button execute;
        private Button cleaner;
    }
}