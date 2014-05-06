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

        private void uiGetImagesButton_Click(object sender, EventArgs e)
        {
            string getImageUrl = "https://" + "api.vk.com/method/photos.get?"
                          + "owner_id=" + ownerIdTextBox.Text
                          + "&album_id=" + uiAlbumIdTextBox.Text;
            WebRequest request = WebRequest.Create(getImageUrl);
            Stream objStream = request.GetResponse().GetResponseStream();
            if (objStream != null)
            {
                var objReader = new StreamReader(objStream);
                string jsonText = objReader.ReadLine();
                var obj = Activator.CreateInstance<RootObject>();
                if (jsonText != null)
                {
                    var ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonText));
                    var serializer = new DataContractJsonSerializer(obj.GetType());
                    obj = (RootObject)serializer.ReadObject(ms);
                    var webClient = new WebClient();
                    foreach (var vkImage in obj.response)
                    {
                        webClient.DownloadFile(vkImage.src_big, "D:\\" + vkImage.pid+".jpg");
                    }
                    ms.Close();
                }
            }
        }
    }
}
