using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;

namespace RiotApiForm
{
    public partial class Form1 : Form
    {
        public string summonerNameSearch;
        public string summonerRegionSearch;
        public string apiKeySearch;

        public readonly string SumName;

        public Form1(string SumName)
        {
            SumName = summonerNameSearch;
        }

        public string SummonerName
        {
            get { return Summoners_Name_Search_Box.Text; }
            set { Summoners_Name_Search_Box.Text = value; }
        }

        public Form1()
        {
            InitializeComponent();
            _Form1 = this;
        }

        public static Form1 _Form1;

        public void update(string summonerName_)
        {
            Summoners_Name_Search_Box.Text = summonerName_;
        }

        public void Submit_Button_Click(object sender, EventArgs e)
        {
            summonerNameSearch = Summoners_Name_Search_Box.Text;

            summonerRegionSearch = Summoners_Region_Search_Box.Text;
            apiKeySearch = API_Key_Text_Box.Text;

            var riotApi = MingweiSamuel.Camille.RiotApi.NewInstance(apiKeySearch);
            var summoner = riotApi.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, summonerNameSearch);

            Summoners_Name_Box.Text = summoner.Name;
            Summoner_Level_Text_Box.Text = summoner.SummonerLevel.ToString();
            Summoners_Icon_ID_Box.Text = summoner.ProfileIconId.ToString();
            Summoner_ID_Text_Box.Text = summoner.AccountId;
        }
        private void Summoners_Name_Search_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Summoner_Level_Text_Box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void API_Key_Text_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}