namespace CodeWheelApp
{
    partial class UserControlDecoderDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBoxOuterWheel = new TextBox();
            label4 = new Label();
            textBoxMidWheel = new TextBox();
            label3 = new Label();
            textBoxInnerWheel = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBoxOuterWheel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxMidWheel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxInnerWheel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBoxOuterWheel
            // 
            textBoxOuterWheel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOuterWheel.Location = new Point(80, 80);
            textBoxOuterWheel.Name = "textBoxOuterWheel";
            textBoxOuterWheel.ReadOnly = true;
            textBoxOuterWheel.Size = new Size(135, 23);
            textBoxOuterWheel.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 83);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 11;
            label4.Text = "Outer Value";
            // 
            // textBoxMidWheel
            // 
            textBoxMidWheel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMidWheel.Location = new Point(80, 51);
            textBoxMidWheel.Name = "textBoxMidWheel";
            textBoxMidWheel.ReadOnly = true;
            textBoxMidWheel.Size = new Size(135, 23);
            textBoxMidWheel.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 54);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 9;
            label3.Text = "Mid Value";
            // 
            // textBoxInnerWheel
            // 
            textBoxInnerWheel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInnerWheel.Location = new Point(80, 22);
            textBoxInnerWheel.Name = "textBoxInnerWheel";
            textBoxInnerWheel.ReadOnly = true;
            textBoxInnerWheel.Size = new Size(135, 23);
            textBoxInnerWheel.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 7;
            label1.Text = "Inner Value";
            // 
            // UserControlDecoderDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "UserControlDecoderDisplay";
            Size = new Size(227, 132);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxOuterWheel;
        private Label label4;
        private TextBox textBoxMidWheel;
        private Label label3;
        private TextBox textBoxInnerWheel;
        private Label label1;
    }
}
