namespace FileCompare
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
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            btnCopyFromLeft = new Button();
            txtLeftDir = new TextBox();
            panel3 = new Panel();
            lvwLeftDir = new ListView();
            panel1 = new Panel();
            btnLeftDir = new Button();
            lblAppName = new Label();
            panel6 = new Panel();
            txtRightDir = new TextBox();
            btnCopyFromRight = new Button();
            panel5 = new Panel();
            btnRightDir = new Button();
            panel4 = new Panel();
            lvwRightDir = new ListView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(10, 10);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Size = new Size(987, 436);
            splitContainer1.SplitterDistance = 493;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCopyFromLeft);
            panel2.Controls.Add(txtLeftDir);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 41);
            panel2.TabIndex = 2;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromLeft.Location = new Point(401, 6);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(89, 29);
            btnCopyFromLeft.TabIndex = 6;
            btnCopyFromLeft.Text = "폴더선택";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Location = new Point(3, 6);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(385, 27);
            txtLeftDir.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(lvwLeftDir);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(493, 331);
            panel3.TabIndex = 3;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Dock = DockStyle.Fill;
            lvwLeftDir.Location = new Point(0, 0);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(493, 331);
            lvwLeftDir.TabIndex = 1;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLeftDir);
            panel1.Controls.Add(lblAppName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 64);
            panel1.TabIndex = 0;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLeftDir.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            btnLeftDir.Location = new Point(397, 19);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(86, 35);
            btnLeftDir.TabIndex = 1;
            btnLeftDir.Text = ">>>";
            btnLeftDir.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("맑은 고딕", 20F, FontStyle.Bold);
            lblAppName.Location = new Point(3, 5);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(258, 54);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Compare";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtRightDir);
            panel6.Controls.Add(btnCopyFromRight);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 64);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(490, 41);
            panel6.TabIndex = 2;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Location = new Point(4, 7);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(385, 27);
            txtRightDir.TabIndex = 5;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromRight.Location = new Point(395, 6);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(89, 29);
            btnCopyFromRight.TabIndex = 4;
            btnCopyFromRight.Text = "폴더선택";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRightDir);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(490, 64);
            panel5.TabIndex = 1;
            // 
            // btnRightDir
            // 
            btnRightDir.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            btnRightDir.Location = new Point(13, 19);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(86, 35);
            btnRightDir.TabIndex = 2;
            btnRightDir.Text = "<<<";
            btnRightDir.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(lvwRightDir);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(490, 331);
            panel4.TabIndex = 3;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Dock = DockStyle.Fill;
            lvwRightDir.Location = new Point(0, 0);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(490, 331);
            lvwRightDir.TabIndex = 1;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 456);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Padding = new Padding(10);
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label lblAppName;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnLeftDir;
        private Button btnCopyFromRight;
        private Button btnRightDir;
        private TextBox txtRightDir;
        private ListView lvwRightDir;
        private Panel panel2;
        private Panel panel3;
        private Button btnCopyFromLeft;
        private TextBox txtLeftDir;
        private ListView lvwLeftDir;
    }
}
