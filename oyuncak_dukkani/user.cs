using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyuncak_dukkani
{
    public class User
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        // Parametresiz constructor
        public User()
        {
        }

        // Parametreli constructor (tüm alanlar)
        public User(int id, string kullaniciAdi, string sifre, string isim, string soyisim)
        {
            Id = id;
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
            Isim = isim;
            Soyisim = soyisim;
        }
    }
}
