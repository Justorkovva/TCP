using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void Polacz_Click(object sender, EventArgs e)
        {
            string host = Adres.Text;
            int port = System.Convert.ToInt32(Port.Value);

            try
            {
                TcpClient klient = new TcpClient(host, port);
                info_o_polaczeniach.Items.Add("Nawiazano polaczenie z" + host + "na porcie" + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                info_o_polaczeniach.Items.Add("Błąd : Nie udało się nawiązać połączenia!");
                MessageBox.Show(ex.ToString(), "Błąd");
            }

            }
        
    }
}
