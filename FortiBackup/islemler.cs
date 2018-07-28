using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FortiBackup.Objeler;
using Newtonsoft.Json;
using System.Collections.Generic;
using Renci.SshNet;
using System.Threading;
using System.Globalization;
using System.Resources;
namespace FortiBackup
{
   internal class islemler
    {
        public static string AppDir = Directory.GetParent(Application.ExecutablePath).ToString() + "\\";
        private static string dataKlasor = @"db/";
        private static string dataFile = dataKlasor+"\\ip.db";
        private static string Backup = @"backup/";
        public static string okey = "112233";

        public static ResourceManager res_man;
        public static CultureInfo cul;

        public islemler()
        {
            res_man = Form1.res_man;
            cul = Form1.cul;
        }

        internal static void log(string v)
        {
            StreamWriter sw = new StreamWriter(AppDir + "sonuc.txt", true, Encoding.Default);
            sw.WriteLine(v);
            sw.Close();
        }

        internal static void ProcessResults(string result,string file_name,string hostname, ListViewItem litem)
        {
            string metin = result.Replace(hostname + " # ", "").Replace("--More--", "");
            string[] lines = metin.Split('\n');
            long currentPosition = 0;
            int val = 0;
            string backupFolder = AppDir + Backup + litem.SubItems[1].Text.Replace(" ", "_");

            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }

            
            File.WriteAllLines(backupFolder + "\\" + file_name, lines, Encoding.Default);
           /* 
            StreamWriter sw = new StreamWriter(backupFolder + "\\" + file_name, true, Encoding.Default);
            foreach (string item in lines)
            {
               // string metin = item.Replace(hostname + " # ", "").Replace("--More--", "");
                //dosyayaz(metin,file_name);
                sw.WriteLine(item);
                currentPosition++;
                val = (int)Math.Round(((decimal)currentPosition / (decimal)lines.Length) * (decimal)100, 0);
                litem.SubItems[7].Text = " % "+val.ToString();
                Application.DoEvents();
            }
            sw.Close();
            */
        }

        internal static void DbKontrol()
        {
            if (!Directory.Exists(dataKlasor))
            {
                Directory.CreateDirectory(dataKlasor);
            }

            if (!Directory.Exists(Backup))
            {
                Directory.CreateDirectory(Backup);
            }
            if (!File.Exists(dataFile))
            {
                File.Create(dataFile).Close();
            }
        }

        internal static Result CihazSil(Cihazlar cihaz)
        {
            Result r = new Result();
            try
            {
                CihazList plist = new CihazList();
                plist.cihazlar = new List<Cihazlar>();
                var clist = GetAllCihazlar();
                foreach (Cihazlar item in clist.cihazlar)
                {
                    if (!item.ID.Equals(cihaz.ID))
                    {
                        plist.cihazlar.Add(item);
                    }
                }
                int sira = 1;
                foreach (Cihazlar item in plist.cihazlar)
                {
                    item.ID = sira;
                    sira++;
                }

                var json = JsonConvert.SerializeObject(plist);
                RecordDatabase(json);
                r.success = true;
                r.mesaj = cihaz.CihazAdi + " "+ res_man.GetString("txtSilindi", cul);
            }
            catch (Exception e)
            {
                r.success = false;
                r.mesaj = e.Message;
            }
            return r;
        }

        public Result CihazD(Cihazlar cihaz)
        {
            return CihazDuzenle(cihaz);
        }

        public Result CihazK(Cihazlar cihaz)
        {
            return CihazKayit(cihaz);
        }

        public Result CihazS(Cihazlar cihaz)
        {
            return CihazSil(cihaz);
        }

        internal static Result CihazDuzenle(Cihazlar cihaz)
        {
            Result r = new Result();
            try
            {
                var clist = GetAllCihazlar();
                foreach (Cihazlar item in clist.cihazlar)
                {
                    if (item.ID.Equals(cihaz.ID))
                    {
                        item.Adres= cihaz.Adres;
                        item.CihazAdi = cihaz.CihazAdi;
                        item.Password = cihaz.Password;
                        item.Port = cihaz.Port;
                        item.Username = cihaz.Username;
                        item.Tip = cihaz.Tip;
                    }
                }

                CihazList plist = new CihazList();
                plist.cihazlar = new List<Cihazlar>();
                plist.cihazlar= clist.cihazlar;
                var json = JsonConvert.SerializeObject(plist);
                RecordDatabase(json);
                r.success = true;
                r.mesaj = cihaz.CihazAdi + " "+ res_man.GetString("txtDuzenlendi", cul);
            }
            catch (Exception e)
            {
                r.success = false;
                r.mesaj = e.Message+" \n"+e.StackTrace;
            }
            return r;
        }

