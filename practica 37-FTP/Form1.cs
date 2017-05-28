using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;   

namespace practica_37_FTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSalida_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Abrir Archivo";
            abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            abrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            abrir.FilterIndex = 1;
            abrir.RestoreDirectory = true;
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                label2.Text = abrir.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String servidor = textBoxServer.Text + textBoxFile.Text;
            String archivo = label2.Text;
            WebClient myWebClient = new WebClient();
            myWebClient.Credentials = new NetworkCredential("Luis", "5017");
            byte[] responseArray = myWebClient.UploadFile(servidor, archivo);
            lblSalida.Text = System.Text.Encoding.ASCII.GetString(responseArray);
        }
    }
}
