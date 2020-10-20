using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class CreateCustomerForm : Form
    {
        private Warehouse _warehouse;
        public CreateCustomerForm(Warehouse warehouse)
        {
            _warehouse = warehouse;
            InitializeComponent();
        }

        private void createCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer temp = new Customer();
                temp.Name = customerNameTB.Text;
                temp.Email = customerEmailTB.Text;
                temp.Number = Int32.Parse(customerNumberTB.Text);
                temp.Phone = customerPhoneTB.Text;
                _warehouse.Customers.Add(temp);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
