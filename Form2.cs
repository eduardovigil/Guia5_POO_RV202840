using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia5_POO_RV202840
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private List<Estudiantes> Estudiante = new List<Estudiantes>();
        private int edit_indice = -1;
        public void promedio()
        {

            decimal converperiodo1 = Convert.ToDecimal(textBox2.Text);
            decimal converperiodo2 = Convert.ToDecimal(textBox3.Text);
            decimal converperiodo3 = Convert.ToDecimal(textBox4.Text);
            decimal resultadopromedio;

            resultadopromedio = (converperiodo1 + converperiodo2 + converperiodo3) / 3;
            textBox5.Text = Convert.ToString(resultadopromedio);
        }
        public void limpiar()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private bool validarcampos()
        {
            //variables que verifica si algo ha sido validado
            bool validado = true;
            if (textBox1.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBox1, "Ingresar nombre materia");
            }
            if (textBox2.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBox2, "Ingresar nota periodo 1");
            }
            if (textBox3.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBox3, "Ingresar nota periodo 2");
            }
            if (textBox4.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBox4, "Ingresar nota periodo 3");
            }
            return validado;
        }
        private bool validaciones()
        {
            bool validado = true;
            int converper1 = Convert.ToInt32(textBox2.Text);
            int converper2 = Convert.ToInt32(textBox3.Text);
            int converper3 = Convert.ToInt32(textBox4.Text);
            if (converper1 >= 11)
            {
                MessageBox.Show("Sobrepasa el rango permitido, por favor ingrese un valor valido");
                validado = false;

            }
            else if (converper2 >= 11)
            {
                MessageBox.Show("Sobrepasa el rango permitido, por favor ingrese un valor valido");
                validado = false;
            }
            else if (converper3 >= 11)
            {
                MessageBox.Show("Sobrepasa el rango permitido, por favor ingrese un valor valido");
                validado = false;
            }

            return validado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarcampos() == false)
            {
                MessageBox.Show("Ingrese valores");
            }
            else
            {
                if (validaciones() == false)
                {

                    MessageBox.Show("Ingresaste mal un valor por favor vuelva a intentarlo");
                    limpiar();
                }
                else
                {

                    Estudiantes est = new Estudiantes();
                    est.Nombre = txtnombre.Text;
                    est.Carnet = txtcarnet.Text;
                    est.Nacimiento = txtfecha.Text;
                    est.Correo = txtcorreo.Text;
                    est.Responsable = txtresponsable.Text;
                    est.Materia = textBox1.Text;
                    est.Notas = textBox5.Text;
                    MessageBox.Show("Datos ingresados... ");

                    promedio();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
