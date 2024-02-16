using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBucket : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        // if(other.gameObject.CompareTag("Ball")){

        // }
        Destroy(other.gameObject);
    }
}
