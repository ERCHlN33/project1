using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class HealthPlusScript : MonoBehaviour
{
    BallController ballctrl;
    public GameObject canefekti;



    private void Start()
    {

        ballctrl = FindObjectOfType<BallController>();
    }

    private void Update()
    {


    }
    private void OnTriggerEnter(Collider other)
    {



        if (other.CompareTag("Player"))
        {
            ballctrl.HealthAmount += 25;
            ballctrl.healthbar.fillAmount += .25f;
            Destroy(this.gameObject);
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("heal");


        }
        if (ballctrl.HealthAmount >= 100)
        {
            ballctrl.HealthAmount = 100;
        }


    }
    private void OnTriggerExit(Collider other)
    {



        if (other.CompareTag("Player"))
        {
            
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("heal");
        }

    }
}
