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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnderstandWindownsForms.forms.options.container_student_list
{
    public partial class ContainerStudentListForm : Form
    {
        private List<Student> students;
        public ContainerStudentListForm()
        {
            InitializeComponent();
            addComponentsToPanel();
            // first hide the panel 
            panelInsertStudent.Hide();
            students = new List<Student>();
        }

        private void addComponentsToPanel()
        {
            panelInsertStudent.Controls.Add(labelId);
            panelInsertStudent.Controls.Add(labelFullname);
            panelInsertStudent.Controls.Add(labelAge);
            panelInsertStudent.Controls.Add(textBoxId);
            panelInsertStudent.Controls.Add(textBoxFullname);
            panelInsertStudent.Controls.Add(textBoxAge);
            panelInsertStudent.Controls.Add(buttonInsert);
        }
        private void onCheckboxClicked(object sender, EventArgs e)
        {
            if (checkBoxModeInsert.Checked)
            {
                panelInsertStudent.Show();
            }
            else
            {
                panelInsertStudent.Hide();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Close();
        }

        private void onButtonClicked(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxId.Text); // way to convert to string
            string fullname = textBoxFullname.Text;
            int age = Int32.Parse(textBoxAge.Text);

            // create object student and add data
            Student student = new Student(id, fullname, age,50.5F,156.6F);
            // add to student list
            students.Add(student);
            // add to listview 
            addStudentToListview(student);
        }

        private void addStudentToListview(Student student)
        {
            string[] items = { $"{student.Id}", $"{student.Fullname}", $"{student.Age}" };
            ListViewItem item = new ListViewItem(items);
            listViewStudentList.Items.Add(item);
        }

        private void onMouseClickedRow(object sender, MouseEventArgs e)
        {
            for (int i = listViewStudentList.Items.Count - 1; i >= 0; i--) // loop follow listview size
            {
                if (listViewStudentList.Items[i].Selected) // if user clicked
                {
                    listViewStudentList.Items[i].Remove(); // remove on listview
                    students.Remove(students[i]); // on student list
                }
            }
        }
    }
}
