using FinalIsTakipLibrary.Core;
using KucukLibrary.Genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalIsTakipLibrary.Elastic
{
    public class ES_KullaniciIs : ES_Base
    {
        public string Aciklama { get; set; }

        public ES_AdminKullanici Kullanici { get; set; }

        public static ES_KullaniciIs Yarat(KullaniciIs kullaniciIs)
        {
            if (kullaniciIs.Id == -1)
                return new ES_KullaniciIs();

            var retVal = new ES_KullaniciIs();

            retVal.Id = kullaniciIs.Id;
            retVal.Aciklama= StringIslemleri.KarakterleriSadelestir(kullaniciIs.Aciklama);
            retVal.Kullanici = ES_AdminKullanici.Yarat(AdminKullanici.Getir(kullaniciIs.KullaniciId));

            return retVal;
        }
    }
}
