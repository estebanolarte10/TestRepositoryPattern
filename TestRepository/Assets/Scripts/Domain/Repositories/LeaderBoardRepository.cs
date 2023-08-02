using Domain.Models;
using System;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface ILeaderBoardRepository 
    {
        public void GetLeaderBoard(Action<List<LeaderBoardItem>> onSuccess);
        public void GetLeaderBoardOrderedByName(Action<List<LeaderBoardItem>> onSuccess);
        public void GetLeaderBoardOrderedByScore(Action<List<LeaderBoardItem>> onSuccess);
        public void AddLeaderboardItem(LeaderBoardItem item, Action onSuccess);
    }
}
