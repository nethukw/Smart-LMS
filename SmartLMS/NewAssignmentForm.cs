using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLMS
{
    public partial class NewAssignmentForm : BaseForm
    {
        private static string connString = "server=localhost;user=root;password=your_password;database=smartlms;";
        private static MySqlConnection conn;

        public NewAssignmentForm()
        {
            InitializeComponent();
        }

        private void NewAssignmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
