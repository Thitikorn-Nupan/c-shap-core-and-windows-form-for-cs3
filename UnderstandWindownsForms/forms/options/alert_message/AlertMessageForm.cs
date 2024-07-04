using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderstandWindownsForms.forms.options.alert_message
{
    public partial class AlertMessageForm : Form
    {
        public AlertMessageForm()
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit(); // result same Close()
        }
    }
}
