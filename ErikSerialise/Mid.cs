using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ErikSerialise
{
    class Mid
    {

        public string Time { get; set; }
        public string Name { get; set; }

        public Mid(string time, string name)
        {
            Time = time;
            Name = name;
        }

        public override string ToString()
        {
            return Time + " " + Name;
        }
    }

    class ListMid
    {
        List<Mid> listMid = new List<Mid>();

        public void Add(Mid m)
        {
            listMid.Add(m);
        }

        public void ViewToListBox(ListBox l)
        {
            foreach (var v in listMid)
                l.Items.Add(v);
        }

        public void LoadFromFile()
        {
            using (StreamReader sr = new StreamReader("listmid.json"))
            {
                listMid = JsonConvert.DeserializeObject<List<Mid>>(sr.ReadToEnd());
            }
        }

        public void SaveToFile()
        {
            var mdJson = JsonConvert.SerializeObject(listMid);

            using (StreamWriter sw = new StreamWriter("listmid.json"))
                sw.WriteLine(mdJson);
        }
    }
}
