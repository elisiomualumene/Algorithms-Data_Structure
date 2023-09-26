namespace _019
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
            value = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 0;
            label1.Text = "Peso do Prato Montado";
            // 
            // input
            // 
            input.Location = new Point(14, 38);
            input.Name = "input";
            input.Size = new Size(210, 23);
            input.TabIndex = 1;
            // 
            // execute
            // 
            execute.Location = new Point(14, 167);
            execute.Name = "execute";
            execute.Size = new Size(210, 23);
            execute.TabIndex = 2;
            execute.Text = "Executar";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // value
            // 
            value.AutoSize = true;
            value.Location = new Point(14, 75);
            value.Name = "value";
            value.Size = new Size(0, 15);
            value.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 248);
            Controls.Add(value);
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
        private Label value;
    }
}