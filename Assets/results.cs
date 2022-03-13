using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sonuçlar : MonoBehaviour
{
    //timer GeçenZaman;
    //public Text zamanText;
    // Start is called before the first frame update
    void Start()
    {
        //GeçenZaman = GetComponent<timer>();
    }
    

    // Update is called once per frame
    void Update()
    {
        // zamanText.text = GeçenZaman.ToString();
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene(0);
        }

    }
}
