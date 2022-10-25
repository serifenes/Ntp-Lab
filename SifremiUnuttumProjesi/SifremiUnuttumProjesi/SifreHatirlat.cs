using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db;

namespace SifremiUnuttumProjesi
{
    public partial class SifreHatirlat : Form
    {

        public SifreHatirlat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            SqlConnection con=dbConnection.Connect();
            string kullaniciadi = textBox1.Text;
            SqlCommand command = new SqlCommand("Select * from kullanicilar where kullaniciadi='"+kullaniciadi+"'", con);
            
            SqlDataReader oku = command.ExecuteReader();
            if (oku.Read())
            {
                   sendMail(oku);
                MessageBox.Show("mail gönderildi", "başarılı");
                this.Hide();
            }
            else
            {
                MessageBox.Show("böyle bir kullanıcı yok", "hata");
            }
            

        }

        public static void sendMail(SqlDataReader oku)
        {
            try
            {
                string mail = oku["eposta"].ToString();
                String mesaj = "Merhaba, sistemde kayıtlı olan şifreniz; " + "<br><strong>" + oku["sifre"].ToString() + "</strong><br><br><h3>Şerif Enes Atçı</h3> ";
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.office365.com"; // Hostunuzun smtp için mail domaini.
                client.EnableSsl = true; // Güvenlik ayarları, host'a ve gönderilen server'a göre değişebilir.
                client.Timeout = 10000; // Milisaniye cinsten timeout
                client.DeliveryMethod = SmtpDeliveryMethod.Network; // Mailin yollanma methodu
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("serifenes36@outlook.com", "ntpodev123456"); // Burada hangi hesabı kullanarak mail yollayacaksanız onun ayarlarını yapmanız gerekiyor
                MailMessage mm = new MailMessage("serifenes36@outlook.com", mail, "Şifre Yenileme", mesaj); // Hangi mail adresinden nereye, konu ve içerik mail ayarlarını yapabilirsiniz
                mm.IsBodyHtml = true; // True: Html olarak Gönderme, False: Text olarak Gönderme
                mm.BodyEncoding = UTF8Encoding.UTF8; // UTF8 encoding ayarı
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure; // Hata olduğunda uyarı ver 
                client.Send(mm); // Mail yolla
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        
        }
       
        private void SifreHatirlat_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
