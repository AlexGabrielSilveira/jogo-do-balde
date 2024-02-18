using System;
using UnityEngine;

public class GameOver : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {
        if(GameManager.Instance.GameOver == true) return;

        if(other.gameObject.CompareTag("Ball")) {
            Destroy(other.gameObject);

            GameManager.Instance.GameOver = true;
        };
   }
}