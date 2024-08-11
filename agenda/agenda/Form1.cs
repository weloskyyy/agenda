using System;
using System.Linq;
using System.Windows.Forms;
using agenda.model;

namespace agenda
{
    public partial class Form1 : Form
    {
        private agendaElectronicaEntities context;

        public Form1()
        {
            InitializeComponent();
            context = new agendaElectronicaEntities();
            CargarData();
        }

        private void CargarData()
        {
            dgvContactos.DataSource = context.Contactos.ToList();

            if (dgvContactos.Columns["Eliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
                {
                    Name = "Eliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat,
                    DefaultCellStyle = { BackColor = System.Drawing.Color.Red, ForeColor = System.Drawing.Color.White }
                };
                dgvContactos.Columns.Add(btnEliminar);
            }

            if (dgvContactos.Columns["Actualizar"] == null)
            {
                DataGridViewButtonColumn btnActualizar = new DataGridViewButtonColumn
                {
                    Name = "Actualizar",
                    Text = "Actualizar",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat,
                    DefaultCellStyle = { BackColor = System.Drawing.Color.Blue, ForeColor = System.Drawing.Color.White }
                };
                dgvContactos.Columns.Add(btnActualizar);
            }
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = buscarInp.Text.ToLower();

            var contactoFiltrado = context.Contactos
                .Where(c => c.Nombre.ToLower().Contains(searchTerm) ||
                            c.Apellido.ToLower().Contains(searchTerm) ||
                            c.NumeroTelefono.ToLower().Contains(searchTerm) ||
                            c.CorreoElectronico.ToLower().Contains(searchTerm) ||
                            c.Direccion.ToLower().Contains(searchTerm))
                .ToList();

            dgvContactos.DataSource = contactoFiltrado;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (guardarBtn.Text == "Actualizar")
            {
                if (dgvContactos.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["Id"].Value);
                    var contacto = context.Contactos.Find(id);
                    if (contacto != null)
                    {
                        contacto.Nombre = nombreInp.Text;
                        contacto.Apellido = apellidoInp.Text;
                        contacto.NumeroTelefono = numeroInp.Text;
                        contacto.CorreoElectronico = correoInp.Text;
                        contacto.Direccion = direccionInp.Text;

                        context.SaveChanges();
                        guardarBtn.Text = "Guardar";
                        CargarData();

                        LimpiarCampos(); // Limpia los campos
                    }
                }
            }
            else
            {
                Contactos contacto = new Contactos
                {
                    Nombre = nombreInp.Text,
                    Apellido = apellidoInp.Text,
                    NumeroTelefono = numeroInp.Text,
                    CorreoElectronico = correoInp.Text,
                    Direccion = direccionInp.Text
                };

                context.Contactos.Add(contacto);
                context.SaveChanges();
                CargarData();

                LimpiarCampos(); 
            }
        }

        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvContactos.Columns["Eliminar"].Index)
                {
                    int id = Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells["Id"].Value);
                    var contacto = context.Contactos.Find(id);
                    if (contacto != null)
                    {
                        context.Contactos.Remove(contacto);
                        context.SaveChanges();
                        CargarData();
                    }
                }
                else if (e.ColumnIndex == dgvContactos.Columns["Actualizar"].Index)
                {
                    int id = Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells["Id"].Value);
                    var contacto = context.Contactos.Find(id);
                    if (contacto != null)
                    {
                        nombreInp.Text = contacto.Nombre;
                        apellidoInp.Text = contacto.Apellido;
                        numeroInp.Text = contacto.NumeroTelefono;
                        correoInp.Text = contacto.CorreoElectronico;
                        direccionInp.Text = contacto.Direccion;

                        guardarBtn.Text = "Actualizar";
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
            nombreInp.Text = "";
            apellidoInp.Text = "";
            numeroInp.Text = "";
            correoInp.Text = "";
            direccionInp.Text = "";
        }

        private void nombreInp_TextChanged(object sender, EventArgs e)
        {
        }

        private void apellidoInp_TextChanged(object sender, EventArgs e)
        {
        }

        private void numeroInp_TextChanged(object sender, EventArgs e)
        {
        }

        private void correoInp_TextChanged(object sender, EventArgs e)
        {
        }

        private void direccionInp_TextChanged(object sender, EventArgs e)
        {
        }

        private void buscarInp_TextChanged(object sender, EventArgs e)
        {
            buscarBtn_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void numeroLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
