using CovidViewer.Core;
using CovidViewer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidViewer.UI
{
    public partial class Main : Form
    {
        private readonly GetCovid _GetCovid;
        public Main()
        {
            InitializeComponent();
            _GetCovid = new GetCovid();
        }

        private async void GetData_Click(object sender, EventArgs e)
        {
            try
            {
                var Data = await _GetCovid.GetData((string)CountryList.SelectedValue);
                BinData.Add(Data);

                DataBox.DataSource = BinData;
                DataBox.Update();
                DataBox.Refresh();

            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var ISOCountry = ISO3166.Country.List;
            CountryList.DisplayMember = "Name";
            CountryList.ValueMember = "TwoLetterCode";
            CountryList.DataSource = ISOCountry;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BinData.Clear();
        }       

        private void DataBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BinData_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
