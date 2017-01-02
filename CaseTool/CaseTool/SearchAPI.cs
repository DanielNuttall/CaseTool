﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Web;
using System.Net;

using Newtonsoft.Json;


namespace CaseTool
{
    public partial class SearchAPI : Form
    {
        private int x;
        private int y;
        public event EventHandler buttonClicked;

        public SearchAPI(int x, int y)
        {
            InitializeComponent();
            this.x = x;
            this.y = y;
        }

        public string GetRequest(string url)
        {
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            string result = null;
            using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Left = x;
            groupBox1.Top = y;
            button1.Hide();

            if (buttonClicked != null)
                buttonClicked(groupBox1, null);

            this.Dispose();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string URL = "http://apis.io/api/search?q=" + queryValue.Text + "&limit=100&fields=name,description";

            string JSONstring = (GetRequest(URL));
            API p1 = JsonConvert.DeserializeObject<API>(JSONstring);

            // CleanUp and convert to table.
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("name", "name");
            dataGridView1.Columns.Add("description", "description");

            foreach (Dictionary<string, string> a in p1.data)
            {

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = a["name"];
                row.Cells[1].Value = a["description"];

                this.dataGridView1.Rows.Add(row);
            }

            dataGridView1.AutoResizeColumns();

        }
    }
}
