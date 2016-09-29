using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Application Name: Mail Order Sales Bonus Calculator.
/// Author's Name: Bradley Girard
/// Application Creation Date: September 22nd, 2016
/// Application Summary: Calculates an employee's sales bonus based on the 
///                      hours worked, and the company's sales for the month.
/// </summary>

namespace Assignment_1
{
    public partial class SalesBonus : Form
    {
        public SalesBonus()
        {
            InitializeComponent();
        }
        
        // Changes the labels to French.
        private void _FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Nom de l'employé:";
            EmployeeIDLabel.Text = "Employé ID:";
            TotalHoursLabel.Text = "Heures totales:";
            TotalMonthlySalesLabel.Text = "Total des ventes mensuelles:";
            SalesBonusLabel.Text = "Bonus de vente:";
            CalculateButton.Text = "Calculer";
            NextButton.Text = "Prochain";
            PrintButton.Text = "Impression";
        }

        // Changes the Labels to English.
        private void _EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Employee Name:";
            EmployeeIDLabel.Text = "Employee ID:";
            TotalHoursLabel.Text = "Total Hours:";
            TotalMonthlySalesLabel.Text = "Total Monthly Sales:";
            SalesBonusLabel.Text = "Sales Bonus:";
        }
        /// <summary>
        /// When Calculate is pressed, it will calculate the Sales Bonus using
        /// the Total Hours Worked, and the Total Monthly Sales for the employee
        /// and the Employer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _CalculateButton_Click(object sender, EventArgs e)
        {
            // Private variables
            double _HoursWorked;
            double _TotalMonthlySales;
            double _SalesBonus;

            try
            {
                _HoursWorked = Convert.ToDouble(TotalHoursUpDownBox.Text) / 160;
                _TotalMonthlySales = Convert.ToDouble(TotalMonthlySalesTextbox.Text) * 0.02;
                _SalesBonus = _HoursWorked * _TotalMonthlySales;

                SalesBonusTextbox.Text = _SalesBonus.ToString("C2");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data.", "Input Error.");
                Debug.WriteLine(exception.Message);
            }

        }

        //Resets all fields to either blank or default values.
        private void _NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextbox.Text = "";
            EmployeeIDTextbox.Text = "";
            TotalHoursUpDownBox.Value = 0;
            SalesBonusTextbox.Text = "$0.00";
        }

        // Shows message box that tells the user that it is printing.
        private void _PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing to the Printer", "Printing", MessageBoxButtons.OKCancel);
        }
    }   
}

