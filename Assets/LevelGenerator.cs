using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab;
    public GameObject platformBoostedPrefab;
    public GameObject platformDamagingPrefab;

    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
    private float firstMaxY = .5f;

    // Use this for initialization
    void Start()
    {
        Vector3 platformSpawnPosition = new Vector3();
        Vector3 obstacleSpawnPosition = new Vector3();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            //InstantiateMovementPlatform(platformSpawnPosition, i);
            if (i == 0)
            {
                platformSpawnPosition.y += Random.Range(minY, firstMaxY);
            }
            else
            {
                platformSpawnPosition.y += Random.Range(minY, maxY);
            }
            platformSpawnPosition.x = Random.Range(-levelWidth, levelWidth);
            if (Random.Range(0f, 10f) > 9)
            {
                Instantiate(platformBoostedPrefab, platformSpawnPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(platformPrefab, platformSpawnPosition, Quaternion.identity);
            }
            //InstantiateDamagePlatform(obstacleSpawnPosition);
            obstacleSpawnPosition.y += Random.Range(minY, maxY);
            obstacleSpawnPosition.x = Random.Range(-levelWidth, levelWidth);
            if (Random.Range(0f, 10f) > 9)
            {
                Instantiate(platformDamagingPrefab, obstacleSpawnPosition, Quaternion.identity);
            }
        }
    }

    /**
     * Not working for some reason
     */
    private void InstantiateMovementPlatform(Vector3 spawnPosition, int orderNumber)
    {
        if (orderNumber == 0)
        {
            spawnPosition.y += Random.Range(minY, firstMaxY);
        }
        else
        {
            spawnPosition.y += Random.Range(minY, maxY);
        }
        spawnPosition.x = Random.Range(-levelWidth, levelWidth);
        if (Random.Range(0f, 10f) > 9)
        {
            Instantiate(platformBoostedPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    /**
     * Not working for some reason
     */
    private void InstantiateDamagePlatform(Vector3 spawnPosition)
    {
        spawnPosition.y += Random.Range(minY, maxY);
        spawnPosition.x = Random.Range(-levelWidth, levelWidth);
        if (Random.Range(0f, 10f) > 9)
        {
            Instantiate(platformDamagingPrefab, spawnPosition, Quaternion.identity);
        }
    }

}
