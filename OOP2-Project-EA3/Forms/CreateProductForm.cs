﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP2_Project_EA3
{
    public partial class CreateProductForm : Form
    {
        private Warehouse _warehouse;
        public CreateProductForm(Warehouse warehouse)
        {
            _warehouse = warehouse;
            InitializeComponent();
        }
    }
}
