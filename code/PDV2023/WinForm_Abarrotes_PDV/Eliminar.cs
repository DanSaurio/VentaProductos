﻿using Middle_Abarrotes_PDV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Back_CRUDs_BD;

namespace pruebaVENTA
{
    public partial class Eliminar : Form
    {
        Producto prod = new Producto();
        public Eliminar()
        {
            InitializeComponent();
        }
        CRUDs_BD bd;



        private void btnAceptarEliminar_Click(object sender, EventArgs e)
        {
            

        }
    }
}
