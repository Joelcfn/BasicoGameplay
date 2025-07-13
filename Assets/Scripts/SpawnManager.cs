using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float SpawnPosZ = 20;
private float startDelay = 2;
private float spawnInterval = 1.5f;



    void Start()
    {
            InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal() {
  
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, SpawnPosZ);

        // 3) Instancia o prefab na posição e rotação originais do prefab
        Instantiate(
            animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
}

}

