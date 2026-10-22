using UnityEngine;

public class SpawnTowers : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnTower();
        }
    }

    private void SpawnTower()
    {
        float x = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);

        Vector3 spawnPosition = new Vector3(x, 0f, z);

        Instantiate(towerPrefab, spawnPosition, Quaternion.identity);
    }
}
