using CadParcial2Bss;
using ClnParcial2Bss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpParcial2Bss
{
    public partial class FrmSerie : Form
    {
        private bool esNuevo = false;
        public FrmSerie()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            var lista = SerieCln.ListarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["titulo"].HeaderText = "Título";
            dgvLista.Columns["sinopsis"].HeaderText = "Sinopsis";
            dgvLista.Columns["director"].HeaderText = "Director";
            dgvLista.Columns["episodios"].HeaderText = "Episodios";
            dgvLista.Columns["fechaEstreno"].HeaderText = "Fecha de Estreno";
            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["titulo"];
        }

        private void FrmSerie_Load(object sender, EventArgs e)
        {
            Size = new Size(835, 363);
            Listar();
        }

        private void Limpiar()
        {
            txtTitulo.Text = string.Empty;
            txtSinopsis.Text = string.Empty;
            txtDirector.Text = string.Empty;
            nudEpisodios.Value = 0;
            dtpFechaEstreno.Value = dtpFechaEstreno.MinDate;
            txtUrlPortada.Text = string.Empty;
            cbxIdiomaOriginal.SelectedIndex = -1;
        }
   
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(835, 363);
            Limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(835, 487);
            txtTitulo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(860, 650);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var serie = SerieCln.ObtenerUno(id);
            txtTitulo.Text = serie.titulo;
            txtSinopsis.Text = serie.sinopsis;
            txtDirector.Text = serie.director;
            nudEpisodios.Text = serie.episodios.ToString();
            dtpFechaEstreno.Value = serie.fechaEstreno;
            txtUrlPortada.Text = serie.urlPortada;
            cbxIdiomaOriginal.Text = serie.idiomaOriginal;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Listar();
        }

        private bool validar()
        {
            bool esValido = true;
            erpTitulo.SetError(txtTitulo, "");
            erpSinopsis.SetError(txtSinopsis, "");
            erpDirector.SetError(txtDirector, "");
            erpEpisodios.SetError(nudEpisodios, "");
            erpFechaEstreno.SetError(dtpFechaEstreno, "");
            erpUrlPortada.SetError(txtUrlPortada, "");
            erpIdiomaOriginal.SetError(cbxIdiomaOriginal, "");

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                esValido = false;
                erpTitulo.SetError(txtTitulo, "El campo Título es obligatorio");
            }
            if (string.IsNullOrEmpty(txtSinopsis.Text))
            {
                esValido = false;
                erpSinopsis.SetError(txtSinopsis, "El campo Sinopsis es obligatorio");
            }
            if (string.IsNullOrEmpty(txtDirector.Text))
            {
                esValido = false;
                erpDirector.SetError(txtDirector, "El campo Director es obligatorio");
            }
            if (string.IsNullOrEmpty(nudEpisodios.Text))
            {
                esValido = false;
                erpEpisodios.SetError(nudEpisodios, "El campo Episodios es obligatorio");
            }
            if (nudEpisodios.Value <= 0)
            {
                esValido = false;
                erpEpisodios.SetError(nudEpisodios, "El campo Episodios debe ser mayor a Cero");
            }
            if (string.IsNullOrEmpty(dtpFechaEstreno.Text))
            {
                esValido = false;
                erpFechaEstreno.SetError(dtpFechaEstreno, "El campo Fecha de Estreno es obligatorio");
            }
            if (string.IsNullOrEmpty(txtUrlPortada.Text))
            {
                esValido = false;
                erpUrlPortada.SetError(txtUrlPortada, "El campo URL Portada es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxIdiomaOriginal.Text))
            {
                esValido = false;
                erpIdiomaOriginal.SetError(cbxIdiomaOriginal, "El campo Idioma Original es obligatorio");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var serie = new Serie();
                serie.titulo = txtTitulo.Text.Trim();
                serie.sinopsis = txtSinopsis.Text.Trim();
                serie.director = txtDirector.Text.Trim();
                serie.episodios = (int)nudEpisodios.Value;
                serie.fechaEstreno = dtpFechaEstreno.Value;
                serie.urlPortada = txtUrlPortada.Text.Trim();
                serie.idiomaOriginal = cbxIdiomaOriginal.Text.Trim();

                if (esNuevo)
                {
                    serie.estado = 1;
                    SerieCln.Insertar(serie);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    serie.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    SerieCln.Actualizar(serie);
                }
                Listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Serie guardada correctamente", "::: Parcial2 - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string titulo = dgvLista.Rows[index].Cells["titulo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja la serie con título {titulo}?",
                "::: Parcial2 - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                SerieCln.Eliminar(id);
                Listar();
                MessageBox.Show("Serie dado de baja correctamente", "::: Parcial2 - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
