using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float timerr = 0.0f;
    public Text timerText;
   
    public Canvas canvas;
    
    void Start()
    {
        
    }

    void Update()
    {

        timerr += Time.deltaTime;
        timerText.text = Mathf.Round(timerr).ToString() + ("SAN�YEDE B�T�RD�N�Z");

        DontDestroyOnLoad(canvas);
     
        


    }
   
    

}