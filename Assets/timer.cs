using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
   public float GešenZaman;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GešenZaman = Time.realtimeSinceStartup;
        
    }
}
