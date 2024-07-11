using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnderstandWindownsForms.entities;
using UnderstandWindownsForms.forms.options.reads_read;
using UnderstandWindownsForms.logging;
using UnderstandWindownsForms.repository;
using UnderstandWindownsForms.sevices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UnderstandWindownsForms.forms.options.create_update {

    public partial class CreateAndUpdateForm : Form {
        private TtknpLog ttknpLog;
        private ILogger logger;
        private ObjectRepo<Mobile> mobileService;

        public CreateAndUpdateForm() {
            InitializeComponent();
            logger = new TtknpLog().iLoggerFactory.CreateLogger<CreateAndUpdateForm>();
            addComponentsToPanels();
            mobileService = new MobileService();
        }

        private void addComponentsToPanels() {
            // remember panels don't nested becasue it mapped auto
            // add components to Panel create
            panelCreateForm.Controls.Add(label1);
            panelCreateForm.Controls.Add(label2);
            panelCreateForm.Controls.Add(label3);
            panelCreateForm.Controls.Add(label4);
            panelCreateForm.Controls.Add(label5);
            panelCreateForm.Controls.Add(textBoxMobileId);
            panelCreateForm.Controls.Add(textBoxModel);
            panelCreateForm.Controls.Add(textBoxBrand);
            panelCreateForm.Controls.Add(textBoxPrice);
            panelCreateForm.Controls.Add(textBoxAmount);
            panelCreateForm.Controls.Add(buttonCreate);
            // and hide
            panelCreateForm.Hide();

            // add components to Panel update
            panelUpdateForm.Controls.Add(label6);
            panelUpdateForm.Controls.Add(label7);
            panelUpdateForm.Controls.Add(label8);
            panelUpdateForm.Controls.Add(label9);
            panelUpdateForm.Controls.Add(label10);
            panelUpdateForm.Controls.Add(textBoxMobileIdForSearch);
            panelUpdateForm.Controls.Add(textBoxModelEdit);
            panelUpdateForm.Controls.Add(textBoxBrandEdit);
            panelUpdateForm.Controls.Add(textBoxPriceEdit);
            panelUpdateForm.Controls.Add(textBoxAmountEdit);
            panelUpdateForm.Controls.Add(listViewMobiles);
            panelUpdateForm.Controls.Add(buttonSearch);
            panelUpdateForm.Controls.Add(buttonEdit);
            // and hide
            panelUpdateForm.Hide();
        }

        private void onClickedAddCheckboxMobile(object sender, EventArgs e) {
            if (checkBoxCreate.Checked) {
                panelCreateForm.Show();
                // *** common
                checkBoxUpdate.Enabled = false;
            }
            else {
                panelCreateForm.Hide();
                checkBoxUpdate.Enabled = true;
            }
        }

        private void onClickedEditCheckboxMobile(object sender, EventArgs e) {
            if (checkBoxUpdate.Checked) {
                panelUpdateForm.Show();
                // *** common
                checkBoxCreate.Enabled = false;
            }
            else {
                panelUpdateForm.Hide();
                checkBoxCreate.Enabled = true;
            }
        }

        private void onClickedCreate(object sender, EventArgs e) {
            Mobile mobile = new Mobile(
                textBoxMobileId.Text,
                textBoxModel.Text,
                textBoxBrand.Text,
                Convert.ToDouble(textBoxPrice.Text),
                Convert.ToInt32(textBoxAmount.Text)
                );

            bool resultQuery = mobileService.createObject(mobile);
            // if created
            if (resultQuery) {
                // may alert success
                string messageBoxText = $"Added Mobile ID : {mobile.Mbid} to database";
                string caption = "Successed";
                MessageBox.Show(messageBoxText, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                // clear text boxes
                textBoxMobileId.Text = "";
                textBoxModel.Text = "";
                textBoxBrand.Text = "";
                textBoxPrice.Text = "";
                textBoxAmount.Text = "";
            }
        }

        private void onClickedSearch(object sender, EventArgs e) {
            string mbid = textBoxMobileIdForSearch.Text;
            Mobile mobile = mobileService.getObject(mbid);
            if (mobile != null) {
                // clear list
                listViewMobiles.Items.Clear();
                string[] items = { $"{mobile.Mbid}", $"{mobile.Model}", $"{mobile.Brand}", $"{mobile.Price}", $"{mobile.Amount}" };
                ListViewItem item = new ListViewItem(items);
                listViewMobiles.Items.Add(item);
                // and add to textbox
                textBoxModelEdit.Text = mobile.Model;
                textBoxBrandEdit.Text = mobile.Brand;
                textBoxPriceEdit.Text = $@"{mobile.Price}";
                textBoxAmountEdit.Text = $@"{mobile.Amount}";
                // enable edit
                textBoxModelEdit.Enabled = true;
                textBoxBrandEdit.Enabled = true;
                textBoxPriceEdit.Enabled = true;
                textBoxAmountEdit.Enabled = true;
                // enable button
                buttonEdit.Enabled = true;
            }
            else {
                clearTextBoxesAndButtonAndUnenabled();
            }
        }


        private void onClickedEditForm(object sender, EventArgs e) {
            string mbid = listViewMobiles.Items[0].Text;
            logger.LogInformation("mbid : {}", mbid);

            Mobile mobile = new Mobile(
                "",
                textBoxModelEdit.Text,
                textBoxBrandEdit.Text,
                Convert.ToDouble(textBoxPriceEdit.Text),
                Convert.ToInt32(textBoxAmountEdit.Text)
            );

            bool resultQuery = mobileService.editObject(mobile, mbid);
            if (resultQuery) {
                // may alert success
                string messageBoxText = $"Updated Mobile ID : {mobile.Mbid} to database";
                string caption = "Successed";
                MessageBox.Show(messageBoxText, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                // clear text boxes
                clearTextBoxesAndButtonAndUnenabled();
            }
        }

        private void clearTextBoxesAndButtonAndUnenabled() {
            
            listViewMobiles.Items.Clear();
            textBoxMobileIdForSearch.Text = "";

            textBoxModelEdit.Text = "";
            textBoxBrandEdit.Text = "";
            textBoxPriceEdit.Text = "";
            textBoxAmountEdit.Text = "";

            textBoxModelEdit.Enabled = false;
            textBoxBrandEdit.Enabled = false;
            textBoxPriceEdit.Enabled = false;
            textBoxAmountEdit.Enabled = false;

            buttonEdit.Enabled = false;
        }

        protected override void OnClosing(CancelEventArgs e) {
            logger.LogInformation("CreateAndUpdate class gonna close");
            if (Application.OpenForms.Count == 0) {
                Application.Exit();
            }
        }
    }
}