﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrudSharp
{
    public partial class FrmPhysicalPerson : Form
    {
        public FrmPhysicalPerson()
        {
            InitializeComponent();
        }

        private void FrmPhysicalPerson_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
