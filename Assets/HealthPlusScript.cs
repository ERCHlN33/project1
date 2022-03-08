using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlusScript : MonoBehaviour
{
    BallController ballctrl;

    

    private void Start()
    {
        ballctrl = FindObjectOfType<BallController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ballctrl.HealthAmount += 25;
            ballctrl.healthbar.fillAmount += .25f;
            Destroy(this.gameObject);
        }
        if (ballctrl.HealthAmount>=100)
        {
            ballctrl.HealthAmount = 100;
        }
    }
}
