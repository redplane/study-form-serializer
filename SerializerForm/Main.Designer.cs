namespace SerializerForm
{
    partial class Main
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
            this.btnStoreForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStoreForm
            // 
            this.btnStoreForm.Location = new System.Drawing.Point(12, 228);
            this.btnStoreForm.Name = "btnStoreForm";
            this.btnStoreForm.Size = new System.Drawing.Size(311, 23);
            this.btnStoreForm.TabIndex = 0;
            this.btnStoreForm.Text = "Store Form";
            this.btnStoreForm.UseVisualStyleBackColor = true;
            this.btnStoreForm.Click += new System.EventHandler(this.btnStoreForm_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 263);
            this.Controls.Add(this.btnStoreForm);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStoreForm;
    }
}