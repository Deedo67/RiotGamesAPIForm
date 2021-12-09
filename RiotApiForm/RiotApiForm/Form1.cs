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
using MingweiSamuel.Camille.MatchV5;

namespace RiotApiForm
{
    public partial class Form1 : Form
    {
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
            string summonerNameSearch = Summoners_Name_Search_Box.Text;

            string summonerRegionSearch = Summoners_Region_Search_Box.Text;
            string apiKeySearch = API_Key_Text_Box.Text;

            var riotApi = MingweiSamuel.Camille.RiotApi.NewInstance(apiKeySearch);
            var summoner = riotApi.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, summonerNameSearch);

            Summoners_Name_Box.Text = summoner.Name;
            Summoner_Level_Text_Box.Text = summoner.SummonerLevel.ToString();
            Summoners_Icon_ID_Box.Text = summoner.ProfileIconId.ToString();
            Summoner_ID_Text_Box.Text = summoner.AccountId;
        }

        private void Submit_Button_2_Click(object sender, EventArgs e)
        {
            string PUID = PUID_Box.Text;

            string apiKeySearch = API_Key_Text_Box.Text;

            var riotApi = MingweiSamuel.Camille.RiotApi.NewInstance(apiKeySearch);
            var match = riotApi.MatchV5.GetMatchIdsByPUUID(MingweiSamuel.Camille.Enums.Region.Americas, PUID, 0, 10);

            for (int i = 0; i < match.Length; i++)
            {
                Match_ID_List.Items.Add(match[i].ToString());
            }
        }

        private void Submit_Button_3_Click(object sender, EventArgs e)
        {
            string matchID = Match_ID_Box.Text;

            string apiKeySearch = API_Key_Text_Box.Text;

            var riotApi = MingweiSamuel.Camille.RiotApi.NewInstance(apiKeySearch);
            var matchInfo = riotApi.MatchV5.GetMatch(MingweiSamuel.Camille.Enums.Region.Americas, matchID);

            //Game_Creation_Box.Text = matchInfo
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}