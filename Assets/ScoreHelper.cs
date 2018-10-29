public class ScoreHelper
{
    private static ScoreHelper instance = null;
    private static readonly object theLock = new object();

    private int score;

    private ScoreHelper()
    {

    }

    public int GetScore()
    {
        return score;
    }

    public void IncrementScore()
    {
        lock (theLock)
        {
            score++;
        }
    }

    public void ResetScore()
    {
        lock (theLock)
        {
            score = 0;
        }
    }

    public static ScoreHelper GetInstance()
    {
        if (instance == null)
        {
            lock (theLock)
            {
                if (instance == null)
                {
                    instance = new ScoreHelper();
                }
            }
        }
        return instance;
    }

}
