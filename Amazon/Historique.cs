using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Historique
    {
        private List<List<Article>> _Historique;

        public Historique()
        {
            Liste_Histo = new List<List<Article>>();
            datetime = DateTime.Now;
        }

        private int KEY;

        [Key]
        public int _key
        {
            get { return KEY; }
            set { KEY = value; }
        }

        [Column("Historique")]
        public List<List<Article>> Liste_Histo
        {
            get { return _Historique; }
            set { _Historique = value; }
        }

        [Column("Date")]
        private DateTime _dateTime;
        public DateTime datetime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }


    }
}
