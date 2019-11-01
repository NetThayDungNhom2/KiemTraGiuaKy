using AppG2.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Controller
{
    class ContactService
    {
        public static List<ClientContact> GetClientContact(string pathDataFile)
        {
            List<ClientContact> listClients = new List<ClientContact>();
            if (File.Exists(pathDataFile))
            {
                string[] listLines = File.ReadAllLines(pathDataFile);
                foreach (string line in listLines)
                {
                    string[] rs = line.Split(new char[] { '#' });
                    ClientContact client = new ClientContact
                    {
                        FindN = rs[1].Substring(0,1),
                        Name = rs[1],
                        Phone = rs[2],
                        Email = rs[3]
                    };
                    listClients.Add(client);
                }
                return listClients;
            }
            else
            {
                throw new Exception(pathDataFile);
                return null;
            }

        }
    }
}
