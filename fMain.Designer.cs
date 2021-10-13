
namespace GestorDeTareas
{
    partial class Gestor_de_tareas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestor_de_tareas));
            this.Titulo = new System.Windows.Forms.TextBox();
            this.ListTask = new System.Windows.Forms.ListBox();
            this.TexBox = new System.Windows.Forms.TextBox();
            this.AddNewTask = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Titulo, "Titulo");
            this.Titulo.Name = "Titulo";
            // 
            // ListTask
            // 
            resources.ApplyResources(this.ListTask, "ListTask");
            this.ListTask.FormattingEnabled = true;
            this.ListTask.Name = "ListTask";
            this.ListTask.SelectedIndexChanged += new System.EventHandler(this.ListTask_SelectedIndexChanged);
            // 
            // TexBox
            // 
            resources.ApplyResources(this.TexBox, "TexBox");
            this.TexBox.Name = "TexBox";
            this.TexBox.TextChanged += new System.EventHandler(this.TexBox_TextChanged);
            // 
            // AddNewTask
            // 
            resources.ApplyResources(this.AddNewTask, "AddNewTask");
            this.AddNewTask.Name = "AddNewTask";
            this.AddNewTask.UseVisualStyleBackColor = true;
            this.AddNewTask.Click += new System.EventHandler(this.AddNewTask_Click);
            // 
            // SaveChanges
            // 
            resources.ApplyResources(this.SaveChanges, "SaveChanges");
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Cancel
            // 
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.Name = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Gestor_de_tareas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.AddNewTask);
            this.Controls.Add(this.TexBox);
            this.Controls.Add(this.ListTask);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestor_de_tareas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gestor_de_tareas_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.ListBox ListTask;
        private System.Windows.Forms.TextBox TexBox;
        private System.Windows.Forms.Button AddNewTask;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

