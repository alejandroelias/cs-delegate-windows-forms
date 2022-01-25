namespace DelegateSendingData
{
    partial class ChildForm
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
            this.lblAppended1 = new System.Windows.Forms.Label();
            this.lblAppended2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAppended1
            // 
            this.lblAppended1.AutoSize = true;
            this.lblAppended1.Location = new System.Drawing.Point(93, 111);
            this.lblAppended1.Name = "lblAppended1";
            this.lblAppended1.Size = new System.Drawing.Size(76, 13);
            this.lblAppended1.TabIndex = 0;
            this.lblAppended1.Text = "Not Appended";
            // 
            // lblAppended2
            // 
            this.lblAppended2.AutoSize = true;
            this.lblAppended2.Location = new System.Drawing.Point(93, 166);
            this.lblAppended2.Name = "lblAppended2";
            this.lblAppended2.Size = new System.Drawing.Size(76, 13);
            this.lblAppended2.TabIndex = 1;
            this.lblAppended2.Text = "Not Appended";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblAppended2);
            this.Controls.Add(this.lblAppended1);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppended1;
        private System.Windows.Forms.Label lblAppended2;
    }
}