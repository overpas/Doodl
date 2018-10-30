using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameOverController : MonoBehaviour {

    public Text scoreText;

    void Start()
    {
        var scoreString = "Score: " + String.Format("{0:0}", ScoreHelper.GetInstance().GetScore());
        Debug.Log(scoreString);
        scoreText.text = scoreString;
    }

    public void GoToMain()
    {
        SceneManager.LoadScene(0);
    }
}
