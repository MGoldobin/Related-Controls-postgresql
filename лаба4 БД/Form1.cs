using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace лаба4_БД
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fill();
        }


        string ConnectionString = @"Host = localhost;Username = postgres;Password = Misha310; Database = postgres";

        private async void fill()
        {
            var Connect = new NpgsqlConnection(ConnectionString);
            NpgsqlDataAdapter adapState = new NpgsqlDataAdapter("SELECT statevid, statename FROM state", Connect);
            DataTable dtState = new DataTable();
            adapState.Fill(dtState);
            comboBoxState.DataSource = dtState;
            comboBoxState.DisplayMember = "statename";
            comboBoxState.ValueMember = "statename";
        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Connect = new NpgsqlConnection(ConnectionString);
            NpgsqlDataAdapter adapCity = new NpgsqlDataAdapter("SELECT city.cityname FROM city, state WHERE state.statename='" + comboBoxState.SelectedValue.ToString() + "' AND  city.state_id=state.statevid", Connect);
            DataTable dtCity = new DataTable();
            adapCity.Fill(dtCity);
            if (dtCity.Rows.Count > 0)
            {
                comboBoxCity.DataSource = dtCity;
                comboBoxCity.DisplayMember = "cityname";
                comboBoxCity.ValueMember = "cityname";
            }
            else
            {
                comboBoxCity.DataSource = null;
                comboBoxCity.Text = "NULL";
            }
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Connect = new NpgsqlConnection(ConnectionString);
            NpgsqlDataAdapter adapLocalShop = new NpgsqlDataAdapter("SELECT addres FROM localshop, city WHERE city.cityname='" + comboBoxCity.SelectedValue.ToString() + "' AND  localshop.city_id=city.cityid", Connect);
            DataTable dtLocalShop = new DataTable();
            adapLocalShop.Fill(dtLocalShop);
            if (dtLocalShop.Rows.Count > 0)
            {
                comboBoxLocalShop.DataSource = dtLocalShop;
                comboBoxLocalShop.DisplayMember = "addres";
                comboBoxLocalShop.ValueMember = "addres";
            }
            else
            {
                comboBoxLocalShop.DataSource = null;
                comboBoxLocalShop.Text = "NULL";
            }
        }
    }
}
