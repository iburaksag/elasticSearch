using Nest;
using System;

namespace FinalIsTakipLibrary.Elastic
{
    public class ES_ClientMotoru
    {
        private static readonly string _elasticSearchAddress = "http://localhost:9200";

        public static ElasticClient AdminKullaniciClientGetir()
        {
            return new ElasticClient(new ConnectionSettings(new Uri(_elasticSearchAddress)).DefaultIndex("adminkullanicifit"));
        }

        public static ElasticClient KullaniciIsClientGetir()
        {
            return new ElasticClient(new ConnectionSettings(new Uri(_elasticSearchAddress)).DefaultIndex("kullaniciis"));
        }
    }
}
