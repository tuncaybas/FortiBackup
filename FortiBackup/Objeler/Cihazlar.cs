using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortiBackup.Objeler
{
   public class Cihazlar
    {
        public int ID { get; set; }
        public string CihazAdi { get; set; }
        public string Adres { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Turu Tip { get; set; }
    }

    public class CihazList
    {
        public List<Cihazlar> cihazlar { get; set; }
    }

    public enum Turu
    {
        Fortigate,
        Fortimail
    }

}
