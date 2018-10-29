using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {

    public Text scoreText;

    void Start()
    {
        scoreText.text = "Score: " + ScoreHelper.GetInstance().GetScore();
    }

    public void GoToMain()
    {
        SceneManager.LoadScene(0);
    }
}
