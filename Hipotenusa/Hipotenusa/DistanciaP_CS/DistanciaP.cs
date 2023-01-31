using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanciaP_CS
{
    public partial class DistanciaP : Form
    {
        public DistanciaP()
        {
            InitializeComponent();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            double d;
            Distancia dis = new Distancia(Int32.Parse(Txt_x1.Text) , Int32.Parse(Txt_x2.Text), Int32.Parse(Txt_y1.Text), Int32.Parse(Txt_y2.Text));
            d = dis.Calcular();

            Text_Resultado.Text = d.ToString();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Text_Resultado.Clear();
            Txt_x1.Text = ("");
            Txt_x2.Text = ("");
            Txt_y2.Text = ("");
            Txt_y1.Text = ("");
        }

        private void DistanciaP_Load(object sender, EventArgs e)
        {
            Text_Resultado.Enabled = false;
        }
    }
}
