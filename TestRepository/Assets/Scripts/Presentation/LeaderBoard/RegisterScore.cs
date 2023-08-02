using TMPro;
using UnityEngine.UI;
using UnityEngine;
using Domain.Services;
using Domain.Repositories;
using Domain.Models;

public class RegisterScore : MonoBehaviour
{
    [SerializeField] private TMP_InputField _nameField;
    [SerializeField] private TMP_InputField _scoreField;
    [SerializeField] private Button _submitButton;
    [SerializeField] private LeaderBoardView _leaderBoardView;

    private LeaderBoardService _leaderBoardService;

    private void Awake()
    {
        ILeaderBoardRepository leaderBoardRepository = new LeaderBoardRepositoryImpl();
        _leaderBoardService = new LeaderBoardService(leaderBoardRepository);

        _submitButton.onClick.AddListener(AddScore);
    }

    public void AddScore()
    {
        if (string.IsNullOrEmpty(_scoreField.text))
        {
            Debug.LogError("The score field cannot be empty");
            return;
        }


        try
        {
            var item = new LeaderBoardItem(_nameField.text, int.Parse(_scoreField.text));
            _leaderBoardService.AddLeaderboardItem(item, _leaderBoardView.GetLeaderBoard);
        }
        catch (System.Exception e)
        {
            Debug.LogError(e);
        }
    }
}
