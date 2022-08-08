using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Automotive
{
    public partial class automotive_Form : Form
    {
        public automotive_Form()
        {
            InitializeComponent();
        }
        // OilLubeCharges method that takes oil and lube as arguments
        //returns total for oil + lube
        private double OilLubeCharges(double oil, double lube)
        {
            return oil + lube;
        }
        // FlushCharges method that takes radFlush and transFlush as arguments
        // returns total for radFlush + transFlush 
        private double FlushCharges(double radFlush, double transFlush)
        {
            return radFlush + transFlush;
        }
        // MiscChrages method that takes inspection, muffler, tire as arguments
        // returns total of inspection + muffler + tire
        private double MiscCharges(double inspection, double muffler, double tire)
        {
            return inspection + muffler + tire;
        }
        // OtherCharges method that takes parts and labor as arguments
        // returns total of parts + labor
        private double OtherCharges(double parts, double labor)
        {
            return parts + labor;
        }
        // TaxCharges method that takes parts, labor, oilLube, flush, misc, other as arguments
        // If parts, labor, oilLube, flush, misc, other are not equal to 0
        // returns .06 times parts to calculate tax on parts
        // else it returns 0
        private double TaxCharges(double parts, double labor, double oilLube, double flush, double misc, double other)
        {
            if (parts != 0 && labor != 0 && (oilLube != 0 && flush != 0 && misc != 0 && other != 0))
            {
                return .06 * parts;
            }
            else
            {
                return 0;
            }
        }
        // TotalCharges method that takes tax, oilLube, flush, misc, other as arguments
        // returns total of tax + oilLube + flush + misc + other
        private double TotalCharges(double tax, double oilLube, double flush, double misc, double other)
        {
            return tax + oilLube + flush + misc + other;
        }
        // ClearOilLube method see if oil checkbox and lube checkbox is checked
        // then makes oil and lube checkboxes unchecked
        private void ClearOilLube()
        {
            if (oil_Checkbox.Checked == true)
            {
                oil_Checkbox.Checked = false;
            }
            if (lube_Checkbox.Checked == true)
            {
                lube_Checkbox.Checked = false;
            }
        }
        // ClearFlushes method sees if raditator flush and transmission flush is checked
        // then makes radiator and transmission checkbox unchecked
        private void ClearFlushes()
        {
            if (radiatorFlush_Checkbox.Checked == true)
            {
                radiatorFlush_Checkbox.Checked = false;
            }
            if (transFlush_Checkbox.Checked == true)
            {
                transFlush_Checkbox.Checked = false;
            }
        }
        // ClearMisc method sees if inspection, muffler, tireRotation are checked
        // then makes them unchecked
        private void ClearMisc()
        {
            if (inspection_Checkbox.Checked == true)
            {
                inspection_Checkbox.Checked = false;
            }
            if (muffler_Checkbox.Checked == true)
            {
                muffler_Checkbox.Checked = false;
            }
            if (tireRotation_Checkbox.Checked == true)
            {
                tireRotation_Checkbox.Checked = false;
            }
        }
        // ClearOther method makes parts and labor textboxes empty
        private void ClearOther()
        {
            parts_Textbox.Text = null;
            labor_Textbox.Text = null;
        }
        // ClearFees method makes service, partTotal, tax, and total textboxes return empty
        private void ClearFees()
        {
            service_labor_Textbox.Text = null;
            partTotal_Textbox.Text = null;
            tax_Textbox.Text = null;
            total_Textbox.Text = null;
        }
        private void calculate_Button_Click(object sender, EventArgs e)
        {
            // Declares variables 
            double oil = 0, lube = 0, radFlush = 0, transFlush = 0, inspection = 0,
                muffler = 0, tire = 0, parts, labor;
            // If oil checkbox is checked 
            // oil is 26
            if (oil_Checkbox.Checked == true)
            {
                oil = 26;
            }
            // If lube checkbox is checked
            // lube is 18
            if (lube_Checkbox.Checked == true)
            {
                lube = 18;
            }
            // If radiator checkbox is checked
            // radFluah is 30
            if (radiatorFlush_Checkbox.Checked == true)
            {
                radFlush = 30;
            }
            // If transFlush checkbox is checked
            // transFlush is 80
            if (transFlush_Checkbox.Checked == true)
            {
                transFlush = 80;
            }
            // If inspection checkbox is checked
            // inspection is 15
            if (inspection_Checkbox.Checked == true)
            {
                inspection = 15;
            }
            // If muffler checkbox is checked 
            // muffler is 100
            if (muffler_Checkbox.Checked == true)
            {
                muffler = 100;
            }
            // If tireRotation is checked 
            // tire is 20
            if (tireRotation_Checkbox.Checked == true)
            {
                tire = 20;
            }
            // Takes users data for parts and labor textboxes and turns into double
            parts = double.Parse(parts_Textbox.Text);
            labor = double.Parse(labor_Textbox.Text);
            // oilLube vriable calls OilLubeCharges method
            double oilLube = OilLubeCharges(oil, lube);
            // flush variable calls FlushCharges method 
            double flush = FlushCharges(radFlush, transFlush);
            // misc variable calls MiscCharges method
            double misc = MiscCharges(inspection, muffler, tire);
            // other variable calls OtherCharges method
            double other = OtherCharges(parts, labor);
            // tax variable calls TaxCharges method
            double tax = TaxCharges(parts, labor, oilLube, flush, misc, other);
            // total variable calls TotalCharges method
            double total = TotalCharges(oilLube, flush, misc, tax, other);
            // services variable gets total of oilLube + flush + misc
            double services = oilLube + flush + misc;
            // Displays services as string to service_labor textbox
            // Displays others as a string to partTotal textbox
            // Displays tax as a string to tax textbox
            // Displays total as a string to total textbox
            service_labor_Textbox.Text = services.ToString("c");
            partTotal_Textbox.Text = other.ToString("c");
            tax_Textbox.Text = tax.ToString("c");
            total_Textbox.Text = total.ToString("c");
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Calls methods to clear entries
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearFees();
            ClearOther();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
