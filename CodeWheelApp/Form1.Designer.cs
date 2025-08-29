namespace CodeWheelApp
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
            userControlInnerCodeWheel1 = new UserControlCodeWheel();
            buttonTurnInnerLeft = new Button();
            buttonTurnInnerRight = new Button();
            groupBox2 = new GroupBox();
            buttonTurnOuterLeft = new Button();
            buttonTurnOuterRight = new Button();
            buttonTurnMidLeft = new Button();
            buttonTurnMidRight = new Button();
            groupBox3 = new GroupBox();
            buttonDmDisplay = new Button();
            userControlDecoderDisplayScroll2 = new UserControlDecoderDisplay();
            userControlDecoderDisplayScroll1 = new UserControlDecoderDisplay();
            buttonPrintPress2 = new Button();
            userControlScroll2 = new UserControlScroll();
            buttonPrintPress1 = new Button();
            userControlScroll1 = new UserControlScroll();
            userControlDecoderDisplayWheel = new UserControlDecoderDisplay();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // userControlInnerCodeWheel1
            // 
            userControlInnerCodeWheel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userControlInnerCodeWheel1.BackColor = Color.Transparent;
            userControlInnerCodeWheel1.Location = new Point(179, 34);
            userControlInnerCodeWheel1.Name = "userControlInnerCodeWheel1";
            userControlInnerCodeWheel1.Size = new Size(701, 668);
            userControlInnerCodeWheel1.TabIndex = 0;
            // 
            // buttonTurnInnerLeft
            // 
            buttonTurnInnerLeft.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnInnerLeft.Location = new Point(7, 14);
            buttonTurnInnerLeft.Name = "buttonTurnInnerLeft";
            buttonTurnInnerLeft.Size = new Size(88, 53);
            buttonTurnInnerLeft.TabIndex = 3;
            buttonTurnInnerLeft.Text = "<<";
            buttonTurnInnerLeft.UseVisualStyleBackColor = true;
            buttonTurnInnerLeft.Click += buttonTurnLeft_Click;
            // 
            // buttonTurnInnerRight
            // 
            buttonTurnInnerRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTurnInnerRight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnInnerRight.Location = new Point(89, 14);
            buttonTurnInnerRight.Name = "buttonTurnInnerRight";
            buttonTurnInnerRight.Size = new Size(88, 53);
            buttonTurnInnerRight.TabIndex = 4;
            buttonTurnInnerRight.Text = ">>";
            buttonTurnInnerRight.UseVisualStyleBackColor = true;
            buttonTurnInnerRight.Click += buttonTurnRight_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonTurnOuterLeft);
            groupBox2.Controls.Add(buttonTurnOuterRight);
            groupBox2.Controls.Add(buttonTurnMidLeft);
            groupBox2.Controls.Add(buttonTurnMidRight);
            groupBox2.Controls.Add(buttonTurnInnerLeft);
            groupBox2.Controls.Add(buttonTurnInnerRight);
            groupBox2.Location = new Point(6, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 191);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // buttonTurnOuterLeft
            // 
            buttonTurnOuterLeft.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnOuterLeft.Location = new Point(7, 132);
            buttonTurnOuterLeft.Name = "buttonTurnOuterLeft";
            buttonTurnOuterLeft.Size = new Size(88, 51);
            buttonTurnOuterLeft.TabIndex = 7;
            buttonTurnOuterLeft.Text = "<<";
            buttonTurnOuterLeft.UseVisualStyleBackColor = true;
            buttonTurnOuterLeft.Click += buttonTurnOuterLeft_Click;
            // 
            // buttonTurnOuterRight
            // 
            buttonTurnOuterRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTurnOuterRight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnOuterRight.Location = new Point(89, 132);
            buttonTurnOuterRight.Name = "buttonTurnOuterRight";
            buttonTurnOuterRight.Size = new Size(87, 51);
            buttonTurnOuterRight.TabIndex = 8;
            buttonTurnOuterRight.Text = ">>";
            buttonTurnOuterRight.UseVisualStyleBackColor = true;
            buttonTurnOuterRight.Click += buttonTurnOuterRight_Click;
            // 
            // buttonTurnMidLeft
            // 
            buttonTurnMidLeft.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnMidLeft.Location = new Point(6, 73);
            buttonTurnMidLeft.Name = "buttonTurnMidLeft";
            buttonTurnMidLeft.Size = new Size(89, 53);
            buttonTurnMidLeft.TabIndex = 5;
            buttonTurnMidLeft.Text = "<<";
            buttonTurnMidLeft.UseVisualStyleBackColor = true;
            buttonTurnMidLeft.Click += buttonTurnMidLeft_Click;
            // 
            // buttonTurnMidRight
            // 
            buttonTurnMidRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTurnMidRight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnMidRight.Location = new Point(89, 73);
            buttonTurnMidRight.Name = "buttonTurnMidRight";
            buttonTurnMidRight.Size = new Size(87, 53);
            buttonTurnMidRight.TabIndex = 6;
            buttonTurnMidRight.Text = ">>";
            buttonTurnMidRight.UseVisualStyleBackColor = true;
            buttonTurnMidRight.Click += buttonTurnMidRight_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(buttonDmDisplay);
            groupBox3.Controls.Add(userControlDecoderDisplayScroll2);
            groupBox3.Controls.Add(userControlDecoderDisplayScroll1);
            groupBox3.Controls.Add(buttonPrintPress2);
            groupBox3.Controls.Add(userControlScroll2);
            groupBox3.Controls.Add(buttonPrintPress1);
            groupBox3.Controls.Add(userControlScroll1);
            groupBox3.Location = new Point(878, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(494, 848);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Scrolls";
            // 
            // buttonDmDisplay
            // 
            buttonDmDisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDmDisplay.Location = new Point(413, 802);
            buttonDmDisplay.Name = "buttonDmDisplay";
            buttonDmDisplay.Size = new Size(75, 40);
            buttonDmDisplay.TabIndex = 6;
            buttonDmDisplay.Text = "Dm";
            buttonDmDisplay.UseVisualStyleBackColor = true;
            buttonDmDisplay.Click += buttonDmDisplay_Click;
            // 
            // userControlDecoderDisplayScroll2
            // 
            userControlDecoderDisplayScroll2.DisplayText = "Scroll 2 Translation";
            userControlDecoderDisplayScroll2.Location = new Point(6, 484);
            userControlDecoderDisplayScroll2.Name = "userControlDecoderDisplayScroll2";
            userControlDecoderDisplayScroll2.Size = new Size(215, 132);
            userControlDecoderDisplayScroll2.TabIndex = 5;
            userControlDecoderDisplayScroll2.Visible = false;
            // 
            // userControlDecoderDisplayScroll1
            // 
            userControlDecoderDisplayScroll1.DisplayText = "Scroll 1 Translation";
            userControlDecoderDisplayScroll1.Location = new Point(6, 101);
            userControlDecoderDisplayScroll1.Name = "userControlDecoderDisplayScroll1";
            userControlDecoderDisplayScroll1.Size = new Size(215, 132);
            userControlDecoderDisplayScroll1.TabIndex = 4;
            userControlDecoderDisplayScroll1.Visible = false;
            // 
            // buttonPrintPress2
            // 
            buttonPrintPress2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            buttonPrintPress2.Location = new Point(6, 408);
            buttonPrintPress2.Name = "buttonPrintPress2";
            buttonPrintPress2.Size = new Size(215, 70);
            buttonPrintPress2.TabIndex = 3;
            buttonPrintPress2.Text = "PRESS";
            buttonPrintPress2.UseVisualStyleBackColor = true;
            buttonPrintPress2.Click += buttonPrintPress2_Click;
            // 
            // userControlScroll2
            // 
            userControlScroll2.Location = new Point(229, 408);
            userControlScroll2.Name = "userControlScroll2";
            userControlScroll2.Size = new Size(265, 352);
            userControlScroll2.TabIndex = 2;
            // 
            // buttonPrintPress1
            // 
            buttonPrintPress1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            buttonPrintPress1.Location = new Point(6, 25);
            buttonPrintPress1.Name = "buttonPrintPress1";
            buttonPrintPress1.Size = new Size(215, 70);
            buttonPrintPress1.TabIndex = 1;
            buttonPrintPress1.Text = "PRESS";
            buttonPrintPress1.UseVisualStyleBackColor = true;
            buttonPrintPress1.Click += buttonPrintPress_Click;
            // 
            // userControlScroll1
            // 
            userControlScroll1.Location = new Point(229, 22);
            userControlScroll1.Name = "userControlScroll1";
            userControlScroll1.Size = new Size(265, 352);
            userControlScroll1.TabIndex = 0;
            // 
            // userControlDecoderDisplayWheel
            // 
            userControlDecoderDisplayWheel.DisplayText = "Wheel Translation";
            userControlDecoderDisplayWheel.Location = new Point(6, 222);
            userControlDecoderDisplayWheel.Name = "userControlDecoderDisplayWheel";
            userControlDecoderDisplayWheel.Size = new Size(186, 132);
            userControlDecoderDisplayWheel.TabIndex = 9;
            userControlDecoderDisplayWheel.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(userControlDecoderDisplayWheel);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(userControlInnerCodeWheel1);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(860, 848);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Wheel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 875);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Gnome Wheel Puzzle";
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UserControlCodeWheel userControlInnerCodeWheel1;
        private Button buttonTurnInnerLeft;
        private Button buttonTurnInnerRight;
        private GroupBox groupBox2;
        private Button buttonTurnOuterLeft;
        private Button buttonTurnOuterRight;
        private Button buttonTurnMidLeft;
        private Button buttonTurnMidRight;
        private GroupBox groupBox3;
        private UserControlScroll userControlScroll1;
        private Button buttonPrintPress1;
        private Button buttonPrintPress2;
        private UserControlScroll userControlScroll2;
        private UserControlDecoderDisplay userControlDecoderDisplayScroll2;
        private UserControlDecoderDisplay userControlDecoderDisplayScroll1;
        private UserControlDecoderDisplay userControlDecoderDisplayWheel;
        private GroupBox groupBox1;
        private Button buttonDmDisplay;
    }
}
