using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnderstandWindownsForms.config_db;
using UnderstandWindownsForms.forms.options_form_crud;
using UnderstandWindownsForms.forms.options_forms;

namespace UnderstandWindownsForms {

    internal class Program {

        private static void Main() {
            Application.EnableVisualStyles(); // for Pretties components
            // Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OptionsFormCrud()); // recommend start without debug
        }
    }
}