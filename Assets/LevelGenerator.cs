using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab;
    public GameObject platformBoostedPrefab;

    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
    private float firstMaxY = .5f;

    // Use this for initialization
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            if (i == 0)
            {
                spawnPosition.y += Random.Range(minY, firstMaxY);
            } else
            {
                spawnPosition.y += Random.Range(minY, maxY);
            }
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            if (Random.Range(0f,10f) > 9)
            {
                Instantiate(platformBoostedPrefab, spawnPosition, Quaternion.identity);
            } else {
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }
        }
    }
}
