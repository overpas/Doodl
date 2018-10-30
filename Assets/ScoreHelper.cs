public class ScoreHelper
{
    private static ScoreHelper instance = null;
    private static readonly object theLock = new object();

    private double score = 0d;

    private ScoreHelper()
    {

    }

    public double GetScore()
    {
        return score;
    }

    public void Add(float increase)
    {
        lock (theLock)
        {
            score += increase;
        }
    }

    public void ResetScore()
    {
        lock (theLock)
        {
            score = 0d;
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
