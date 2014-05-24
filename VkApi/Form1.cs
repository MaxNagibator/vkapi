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
        private string _accessToken = "";
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
                var obj = Activator.CreateInstance<VkImages>();
                if (jsonText != null)
                {
                    var ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonText));
                    var serializer = new DataContractJsonSerializer(obj.GetType());
                    obj = (VkImages)serializer.ReadObject(ms);
                    var webClient = new WebClient();
                    foreach (var vkImage in obj.response)
                    {
                        webClient.DownloadFile(vkImage.src_big, "D:\\" + vkImage.pid+".jpg");
                    }
                    ms.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getFriendUrl = "https://" + "api.vk.com/method/friends.get?"
              + "user_id=" + ownerIdTextBox.Text;
            WebRequest request = WebRequest.Create(getFriendUrl);
            Stream objStream = request.GetResponse().GetResponseStream();
            if (objStream != null)
            {
                var objReader = new StreamReader(objStream);
                string jsonText = objReader.ReadLine();
                var obj = Activator.CreateInstance<FriendsIds>();
                if (jsonText != null)
                {
                    var ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonText));
                    var serializer = new DataContractJsonSerializer(obj.GetType());
                    obj = (FriendsIds)serializer.ReadObject(ms);
                    comboBox1.Items.Clear();
                    if (obj.response != null)
                        foreach (var id in obj.response)
                        {
                            comboBox1.Items.Add(id);
                        }
                    ms.Close();
                }
            }
        }

        private void uiAutorizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var url = webBrowser1.Url.ToString();
                var indexToken = url.IndexOf("access_token=", StringComparison.Ordinal);
                const int tokenLenght = 85;
                var length = "access_token=".Length + tokenLenght;
                _accessToken = url.Substring(indexToken, length);
                textBox1.Text = "vse tip top";
                uiAutorizeButton.BackColor = Color.Green;
            }
            catch (Exception)
            {
                textBox1.Text = "vse hrenovo";
                uiAutorizeButton.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Url =new Uri(@"https://oauth.vk.com/oauth/authorize?client_id=4347048&redirect_uri=https://oauth.vk.com/blank.html&response_type=token&scope=4194303&v=&state=&display=mobile");
        }

        private void uiGetMessagesButton_Click(object sender, EventArgs e)
        {
            GetMessage(uiInboxMessagesComboBox, 0);
            GetMessage(uiOutboxMessagesComboBox, 1);
        }

        private void GetMessage(ComboBox comboBox, int isOutbox)
        {
            string getFriendUrl = "https://" + "api.vk.com/method/messages.get?" + _accessToken + "&out="+isOutbox+"&v=5.21";
            WebRequest request = WebRequest.Create(getFriendUrl);
            Stream objStream = request.GetResponse().GetResponseStream();
            if (objStream != null)
            {
                var objReader = new StreamReader(objStream);
                string jsonText = objReader.ReadLine();
                var obj = Activator.CreateInstance<VkMessages>();
                if (jsonText != null)
                {
                    var ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonText));
                    var serializer = new DataContractJsonSerializer(obj.GetType());
                    obj = (VkMessages)serializer.ReadObject(ms);
                    comboBox.Items.Clear();
                    if (obj.response.items != null)
                        foreach (var mess in obj.response.items)
                        {
                            comboBox.Items.Add(mess.body);
                        }
                    ms.Close();
                }
            }
        }
    }
}
