﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _14_6_24Laboratorio.Models;

namespace _14_6_24Laboratorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Controlador control = new Controlador();

        private void btnAgregarCompetidor_Click(object sender, EventArgs e)
        {
            InscripcionCompetidor inscrip = new InscripcionCompetidor();    
            if (inscrip.ShowDialog() == DialogResult.OK)
            {
                control.AgregarCompetidor(inscrip.tbNombre.Text);
            }
            inscrip.Dispose();
        }

        private void btnCargarTiempos_Click(object sender, EventArgs e)
        {
            CargaDeTiempo cargar = new CargaDeTiempo(); 
            for (int i = 0; i < control.cont; i++)
            {
                if (cargar.ShowDialog() == DialogResult.OK)
                {
                    control.AgregarTiempos(control.cont, Convert.ToInt32(cargar.tbHoras.Text), Convert.ToInt32(cargar.tbMins.Text));
                }
            }
            cargar.Dispose();
        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            VerResultados ver = new VerResultados();
            control.MetodoBurbuja();
            for (int i = 0; i<control.cont; i++)
            {
                ver.lbxResultados.Items.Add($"{i}, {control.names}, {control.tiempos}");
            }

            if (ver.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
