using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using UnderstandWindownsForms.forms.options.create_update;
using UnderstandWindownsForms.forms.options.reads_read;
using UnderstandWindownsForms.logging;

namespace UnderstandWindownsForms.forms.options_form_crud
{
    public partial class OptionsFormCrud : Form
    {
        private TtknpLog ttknpLog;
        private ILogger logger;
        private ReadsAndReadForm readsAndReadForm;
        private CreateAndUpdateForm createAndUpdateForm;

        public OptionsFormCrud()
        {
            InitializeComponent();
            logger = new TtknpLog().iLoggerFactory.CreateLogger<OptionsFormCrud>();
        }

        /*protected override void OnClosing(CancelEventArgs e)
        {
            logger.LogInformation("{}","OptionForCrud closed");
        }*/
        private void openReadsAndReadForm(object sender, EventArgs e)
        {
            Hide();
            logger.LogInformation("{}", "OptionFormCrud is hided");
            readsAndReadForm = new ReadsAndReadForm();
            // have to show because is hiding
            readsAndReadForm.Show();
        }

        private void openCreateAndUpdateForm(object sender, EventArgs e)
        {
            Hide();
            logger.LogInformation("{}", "OptionFormCrud is hided");
            createAndUpdateForm = new CreateAndUpdateForm();
            createAndUpdateForm.Show();
        }
    }
}
