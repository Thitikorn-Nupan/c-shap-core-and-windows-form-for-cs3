namespace UnderstandWindownsForms.forms.options_forms
{
    partial class OptionsForm
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
            this.buttonAlertMessage = new System.Windows.Forms.Button();
            this.buttonInputOutput = new System.Windows.Forms.Button();
            this.buttonStudentList = new System.Windows.Forms.Button();
            this.buttonContainer = new System.Windows.Forms.Button();
            this.buttonContainerStudentList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAlertMessage
            // 
            this.buttonAlertMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonAlertMessage.Location = new System.Drawing.Point(128, 65);
            this.buttonAlertMessage.Name = "buttonAlertMessage";
            this.buttonAlertMessage.Size = new System.Drawing.Size(216, 42);
            this.buttonAlertMessage.TabIndex = 0;
            this.buttonAlertMessage.Text = "Alert Message";
            this.buttonAlertMessage.UseVisualStyleBackColor = true;
            this.buttonAlertMessage.Click += new System.EventHandler(this.getAlertMessage);
            // 
            // buttonInputOutput
            // 
            this.buttonInputOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonInputOutput.Location = new System.Drawing.Point(128, 144);
            this.buttonInputOutput.Name = "buttonInputOutput";
            this.buttonInputOutput.Size = new System.Drawing.Size(216, 42);
            this.buttonInputOutput.TabIndex = 1;
            this.buttonInputOutput.Text = "Input Output";
            this.buttonInputOutput.UseVisualStyleBackColor = true;
            this.buttonInputOutput.Click += new System.EventHandler(this.getInputOutput);
            // 
            // buttonStudentList
            // 
            this.buttonStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonStudentList.Location = new System.Drawing.Point(128, 222);
            this.buttonStudentList.Name = "buttonStudentList";
            this.buttonStudentList.Size = new System.Drawing.Size(216, 42);
            this.buttonStudentList.TabIndex = 2;
            this.buttonStudentList.Text = "Student List";
            this.buttonStudentList.UseVisualStyleBackColor = true;
            this.buttonStudentList.Click += new System.EventHandler(this.getStudentList);
            // 
            // buttonContainer
            // 
            this.buttonContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonContainer.Location = new System.Drawing.Point(128, 300);
            this.buttonContainer.Name = "buttonContainer";
            this.buttonContainer.Size = new System.Drawing.Size(216, 42);
            this.buttonContainer.TabIndex = 3;
            this.buttonContainer.Text = "Container";
            this.buttonContainer.UseVisualStyleBackColor = true;
            this.buttonContainer.Click += new System.EventHandler(this.getContainer);
            // 
            // buttonContainerStudentList
            // 
            this.buttonContainerStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonContainerStudentList.Location = new System.Drawing.Point(128, 385);
            this.buttonContainerStudentList.Name = "buttonContainerStudentList";
            this.buttonContainerStudentList.Size = new System.Drawing.Size(216, 42);
            this.buttonContainerStudentList.TabIndex = 4;
            this.buttonContainerStudentList.Text = "Container + Student List";
            this.buttonContainerStudentList.UseVisualStyleBackColor = true;
            this.buttonContainerStudentList.Click += new System.EventHandler(this.getContainerStudentList);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 680);
            this.Controls.Add(this.buttonContainerStudentList);
            this.Controls.Add(this.buttonContainer);
            this.Controls.Add(this.buttonStudentList);
            this.Controls.Add(this.buttonInputOutput);
            this.Controls.Add(this.buttonAlertMessage);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options For You";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAlertMessage;
        private System.Windows.Forms.Button buttonInputOutput;
        private System.Windows.Forms.Button buttonStudentList;
        private System.Windows.Forms.Button buttonContainer;
        private System.Windows.Forms.Button buttonContainerStudentList;
    }
}