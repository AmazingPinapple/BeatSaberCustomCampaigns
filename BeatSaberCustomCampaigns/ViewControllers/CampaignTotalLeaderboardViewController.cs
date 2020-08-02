﻿using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;
using CustomCampaignLeaderboardLibrary;
using IPA.Utilities;
using TMPro;

namespace BeatSaberCustomCampaigns.campaign
{
    public class CampaignTotalLeaderboardViewController : BSMLResourceViewController
    {
        public override string ResourceName => "BeatSaberCustomCampaigns.Views.campaign-leaderboard.bsml";

        [UIComponent("leaderboard")]
        LeaderboardTableView table;
        public string lastClicked = "";
        
        public void UpdateLeaderboards()
        {
            StartCoroutine(CustomCampaignLeaderboard.LoadTotalLeaderboards(table, lastClicked));
        }
    }
}
