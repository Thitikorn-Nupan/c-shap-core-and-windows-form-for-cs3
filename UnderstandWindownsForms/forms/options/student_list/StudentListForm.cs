using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnderstandWindownsForms.entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnderstandWindownsForms.forms.options.student_list
{
    public partial class StudentListForm : Form
    {
        private List<Student> students;

        public StudentListForm()
        {
            InitializeComponent();

        }

        private void addStudentsToList()
        {
            students = new List<Student>();
            students.Add(new Student(1000, "alex ryder", 22, 66.6F, 169.6F));
            students.Add(new Student(1001, "kevin owner", 22, 66.6F, 169.6F));
            students.Add(new Student(1002, "mack slider", 20, 66.6F, 169.6F));
            students.Add(new Student(1003, "randy ortuns", 21, 66.6F, 169.6F));
            students.Add(new Student(1004, "lux ortuns", 22, 6.6F, 169.6F));
            students.Add(new Student(1005, "max slider", 22, 6.6F, 169.6F));

            // way to add items to listView component
            for (int i = 0; i < students.Count; i++)
            {
                Student student = students[i];
                Console.WriteLine(student);
                string[] items = { $"{student.Id}", $"{student.Fullname}", $"{student.Age}" };
                ListViewItem item = new ListViewItem(items);
                listViewStudentList.Items.Add(item);
            }
        }

        private void loadStudentList(object sender, EventArgs e)
        {
            // Console.WriteLine(checkBoxLoadStudentList.Checked);
            if (checkBoxLoadStudentList.Checked)
            {
                addStudentsToList();
            }
            else
            {
                listViewStudentList.Items.Clear();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Close();
        }

        private void onMouseClicked(object sender, MouseEventArgs e) {
                int? row = null;
                if (listViewStudentList.SelectedItems.Count > 0) // idf user clicked some rows
                {
                    row = listViewStudentList.Items.IndexOf(listViewStudentList.SelectedItems[0]);
                }

                /*students.ForEach((student =>
                {

                }));*/
                Console.WriteLine(students[row ?? 0]);
        }
    }
}
