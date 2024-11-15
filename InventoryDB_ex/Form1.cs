﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventoryDB_ex
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = .; Initial Catalog = production; Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadPlan()
        {
            if (cbYear.SelectedItem == null || cbMonth.SelectedItem == null)
            {
                MessageBox.Show("년도와 월을 선택하세요");
                return;
            }
            string planYear = cbYear.SelectedItem.ToString();
            string planMonth = cbMonth.SelectedItem.ToString();
            proList.Items.Clear();
            conn.Open();

            string query = String.Format("select * from production where YEAR(startdate) = {0} and MONTH(startdate) ={1}", planYear, planMonth);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader r = cmd.ExecuteReader();
            string[] fields = new string[6];
            while (r.Read())
            {
                for (int i = 0; i < 6; i++)
                {
                    // 각 열의 값을 읽어와서 배열에 저장
                    fields[i] = r[i].ToString();
                }
                // 날짜 정보에서 시간 제거
                if (fields[4].Length > 10)
                    fields[4] = fields[4].Substring(0, 10);

                if (fields[5].Length > 10)
                    fields[5] = fields[5].Substring(0, 10);

                // ListView에 행 추가
                ListViewItem row = new ListViewItem(fields);
                proList.Items.Add(row);
            }

            conn.Close();
        }
        public int NewProCode()
        {
            conn.Open();
            string query = "select max(procode) +1 from production";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader r = cmd.ExecuteReader();
            r.Read();
            int proCode = 1;
            if (r[0].ToString().Length > 0) proCode = int.Parse(r[0].ToString());
            r.Close();
            conn.Close();
            return proCode;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbItem.SelectedItem == null || cbWorkcenter.SelectedItem == null || txtQty.TextLength == 0)
            {
                MessageBox.Show("품목과 작업장 및 수량을 체크하세요");
                return;
            }
            int procode = NewProCode();
            string item = cbItem.SelectedItem.ToString();
            string wc = cbWorkcenter.SelectedItem.ToString();
            DateTime date = dtStart.Value;
            int qty = int.Parse(txtQty.Text);

            conn.Open();
            string query = "insert into production (procode, item, workcenter, startdate, qty) values (@procode, @item, @workcenter, @startdate, @qty)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@procode", procode);
            cmd.Parameters.AddWithValue("@item", item);
            cmd.Parameters.AddWithValue("@workcenter", wc);
            cmd.Parameters.AddWithValue("@startdate", date);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadPlan();
        }

        private void btPlanQuery_Click(object sender, EventArgs e)
        {
            LoadPlan();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (proList.SelectedItems.Count > 0)
            {
                string code = proList.SelectedItems[0].SubItems[0].Text;
                conn.Open();
                string query = "delete from production where procode = @procode";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@procode", code);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadPlan();
            }
        }
        private void btComplete_Click(object sender, EventArgs e)
        {
            if (proList.SelectedItems.Count > 0)
            {
                string code = proList.SelectedItems[0].SubItems[0].Text;
                string date = dtEnd.Value.Date.ToString("yyyy-MM-dd");
                conn.Open();
                string query = "update production set enddate = @enddate where procode = @procode";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@enddate", date);
                cmd.Parameters.AddWithValue("@procode", code);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            LoadPlan();
        }
        private void btSummary_Click(object sender, EventArgs e)
        {
            if (cbYear.SelectedItem == null || cbMonth.SelectedItem == null)
            {
                MessageBox.Show("년도와 월을 선택하세요");
                return;
            }
            string planYear = cbYear.SelectedItem.ToString();
            string planMonth = cbMonth.SelectedItem.ToString();
            txtSummary.Text = "";

            conn.Open();
            string query = "select distinct(item) from production where YEAR(startdate) = @year and MONTH(startdate) = @month";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@year", planYear);
            cmd.Parameters.AddWithValue("@month", planMonth);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                string item = r[0]?.ToString() ?? "";
                if (!string.IsNullOrEmpty(item))
                {
                    int planQty = QueryPlanQty(item, planYear, planMonth);
                    int completeQty = QueryCompleteQty(item, planYear, planMonth);
                    double progress = 0.0;
                    if (planQty > 0)
                    {
                        progress = 100.0 * ((double)completeQty / planQty);
                        txtSummary.Text += $"{item} 계획량 = {planQty}, 완료량 = {completeQty}, 진척률 = {progress:F2}%\r\n";
                    }
                }
            }
            conn.Close();
        }

        public int QueryPlanQty(string item, string planYear, string planMonth)
        {
            int qty = 0;

            // using 문으로 SqlConnection과 SqlDataReader를 자동으로 관리
            using (SqlConnection conn = new SqlConnection("Data Source = .; Initial Catalog = production; Integrated Security = True"))
            {
                conn.Open();
                string query = "select sum(qty) from production where YEAR(startdate) = @year and MONTH(startdate) = @month and item = @item";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@year", planYear);
                cmd.Parameters.AddWithValue("@month", planMonth);
                cmd.Parameters.AddWithValue("@item", item);

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read() && r[0] != DBNull.Value)
                    {
                        qty = Convert.ToInt32(r[0]);
                    }
                } // SqlDataReader가 자동으로 닫힘
            } // SqlConnection이 자동으로 닫힘

            return qty;
        }


        public int QueryCompleteQty(string item, string planYear, string planMonth)
        {
            int qty = 0;

            // using 문으로 SqlConnection과 SqlDataReader를 자동으로 관리
            using (SqlConnection conn = new SqlConnection("Data Source = .; Initial Catalog = production; Integrated Security = True"))
            {
                conn.Open();
                string query = "select sum(qty) from production where YEAR(startdate) = @year and MONTH(startdate) = @month and item = @item and enddate is not null";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@year", planYear);
                cmd.Parameters.AddWithValue("@month", planMonth);
                cmd.Parameters.AddWithValue("@item", item);

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read() && r[0] != DBNull.Value)
                    {
                        qty = Convert.ToInt32(r[0]);
                    }
                } // SqlDataReader가 자동으로 닫힘
            } // SqlConnection이 자동으로 닫힘

            return qty;
        }
    }
}
