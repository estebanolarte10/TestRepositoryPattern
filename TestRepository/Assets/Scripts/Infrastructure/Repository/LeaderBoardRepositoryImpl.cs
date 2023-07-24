using Domain.Models;
using Domain.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class LeaderBoardRepositoryImpl : ILeaderBoardRepository
{
    private string _leaderBoardpath = "E:\\UnityProjects\\TestRepositoryPattern\\Leaderboards\\Leaderboard.json";
    public void GetLeaderBoard(Action<List<LeaderBoardItem>> onSuccess)
    {
        System.IO.StreamReader reader = new System.IO.StreamReader(_leaderBoardpath);
        string json = reader.ReadToEnd();

        var leaderboardDtoList = JsonConvert.DeserializeObject<List<LeaderBoarItemDto>>(json);

        onSuccess(LeaderBoardAdapter.GetDomainItems(leaderboardDtoList));
    }
}

