using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderstandWindownsForms.forms.options.input_output {

    public partial class InputOutputForm : Form {

        public InputOutputForm() {
            InitializeComponent();
        }

        private void onSubmit(object sender, EventArgs e) {
            labelOutput.Text = $@"{textBoxFirstname.Text} {textBoxLastname.Text}";
        }

        protected override void OnClosing(CancelEventArgs e) {
            if (Application.OpenForms.Count == 0) {
                Application.Exit();
            }
        }
    }
}