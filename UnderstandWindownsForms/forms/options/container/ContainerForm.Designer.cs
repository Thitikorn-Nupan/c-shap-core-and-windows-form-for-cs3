namespace UnderstandWindownsForms.forms.options.container
{
    partial class ContainerForm
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
            this.panelA = new System.Windows.Forms.Panel();
            this.panelB = new System.Windows.Forms.Panel();
            this.panelC = new System.Windows.Forms.Panel();
            this.labelPa = new System.Windows.Forms.Label();
            this.labelPb = new System.Windows.Forms.Label();
            this.labelPc = new System.Windows.Forms.Label();
            this.checkBoxDisablePa = new System.Windows.Forms.CheckBox();
            this.checkBoxDisablePb = new System.Windows.Forms.CheckBox();
            this.checkBoxDisablePc = new System.Windows.Forms.CheckBox();
            this.panelA.SuspendLayout();
            this.panelB.SuspendLayout();
            this.panelC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.SystemColors.Info;
            this.panelA.Controls.Add(this.labelPa);
            this.panelA.Location = new System.Drawing.Point(29, 214);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(174, 115);
            this.panelA.TabIndex = 0;
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelB.Controls.Add(this.labelPb);
            this.panelB.Location = new System.Drawing.Point(252, 214);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(167, 115);
            this.panelB.TabIndex = 1;
            // 
            // panelC
            // 
            this.panelC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelC.Controls.Add(this.labelPc);
            this.panelC.Location = new System.Drawing.Point(467, 214);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(176, 115);
            this.panelC.TabIndex = 2;
            // 
            // labelPa
            // 
            this.labelPa.AutoSize = true;
            this.labelPa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPa.Location = new System.Drawing.Point(56, 51);
            this.labelPa.Name = "labelPa";
            this.labelPa.Size = new System.Drawing.Size(54, 16);
            this.labelPa.TabIndex = 0;
            this.labelPa.Text = "Panel A";
            // 
            // labelPb
            // 
            this.labelPb.AutoSize = true;
            this.labelPb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPb.Location = new System.Drawing.Point(57, 51);
            this.labelPb.Name = "labelPb";
            this.labelPb.Size = new System.Drawing.Size(54, 16);
            this.labelPb.TabIndex = 1;
            this.labelPb.Text = "Panel B";
            // 
            // labelPc
            // 
            this.labelPc.AutoSize = true;
            this.labelPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPc.Location = new System.Drawing.Point(59, 51);
            this.labelPc.Name = "labelPc";
            this.labelPc.Size = new System.Drawing.Size(54, 16);
            this.labelPc.TabIndex = 2;
            this.labelPc.Text = "Panel C";
            // 
            // checkBoxDisablePa
            // 
            this.checkBoxDisablePa.AutoSize = true;
            this.checkBoxDisablePa.Location = new System.Drawing.Point(57, 97);
            this.checkBoxDisablePa.Name = "checkBoxDisablePa";
            this.checkBoxDisablePa.Size = new System.Drawing.Size(101, 17);
            this.checkBoxDisablePa.TabIndex = 3;
            this.checkBoxDisablePa.Text = "Disable Panel A";
            this.checkBoxDisablePa.UseVisualStyleBackColor = true;
            this.checkBoxDisablePa.CheckedChanged += new System.EventHandler(this.disablePanelA);
            // 
            // checkBoxDisablePb
            // 
            this.checkBoxDisablePb.AutoSize = true;
            this.checkBoxDisablePb.Location = new System.Drawing.Point(275, 97);
            this.checkBoxDisablePb.Name = "checkBoxDisablePb";
            this.checkBoxDisablePb.Size = new System.Drawing.Size(101, 17);
            this.checkBoxDisablePb.TabIndex = 4;
            this.checkBoxDisablePb.Text = "Disable Panel B";
            this.checkBoxDisablePb.UseVisualStyleBackColor = true;
            this.checkBoxDisablePb.CheckedChanged += new System.EventHandler(this.disablePanelB);
            // 
            // checkBoxDisablePc
            // 
            this.checkBoxDisablePc.AutoSize = true;
            this.checkBoxDisablePc.Location = new System.Drawing.Point(505, 97);
            this.checkBoxDisablePc.Name = "checkBoxDisablePc";
            this.checkBoxDisablePc.Size = new System.Drawing.Size(101, 17);
            this.checkBoxDisablePc.TabIndex = 5;
            this.checkBoxDisablePc.Text = "Disable Panel C";
            this.checkBoxDisablePc.UseVisualStyleBackColor = true;
            this.checkBoxDisablePc.CheckedChanged += new System.EventHandler(this.disablePanelC);
            // 
            // ContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 415);
            this.Controls.Add(this.checkBoxDisablePc);
            this.Controls.Add(this.checkBoxDisablePb);
            this.Controls.Add(this.checkBoxDisablePa);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelA);
            this.Name = "ContainerForm";
            this.Text = "Panel Container";
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Label labelPa;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Label labelPb;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Label labelPc;
        private System.Windows.Forms.CheckBox checkBoxDisablePa;
        private System.Windows.Forms.CheckBox checkBoxDisablePb;
        private System.Windows.Forms.CheckBox checkBoxDisablePc;
    }
}