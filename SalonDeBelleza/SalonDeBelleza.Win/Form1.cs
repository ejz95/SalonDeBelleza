﻿using SalonDeBelleza.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalondeBelleza.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productosBL = new ProductosBL();
            var ListadeProductos = productosBL.ObtenerProductos();

            listadeProductosBindingSource.DataSource = ListadeProductos;
        }
    }
}
