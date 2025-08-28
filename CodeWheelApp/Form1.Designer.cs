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
            label1 = new Label();
            textBoxInnerWheel = new TextBox();
            buttonTurnInnerLeft = new Button();
            buttonTurnInnerRight = new Button();
            groupBox1 = new GroupBox();
            textBoxOuterWheel = new TextBox();
            label4 = new Label();
            textBoxMidWheel = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            buttonTurnOuterLeft = new Button();
            buttonTurnOuterRight = new Button();
            buttonTurnMidLeft = new Button();
            buttonTurnMidRight = new Button();
            groupBox3 = new GroupBox();
            userControlScroll1 = new UserControlScroll();
            buttonPrintPress = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // userControlInnerCodeWheel1
            // 
            userControlInnerCodeWheel1.BackColor = Color.Transparent;
            userControlInnerCodeWheel1.Location = new Point(34, 12);
            userControlInnerCodeWheel1.Name = "userControlInnerCodeWheel1";
            userControlInnerCodeWheel1.Size = new Size(796, 750);
            userControlInnerCodeWheel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Inner Value";
            // 
            // textBoxInnerWheel
            // 
            textBoxInnerWheel.Location = new Point(77, 22);
            textBoxInnerWheel.Name = "textBoxInnerWheel";
            textBoxInnerWheel.ReadOnly = true;
            textBoxInnerWheel.Size = new Size(179, 23);
            textBoxInnerWheel.TabIndex = 2;
            // 
            // buttonTurnInnerLeft
            // 
            buttonTurnInnerLeft.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnInnerLeft.Location = new Point(38, 22);
            buttonTurnInnerLeft.Name = "buttonTurnInnerLeft";
            buttonTurnInnerLeft.Size = new Size(75, 58);
            buttonTurnInnerLeft.TabIndex = 3;
            buttonTurnInnerLeft.Text = "<<";
            buttonTurnInnerLeft.UseVisualStyleBackColor = true;
            buttonTurnInnerLeft.Click += buttonTurnLeft_Click;
            // 
            // buttonTurnInnerRight
            // 
            buttonTurnInnerRight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnInnerRight.Location = new Point(119, 22);
            buttonTurnInnerRight.Name = "buttonTurnInnerRight";
            buttonTurnInnerRight.Size = new Size(75, 58);
            buttonTurnInnerRight.TabIndex = 4;
            buttonTurnInnerRight.Text = ">>";
            buttonTurnInnerRight.UseVisualStyleBackColor = true;
            buttonTurnInnerRight.Click += buttonTurnRight_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(textBoxOuterWheel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxMidWheel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxInnerWheel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1119, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 130);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // textBoxOuterWheel
            // 
            textBoxOuterWheel.Location = new Point(77, 80);
            textBoxOuterWheel.Name = "textBoxOuterWheel";
            textBoxOuterWheel.ReadOnly = true;
            textBoxOuterWheel.Size = new Size(179, 23);
            textBoxOuterWheel.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 5;
            label4.Text = "Outer Value";
            // 
            // textBoxMidWheel
            // 
            textBoxMidWheel.Location = new Point(77, 51);
            textBoxMidWheel.Name = "textBoxMidWheel";
            textBoxMidWheel.ReadOnly = true;
            textBoxMidWheel.Size = new Size(179, 23);
            textBoxMidWheel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 3;
            label3.Text = "Mid Value";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(buttonTurnOuterLeft);
            groupBox2.Controls.Add(buttonTurnOuterRight);
            groupBox2.Controls.Add(buttonTurnMidLeft);
            groupBox2.Controls.Add(buttonTurnMidRight);
            groupBox2.Controls.Add(buttonTurnInnerLeft);
            groupBox2.Controls.Add(buttonTurnInnerRight);
            groupBox2.Location = new Point(1119, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 611);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // buttonTurnOuterLeft
            // 
            buttonTurnOuterLeft.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnOuterLeft.Location = new Point(38, 150);
            buttonTurnOuterLeft.Name = "buttonTurnOuterLeft";
            buttonTurnOuterLeft.Size = new Size(75, 58);
            buttonTurnOuterLeft.TabIndex = 7;
            buttonTurnOuterLeft.Text = "<<";
            buttonTurnOuterLeft.UseVisualStyleBackColor = true;
            buttonTurnOuterLeft.Click += buttonTurnOuterLeft_Click;
            // 
            // buttonTurnOuterRight
            // 
            buttonTurnOuterRight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnOuterRight.Location = new Point(119, 150);
            buttonTurnOuterRight.Name = "buttonTurnOuterRight";
            buttonTurnOuterRight.Size = new Size(75, 58);
            buttonTurnOuterRight.TabIndex = 8;
            buttonTurnOuterRight.Text = ">>";
            buttonTurnOuterRight.UseVisualStyleBackColor = true;
            buttonTurnOuterRight.Click += buttonTurnOuterRight_Click;
            // 
            // buttonTurnMidLeft
            // 
            buttonTurnMidLeft.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnMidLeft.Location = new Point(38, 86);
            buttonTurnMidLeft.Name = "buttonTurnMidLeft";
            buttonTurnMidLeft.Size = new Size(75, 58);
            buttonTurnMidLeft.TabIndex = 5;
            buttonTurnMidLeft.Text = "<<";
            buttonTurnMidLeft.UseVisualStyleBackColor = true;
            buttonTurnMidLeft.Click += buttonTurnMidLeft_Click;
            // 
            // buttonTurnMidRight
            // 
            buttonTurnMidRight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnMidRight.Location = new Point(119, 86);
            buttonTurnMidRight.Name = "buttonTurnMidRight";
            buttonTurnMidRight.Size = new Size(75, 58);
            buttonTurnMidRight.TabIndex = 6;
            buttonTurnMidRight.Text = ">>";
            buttonTurnMidRight.UseVisualStyleBackColor = true;
            buttonTurnMidRight.Click += buttonTurnMidRight_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(userControlScroll1);
            groupBox3.Location = new Point(836, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(277, 747);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // userControlScroll1
            // 
            userControlScroll1.Location = new Point(6, 19);
            userControlScroll1.Name = "userControlScroll1";
            userControlScroll1.Size = new Size(265, 352);
            userControlScroll1.TabIndex = 0;
            // 
            // buttonPrintPress
            // 
            buttonPrintPress.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 186);
            buttonPrintPress.Location = new Point(688, 33);
            buttonPrintPress.Name = "buttonPrintPress";
            buttonPrintPress.Size = new Size(132, 70);
            buttonPrintPress.TabIndex = 1;
            buttonPrintPress.Text = "PRESS";
            buttonPrintPress.UseVisualStyleBackColor = true;
            buttonPrintPress.Click += buttonPrintPress_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 774);
            Controls.Add(buttonPrintPress);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(userControlInnerCodeWheel1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UserControlCodeWheel userControlInnerCodeWheel1;
        private Label label1;
        private TextBox textBoxInnerWheel;
        private Button buttonTurnInnerLeft;
        private Button buttonTurnInnerRight;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxOuterWheel;
        private Label label4;
        private TextBox textBoxMidWheel;
        private Label label3;
        private Button buttonTurnOuterLeft;
        private Button buttonTurnOuterRight;
        private Button buttonTurnMidLeft;
        private Button buttonTurnMidRight;
        private GroupBox groupBox3;
        private UserControlScroll userControlScroll1;
        private Button buttonPrintPress;
    }
}
