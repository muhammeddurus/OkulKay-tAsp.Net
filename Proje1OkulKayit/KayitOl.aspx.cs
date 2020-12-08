using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje1OkulKayit
{
    public partial class KayitOl : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == false)
            {
                Alarm();
               
                
            }
            else
            {
               
                DataSet1TableAdapters.TBLOGRENCITableAdapter dt= new DataSet1TableAdapters.TBLOGRENCITableAdapter() ;
                dt.OgrenciEkle(TextBox2.Text, TextBox1.Text, TextBox3.Text, TextBox4.Text);
            }
            

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void Alarm()
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Hatalı Giriş Kontrol Ediniz');", true);
        }
    }
}