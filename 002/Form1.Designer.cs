namespace _002
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
            label2 = new Label();
            label3 = new Label();
            before = new Label();
            after = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "Insira um Número:";
            // 
            // input
            // 
            input.Location = new Point(19, 51);
            input.Name = "input";
            input.Size = new Size(252, 23);
            input.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 85);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Antecessor";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 113);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Sucessor";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // before
            // 
            before.AutoSize = true;
            before.Location = new Point(91, 85);
            before.Name = "before";
            before.Size = new Size(0, 15);
            before.TabIndex = 4;
            // 
            // after
            // 
            after.AutoSize = true;
            after.Location = new Point(81, 113);
            after.Name = "after";
            after.Size = new Size(0, 15);
            after.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(16, 142);
            button1.Name = "button1";
            button1.Size = new Size(255, 34);
            button1.TabIndex = 6;
            button1.Text = "Executar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 188);
            Controls.Add(button1);
            Controls.Add(after);
            Controls.Add(before);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Antecessor/Sucessor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input;
        private Label label2;
        private Label label3;
        private Label before;
        private Label after;
        private Button button1;
    }
}