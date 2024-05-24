namespace WinFormsApp2
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
            panel1 = new Panel();
            Paint_btn = new Button();
            m_pb = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)m_pb).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(Paint_btn);
            panel1.Location = new Point(796, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 571);
            panel1.TabIndex = 0;
            // 
            // Paint_btn
            // 
            Paint_btn.Cursor = Cursors.IBeam;
            Paint_btn.Location = new Point(12, 3);
            Paint_btn.Name = "Paint_btn";
            Paint_btn.Size = new Size(94, 76);
            Paint_btn.TabIndex = 0;
            Paint_btn.Text = "Paint";
            Paint_btn.UseVisualStyleBackColor = true;
            Paint_btn.Click += Paint_btn_Click;
            // 
            // m_pb
            // 
            m_pb.Location = new Point(1, 3);
            m_pb.Name = "m_pb";
            m_pb.Size = new Size(801, 568);
            m_pb.SizeMode = PictureBoxSizeMode.Zoom;
            m_pb.TabIndex = 1;
            m_pb.TabStop = false;
            m_pb.Click += m_pb_Click;
            m_pb.MouseDown += m_pb_MouseDown;
            m_pb.MouseMove += m_pb_MouseMove;
            m_pb.MouseUp += m_pb_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 571);
            Controls.Add(m_pb);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)m_pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox m_pb;
        private Button Paint_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
