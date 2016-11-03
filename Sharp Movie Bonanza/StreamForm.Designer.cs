namespace Sharp_Movie_Bonanza
{
    partial class StreamForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.ChargedCostLabel = new System.Windows.Forms.Label();
            this.StreamingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(80, 51);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Location = new System.Drawing.Point(29, 9);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(181, 13);
            this.ThankYouLabel.TabIndex = 1;
            this.ThankYouLabel.Text = "Thank you for using Movie Bonanza!";
            // 
            // ChargedCostLabel
            // 
            this.ChargedCostLabel.AutoSize = true;
            this.ChargedCostLabel.Location = new System.Drawing.Point(12, 22);
            this.ChargedCostLabel.Name = "ChargedCostLabel";
            this.ChargedCostLabel.Size = new System.Drawing.Size(214, 13);
            this.ChargedCostLabel.TabIndex = 2;
            this.ChargedCostLabel.Text = "Your credit card has Been charged $[15.99]";
            // 
            // StreamingLabel
            // 
            this.StreamingLabel.AutoSize = true;
            this.StreamingLabel.Location = new System.Drawing.Point(9, 35);
            this.StreamingLabel.Name = "StreamingLabel";
            this.StreamingLabel.Size = new System.Drawing.Size(221, 13);
            this.StreamingLabel.TabIndex = 3;
            this.StreamingLabel.Text = "[Your movie] will begin streaming momentarily.";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 80);
            this.ControlBox = false;
            this.Controls.Add(this.StreamingLabel);
            this.Controls.Add(this.ChargedCostLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Controls.Add(this.OKButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Successful!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Label ChargedCostLabel;
        private System.Windows.Forms.Label StreamingLabel;
    }
}