using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeaderBoardItemView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _nameText;
    [SerializeField] private TextMeshProUGUI _scoreText;

    public void Setup(string name, int score)
    {
        _nameText.text = name;
        _scoreText.text = score.ToString();
    }
}
