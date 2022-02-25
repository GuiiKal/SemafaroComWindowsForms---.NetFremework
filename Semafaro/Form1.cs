using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semafaro
{
   
    public partial class Form1 : Form
    {
        Timer timer1 = new Timer();
        int aux = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(semafaro);
            timer1.Start();

        }
        private void semafaro(object sender, EventArgs e)
        {
            switch (aux)
            {
                case 0:
                    pictureBoxVerdeAcesso.Image = Properties.Resources.verde_aceso;
                    pictureBoxPedestre.Image = Properties.Resources.ped_vermelho;
                    pictureBoxVermelhoA.Image = Properties.Resources.vermelho;
                    pictureBoxAmarelo.Image = Properties.Resources.amarelo;
                    timer1.Interval = 7000;
                    aux = 1;
                break;
                case 1:
                    pictureBoxAmarelo.Image = Properties.Resources.amarelo_aceso;
                    pictureBoxPedestre.Image = Properties.Resources.ped_vermelho;
                    pictureBoxVerdeAcesso.Image = Properties.Resources.verde;
                    pictureBoxVermelhoA.Image = Properties.Resources.vermelho;
                    timer1.Interval = 2000;
                    aux = 2;
                break;
                case 2:
                    pictureBoxVermelhoA.Image = Properties.Resources.vermelho_aceso;
                    pictureBoxPedestre.Image = Properties.Resources.ped_verde;
                    pictureBoxVerdeAcesso.Image = Properties.Resources.verde;
                    pictureBoxAmarelo.Image = Properties.Resources.amarelo;
                    timer1.Interval = 5000;
                    aux = 0;
                break;


            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
