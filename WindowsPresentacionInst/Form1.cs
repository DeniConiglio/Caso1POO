using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaInstrumentos.Models.Base;
using PracticaInstrumentos.Models.Derivada;


namespace WindowsPresentacionInst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfinarGuitarra_Click(object sender, EventArgs e)
        {
            //Guitarra guitarra = new Guitarra("afinando guitarra..");
            MessageBox.Show("afinando guitarra..");
            
        }

        private void btnAfinarViolin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("afinando violin..");
        }

        private void btnAfinarPiano_Click(object sender, EventArgs e)
        {
            MessageBox.Show("afinando piano..");
        }
    }
}
