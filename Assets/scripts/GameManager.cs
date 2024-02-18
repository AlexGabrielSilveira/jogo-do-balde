using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    [HideInInspector]public bool GameOver = false;
    public float gameWidth = 22;
    [HideInInspector]public int score = 0;

    void Awake() {
        if(Instance != null && Instance != this) {
            Destroy(this);
        }else {
            Instance = this;
        }
    }
}
