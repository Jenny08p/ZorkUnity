namespace Zork_Builder
{
    partial class directionButton
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
            this.neighborButton = new System.Windows.Forms.Button();
            this.neighborLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // neighborButton
            // 
            this.neighborButton.Location = new System.Drawing.Point(22, 22);
            this.neighborButton.Name = "neighborButton";
            this.neighborButton.Size = new System.Drawing.Size(65, 49);
            this.neighborButton.TabIndex = 0;
            this.neighborButton.UseVisualStyleBackColor = true;
            // 
            // neighborLabel
            // 
            this.neighborLabel.AutoSize = true;
            this.neighborLabel.Location = new System.Drawing.Point(32, 38);
            this.neighborLabel.Name = "neighborLabel";
            this.neighborLabel.Size = new System.Drawing.Size(0, 17);
            this.neighborLabel.TabIndex = 1;
            // 
            // directionButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neighborLabel);
            this.Controls.Add(this.neighborButton);
            this.Name = "directionButton";
            this.Size = new System.Drawing.Size(112, 101);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button neighborButton;
        private System.Windows.Forms.Label neighborLabel;
    }
}
