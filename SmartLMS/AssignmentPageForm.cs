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
    public partial class AssignmentPageForm : Form
    {
        public AssignmentPageForm()
        {
            InitializeComponent();
        }

        private void dgvAssignments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure user clicked the Action column (Upload button)
            if (e.ColumnIndex == dgvAssignments.Columns["ActionColumn"].Index && e.RowIndex >= 0)
            {
                // Show the Upload panel
                pnlUpload.Visible = true;
            }


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Show selected file name
                MessageBox.Show("Selected File: " + openFileDialog1.FileName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assignment Submitted!");
            pnlUpload.Visible = false;
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits (0-9) and Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the key
            }
        }

        private void btnSubmitGrade_Click(object sender, EventArgs e)
        {
            string score = txtScore.Text;
            string comment = txtComment.Text;

            if (score == "")
            {
                MessageBox.Show("Please enter a score.");
                return;
            }

            // Here, you’d save to the database...
            MessageBox.Show("✅ Graded Successfully!");

            // Hide the grading panel
            pnlGrade.Visible = false;

            // Optional: refresh DataGridView to show "Graded"
        }

        private void lnkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filePath = "C:\\Assignments\\quiz1.pdf"; // Load actual file path
            try
            {
                System.Diagnostics.Process.Start(filePath);
            }
            catch
            {
                MessageBox.Show("Cannot open file.");
            }
        }

        private void AssignmentPageForm_Load(object sender, EventArgs e)
        {

        }

        private void LblAssignments_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFilterbyStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFilterbyCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlUpload_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlGrade_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
