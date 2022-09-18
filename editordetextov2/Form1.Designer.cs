namespace editordetextov2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionnar = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeLetraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(755, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevo,
            this.abrir,
            this.toolStripSeparator1,
            this.guardar,
            this.toolStripSeparator4,
            this.salir});
            this.archivosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(50, 27);
            this.archivosToolStripMenuItem.Text = "File";
            this.archivosToolStripMenuItem.Click += new System.EventHandler(this.archivosToolStripMenuItem_Click);
            // 
            // nuevo
            // 
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.Name = "nuevo";
            this.nuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevo.Size = new System.Drawing.Size(224, 28);
            this.nuevo.Text = "New";
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click_1);
            // 
            // abrir
            // 
            this.abrir.Image = ((System.Drawing.Image)(resources.GetObject("abrir.Image")));
            this.abrir.Name = "abrir";
            this.abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrir.Size = new System.Drawing.Size(224, 28);
            this.abrir.Text = "Open";
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // guardar
            // 
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.Name = "guardar";
            this.guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardar.Size = new System.Drawing.Size(224, 28);
            this.guardar.Text = "Save As...";
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // salir
            // 
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Name = "salir";
            this.salir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salir.Size = new System.Drawing.Size(224, 28);
            this.salir.Text = "Exit";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.copiar,
            this.pegar,
            this.cortarToolStripMenuItem,
            this.toolStripSeparator3,
            this.seleccionnar,
            this.eliminar});
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.editarToolStripMenuItem.Text = "Edit";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // copiar
            // 
            this.copiar.Image = ((System.Drawing.Image)(resources.GetObject("copiar.Image")));
            this.copiar.Name = "copiar";
            this.copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiar.Size = new System.Drawing.Size(294, 28);
            this.copiar.Text = "Copy";
            this.copiar.Click += new System.EventHandler(this.copiar_Click);
            // 
            // pegar
            // 
            this.pegar.Image = ((System.Drawing.Image)(resources.GetObject("pegar.Image")));
            this.pegar.Name = "pegar";
            this.pegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegar.Size = new System.Drawing.Size(294, 28);
            this.pegar.Text = "Paste";
            this.pegar.Click += new System.EventHandler(this.pegar_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripMenuItem.Image")));
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.cortarToolStripMenuItem.Text = "Cut";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(291, 6);
            // 
            // seleccionnar
            // 
            this.seleccionnar.Image = ((System.Drawing.Image)(resources.GetObject("seleccionnar.Image")));
            this.seleccionnar.Name = "seleccionnar";
            this.seleccionnar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.seleccionnar.Size = new System.Drawing.Size(294, 28);
            this.seleccionnar.Text = "Select All";
            this.seleccionnar.Click += new System.EventHandler(this.seleccionnar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.Name = "eliminar";
            this.eliminar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.eliminar.Size = new System.Drawing.Size(294, 28);
            this.eliminar.Text = "Delete All";
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.tipoDeLetraToolStripMenuItem});
            this.formatoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.formatoToolStripMenuItem.Text = "Format";
            this.formatoToolStripMenuItem.Click += new System.EventHandler(this.formatoToolStripMenuItem_Click_1);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorToolStripMenuItem.Image")));
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(135, 28);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click_1);
            // 
            // tipoDeLetraToolStripMenuItem
            // 
            this.tipoDeLetraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoDeLetraToolStripMenuItem.Image")));
            this.tipoDeLetraToolStripMenuItem.Name = "tipoDeLetraToolStripMenuItem";
            this.tipoDeLetraToolStripMenuItem.Size = new System.Drawing.Size(135, 28);
            this.tipoDeLetraToolStripMenuItem.Text = "Font";
            this.tipoDeLetraToolStripMenuItem.Click += new System.EventHandler(this.tipoDeLetraToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(755, 476);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(755, 509);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevo;
        private System.Windows.Forms.ToolStripMenuItem abrir;
        private System.Windows.Forms.ToolStripMenuItem guardar;
        private System.Windows.Forms.ToolStripMenuItem salir;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem copiar;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem seleccionnar;
        private System.Windows.Forms.ToolStripMenuItem eliminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeLetraToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

