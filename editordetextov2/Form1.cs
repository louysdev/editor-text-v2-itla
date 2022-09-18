using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace editordetextov2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrir_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivo.ReadLine();
            textBox1.Text = r.ToString();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Sin titulo.txt";
            var guardar = saveFileDialog1.ShowDialog();

            if (guardar == DialogResult.OK)
            {
                using (var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_archivo.WriteLine(textBox1.Text);
                }
            }


        }

        private void salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void atras_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void adelante_Click(object sender, EventArgs e)
        {
           
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void pegar_Click(object sender, EventArgs e)
        {
            textBox1.Paste();  
        }

        private void seleccionnar_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void tipoDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == DialogResult.OK) 
            {
                textBox1.ForeColor = colorDialog1.Color;
            }


        }

        private void tipoDeLetraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog();
            if(frmt == DialogResult.OK) 
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void formatoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void nuevo_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
    
}
