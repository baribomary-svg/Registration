using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Registration
{
    public partial class frmLab1 : Form
    {
        public frmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))

            {

                MessageBox.Show("Error: Input box cannot be empty. Please enter text before creating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtInput.Focus();

                return;

            }


            frmFileName.SetFileName = "";

            frmFileName frm = new frmFileName();

            frm.ShowDialog();


            if (string.IsNullOrWhiteSpace(frmFileName .SetFileName))

            {

                MessageBox.Show("Operation cancelled: A valid file name is required to proceed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }


            string getInput = txtInput.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, frmFileName.SetFileName)))

            {

                outputFile.WriteLine(getInput);

                Console.WriteLine(getInput);

            }


            MessageBox.Show("Lab 1 text file successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmRegistration regForm = new frmRegistration();

            regForm.ShowDialog();
        }
    }
}
