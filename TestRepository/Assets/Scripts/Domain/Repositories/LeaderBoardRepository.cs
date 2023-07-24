using Domain.Models;
using System;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface ILeaderBoardRepository 
    {
        public void GetLeaderBoard(Action<List<LeaderBoardItem>> onSuccess);
    }
}
