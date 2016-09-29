using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class SalesBonus : Form
    {
        public SalesBonus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Nom de l'employé:";
            EmployeeIDLabel.Text = "Employé ID:";
            TotalHoursLabel.Text = "Heures totales:";
            TotalMonthlySalesLabel.Text = "Total des ventes mensuelles:";
            SalesBonusLabel.Text = "Bonus de vente:";
        }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Employee Name:";
            EmployeeIDLabel.Text = "Employee ID:";
            TotalHoursLabel.Text = "Total Hours:";
            TotalMonthlySalesLabel.Text = "Total Monthly Sales:";
            SalesBonusLabel.Text = "Sales Bonus:";
        }
    }
}
