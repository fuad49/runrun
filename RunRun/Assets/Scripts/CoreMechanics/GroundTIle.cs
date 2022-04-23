using UnityEngine;

public class GroundTIle : MonoBehaviour
{
    GroundSpawner groundspawner;

    [SerializeField]private Obstacles scObstacle;
    [SerializeField]private GameObject coinPrefab;

    private void Start() 
    {
        groundspawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnCoins();
    }

    void OnTriggerExit(Collider other)
    {
        groundspawner.SpawnTile(true);
        Destroy(gameObject, 2);        
    }

    public void SpawnObstacle()
    {

        int obstacleSpwanIndex = Random.Range(2,5);
        int obstacleToSpawn = Random.Range(0, scObstacle.prefabs.Length);

        int randomObstacle = Random.Range(0,scObstacle.col.Length);
        Transform spawnPoint = transform.GetChild(obstacleSpwanIndex).transform;

        Instantiate(scObstacle.prefabs[obstacleToSpawn], spawnPoint.position, Quaternion.identity, transform);
        
    }

    void SpawnCoins()
    {
        int coinsToSpawn = 5;
        for(int i = 0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab , transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );

            if(point != collider.ClosestPoint(point))
            {
                point = GetRandomPointInCollider(collider);
            }

            point.y = 1;
            return point;

    }

}
