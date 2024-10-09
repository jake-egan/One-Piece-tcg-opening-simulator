namespace card_simulator
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
            card = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)card).BeginInit();
            SuspendLayout();
            // 
            // card
            // 
            card.Location = new Point(12, 34);
            card.Name = "card";
            card.Size = new Size(364, 484);
            card.SizeMode = PictureBoxSizeMode.StretchImage;
            card.TabIndex = 0;
            card.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(132, 547);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 1;
            button1.Text = "OPEN NEW PACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 582);
            Controls.Add(button1);
            Controls.Add(card);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)card).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox card;
        private Button button1;
    }
}
