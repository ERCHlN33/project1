using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireScript : MonoBehaviour
{
    BallController ballctrl;


    private void Start()
    {
        ballctrl = FindObjectOfType<BallController>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ballctrl.HealthAmount -= 10;

        }
    }
}