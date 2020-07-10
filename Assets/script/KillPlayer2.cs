using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer2 : MonoBehaviour
{
    public LevelManager2 levelManager;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager2>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "player")
        {
            levelManager.RespawnPlayer();
        }
    }
}
