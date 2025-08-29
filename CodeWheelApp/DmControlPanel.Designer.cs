namespace CodeWheelApp
{
    partial class DmControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userControlDecoderDisplayWheel = new UserControlDecoderDisplay();
            userControlDecoderDisplayScroll1 = new UserControlDecoderDisplay();
            userControlDecoderDisplayScroll2 = new UserControlDecoderDisplay();
            buttonToggleTranslation = new Button();
            SuspendLayout();
            // 
            // userControlDecoderDisplayWheel
            // 
            userControlDecoderDisplayWheel.DisplayText = "Wheel Translation";
            userControlDecoderDisplayWheel.Location = new Point(12, 12);
            userControlDecoderDisplayWheel.Name = "userControlDecoderDisplayWheel";
            userControlDecoderDisplayWheel.Size = new Size(227, 132);
            userControlDecoderDisplayWheel.TabIndex = 0;
            // 
            // userControlDecoderDisplayScroll1
            // 
            userControlDecoderDisplayScroll1.DisplayText = "Scroll 1";
            userControlDecoderDisplayScroll1.Location = new Point(12, 150);
            userControlDecoderDisplayScroll1.Name = "userControlDecoderDisplayScroll1";
            userControlDecoderDisplayScroll1.Size = new Size(227, 132);
            userControlDecoderDisplayScroll1.TabIndex = 1;
            // 
            // userControlDecoderDisplayScroll2
            // 
            userControlDecoderDisplayScroll2.DisplayText = "Scroll 2";
            userControlDecoderDisplayScroll2.Location = new Point(12, 288);
            userControlDecoderDisplayScroll2.Name = "userControlDecoderDisplayScroll2";
            userControlDecoderDisplayScroll2.Size = new Size(227, 132);
            userControlDecoderDisplayScroll2.TabIndex = 2;
            // 
            // buttonToggleTranslation
            // 
            buttonToggleTranslation.Location = new Point(12, 426);
            buttonToggleTranslation.Name = "buttonToggleTranslation";
            buttonToggleTranslation.Size = new Size(227, 65);
            buttonToggleTranslation.TabIndex = 3;
            buttonToggleTranslation.Text = "TOGGLE TRANSLATION";
            buttonToggleTranslation.UseVisualStyleBackColor = true;
            buttonToggleTranslation.Click += buttonToggleTranslation_Click;
            // 
            // DmControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 516);
            Controls.Add(buttonToggleTranslation);
            Controls.Add(userControlDecoderDisplayScroll2);
            Controls.Add(userControlDecoderDisplayScroll1);
            Controls.Add(userControlDecoderDisplayWheel);
            Name = "DmControlPanel";
            Text = "DmControlPanel";
            FormClosing += DmControlPanel_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private UserControlDecoderDisplay userControlDecoderDisplayWheel;
        private UserControlDecoderDisplay userControlDecoderDisplayScroll1;
        private UserControlDecoderDisplay userControlDecoderDisplayScroll2;
        private Button buttonToggleTranslation;
    }
}