        private static void dosyayaz(string item,string dosya)
        {
            StreamWriter sw = new StreamWriter(AppDir + Backup+"\\"+ dosya, true, Encoding.Default);
            sw.WriteLine(item);
            sw.Close();
        }

        internal static string getHostName(string result)
        {
            string[] lines = result.Split('\n');
            string hostname = "";
            foreach (string item in lines)
            {
                string metin = item.Replace("--More--", "");
                string[] bol = metin.Split(':');
                if (bol[0].Trim().ToLower() == "hostname")
                {
                    hostname = bol[1].Trim();
                }
            }

            return hostname;
        }

        internal static Result CihazKayit(Cihazlar cihaz)
        {
            Result r = new Result();
            try
            {
                var clist = GetAllCihazlar();
                int i = 1;

                if (clist.cihazlar.Count > 0)
                {
                    i = clist.cihazlar.Count + 1;
                }
                else
                {
                    clist.cihazlar = new List<Cihazlar>();
                }
                cihaz.ID = i;
                clist.cihazlar.Add(cihaz);
                var jSon = JsonConvert.SerializeObject(clist);
                RecordDatabase(jSon.ToString());
                r.success = true;
            }catch(Exception ee)
            {
                r.success = false;
                r.mesaj = ee.Message;
            }
            return r;
        }

        public static CihazList GetAllCihazlar()
        {
            string profiller = ReadDataBase(dataFile);
            if (!String.IsNullOrEmpty(profiller))
            {
                var pall = JsonConvert.DeserializeObject<CihazList>(profiller);
                return pall;
            }
            else
            {
                var nullList= new CihazList();
                nullList.cihazlar = new List<Cihazlar>();
                return nullList;
            }
        }

        private static string ReadDataBase(string dataFile)
        {
            //StreamReader stream = Decrypt(dataFile, okey);
            StreamReader stream = new StreamReader(dataFile);
            string lines = stream.ReadToEnd();
            stream.Close();
            stream.Dispose();
            if (String.IsNullOrEmpty(lines))
                return "";
            else
                return Encryption.DecryptString(lines,okey);
        }

        public static void Encrypt(string text, string destination, string sKey)
        {
            Encryption.EncryptFile(text, destination, sKey);
        }

        public static StreamReader DecryptText(byte[] text, string sKey)
        {
            return Encryption.DecryptText(text, sKey);
        }

        public static StreamReader Decrypt(string source, string sKey)
        {
            return Encryption.DecryptFile(source, sKey);
        }

        private static void RecordDatabase(string json)
        {
            string encString = Encryption.EncryptString(json, okey);

            StreamWriter stream = new StreamWriter(dataFile, false);
            stream.Write(encString);
            stream.Close();
            stream.Dispose();
        }

        internal static bool SSHBaglan(Cihazlar cihaz, ListViewItem item)
        {
            try
            {
                using (SshClient ssh = new SshClient(CreateConnectionInfo(cihaz)))
                {
                    ssh.Connect();
                    var status = ssh.RunCommand("get system status");
                    string hostname = getHostName(status.Result);
                    var result =ssh.RunCommand("show");
                    ssh.Disconnect();
                    string cihazname = cihaz.CihazAdi.Replace(" ", "_");
                    string file_name = cihazname + "_" + DateTime.Now.ToString("MMddyyyy_hhmmss") + ".conf";
                    ProcessResults(result.Result, file_name, hostname,item);
                }
                return true;
            }
            catch(Exception e)
            {
                log(e.Message);
                return false;
            }
        }

        private static ConnectionInfo CreateConnectionInfo(Cihazlar c)
        {
            AuthenticationMethod auth = new PasswordAuthenticationMethod(c.Username, c.Password);
            ConnectionInfo info = new ConnectionInfo(c.Adres, c.Port, c.Username, auth);
            return info;
        }
    }
}