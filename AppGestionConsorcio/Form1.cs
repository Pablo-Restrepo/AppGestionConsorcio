using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGestionConsorcio.logica;

namespace AppGestionConsorcio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Consorcio con = new Consorcio();
        Abogado abo = new Abogado();
        Trabajo tra = new Trabajo();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int nit, resultado = 0, aniofundacion;
            string nombre;
            if (!txtNIT.Text.Equals("") && !txtNombre.Text.Equals("") && !txtAnioFund.Text.Equals(""))
            {
                try
                {
                    nit = int.Parse(txtNIT.Text);
                    nombre = txtNombre.Text;
                    aniofundacion = int.Parse(txtAnioFund.Text);
                    resultado = con.registrarConsorcio(nit, nombre, aniofundacion);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Formato incorrecto" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                if (resultado > 0)
                {
                    MessageBox.Show("Consorcio registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNIT.Clear();
                    txtNombre.Clear();
                    txtAnioFund.Clear();
                }
                else
                {
                    MessageBox.Show("Consorcio NO registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay espacios vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarAbo_Click(object sender, EventArgs e)
        {
            int id, resultado=0;
            string nombre,apellido,tipoabogado, numcasosganados;
            if (!txtCedula.Text.Equals("") && !txtNombreAbo.Text.Equals("") && !txtApellido.Text.Equals("") && !cbCasosGanados.Text.Equals("") && !cbTipoAbogado.Text.Equals(""))
            {
                try
                {
                    id = int.Parse(txtCedula.Text);
                    nombre = txtNombreAbo.Text;
                    apellido = txtApellido.Text;
                    numcasosganados = cbCasosGanados.Text;
                    tipoabogado = cbTipoAbogado.Text;
                    resultado = abo.registrarAbogado(id, nombre, apellido, numcasosganados, tipoabogado);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (resultado > 0)
                {
                    MessageBox.Show("Abogado registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCedula.Clear();
                    txtNombreAbo.Clear();
                    txtApellido.Clear();
                }
                else
                {
                    MessageBox.Show("Abogado NO registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay espacios vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardartrabajo_Click(object sender, EventArgs e)
        {
            int id, NIT, resultado=0;
            string inicio, fin;
            if (!txtNITt.Text.Equals("") && !txtCedulat.Text.Equals("") && !dateTimeInicio.Text.Equals("") && !dateTimeFin.Text.Equals(""))
            {
                try
                {
                    NIT = int.Parse(txtNITt.Text);
                    id = int.Parse(txtCedulat.Text);
                    inicio = dateTimeInicio.Text;
                    fin = dateTimeFin.Text;
                    resultado = tra.registrarTrabajo(NIT, id, inicio, fin);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                if (resultado > 0)
                {
                    MessageBox.Show("Trabajo registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNITt.Clear();
                    txtCedulat.Clear();
                }
                else
                {
                    MessageBox.Show("Trabajo NO registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay espacios vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fin;
            if (!dateTimeFInicio.Text.Equals(""))
            {
                DataSet dsResultado = new DataSet();
                fin = dateTimeFInicio.Text;
                dsResultado = tra.buscarFechaIni(fin);
                dataGridFechas.DataSource = dsResultado;
                dataGridFechas.DataMember = "ResultadoDatos";
            }
            else
            {
                MessageBox.Show("Hay espacios vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarAboga_Click(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();
            dsResultado = abo.cuantosPenalistas();
            lblNumAboPenal.Text = "Numero de Abogados Penalistas es:  " + dsResultado.Tables[0].Rows[0].ItemArray[0].ToString(); ;
        }
    }
}
