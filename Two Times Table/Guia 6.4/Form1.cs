using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        int Dos = 2;
        int Incremento = 0;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            int resultado = 0;
            IncrementoUno (ref Incremento);
            Calcular(resultado,Incremento);
            
            
        }
        private void IncrementoUno(ref int incremento)
        {
            incremento = incremento + 1;
        }
        
        private void Calcular (int resultado, int incremento1)
        {
                     
            resultado = Dos * incremento1;
            lstTabla.Items.Add(Dos + "X" + incremento1 + "= " + resultado);
        }
        

    }

}
