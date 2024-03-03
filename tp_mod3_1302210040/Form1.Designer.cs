namespace tp_mod3_1302210040
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
            name = new TextBox();
            submit = new Button();
            output = new Label();
            nim = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 107);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "nama ";
            // 
            // name
            // 
            name.Location = new Point(369, 107);
            name.Name = "name";
            name.Size = new Size(191, 27);
            name.TabIndex = 1;
            // 
            // submit
            // 
            submit.Location = new Point(300, 205);
            submit.Name = "submit";
            submit.Size = new Size(196, 58);
            submit.TabIndex = 3;
            submit.Text = "submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += button2_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(369, 281);
            output.Name = "output";
            output.Size = new Size(50, 20);
            output.TabIndex = 5;
            output.Text = "label2";
            // 
            // nim
            // 
            nim.Location = new Point(369, 150);
            nim.Name = "nim";
            nim.Size = new Size(191, 27);
            nim.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 150);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 7;
            label2.Text = " nim";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(nim);
            Controls.Add(output);
            Controls.Add(submit);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private Button submit;
        private Button button3;
        private Label output;
        private TextBox nim;
        private Label label2;
    }
}