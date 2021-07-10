
namespace CalculadoraCum
{
    partial class FormBase
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
            this.WelComeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelComeLabel
            // 
            this.WelComeLabel.Location = new System.Drawing.Point(101, 34);
            this.WelComeLabel.Name = "WelComeLabel";
            this.WelComeLabel.Size = new System.Drawing.Size(512, 23);
            this.WelComeLabel.TabIndex = 0;
            this.WelComeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.WelComeLabel);
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelComeLabel;
    }
}