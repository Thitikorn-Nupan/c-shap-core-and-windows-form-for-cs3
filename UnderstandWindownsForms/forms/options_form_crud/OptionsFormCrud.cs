using System;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using UnderstandWindownsForms.forms.options.create_update;
using UnderstandWindownsForms.forms.options.reads_read;
using UnderstandWindownsForms.logging;

namespace UnderstandWindownsForms.forms.options_form_crud {

    public partial class OptionsFormCrud : Form {

        private TtknpLog ttknpLog;
        private ILogger logger;
        private ReadsAndReadForm readsAndReadForm;
        private CreateAndUpdateForm createAndUpdateForm;

        public OptionsFormCrud() {
            InitializeComponent();
            logger = new TtknpLog().iLoggerFactory.CreateLogger<OptionsFormCrud>();
        }

        private void openReadsAndReadForm(object sender, EventArgs e) {
            // Hide();
            // logger.LogInformation("{}", "OptionFormCrud is hided");
            readsAndReadForm = new ReadsAndReadForm();
            // have to show because it's hiding at the first create
            readsAndReadForm.Show();
        }

        private void openCreateAndUpdateForm(object sender, EventArgs e) {
            // Hide();
            // logger.LogInformation("{}", "OptionFormCrud is hided");
            createAndUpdateForm = new CreateAndUpdateForm();
            createAndUpdateForm.Show();
        }

        protected override void OnClosing(CancelEventArgs e) {
            logger.LogInformation("OptionsFormCrud class gonna close");
            if (Application.OpenForms.Count == 0) {
                Application.Exit();
            }
        }
    }
}