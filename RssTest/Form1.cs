using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RssTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void rss()
        {
            
            XmlTextReader xlmchz = new XmlTextReader(" "+link);
            while (xlmchz.Read())
            {
                if (xlmchz.Name == "title")
                {
                    listBox1.Items.Add(xlmchz.ReadString());
                }
            }
        }
        string link;
      
        private void Form1_Load(object sender, EventArgs e)
        {
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text != "")
            {
                link = textBox1.Text;
                rss();
            }
        }
    }
}
