using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
   public float Ge�enZaman;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ge�enZaman = Time.realtimeSinceStartup;
        
    }
}
