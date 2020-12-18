using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KucukLibrary.Genel;
using Nest;

namespace FinalIsTakipLibrary.Elastic
{
    public class ES_Base
    {
        public int Id;

        public void Indexle<T>(ElasticClient es, T esObject) where T : ES_Base
        {
            IndexSil(es, esObject);
            es.IndexDocument(esObject);
        }


        public void IndexSil<T>(ElasticClient es, T esObject) where T : ES_Base
        {
            es.DeleteByQuery<T>(s => s
                .Query(q => q
                    .Term(p => p.Id, esObject.Id)));
        }

        public void ListeyiIndexle<T>(ElasticClient es, List<T> liste) where T : ES_Base
        {
            foreach (var obj in liste)
                Indexle(es, obj);
        }


        public static List<T> Ara<T>(ElasticClient es, string qry) where T : class
        {
            return es.Search<T>(s => s
                .Query(q => q
                    .QueryString(qs => qs
                        .Query(StringIslemleri.KarakterleriSadelestir(qry))))
                //.From(sayfaNo * sayfadakiKayitSayisi)
                .Size(10000)
            ).Documents.ToList();
        }
    }
}
