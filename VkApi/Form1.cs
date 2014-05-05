using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VkApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sURL = "https://api.vk.com/method/photos.get?owner_id=" + textBox1.Text + "&album_id=" + textBox2.Text;
            WebRequest wrGETURL = WebRequest.Create(sURL);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            string sLine = "";
            int i = 0;
            StreamReader objReader = new StreamReader(objStream);
            string a = "";
            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                var text = String.Format("{0}:{1}", i, sLine);
                if (sLine != null)
                    //MessageBox.Show(text);
                    a = sLine;
            }
            RootObject obj = Activator.CreateInstance<RootObject>();
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(a));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            obj = (RootObject)serializer.ReadObject(ms);
            WebClient webClient = new WebClient();
            foreach (var vkImage in obj.response)
            {
                webClient.DownloadFile(vkImage.src_big, "D:\\" + vkImage.pid+".jpg");
            }
            ms.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
