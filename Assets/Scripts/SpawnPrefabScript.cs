using UnityEngine;

public class SpawnPrefabScript : MonoBehaviour
{
    public GameObject prefabToSpawn; // Das Prefab, das gespawnt werden soll
    public float spawnDelay = 1f; // Verz�gerung in Sekunden zwischen den Spawns

    private float lastSpawnTime;

    void Update()
    {
        // �berpr�fe, ob die Leertaste gedr�ckt wurde und gen�gend Zeit seit dem letzten Spawn vergangen ist
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastSpawnTime >= spawnDelay)
        {
            // Spawne das Prefab an der Position des GameObjects
            SpawnPrefab();

            // Aktualisiere den Zeitpunkt des letzten Spawns
            lastSpawnTime = Time.time;
        }
    }

    void SpawnPrefab()
    {
        // �berpr�fe, ob ein Prefab zugewiesen wurde
        if (prefabToSpawn != null)
        {
            // Spawne das Prefab an der Position des GameObjects
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("PrefabToSpawn wurde nicht zugewiesen! Weise ein Prefab im Inspector zu.");
        }
    }
}


