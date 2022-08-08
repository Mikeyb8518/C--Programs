using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile_Costs
{
    public partial class automobile_Cost_Form : Form
    {
        public automobile_Cost_Form()
        {
            InitializeComponent();
        }

        private void automobile_Cost_Form_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            double loan_payment;    // Loan Payment Cost
            double insurance_cost;  // Insurance Cost
            double gas_cost;        // Gas Cost
            double oil_cost;        // Oil Cost
            double tire_cost;       // Tire Cost
            double maintenance_cost; // Maintenance Cost
            double total;           // Total Of All Costs

            loan_payment = double.Parse(loan_Box.Text); // User Enters Loan Payment
            insurance_cost = double.Parse(insurance_Box.Text);  // User Enters insurance Cost
            gas_cost = double.Parse(gas_Box.Text); // User Enters Gas Cost
            oil_cost = double.Parse(oil_Box.Text); // User Enters Oil Cost
            tire_cost = double.Parse(tire_Box.Text); // User Enters Tire Cost
            maintenance_cost = double.Parse(maintenance_Box.Text); // User Enters Tire Cost

            total = loan_payment + insurance_cost + gas_cost + oil_cost + tire_cost + maintenance_cost;
            // Adds The Total Of All Costs For Monthly Payment

            total_Box.Text = total.ToString("c"); // Displays The Monthly Costs Of Your Vehcile
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            loan_Box.Text = "";     // Clears Loan Box
            insurance_Box.Text = "";    // Clears Insurance Box   
            gas_Box.Text = "";      // Clears Gas Box
            oil_Box.Text = "";      // Clears Oil Box
            tire_Box.Text = "";     // Clears Tire Box
            maintenance_Box.Text = "";      // Clears Maintenance Box
            total_Box.Text = "";    // Clears Total Box
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();   // Exits The Program
        }
    }
}
