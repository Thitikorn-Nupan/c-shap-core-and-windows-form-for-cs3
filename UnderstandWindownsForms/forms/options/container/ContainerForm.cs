using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderstandWindownsForms.forms.options.container
{
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();
            // when you generate by gui 
            // it does not add any components to panel
            // you have to do own
            panelA.Controls.Add(labelPa);
            panelB.Controls.Add(labelPb);
            panelC.Controls.Add(labelPc);
        }

 

        private void disablePanelA(object sender, EventArgs e)
        {
            // check is clicked or not
            if (checkBoxDisablePa.Checked)
            {
                panelA.Hide();
            }
            else
            {
                panelA.Show();
            }

        }

        private void disablePanelB(object sender, EventArgs e)
        {
            if (checkBoxDisablePb.Checked)
            {
                panelB.Hide();
            }
            else
            {
                panelB.Show();
            }
        }

        private void disablePanelC(object sender, EventArgs e)
        {
            if (checkBoxDisablePc.Checked)
            {
                panelC.Hide();
            }
            else
            {
                panelC.Show();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Close();
        }
    }
}
