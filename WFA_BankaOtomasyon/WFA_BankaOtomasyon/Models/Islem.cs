using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BankaOtomasyon.Models
{
    public  class Islem
    {
        public string ParaGonder { get; set; }
        public string   ParaCek { get; set; }
        public string ParaYatır { get; set; }

        public DateTime IslemTarihi { get; set; }
    }
}
