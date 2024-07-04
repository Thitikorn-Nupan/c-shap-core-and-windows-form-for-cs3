namespace UnderstandWindownsForms.forms.options.reads_read
{
    partial class ReadsAndReadForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMobileId = new System.Windows.Forms.TextBox();
            this.checkBoxEnableMobileId = new System.Windows.Forms.CheckBox();
            this.listViewMobiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(193, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read(s) Mobile(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(133, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile Id";
            // 
            // textBoxMobileId
            // 
            this.textBoxMobileId.Enabled = false;
            this.textBoxMobileId.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxMobileId.Location = new System.Drawing.Point(260, 93);
            this.textBoxMobileId.Name = "textBoxMobileId";
            this.textBoxMobileId.Size = new System.Drawing.Size(185, 29);
            this.textBoxMobileId.TabIndex = 2;
            // 
            // checkBoxEnableMobileId
            // 
            this.checkBoxEnableMobileId.AutoEllipsis = true;
            this.checkBoxEnableMobileId.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBoxEnableMobileId.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxEnableMobileId.Location = new System.Drawing.Point(95, 93);
            this.checkBoxEnableMobileId.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxEnableMobileId.MaximumSize = new System.Drawing.Size(30, 30);
            this.checkBoxEnableMobileId.MinimumSize = new System.Drawing.Size(30, 30);
            this.checkBoxEnableMobileId.Name = "checkBoxEnableMobileId";
            this.checkBoxEnableMobileId.Size = new System.Drawing.Size(30, 30);
            this.checkBoxEnableMobileId.TabIndex = 5;
            this.checkBoxEnableMobileId.UseVisualStyleBackColor = false;
            this.checkBoxEnableMobileId.CheckedChanged += new System.EventHandler(this.enableTextbox);
            // 
            // listViewMobiles
            // 
            this.listViewMobiles.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewMobiles.BackColor = System.Drawing.SystemColors.Control;
            this.listViewMobiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewMobiles.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listViewMobiles.FullRowSelect = true;
            this.listViewMobiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMobiles.HideSelection = false;
            this.listViewMobiles.LabelWrap = false;
            this.listViewMobiles.Location = new System.Drawing.Point(68, 145);
            this.listViewMobiles.Name = "listViewMobiles";
            this.listViewMobiles.Size = new System.Drawing.Size(476, 269);
            this.listViewMobiles.TabIndex = 6;
            this.listViewMobiles.UseCompatibleStateImageBehavior = false;
            this.listViewMobiles.View = System.Windows.Forms.View.Details;
            this.listViewMobiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClickedRow);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mobile Id";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Brand";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 101;
            // 
            // button
            // 
            this.button.Enabled = false;
            this.button.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button.Location = new System.Drawing.Point(465, 92);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(60, 30);
            this.button.TabIndex = 7;
            this.button.Text = "search";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.searchMobileById);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMessage.Location = new System.Drawing.Point(65, 425);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(188, 16);
            this.labelMessage.TabIndex = 12;
            this.labelMessage.Text = "Click on the row to remove";
            // 
            // ReadsAndReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(600, 465);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.button);
            this.Controls.Add(this.listViewMobiles);
            this.Controls.Add(this.checkBoxEnableMobileId);
            this.Controls.Add(this.textBoxMobileId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReadsAndReadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reads And Read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMobileId;
        private System.Windows.Forms.CheckBox checkBoxEnableMobileId;
        private System.Windows.Forms.ListView listViewMobiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelMessage;
    }
}