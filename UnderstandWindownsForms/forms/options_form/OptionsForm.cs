using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnderstandWindownsForms.forms.options.alert_message;
using UnderstandWindownsForms.forms.options.container;
using UnderstandWindownsForms.forms.options.container_student_list;
using UnderstandWindownsForms.forms.options.input_output;
using UnderstandWindownsForms.forms.options.student_list;

namespace UnderstandWindownsForms.forms.options_forms {

    public partial class OptionsForm : Form {
        
        // these are component Class it waits to create
        private AlertMessageForm alertMessageForm;
        private InputOutputForm inputOutputForm;
        private StudentListForm studentListForm;
        private ContainerForm containerForm;
        private ContainerStudentListForm containerStudentListForm;

        public OptionsForm() {
            InitializeComponent();
        }

        private void getAlertMessage(object sender, EventArgs e) {
            // remember Hind() it is not closed form you have to use Close() it works
            // Hide(); // hide this form
            alertMessageForm = new AlertMessageForm();
            alertMessageForm.Show();
        }

        private void getInputOutput(object sender, EventArgs e) {
            // Hide();
            inputOutputForm = new InputOutputForm();
            inputOutputForm.Show();
        }

        private void getStudentList(object sender, EventArgs e) {
            // Hide();
            studentListForm = new StudentListForm();
            studentListForm.Show();
        }

        private void getContainer(object sender, EventArgs e) {
            // Hide();
            containerForm = new ContainerForm();
            containerForm.Show();
        }

        private void getContainerStudentList(object sender, EventArgs e) {
            // Hide();
            containerStudentListForm = new ContainerStudentListForm();
            containerStudentListForm.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Console.WriteLine("Options is closing");
            if (Application.OpenForms.Count == 0) {
                Application.Exit();
            }
        }
    }
}