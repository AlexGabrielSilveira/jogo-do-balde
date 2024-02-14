using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawner : MonoBehaviour
{
    public float interval = 1;
    private float cooldown = 0;
    public Vector3 originPoint = new Vector3(0,0,0);

    public List<GameObject> prefabs;

    void Start()
    {
        
    }

    void Update()
    {   
        cooldown -= Time.deltaTime;
        if(cooldown <= 0f) {
            cooldown = interval;
            SpawnBall();
        }
    } 

    private void SpawnBall() {
        int prefabIndex = Random.Range(0, prefabs.Count);

        GameObject prefab = prefabs[prefabIndex];

        Vector3 position = originPoint;

        Quaternion rotation = prefab.transform. rotation;

        Instantiate(prefab, position, rotation);
    }
}
