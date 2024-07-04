namespace UnderstandWindownsForms.forms.options.create_update
{
    partial class CreateAndUpdateForm
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
            this.checkBoxCreate = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdate = new System.Windows.Forms.CheckBox();
            this.panelCreateForm = new System.Windows.Forms.Panel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMobileId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUpdateForm = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxAmountEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPriceEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBrandEdit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxModelEdit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listViewMobiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxMobileIdForSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelCreateForm.SuspendLayout();
            this.panelUpdateForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxCreate
            // 
            this.checkBoxCreate.AutoSize = true;
            this.checkBoxCreate.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxCreate.Location = new System.Drawing.Point(127, 35);
            this.checkBoxCreate.Name = "checkBoxCreate";
            this.checkBoxCreate.Size = new System.Drawing.Size(147, 34);
            this.checkBoxCreate.TabIndex = 0;
            this.checkBoxCreate.Text = "Add mobile";
            this.checkBoxCreate.UseVisualStyleBackColor = true;
            this.checkBoxCreate.CheckedChanged += new System.EventHandler(this.onClickedAddCheckboxMobile);
            // 
            // checkBoxUpdate
            // 
            this.checkBoxUpdate.AutoSize = true;
            this.checkBoxUpdate.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBoxUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxUpdate.Location = new System.Drawing.Point(315, 35);
            this.checkBoxUpdate.Name = "checkBoxUpdate";
            this.checkBoxUpdate.Size = new System.Drawing.Size(144, 34);
            this.checkBoxUpdate.TabIndex = 1;
            this.checkBoxUpdate.Text = "Edit mobile";
            this.checkBoxUpdate.UseVisualStyleBackColor = true;
            this.checkBoxUpdate.CheckedChanged += new System.EventHandler(this.onClickedEditCheckboxMobile);
            // 
            // panelCreateForm
            // 
            this.panelCreateForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCreateForm.Controls.Add(this.buttonCreate);
            this.panelCreateForm.Controls.Add(this.textBoxAmount);
            this.panelCreateForm.Controls.Add(this.label5);
            this.panelCreateForm.Controls.Add(this.textBoxPrice);
            this.panelCreateForm.Controls.Add(this.label4);
            this.panelCreateForm.Controls.Add(this.textBoxBrand);
            this.panelCreateForm.Controls.Add(this.label3);
            this.panelCreateForm.Controls.Add(this.textBoxModel);
            this.panelCreateForm.Controls.Add(this.label2);
            this.panelCreateForm.Controls.Add(this.textBoxMobileId);
            this.panelCreateForm.Controls.Add(this.label1);
            this.panelCreateForm.Location = new System.Drawing.Point(83, 117);
            this.panelCreateForm.Name = "panelCreateForm";
            this.panelCreateForm.Size = new System.Drawing.Size(432, 291);
            this.panelCreateForm.TabIndex = 2;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonCreate.Location = new System.Drawing.Point(170, 239);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(98, 29);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "send";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.onClickedCreate);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxAmount.Location = new System.Drawing.Point(170, 198);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(193, 35);
            this.textBoxAmount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(42, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxPrice.Location = new System.Drawing.Point(170, 157);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(193, 35);
            this.textBoxPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(42, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxBrand.Location = new System.Drawing.Point(170, 116);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(193, 35);
            this.textBoxBrand.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Brand";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxModel.Location = new System.Drawing.Point(170, 75);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(193, 35);
            this.textBoxModel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // textBoxMobileId
            // 
            this.textBoxMobileId.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxMobileId.Location = new System.Drawing.Point(170, 34);
            this.textBoxMobileId.Name = "textBoxMobileId";
            this.textBoxMobileId.Size = new System.Drawing.Size(193, 35);
            this.textBoxMobileId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mobile Id";
            // 
            // panelUpdateForm
            // 
            this.panelUpdateForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelUpdateForm.Controls.Add(this.buttonEdit);
            this.panelUpdateForm.Controls.Add(this.textBoxAmountEdit);
            this.panelUpdateForm.Controls.Add(this.label7);
            this.panelUpdateForm.Controls.Add(this.textBoxPriceEdit);
            this.panelUpdateForm.Controls.Add(this.label8);
            this.panelUpdateForm.Controls.Add(this.textBoxBrandEdit);
            this.panelUpdateForm.Controls.Add(this.label9);
            this.panelUpdateForm.Controls.Add(this.textBoxModelEdit);
            this.panelUpdateForm.Controls.Add(this.label10);
            this.panelUpdateForm.Controls.Add(this.listViewMobiles);
            this.panelUpdateForm.Controls.Add(this.buttonSearch);
            this.panelUpdateForm.Controls.Add(this.textBoxMobileIdForSearch);
            this.panelUpdateForm.Controls.Add(this.label6);
            this.panelUpdateForm.Location = new System.Drawing.Point(53, 87);
            this.panelUpdateForm.Name = "panelUpdateForm";
            this.panelUpdateForm.Size = new System.Drawing.Size(502, 336);
            this.panelUpdateForm.TabIndex = 3;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonEdit.Location = new System.Drawing.Point(363, 269);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 38);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "send";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.onClickedEditForm);
            // 
            // textBoxAmountEdit
            // 
            this.textBoxAmountEdit.Enabled = false;
            this.textBoxAmountEdit.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxAmountEdit.Location = new System.Drawing.Point(148, 272);
            this.textBoxAmountEdit.Name = "textBoxAmountEdit";
            this.textBoxAmountEdit.Size = new System.Drawing.Size(193, 35);
            this.textBoxAmountEdit.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(20, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Amount";
            // 
            // textBoxPriceEdit
            // 
            this.textBoxPriceEdit.Enabled = false;
            this.textBoxPriceEdit.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxPriceEdit.Location = new System.Drawing.Point(148, 231);
            this.textBoxPriceEdit.Name = "textBoxPriceEdit";
            this.textBoxPriceEdit.Size = new System.Drawing.Size(193, 35);
            this.textBoxPriceEdit.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(20, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Price";
            // 
            // textBoxBrandEdit
            // 
            this.textBoxBrandEdit.Enabled = false;
            this.textBoxBrandEdit.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxBrandEdit.Location = new System.Drawing.Point(148, 190);
            this.textBoxBrandEdit.Name = "textBoxBrandEdit";
            this.textBoxBrandEdit.Size = new System.Drawing.Size(193, 35);
            this.textBoxBrandEdit.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(20, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Brand";
            // 
            // textBoxModelEdit
            // 
            this.textBoxModelEdit.Enabled = false;
            this.textBoxModelEdit.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxModelEdit.Location = new System.Drawing.Point(148, 149);
            this.textBoxModelEdit.Name = "textBoxModelEdit";
            this.textBoxModelEdit.Size = new System.Drawing.Size(193, 35);
            this.textBoxModelEdit.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(20, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Model";
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
            this.listViewMobiles.Location = new System.Drawing.Point(18, 65);
            this.listViewMobiles.Name = "listViewMobiles";
            this.listViewMobiles.Size = new System.Drawing.Size(466, 67);
            this.listViewMobiles.TabIndex = 11;
            this.listViewMobiles.UseCompatibleStateImageBehavior = false;
            this.listViewMobiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mobile Id";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Brand";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 111;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonSearch.Location = new System.Drawing.Point(374, 22);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(68, 32);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.onClickedSearch);
            // 
            // textBoxMobileIdForSearch
            // 
            this.textBoxMobileIdForSearch.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxMobileIdForSearch.Location = new System.Drawing.Point(172, 23);
            this.textBoxMobileIdForSearch.Name = "textBoxMobileIdForSearch";
            this.textBoxMobileIdForSearch.Size = new System.Drawing.Size(185, 29);
            this.textBoxMobileIdForSearch.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(53, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mobile Id";
            // 
            // CreateAndUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(600, 456);
            this.Controls.Add(this.panelUpdateForm);
            this.Controls.Add(this.panelCreateForm);
            this.Controls.Add(this.checkBoxUpdate);
            this.Controls.Add(this.checkBoxCreate);
            this.Name = "CreateAndUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create And Update";
            this.panelCreateForm.ResumeLayout(false);
            this.panelCreateForm.PerformLayout();
            this.panelUpdateForm.ResumeLayout(false);
            this.panelUpdateForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCreate;
        private System.Windows.Forms.CheckBox checkBoxUpdate;
        private System.Windows.Forms.Panel panelCreateForm;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMobileId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Panel panelUpdateForm;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxMobileIdForSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewMobiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxAmountEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPriceEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBrandEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxModelEdit;
        private System.Windows.Forms.Label label10;
    }
}