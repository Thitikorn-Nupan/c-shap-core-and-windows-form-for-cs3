namespace UnderstandWindownsForms.forms.options_form_crud
{
    partial class OptionsFormCrud
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
            this.buttonReadsAndRead = new System.Windows.Forms.Button();
            this.buttonCreateAndUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReadsAndRead
            // 
            this.buttonReadsAndRead.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReadsAndRead.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadsAndRead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReadsAndRead.Location = new System.Drawing.Point(116, 84);
            this.buttonReadsAndRead.Name = "buttonReadsAndRead";
            this.buttonReadsAndRead.Size = new System.Drawing.Size(154, 41);
            this.buttonReadsAndRead.TabIndex = 0;
            this.buttonReadsAndRead.Text = "Read(s),Delete";
            this.buttonReadsAndRead.UseVisualStyleBackColor = false;
            this.buttonReadsAndRead.Click += new System.EventHandler(this.openReadsAndReadForm);
            // 
            // buttonCreateAndUpdate
            // 
            this.buttonCreateAndUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCreateAndUpdate.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAndUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateAndUpdate.Location = new System.Drawing.Point(116, 154);
            this.buttonCreateAndUpdate.Name = "buttonCreateAndUpdate";
            this.buttonCreateAndUpdate.Size = new System.Drawing.Size(154, 41);
            this.buttonCreateAndUpdate.TabIndex = 0;
            this.buttonCreateAndUpdate.Text = "Create,Update";
            this.buttonCreateAndUpdate.UseVisualStyleBackColor = false;
            this.buttonCreateAndUpdate.Click += new System.EventHandler(this.openCreateAndUpdateForm);
            // 
            // OptionsFormCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(399, 293);
            this.Controls.Add(this.buttonCreateAndUpdate);
            this.Controls.Add(this.buttonReadsAndRead);
            this.Name = "OptionsFormCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options Crud Concept";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReadsAndRead;
        private System.Windows.Forms.Button buttonCreateAndUpdate;
    }
}