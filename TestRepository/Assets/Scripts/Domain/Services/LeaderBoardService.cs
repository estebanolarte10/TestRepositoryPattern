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
    }
}