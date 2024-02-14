using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketMovement : MonoBehaviour
{
    public float speed = 10;
    void Start()
    {
        
    }

    void Update()
    {
        var left = Input.GetKey(KeyCode.LeftArrow);
        var right = Input.GetKey(KeyCode.RightArrow);
        float movement = speed * Time.deltaTime;

        if(left == right) {
            return;
        }
        if(left) {
            movement *= -1f;
        }
        transform.position += new Vector3(movement,0,0);

    }
}
