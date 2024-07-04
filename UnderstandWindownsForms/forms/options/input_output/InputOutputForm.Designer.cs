namespace UnderstandWindownsForms.forms.options.input_output
{
    partial class InputOutputForm
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
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstname
            // 
            this.labelFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelFirstname.Location = new System.Drawing.Point(102, 83);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(112, 27);
            this.labelFirstname.TabIndex = 0;
            this.labelFirstname.Text = "Firstname";
            // 
            // labelLastname
            // 
            this.labelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelLastname.Location = new System.Drawing.Point(102, 163);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(112, 27);
            this.labelLastname.TabIndex = 1;
            this.labelLastname.Text = "Lastname";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxFirstname.Location = new System.Drawing.Point(243, 83);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(265, 29);
            this.textBoxFirstname.TabIndex = 2;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxLastname.Location = new System.Drawing.Point(243, 160);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(265, 29);
            this.textBoxLastname.TabIndex = 3;
            // 
            // labelOutput
            // 
            this.labelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelOutput.Location = new System.Drawing.Point(102, 331);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(406, 56);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Empty";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button.Location = new System.Drawing.Point(243, 237);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(80, 34);
            this.button.TabIndex = 5;
            this.button.Text = "send";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.onSubmit);
            // 
            // InputOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 443);
            this.Controls.Add(this.button);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelFirstname);
            this.Name = "InputOutputForm";
            this.Text = "Input Output Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button button;
    }
}