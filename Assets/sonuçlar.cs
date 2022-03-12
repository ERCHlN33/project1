using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sonuçlar : MonoBehaviour
{
    timer GeçenZaman;
    public Text zamanText;
    // Start is called before the first frame update
    void Start()
    {
        GeçenZaman = GetComponent<timer>();
    }
    

    // Update is called once per frame
    void Update()
    {
       zamanText.text = GeçenZaman.ToString();
    }
}
