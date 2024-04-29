using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] carPrefabs; // Birden fazla prefab için dizi
    [SerializeField] public float heightRange = 1.0f;
    [SerializeField] public float maxTime;
    private float timer;

    private void Start()
    {
        SpawnCar();
        maxTime = Random.Range(1f, 5f);
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            SpawnCar();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void SpawnCar()
    {
        maxTime = Random.Range(1f, 5f);

        // Rastgele bir prefab seç
        GameObject selectedPrefab = carPrefabs[Random.Range(0, carPrefabs.Length)];

        Vector3 spawnpos = transform.position + new Vector3(0, Random.Range(0, heightRange));
        GameObject car = Instantiate(selectedPrefab, spawnpos, Quaternion.identity);

        Destroy(car, 10f);
    }
}
