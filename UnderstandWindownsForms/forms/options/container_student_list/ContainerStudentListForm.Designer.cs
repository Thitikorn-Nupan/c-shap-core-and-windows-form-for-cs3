namespace UnderstandWindownsForms.forms.options.container_student_list
{
    partial class ContainerStudentListForm
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
            this.listViewStudentList = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelId = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.panelInsertStudent = new System.Windows.Forms.Panel();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBoxModeInsert = new System.Windows.Forms.CheckBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.panelInsertStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewStudentList
            // 
            this.listViewStudentList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listViewStudentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderFullname,
            this.columnHeaderAge});
            this.listViewStudentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listViewStudentList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewStudentList.HideSelection = false;
            this.listViewStudentList.LabelWrap = false;
            this.listViewStudentList.Location = new System.Drawing.Point(23, 236);
            this.listViewStudentList.MultiSelect = false;
            this.listViewStudentList.Name = "listViewStudentList";
            this.listViewStudentList.Scrollable = false;
            this.listViewStudentList.Size = new System.Drawing.Size(454, 233);
            this.listViewStudentList.TabIndex = 1;
            this.listViewStudentList.UseCompatibleStateImageBehavior = false;
            this.listViewStudentList.View = System.Windows.Forms.View.Details;
            this.listViewStudentList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClickedRow);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 150;
            // 
            // columnHeaderFullname
            // 
            this.columnHeaderFullname.Text = "Fullname";
            this.columnHeaderFullname.Width = 150;
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.Text = "Age";
            this.columnHeaderAge.Width = 150;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelId.Location = new System.Drawing.Point(9, 18);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(28, 20);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelFullname.Location = new System.Drawing.Point(9, 62);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(82, 20);
            this.labelFullname.TabIndex = 3;
            this.labelFullname.Text = "Fullname";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelAge.Location = new System.Drawing.Point(9, 101);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(41, 20);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age";
            // 
            // panelInsertStudent
            // 
            this.panelInsertStudent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelInsertStudent.Controls.Add(this.buttonInsert);
            this.panelInsertStudent.Controls.Add(this.textBoxAge);
            this.panelInsertStudent.Controls.Add(this.textBoxFullname);
            this.panelInsertStudent.Controls.Add(this.textBoxId);
            this.panelInsertStudent.Controls.Add(this.labelAge);
            this.panelInsertStudent.Controls.Add(this.labelFullname);
            this.panelInsertStudent.Controls.Add(this.labelId);
            this.panelInsertStudent.Location = new System.Drawing.Point(62, 63);
            this.panelInsertStudent.Name = "panelInsertStudent";
            this.panelInsertStudent.Size = new System.Drawing.Size(369, 154);
            this.panelInsertStudent.TabIndex = 5;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonInsert.Location = new System.Drawing.Point(308, 62);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(45, 34);
            this.buttonInsert.TabIndex = 8;
            this.buttonInsert.Text = "Add";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.onButtonClicked);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(113, 103);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(169, 20);
            this.textBoxAge.TabIndex = 7;
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.Location = new System.Drawing.Point(113, 64);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.Size = new System.Drawing.Size(169, 20);
            this.textBoxFullname.TabIndex = 6;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(113, 20);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(169, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelTitle.Location = new System.Drawing.Point(58, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(107, 20);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Student List";
            // 
            // checkBoxModeInsert
            // 
            this.checkBoxModeInsert.AutoSize = true;
            this.checkBoxModeInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxModeInsert.Location = new System.Drawing.Point(175, 21);
            this.checkBoxModeInsert.Name = "checkBoxModeInsert";
            this.checkBoxModeInsert.Size = new System.Drawing.Size(256, 22);
            this.checkBoxModeInsert.TabIndex = 10;
            this.checkBoxModeInsert.Text = "Do you want to add students ?";
            this.checkBoxModeInsert.UseVisualStyleBackColor = true;
            this.checkBoxModeInsert.CheckedChanged += new System.EventHandler(this.onCheckboxClicked);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMessage.Location = new System.Drawing.Point(19, 484);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(201, 16);
            this.labelMessage.TabIndex = 11;
            this.labelMessage.Text = "Click at the id to remove row";
            // 
            // ContainerStudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 524);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.checkBoxModeInsert);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listViewStudentList);
            this.Controls.Add(this.panelInsertStudent);
            this.Name = "ContainerStudentListForm";
            this.Text = "Container + Student List Form";
            this.panelInsertStudent.ResumeLayout(false);
            this.panelInsertStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStudentList;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderFullname;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Panel panelInsertStudent;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxModeInsert;
        private System.Windows.Forms.Label labelMessage;
    }
}