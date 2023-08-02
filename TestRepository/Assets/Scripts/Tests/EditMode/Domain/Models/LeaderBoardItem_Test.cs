using System.Collections;
using System.Collections.Generic;
using Domain.Models;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class LeaderBoardItem_Test
{
    // A Test behaves as an ordinary method
    [Test]
    public void LeaderBoardItem_EmptyNameTest()
    {
        //arrange
        //act and assert
        Assert.Throws<EmptyNameException>(() =>
        {
            new LeaderBoardItem("", 0);
        });
    }
    [Test]
    public void LeaderBoardItem_NegativeScore()
    {
        //arrange
        //act and assert
        Assert.Throws<NegativeScoreException>(() =>
        {
            new LeaderBoardItem("aa", -10);
        });
    }
}
