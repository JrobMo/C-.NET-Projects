namespace Lab3B2
{
    partial class Lab3B
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
            this.ServiceBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HairdresserBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChargeBox = new System.Windows.Forms.ListBox();
            this.PriceBox = new System.Windows.Forms.GroupBox();
            this.PriceList = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.FinalPrice = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PriceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServiceBox
            // 
            this.ServiceBox.FormattingEnabled = true;
            this.ServiceBox.ItemHeight = 24;
            this.ServiceBox.Items.AddRange(new object[] {
            "Cut - $30.00",
            "Wash blow-dry and style - $20.00",
            "Colour - $40.00",
            "Highlights - $50.00",
            "Extension - $200.00",
            "Up-do - $60.00"});
            this.ServiceBox.Location = new System.Drawing.Point(6, 42);
            this.ServiceBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceBox.Name = "ServiceBox";
            this.ServiceBox.Size = new System.Drawing.Size(404, 388);
            this.ServiceBox.TabIndex = 0;
            this.ServiceBox.SelectedIndexChanged += new System.EventHandler(this.ServiceBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HairdresserBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(326, 506);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Hairdresser:";
            // 
            // HairdresserBox
            // 
            this.HairdresserBox.DisplayMember = "30";
            this.HairdresserBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HairdresserBox.FormatString = "C2";
            this.HairdresserBox.FormattingEnabled = true;
            this.HairdresserBox.Items.AddRange(new object[] {
            "Jane - $30.00",
            "Pat - $45.00",
            "Ron - $40.00",
            "Sue - $50.00",
            "Laurie - $55.00"});
            this.HairdresserBox.Location = new System.Drawing.Point(4, 26);
            this.HairdresserBox.Margin = new System.Windows.Forms.Padding(4);
            this.HairdresserBox.Name = "HairdresserBox";
            this.HairdresserBox.Size = new System.Drawing.Size(318, 32);
            this.HairdresserBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ServiceBox);
            this.groupBox2.Location = new System.Drawing.Point(365, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(425, 506);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Service:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChargeBox);
            this.groupBox3.Location = new System.Drawing.Point(840, 44);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(400, 506);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charged Items:";
            // 
            // ChargeBox
            // 
            this.ChargeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChargeBox.Enabled = false;
            this.ChargeBox.FormattingEnabled = true;
            this.ChargeBox.ItemHeight = 24;
            this.ChargeBox.Location = new System.Drawing.Point(6, 46);
            this.ChargeBox.Margin = new System.Windows.Forms.Padding(4);
            this.ChargeBox.MultiColumn = true;
            this.ChargeBox.Name = "ChargeBox";
            this.ChargeBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ChargeBox.Size = new System.Drawing.Size(292, 384);
            this.ChargeBox.TabIndex = 11;
            // 
            // PriceBox
            // 
            this.PriceBox.Controls.Add(this.PriceList);
            this.PriceBox.Location = new System.Drawing.Point(1261, 44);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Padding = new System.Windows.Forms.Padding(4);
            this.PriceBox.Size = new System.Drawing.Size(302, 506);
            this.PriceBox.TabIndex = 4;
            this.PriceBox.TabStop = false;
            this.PriceBox.Text = "Price:";
            // 
            // PriceList
            // 
            this.PriceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceList.Enabled = false;
            this.PriceList.FormattingEnabled = true;
            this.PriceList.ItemHeight = 24;
            this.PriceList.Location = new System.Drawing.Point(2, 46);
            this.PriceList.Margin = new System.Windows.Forms.Padding(4);
            this.PriceList.MultiColumn = true;
            this.PriceList.Name = "PriceList";
            this.PriceList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.PriceList.Size = new System.Drawing.Size(292, 384);
            this.PriceList.TabIndex = 10;
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(389, 834);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(299, 81);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add Service\r\n";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.Location = new System.Drawing.Point(713, 834);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(273, 81);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate Total";
            this.CalculateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(994, 834);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(257, 81);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1282, 834);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(249, 81);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(1100, 735);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(111, 25);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Total Price:";
            // 
            // FinalPrice
            // 
            this.FinalPrice.FormattingEnabled = true;
            this.FinalPrice.ItemHeight = 24;
            this.FinalPrice.Location = new System.Drawing.Point(1226, 726);
            this.FinalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.Size = new System.Drawing.Size(233, 52);
            this.FinalPrice.TabIndex = 9;
            // 
            // Lab3B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 1023);
            this.Controls.Add(this.FinalPrice);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lab3B";
            this.Text = "Perfect Cut Hair Salon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.PriceBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ServiceBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox PriceBox;
        private System.Windows.Forms.ComboBox HairdresserBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.ListBox PriceList;
        private System.Windows.Forms.ListBox ChargeBox;
        private System.Windows.Forms.ListBox FinalPrice;
    }
}

