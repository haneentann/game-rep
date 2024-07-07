using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public int PlayerScore { get; private set; }
    private List<GameObject> coins;

    void Start()
    {
        PlayerScore = 0;
        coins = new List<GameObject>(GameObject.FindGameObjectsWithTag("Coin"));
    }

    public void CollectCoin(GameObject coin)
    {
        if (coins.Contains(coin))
        {
            PlayerScore += 10;
            coins.Remove(coin);
            Destroy(coin);
        }
    }

    public int GetRemainingCoins()
    {
        return coins.Count;
    }
}

