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
using UnderstandWindownsForms.forms.options_form_crud;
using UnderstandWindownsForms.logging;
using UnderstandWindownsForms.repository;
using UnderstandWindownsForms.sevices;

namespace UnderstandWindownsForms.forms.options.reads_read
{
    public partial class ReadsAndReadForm : Form
    {
        private TtknpLog ttknpLog;
        private ILogger logger;
        private ObjectRepo<Mobile> mobileService;
        private List<Mobile> mobiles;
        public ReadsAndReadForm()
        {
            InitializeComponent();
            logger = new TtknpLog().iLoggerFactory.CreateLogger<ReadsAndReadForm>();
            mobileService = new MobileService();
            loadMobilesToListview();
        }

        private void loadMobilesToListview()
        {
            mobiles = mobileService.getObjects();
            foreach (var mobile in mobiles)
            {
                string[] items = { $"{mobile.Mbid}", $"{mobile.Model}", $"{mobile.Brand}", $"{mobile.Price}", $"{mobile.Amount}" };
                ListViewItem item = new ListViewItem(items);
                listViewMobiles.Items.Add(item);
            }
        }

        private void enableTextbox(object sender, EventArgs e)
        {
            if (checkBoxEnableMobileId.Checked)
            {
                textBoxMobileId.Enabled = true;
                button.Enabled = true;
            }
            else
            {
                textBoxMobileId.Enabled = false;
                button.Enabled = false;

            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            logger.LogInformation("{}", e.CloseReason); // when user close will log UserClosing
            Application.Exit(); // use instead Close() is good , Why use Close() then it has many loops  
        }

        private void searchMobileById(object sender, EventArgs e)
        {
            string mbid = textBoxMobileId.Text;
            Mobile mobile = mobiles.Find(m => m.Mbid == mbid);
            if (mobile != null)
            {
                // clear list
                listViewMobiles.Items.Clear();
                string[] items = { $"{mobile.Mbid}", $"{mobile.Model}", $"{mobile.Brand}", $"{mobile.Price}", $"{mobile.Amount}" };
                ListViewItem item = new ListViewItem(items);
                listViewMobiles.Items.Add(item);
            }
            else
            {
                loadMobilesToListview();
            }
        }

        private void onMouseClickedRow(object sender, MouseEventArgs e)
        {
            string mbid = textBoxMobileId.Text;
            for (int i = listViewMobiles.Items.Count - 1; i >= 0; i--) // loop follow listview size
            {
                if (listViewMobiles.Items[i].Selected) // if user clicked
                {
                    listViewMobiles.Items[i].Remove(); // remove on listview
                    mobileService.removeObject(mbid); // on student list
                }
            }
        }
    }
}
