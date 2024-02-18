using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketMovement : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        if(GameManager.Instance.GameOver == true) return;
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
        LimitPlayer();
    }
    void LimitPlayer() {
        float limitPlayer = GameManager.Instance.gameWidth / 2;
        if(transform.position.x < -limitPlayer) {
            transform.position = new Vector3(-limitPlayer,-3.3f,0);
        }else if(transform.position.x > limitPlayer){
            transform.position = new Vector3(limitPlayer,-3.3f,0);
        }
    }
}
