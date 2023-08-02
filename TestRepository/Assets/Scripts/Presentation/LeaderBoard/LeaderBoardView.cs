using Domain.Models;
using Domain.Repositories;
using Domain.Services;
using System;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoardView : MonoBehaviour
{
    [SerializeField] private LeaderBoardItemView _leaderBoardItemViewPrefab;
    [SerializeField] private Transform _container;

    private LeaderBoardService _leaderBoardService;

    private void Awake()
    {
        ILeaderBoardRepository leaderBoardRepository = new LeaderBoardRepositoryImpl();
        _leaderBoardService = new LeaderBoardService(leaderBoardRepository);

        GetLeaderBoard();
    }

    public void GetLeaderBoard()
    {
        _leaderBoardService.GetLeaderBoardOrderedByScore(OnLeaderBoardGeted);
    }

    private void OnLeaderBoardGeted(List<LeaderBoardItem> items)
    {
        if (_container.childCount != 0)
        {
            foreach (Transform item in _container)
            {
                Destroy(item.gameObject);
            }
        }

        foreach (var item in items)
        {
            var leaderboardItem = Instantiate(_leaderBoardItemViewPrefab, _container);
            leaderboardItem.Setup(item.GetName(), item.GetScore());
        }
    }
}
