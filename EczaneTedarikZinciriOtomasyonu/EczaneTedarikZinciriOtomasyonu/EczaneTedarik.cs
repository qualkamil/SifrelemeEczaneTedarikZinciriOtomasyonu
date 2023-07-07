using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EczaneTedarikZinciriOtomasyonu
{
    class EczaneTedarik
    {
       
        public OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\kamil\\source\\repos\\EczaneTedarikZinciriOtomasyonu\\EczaneTedarikZinciriOtomasyonu\\EczaneDatabase.accdb");
        public void baglanti()
        {
            conn.Close();
            conn.Open();
        }
        
        public void Kapatma()
        {
            Application.Exit();
        }
        public void baglantiKapa()
        {
            conn.Close();
        }
        

    }
}
