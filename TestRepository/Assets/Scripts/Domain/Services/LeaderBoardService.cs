using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;

namespace Domain.Services
{
    public class LeaderBoardService
    {
        private ILeaderBoardRepository _leaderBoardRepository;
        public LeaderBoardService(ILeaderBoardRepository leaderBoardRepository)
        {
            _leaderBoardRepository = leaderBoardRepository;
        }

        public void GetLeaderBoard(Action<List<LeaderBoardItem>> onSuccess)
        {
            _leaderBoardRepository.GetLeaderBoard(onSuccess);
        }
        public void GetLeaderBoardOrderedByName(Action<List<LeaderBoardItem>> onSuccess)
        {
            _leaderBoardRepository.GetLeaderBoardOrderedByName(onSuccess);
        }
        public void GetLeaderBoardOrderedByScore(Action<List<LeaderBoardItem>> onSuccess)
        {
            _leaderBoardRepository.GetLeaderBoardOrderedByScore(onSuccess);
        }
        public void AddLeaderboardItem(LeaderBoardItem item, Action onSuccess)
        {
            _leaderBoardRepository.AddLeaderboardItem(item, onSuccess);
        }
    }
}