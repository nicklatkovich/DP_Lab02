namespace DP_Lab02 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.Button_OpenFile = new System.Windows.Forms.Button();
            this.TextBox_InputText = new System.Windows.Forms.TextBox();
            this.ListBox_Probabilities = new System.Windows.Forms.ListBox();
            this.Label_Entropy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_OpenFile
            // 
            this.Button_OpenFile.AutoSize = true;
            this.Button_OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_OpenFile.ForeColor = System.Drawing.Color.Silver;
            this.Button_OpenFile.Location = new System.Drawing.Point(12, 12);
            this.Button_OpenFile.Name = "Button_OpenFile";
            this.Button_OpenFile.Size = new System.Drawing.Size(163, 35);
            this.Button_OpenFile.TabIndex = 0;
            this.Button_OpenFile.Text = "Open text file";
            this.Button_OpenFile.UseVisualStyleBackColor = false;
            this.Button_OpenFile.Click += new System.EventHandler(this.Button_OpenFile_Click);
            // 
            // TextBox_InputText
            // 
            this.TextBox_InputText.AllowDrop = true;
            this.TextBox_InputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TextBox_InputText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_InputText.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_InputText.Location = new System.Drawing.Point(12, 53);
            this.TextBox_InputText.Multiline = true;
            this.TextBox_InputText.Name = "TextBox_InputText";
            this.TextBox_InputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_InputText.Size = new System.Drawing.Size(339, 324);
            this.TextBox_InputText.TabIndex = 1;
            this.TextBox_InputText.TextChanged += new System.EventHandler(this.TextBox_InputText_TextChanged);
            // 
            // ListBox_Probabilities
            // 
            this.ListBox_Probabilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ListBox_Probabilities.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBox_Probabilities.ForeColor = System.Drawing.Color.Silver;
            this.ListBox_Probabilities.FormattingEnabled = true;
            this.ListBox_Probabilities.ItemHeight = 19;
            this.ListBox_Probabilities.Location = new System.Drawing.Point(357, 12);
            this.ListBox_Probabilities.Name = "ListBox_Probabilities";
            this.ListBox_Probabilities.ScrollAlwaysVisible = true;
            this.ListBox_Probabilities.Size = new System.Drawing.Size(255, 365);
            this.ListBox_Probabilities.TabIndex = 2;
            // 
            // Label_Entropy
            // 
            this.Label_Entropy.AutoSize = true;
            this.Label_Entropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Entropy.ForeColor = System.Drawing.Color.Silver;
            this.Label_Entropy.Location = new System.Drawing.Point(131, 396);
            this.Label_Entropy.Name = "Label_Entropy";
            this.Label_Entropy.Size = new System.Drawing.Size(110, 25);
            this.Label_Entropy.TabIndex = 3;
            this.Label_Entropy.Text = "Entropy = ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Label_Entropy);
            this.Controls.Add(this.ListBox_Probabilities);
            this.Controls.Add(this.TextBox_InputText);
            this.Controls.Add(this.Button_OpenFile);
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DP_Lab02 by Vermilliest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_OpenFile;
        private System.Windows.Forms.TextBox TextBox_InputText;
        private System.Windows.Forms.ListBox ListBox_Probabilities;
        private System.Windows.Forms.Label Label_Entropy;
    }
}

