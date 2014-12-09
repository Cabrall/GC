using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enteros
{
    public partial class frmEnteros : Form
    {
        public frmEnteros()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            
        }

       

        private void frmEnteros_Load(object sender, EventArgs e)
        {

        }

        private void convertirUnNumeroALiteralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enteros.Negocio.Entero entero = new Enteros.Negocio.Entero();
            entero.set(int.Parse(txbIntroduzcaNumero.Text));
            lblNumLetras.Text= entero.enletras();
        }

        private void esParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enteros.Negocio.Entero entero = new Enteros.Negocio.Entero();
            entero.set(int.Parse(txbIntroduzcaNumero.Text));
            lblResultado.Text = "{ "+ entero.EsPar()+" }";
           
        }

        private void esPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enteros.Negocio.Entero entero = new Enteros.Negocio.Entero();
            entero.set(int.Parse(txbIntroduzcaNumero.Text));
            lblResultado.Text = "{ "+ entero.esPrimo()+" }";
                
           

        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enteros.Negocio.Entero entero = new Enteros.Negocio.Entero();
            entero.set(int.Parse(txbIntroduzcaNumero.Text));
            lblResultado.Text = "{ " + entero.invertir() + " }";

        }

        private void esCapicuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enteros.Negocio.Entero entero = new Enteros.Negocio.Entero();
            entero.set(int.Parse(txbIntroduzcaNumero.Text));
            lblResultado.Text = "{ " + entero.esCapicua() + " }";

        }

        private void cantidadDeDigitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enteros.Negocio.Entero entero = new Enteros.Negocio.Entero();
            entero.set(int.Parse(txbIntroduzcaNumero.Text));
            lblResultado.Text = "{ " + entero.cantidadDigitos() + " }";
        }

        private void cantidadDeDigitosPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enteros.Negocio.Entero entero = new Enteros.Negocio.Entero();
            entero.set(int.Parse(txbIntroduzcaNumero.Text));
            lblResultado.Text = "{ " + entero.cantidadDigitosPrimo() + " }";

        }

        private void cantidadDigitosParEImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enteros.Negocio.Entero entero = new Enteros.Negocio.Entero();
            entero.set(int.Parse(txbIntroduzcaNumero.Text));
            lblResultado.Text = "{ " + entero.cantidadDigitosParImpar() + " }";
        }

        private void promediosParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enteros.Negocio.Entero entero = new Enteros.Negocio.Entero();
            entero.set(int.Parse(txbIntroduzcaNumero.Text));
            lblResultado.Text = "{ " + entero.PromedioPar() + " }";
        }

        private void mostrarDigitosPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enteros.Negocio.Entero entero = new Enteros.Negocio.Entero();
            entero.set(int.Parse(txbIntroduzcaNumero.Text));
            lblResultado.Text = "{ " + entero.mostrarPrimos() + " }";
        }

        private void eliminarPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enteros.Negocio.Entero entero = new Enteros.Negocio.Entero();
            entero.set(int.Parse(txbIntroduzcaNumero.Text));
            lblResultado.Text = "{ " + entero.eliminarPrimos() + " }";
        }
           

       
    }
}
