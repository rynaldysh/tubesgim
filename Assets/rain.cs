using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         this.GetComponent<ParticleSystem>().startColor = new Color(1, 0, 1, .10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
