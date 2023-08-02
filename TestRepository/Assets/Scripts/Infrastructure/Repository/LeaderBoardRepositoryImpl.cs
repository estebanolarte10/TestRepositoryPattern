using Domain.Models;
using Domain.Repositories;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class LeaderBoardRepositoryImpl : ILeaderBoardRepository
{
    private string _leaderBoardpath = "E:\\UnityProjects\\TestRepositoryPattern\\Leaderboards\\Leaderboard.json";
    public void GetLeaderBoard(Action<List<LeaderBoardItem>> onSuccess)
    {
        onSuccess(GetLeaderBoardList());
    }
    public void GetLeaderBoardOrderedByName(Action<List<LeaderBoardItem>> onSuccess)
    {
        List<LeaderBoardItem> leaderboard = GetLeaderBoardList().OrderBy(p => p.GetName()).ToList();
        onSuccess(leaderboard);
    }

    public void GetLeaderBoardOrderedByScore(Action<List<LeaderBoardItem>> onSuccess)
    {
        List<LeaderBoardItem> leaderboard = GetLeaderBoardList()
            .OrderByDescending(p => p.GetScore())
            .ThenBy(p => p.GetName())
            .ToList();
        onSuccess(leaderboard);
    }

    public void AddLeaderboardItem(LeaderBoardItem item, Action onSuccess)
    {
        var leaderboardDtoList = GetLeaderBoardListDto();
        leaderboardDtoList.Add(LeaderBoardAdapter.GetDtoItem(item));

        string finalJson = JsonConvert.SerializeObject(leaderboardDtoList, Formatting.Indented);

        File.WriteAllText(_leaderBoardpath, finalJson);
        onSuccess?.Invoke();
    }
    private List<LeaderBoarItemDto> GetLeaderBoardListDto()
    {
        string json = File.ReadAllText(_leaderBoardpath);

        var leaderboardDtoList = JsonConvert.DeserializeObject<List<LeaderBoarItemDto>>(json);

        return leaderboardDtoList;
    }
    private List<LeaderBoardItem> GetLeaderBoardList()
    {
        return LeaderBoardAdapter.GetDomainItems(GetLeaderBoardListDto());
    }

}

