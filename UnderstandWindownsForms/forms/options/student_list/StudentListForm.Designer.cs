namespace UnderstandWindownsForms.forms.options.student_list
{
    partial class StudentListForm
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
            this.label = new System.Windows.Forms.Label();
            this.checkBoxLoadStudentList = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listViewStudentList
            // 
            this.listViewStudentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderFullname,
            this.columnHeaderAge});
            this.listViewStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listViewStudentList.HideSelection = false;
            this.listViewStudentList.Location = new System.Drawing.Point(82, 165);
            this.listViewStudentList.Name = "listViewStudentList";
            this.listViewStudentList.Size = new System.Drawing.Size(455, 233);
            this.listViewStudentList.TabIndex = 0;
            this.listViewStudentList.UseCompatibleStateImageBehavior = false;
            this.listViewStudentList.View = System.Windows.Forms.View.Details;
            this.listViewStudentList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClicked);
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
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label.Location = new System.Drawing.Point(133, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(362, 34);
            this.label.TabIndex = 1;
            this.label.Text = "Student List";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxLoadStudentList
            // 
            this.checkBoxLoadStudentList.AutoSize = true;
            this.checkBoxLoadStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxLoadStudentList.Location = new System.Drawing.Point(243, 103);
            this.checkBoxLoadStudentList.Name = "checkBoxLoadStudentList";
            this.checkBoxLoadStudentList.Size = new System.Drawing.Size(137, 24);
            this.checkBoxLoadStudentList.TabIndex = 2;
            this.checkBoxLoadStudentList.Text = "load students";
            this.checkBoxLoadStudentList.UseVisualStyleBackColor = true;
            this.checkBoxLoadStudentList.CheckedChanged += new System.EventHandler(this.loadStudentList);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 485);
            this.Controls.Add(this.checkBoxLoadStudentList);
            this.Controls.Add(this.label);
            this.Controls.Add(this.listViewStudentList);
            this.Name = "StudentListForm";
            this.Text = "Student List ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStudentList;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderFullname;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.CheckBox checkBoxLoadStudentList;
    }
}