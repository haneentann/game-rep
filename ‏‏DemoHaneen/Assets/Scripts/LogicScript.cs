using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playScore;
    public Text scoreText;
    public GameObject gameOverScene;
 

    [ContextMenu("Increase Score")]
    public void addScore(int ScoreToAdd)
    {
        playScore += ScoreToAdd;
        scoreText.text = playScore.ToString();
    }
    public void restarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScene.SetActive(true);
    }
}
