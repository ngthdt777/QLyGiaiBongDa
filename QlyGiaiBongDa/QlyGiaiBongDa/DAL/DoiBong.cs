using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyGiaiBongDa.BLL
{
    public class DoiBong
    {
        public string id { get; set; }
        public string ten { get; set; }
        public string ten_sannha { get; set; }
        public string slgct { get; set; }
        public DoiBong(string id, string ten, string ten_sannha, string slgct)
        {
            this.id = id;
            this.ten = ten;
            this.ten_sannha = ten_sannha;
            this.slgct = slgct;
        }
        public DoiBong() { }
    }
}
