namespace CatchButton
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
            Catchbutton = new Button();
            SuspendLayout();
            // 
            // Catchbutton
            // 
            Catchbutton.Font = new Font("맑은 고딕", 15F);
            Catchbutton.Location = new Point(248, 138);
            Catchbutton.Name = "Catchbutton";
            Catchbutton.Size = new Size(210, 80);
            Catchbutton.TabIndex = 0;
            Catchbutton.Text = "나를 잡아봐";
            Catchbutton.UseVisualStyleBackColor = true;
            Catchbutton.Click += Catchbutton_Click;
            Catchbutton.MouseDown += Catchbutton_MouseDown;
            Catchbutton.MouseUp += Catchbutton_MouseUp;
            Catchbutton.MouseEnter += Catchbutton_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Catchbutton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Catchbutton;
    }
}
