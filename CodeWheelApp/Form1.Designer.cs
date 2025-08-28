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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            userControlInnerCodeWheel1 = new UserControlCodeWheel();
            label1 = new Label();
            textBox1 = new TextBox();
            buttonTurnLeft = new Button();
            buttonTurnRight = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // userControlInnerCodeWheel1
            // 
            userControlInnerCodeWheel1.BackColor = Color.Transparent;
            userControlInnerCodeWheel1.Location = new Point(184, 130);
            userControlInnerCodeWheel1.Name = "userControlInnerCodeWheel1";
            userControlInnerCodeWheel1.Size = new Size(480, 480);
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
            // textBox1
            // 
            textBox1.Location = new Point(77, 22);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 2;
            // 
            // buttonTurnLeft
            // 
            buttonTurnLeft.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnLeft.Location = new Point(38, 22);
            buttonTurnLeft.Name = "buttonTurnLeft";
            buttonTurnLeft.Size = new Size(75, 58);
            buttonTurnLeft.TabIndex = 3;
            buttonTurnLeft.Text = "<<";
            buttonTurnLeft.UseVisualStyleBackColor = true;
            buttonTurnLeft.Click += buttonTurnLeft_Click;
            // 
            // buttonTurnRight
            // 
            buttonTurnRight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            buttonTurnRight.Location = new Point(119, 22);
            buttonTurnRight.Name = "buttonTurnRight";
            buttonTurnRight.Size = new Size(75, 58);
            buttonTurnRight.TabIndex = 4;
            buttonTurnRight.Text = ">>";
            buttonTurnRight.UseVisualStyleBackColor = true;
            buttonTurnRight.Click += buttonTurnRight_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 186);
            label2.Location = new Point(339, 717);
            label2.Name = "label2";
            label2.Size = new Size(153, 45);
            label2.TabIndex = 5;
            label2.Text = "|             |";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(788, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 130);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonTurnLeft);
            groupBox2.Controls.Add(buttonTurnRight);
            groupBox2.Location = new Point(788, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 614);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 774);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(userControlInnerCodeWheel1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControlCodeWheel userControlInnerCodeWheel1;
        private Label label1;
        private TextBox textBox1;
        private Button buttonTurnLeft;
        private Button buttonTurnRight;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
