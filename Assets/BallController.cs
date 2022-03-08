using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public float movementspeed;
    //[SerializeField] private Rigidbody rb2d;
    [SerializeField] public float HealthAmount = 75;
    float timer = 0;
    public Image healthbar;
    public GameObject ball;
    public CharacterController characterController;
    public GameObject flag;
    public GameObject flag1;


    private void Start()
    {
        // rb2d = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
        healthbar.fillAmount = .75f;
    }
    private void Update()
    {
        Movement();
        timer += Time.deltaTime;
        if (HealthAmount<=0)
        {
            Destroy(ball);
            Time.timeScale = 0;
        }
        

    }
    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        //rb2d.AddForce(movement * movementspeed);
        characterController.Move(movement * movementspeed * Time.deltaTime);

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("eksioncan") && timer >= 1)
        {
            HealthAmount -= 10;
            healthbar.fillAmount -= .1f;
            timer = 0;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("upperflag"))
        {
            //Vector3 yukselt = new Vector3(flag.transform.position.x + 10f, flag.transform.position.y + 10f, flag.transform.position.z + 10f);
            flag.SetActive(false);
            flag1.SetActive(true);
            
        }
    }



}
