namespace DelegateSendingData
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowForm = new System.Windows.Forms.Button();
            this.txtEnterText1 = new System.Windows.Forms.TextBox();
            this.bntAppend = new System.Windows.Forms.Button();
            this.txtEnterText2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowForm
            // 
            this.btnShowForm.Location = new System.Drawing.Point(176, 59);
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.Size = new System.Drawing.Size(75, 23);
            this.btnShowForm.TabIndex = 0;
            this.btnShowForm.Text = "Show Form";
            this.btnShowForm.UseVisualStyleBackColor = true;
            this.btnShowForm.Click += new System.EventHandler(this.btnShowForm_Click);
            // 
            // txtEnterText1
            // 
            this.txtEnterText1.Location = new System.Drawing.Point(45, 124);
            this.txtEnterText1.Name = "txtEnterText1";
            this.txtEnterText1.Size = new System.Drawing.Size(332, 20);
            this.txtEnterText1.TabIndex = 1;
            // 
            // bntAppend
            // 
            this.bntAppend.Location = new System.Drawing.Point(176, 232);
            this.bntAppend.Name = "bntAppend";
            this.bntAppend.Size = new System.Drawing.Size(75, 23);
            this.bntAppend.TabIndex = 0;
            this.bntAppend.Text = "Append";
            this.bntAppend.UseVisualStyleBackColor = true;
            this.bntAppend.Click += new System.EventHandler(this.bntAppend_Click);
            // 
            // txtEnterText2
            // 
            this.txtEnterText2.Location = new System.Drawing.Point(45, 171);
            this.txtEnterText2.Name = "txtEnterText2";
            this.txtEnterText2.Size = new System.Drawing.Size(332, 20);
            this.txtEnterText2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 336);
            this.Controls.Add(this.txtEnterText2);
            this.Controls.Add(this.txtEnterText1);
            this.Controls.Add(this.bntAppend);
            this.Controls.Add(this.btnShowForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowForm;
        private System.Windows.Forms.TextBox txtEnterText1;
        private System.Windows.Forms.Button bntAppend;
        private System.Windows.Forms.TextBox txtEnterText2;
    }
}

