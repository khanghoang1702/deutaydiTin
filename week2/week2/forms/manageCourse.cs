using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week2.model;

namespace week2.forms
{
    public partial class manageCourse : Form
    {
        public manageCourse()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        private void searchBTN_Click(object sender, EventArgs e)
        {
            string label = searchTXT.Text;
            courseList.DataSource = course.courseSearchLb(label);
            labelTotal.Text = "Total Course: " + course.courseSearchLb(label).ToString();
        }
    }
    }
//}
