namespace CombinatoricsProject
{
    partial class UI
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
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionBox = new System.Windows.Forms.ComboBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.eulerButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.generalButton = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.typeBox.Location = new System.Drawing.Point(289, 185);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(283, 39);
            this.typeBox.TabIndex = 0;
            this.typeBox.Text = "Select Graph Type";
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(283, 106);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(86, 32);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(748, 117);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(120, 32);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version:";
            // 
            // versionBox
            // 
            this.versionBox.FormattingEnabled = true;
            this.versionBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.versionBox.Location = new System.Drawing.Point(754, 185);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(235, 39);
            this.versionBox.TabIndex = 3;
            this.versionBox.Text = "Select Version";
            this.versionBox.SelectedIndexChanged += new System.EventHandler(this.versionBox_SelectedIndexChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(33, 489);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(1353, 589);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Read the README if you haven\'t already!";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // eulerButton
            // 
            this.eulerButton.Location = new System.Drawing.Point(140, 345);
            this.eulerButton.Name = "eulerButton";
            this.eulerButton.Size = new System.Drawing.Size(186, 76);
            this.eulerButton.TabIndex = 5;
            this.eulerButton.Text = "Euler Circuit";
            this.eulerButton.UseVisualStyleBackColor = true;
            this.eulerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(622, 345);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(194, 76);
            this.randomButton.TabIndex = 6;
            this.randomButton.Text = "Random Hamiltonian";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // generalButton
            // 
            this.generalButton.Location = new System.Drawing.Point(1105, 345);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(200, 76);
            this.generalButton.TabIndex = 7;
            this.generalButton.Text = "General Hamiltonian";
            this.generalButton.UseVisualStyleBackColor = true;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(1418, 40);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(625, 572);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBox.TabIndex = 9;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.imageBox_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2283, 1107);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.generalButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.eulerButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.versionBox);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeBox);
            this.Name = "UI";
            this.Text = "UI";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ComboBox versionBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button eulerButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button generalButton;
        private System.Windows.Forms.PictureBox imageBox;
    }
}