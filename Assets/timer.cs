using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float timerr = 0.0f;
    public Text timerText;
   
    public Canvas canvas;
    

    void Update()
    {
       timerr += Time.deltaTime;
       timerText.text =Mathf.Round(timerr).ToString();
      
        DontDestroyOnLoad(canvas);
        


    }

}