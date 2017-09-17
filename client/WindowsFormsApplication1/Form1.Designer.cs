namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_up = new System.Windows.Forms.PictureBox();
            this.pictureBox_down = new System.Windows.Forms.PictureBox();
            this.pictureBox_right = new System.Windows.Forms.PictureBox();
            this.pictureBox_left = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label_connect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(93, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // pictureBox_up
            // 
            this.pictureBox_up.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_up.Location = new System.Drawing.Point(38, 15);
            this.pictureBox_up.Name = "pictureBox_up";
            this.pictureBox_up.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_up.TabIndex = 1;
            this.pictureBox_up.TabStop = false;
            // 
            // pictureBox_down
            // 
            this.pictureBox_down.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_down.Location = new System.Drawing.Point(38, 41);
            this.pictureBox_down.Name = "pictureBox_down";
            this.pictureBox_down.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_down.TabIndex = 2;
            this.pictureBox_down.TabStop = false;
            // 
            // pictureBox_right
            // 
            this.pictureBox_right.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_right.Location = new System.Drawing.Point(64, 41);
            this.pictureBox_right.Name = "pictureBox_right";
            this.pictureBox_right.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_right.TabIndex = 3;
            this.pictureBox_right.TabStop = false;
            // 
            // pictureBox_left
            // 
            this.pictureBox_left.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_left.Location = new System.Drawing.Point(12, 41);
            this.pictureBox_left.Name = "pictureBox_left";
            this.pictureBox_left.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_left.TabIndex = 4;
            this.pictureBox_left.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(93, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label_connect
            // 
            this.label_connect.AutoSize = true;
            this.label_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_connect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_connect.Location = new System.Drawing.Point(117, 47);
            this.label_connect.Name = "label_connect";
            this.label_connect.Size = new System.Drawing.Size(103, 13);
            this.label_connect.TabIndex = 7;
            this.label_connect.Text = "waiting to connect...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(235, 66);
            this.Controls.Add(this.label_connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_left);
            this.Controls.Add(this.pictureBox_right);
            this.Controls.Add(this.pictureBox_down);
            this.Controls.Add(this.pictureBox_up);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Car client";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_up;
        private System.Windows.Forms.PictureBox pictureBox_down;
        private System.Windows.Forms.PictureBox pictureBox_right;
        private System.Windows.Forms.PictureBox pictureBox_left;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_connect;
    }
}

