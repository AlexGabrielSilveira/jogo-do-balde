using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBucket : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if(GameManager.Instance.GameOver == true) return;
        Destroy(other.gameObject);
        GameManager.Instance.score++;

        Debug.Log(GameManager.Instance.score);
    }
}
