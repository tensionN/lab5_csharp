using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class AddtionalForm : Form
    {
        public Form1 mainForm;
        public AddtionalForm(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_nameMed.Text = "";
            txt_expDate.Text = "";
            txt_prodDate.Text = "";
            txt_count.Text = "";
            txt_price.Text = "";
            button2.Enabled = false;
            txt_nameMed.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medicine it = new Medicine();
            it.Name = txt_nameMed.Text.Trim();
            it.ExpirationDate = Convert.ToInt32(txt_expDate.Text.Trim());
            it.ProductionDate = DateTime.Parse(txt_prodDate.Text.Trim());
            it.Count = Convert.ToInt32(txt_count.Text.Trim());
            it.Price = Convert.ToDouble(txt_price.Text.Trim());
            GlobalVars.medicines.Add(it);
            mainForm.dataGridView1.Rows.Add(it.Name, it.ExpirationDate, it.ProductionDate, it.Count, it.Price);
        }

        private void txt_nameMed_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidFunctions.IsValidNameMed(txt_nameMed.Text, out errorMsg))
            {
                e.Cancel = true;
                txt_nameMed.Select(0, txt_nameMed.Text.Length);

                this.errorProvider1.SetError(txt_nameMed, errorMsg);
            }
        }

        private void txt_nameMed_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_nameMed, "");
            EnableButton();
        }

        private void txt_expDate_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidFunctions.IsValidInt(txt_expDate.Text, out errorMsg))
            {
                e.Cancel = true;
                txt_expDate.Select(0, txt_expDate.Text.Length);

                this.errorProvider1.SetError(txt_expDate, errorMsg);
            }
        }

        private void txt_expDate_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_expDate, "");
            EnableButton();
        }

        private void txt_prodDate_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidFunctions.IsValidProdDate(txt_prodDate.Text, out errorMsg))
            {
                e.Cancel = true;
                txt_prodDate.Select(0, txt_prodDate.Text.Length);

                this.errorProvider1.SetError(txt_prodDate, errorMsg);
            }
        }

        private void txt_prodDate_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_prodDate, "");
            EnableButton();
        }

        private void txt_count_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidFunctions.IsValidInt(txt_count.Text, out errorMsg))
            {
                e.Cancel = true;
                txt_count.Select(0, txt_count.Text.Length);

                this.errorProvider1.SetError(txt_count, errorMsg);
            }
        }

        private void txt_count_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_count, "");
            EnableButton();
        }

        private void txt_price_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidFunctions.IsValidPrice(txt_price.Text, out errorMsg))
            {
                e.Cancel = true;
                txt_price.Select(0, txt_price.Text.Length);

                this.errorProvider1.SetError(txt_price, errorMsg);
            }
        }

        private void txt_price_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txt_price, "");
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        public void EnableButton()
        {
            if (ValidFunctions.IsValidNameMed(txt_nameMed.Text, out _) &&
                ValidFunctions.IsValidInt(txt_expDate.Text, out _) &&
                ValidFunctions.IsValidProdDate(txt_prodDate.Text, out _) &&
                ValidFunctions.IsValidInt(txt_count.Text, out _) &&
                ValidFunctions.IsValidPrice(txt_price.Text, out _))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}