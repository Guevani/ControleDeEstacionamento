using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstacionamento
{
    public partial class MenuPrincipal : Form
                {
        
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        
        private void lblFrase_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            var menuentrada = new Formulários.Entrada();
            menuentrada.ShowDialog();
        }
    }
}
