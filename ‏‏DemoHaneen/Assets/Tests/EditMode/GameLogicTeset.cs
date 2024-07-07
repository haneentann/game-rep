using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GameLogicTest
{
    private GameLogic gameLogic;
    private GameObject coin;

    [SetUp]
    public void SetUp()
    {
        GameObject gameLogicObject = new GameObject();
        gameLogic = gameLogicObject.AddComponent<GameLogic>();
        coin = new GameObject();
        coin.tag = "Coin";

       // GameObject[] coins = { coin };
        //GameObject.FindGameObjectsWithTag("Coin").Returns(coins);

     //   gameLogic.Start();
    }


    [Test]
    public void PlayerScore_IncreasesOnCollectingCoin()
    {
        gameLogic.CollectCoin(coin);
        Assert.AreEqual(10, gameLogic.PlayerScore);
    }

    [Test]
    public void Coin_RemovedOnCollecting()
    {
        gameLogic.CollectCoin(coin);
        Assert.AreEqual(0, gameLogic.GetRemainingCoins());
    }

    [Test]
    public void CollectCoin_CoinNotInList_NoScoreChange()
    {
        GameObject newCoin = new GameObject();
        gameLogic.CollectCoin(newCoin);
        Assert.AreEqual(0, gameLogic.PlayerScore);
    }

    [TearDown]
    public void TearDown()
    {
        Object.Destroy(gameLogic.gameObject);
        Object.Destroy(coin);
    }

    [UnityTest]
    public IEnumerator DirectionTestWithEnumeratorPasses()
    {
        GameObject gameLogicObject = new GameObject();
        gameLogic = gameLogicObject.AddComponent<GameLogic>();


        yield return null;
    }
}
