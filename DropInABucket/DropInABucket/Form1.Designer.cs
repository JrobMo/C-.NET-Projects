namespace DropInABucket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.changeColourDialogue = new System.Windows.Forms.ColorDialog();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackLabel = new System.Windows.Forms.Label();
            this.interLabel = new System.Windows.Forms.Label();
            this.bucketPanel = new System.Windows.Forms.Panel();
            this.spigotPanel = new System.Windows.Forms.PictureBox();
            this.colourButton = new System.Windows.Forms.Button();
            this.theTimer = new System.Windows.Forms.Timer(this.components);
            this.fillTrack = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spigotPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(746, 977);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(169, 76);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackLabel);
            this.panel1.Controls.Add(this.interLabel);
            this.panel1.Controls.Add(this.bucketPanel);
            this.panel1.Controls.Add(this.spigotPanel);
            this.panel1.Location = new System.Drawing.Point(20, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 849);
            this.panel1.TabIndex = 3;
            // 
            // trackLabel
            // 
            this.trackLabel.AutoSize = true;
            this.trackLabel.Location = new System.Drawing.Point(602, 155);
            this.trackLabel.Name = "trackLabel";
            this.trackLabel.Size = new System.Drawing.Size(120, 25);
            this.trackLabel.TabIndex = 4;
            this.trackLabel.Text = "flowControl :";
            // 
            // interLabel
            // 
            this.interLabel.AutoSize = true;
            this.interLabel.Location = new System.Drawing.Point(602, 99);
            this.interLabel.Name = "interLabel";
            this.interLabel.Size = new System.Drawing.Size(97, 25);
            this.interLabel.TabIndex = 3;
            this.interLabel.Text = "flowRate :";
            // 
            // bucketPanel
            // 
            this.bucketPanel.Location = new System.Drawing.Point(152, 257);
            this.bucketPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bucketPanel.Name = "bucketPanel";
            this.bucketPanel.Size = new System.Drawing.Size(240, 592);
            this.bucketPanel.TabIndex = 2;
            this.bucketPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BucketPanel_Paint);
            // 
            // spigotPanel
            // 
            this.spigotPanel.ErrorImage = ((System.Drawing.Image)(resources.GetObject("spigotPanel.ErrorImage")));
            this.spigotPanel.InitialImage = ((System.Drawing.Image)(resources.GetObject("spigotPanel.InitialImage")));
            this.spigotPanel.Location = new System.Drawing.Point(0, 0);
            this.spigotPanel.Margin = new System.Windows.Forms.Padding(4);
            this.spigotPanel.Name = "spigotPanel";
            this.spigotPanel.Size = new System.Drawing.Size(249, 257);
            this.spigotPanel.TabIndex = 0;
            this.spigotPanel.TabStop = false;
            // 
            // colourButton
            // 
            this.colourButton.Location = new System.Drawing.Point(206, 980);
            this.colourButton.Margin = new System.Windows.Forms.Padding(4);
            this.colourButton.Name = "colourButton";
            this.colourButton.Size = new System.Drawing.Size(502, 76);
            this.colourButton.TabIndex = 4;
            this.colourButton.Text = "Colour Select";
            this.colourButton.UseVisualStyleBackColor = true;
            this.colourButton.Click += new System.EventHandler(this.ColourButton_Click);
            // 
            // theTimer
            // 
            this.theTimer.Enabled = true;
            this.theTimer.Interval = 10;
            // 
            // fillTrack
            // 
            this.fillTrack.Location = new System.Drawing.Point(17, 890);
            this.fillTrack.Name = "fillTrack";
            this.fillTrack.Size = new System.Drawing.Size(881, 80);
            this.fillTrack.TabIndex = 5;
            this.fillTrack.Scroll += new System.EventHandler(this.FillTrack_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(928, 1084);
            this.Controls.Add(this.fillTrack);
            this.Controls.Add(this.colourButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spigotPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog changeColourDialogue;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox spigotPanel;
        private System.Windows.Forms.Panel bucketPanel;
        private System.Windows.Forms.Button colourButton;
        private System.Windows.Forms.Label interLabel;
        private System.Windows.Forms.Label trackLabel;
        public System.Windows.Forms.Timer theTimer;
        private System.Windows.Forms.TrackBar fillTrack;
    }
}

