using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeTareas
{
    public partial class Gestor_de_tareas : Form
    { 
        private bool IsNewTask;
        private bool CambioTarea;

        public Gestor_de_tareas()//fMain
        {
            InitializeComponent();
            _Reset();
        }

        private void _Reset()
        {
            this.AddNewTask.Enabled = true;
            this.SaveChanges.Enabled = false;
            this.Delete.Enabled = false;
            this.Cancel.Enabled = false;
            this.TexBox.Enabled = false;
            this.TexBox.Text = "";
            this.CambioTarea = false;


            //ListTask eneabled bassed on numbers counts 
            this.ListTask.Enabled = this.ListTask.Items.Count > 0? true : false;
            this.ListTask.SelectedIndex = -1;
        }

        private void AgregarNuevaTarea()
        {
            this.SaveChanges.Enabled = true;
            this.AddNewTask.Enabled = false;
            this.TexBox.Enabled = true;
            this.Cancel.Enabled = true;
           
            this.TexBox.Focus();
            this.IsNewTask = true;
        }

        private void Guardar()
        {
            if (this.TexBox.Text.Length > 0)
            {
                if (this.IsNewTask)
                {
                    this.ListTask.Items.Add(this.TexBox.Text);
                    this._Reset();
                }
                else
                {
                    this.ListTask.Items[this.ListTask.SelectedIndex] = this.TexBox.Text;
                    _Reset();
                }
            }
            else
            {
                MessageBox.Show("Debe agregar una tarea!.", "ADEVERTENCIA!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Eliminar()
        {
            if(MessageBox.Show("Estas seguro de eliminar esta tarea?", "Confirmar eliminacion", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.ListTask.Items.RemoveAt(this.ListTask.SelectedIndex);
                this._Reset();
            }
        }

        private void Cancelar()
        {
            if (CambioTarea == true && MessageBox.Show("Desea cancelar esta accion?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Reset();
            }
            else if(CambioTarea==false)
            {
                _Reset();

            }
        }

        private void TareaSeleccionada()
        {
            if (this.ListTask.SelectedIndex >= 0 && this.ListTask.SelectedIndex < this.ListTask.Items.Count)
            {
                this.TexBox.Text = this.ListTask.Items[this.ListTask.SelectedIndex].ToString();
                this.Delete.Enabled = true;
                this.SaveChanges.Enabled = true;
                this.AddNewTask.Enabled = false;
                this.TexBox.Enabled = true;
                this.Cancel.Enabled = true;
                this.IsNewTask = false;
            }            
        }
        
        //----------------------


        private void AddNewTask_Click(object sender, EventArgs e)
        {
            this.AgregarNuevaTarea();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            this.Guardar();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Cancelar();
        }

        private void TexBox_TextChanged(object sender, EventArgs e)
        {
            CambioTarea = true;
        }

        private void ListTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TareaSeleccionada();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Gestor_de_tareas_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("Desea guardar cambios", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (this.CambioTarea==true && DialogResult == DialogResult.Yes)
            {
                this.Guardar();
            }
            else if(DialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }
    }
}
 