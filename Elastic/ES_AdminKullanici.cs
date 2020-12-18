using FinalIsTakipLibrary.Core;
using KucukLibrary.Genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalIsTakipLibrary.Elastic
{
    public class ES_AdminKullanici : ES_Base
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string EPosta { get; set; }

        public static ES_AdminKullanici Yarat(AdminKullanici adminKullanici)
        {            
            if (adminKullanici.Id == -1)
                return new ES_AdminKullanici();

            var retVal = new ES_AdminKullanici();

            retVal.Id = adminKullanici.Id;
            retVal.Ad = StringIslemleri.KarakterleriSadelestir(adminKullanici.Ad);
            retVal.Soyad = StringIslemleri.KarakterleriSadelestir(adminKullanici.Soyad);
            retVal.EPosta = StringIslemleri.KarakterleriSadelestir(adminKullanici.EPosta);

            return retVal;
        }
    }
}
