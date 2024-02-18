using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawner : MonoBehaviour
{
    public float interval = 1;
    private float cooldown = 0;
    public Vector3 originPoint = new Vector3(0,0,0);

    public List<GameObject> prefabs;

    void Update()
    {   
        if(GameManager.Instance.GameOver == true) return;
        cooldown -= Time.deltaTime;
        if(cooldown <= 0f) {
            cooldown = interval;
            SpawnBall();
        }
    } 

    private void SpawnBall() {
        int prefabIndex = Random.Range(0, prefabs.Count);
        GameObject prefab = prefabs[prefabIndex];

        float gameWidth = GameManager.Instance.gameWidth;
        float xOffset = Random.Range(-gameWidth / 2f, gameWidth / 2f);

        Vector3 position = originPoint + new Vector3(xOffset,0,0);

        Quaternion rotation = prefab.transform.rotation;
        Instantiate(prefab, position, rotation);

    }
}
