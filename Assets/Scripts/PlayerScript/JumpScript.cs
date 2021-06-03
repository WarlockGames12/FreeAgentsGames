using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpPower = 8;
    public bool canJump = true;
    public AudioSource JumpPlayer;
    public AudioSource LandPlayer;
   


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {

            JumpPlayer.Play();
            rb.velocity = new Vector3(0, jumpPower, 0);
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
        if (collision.gameObject.CompareTag("Ground"))
        {
            LandPlayer.Play();
           
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
        
    }
   
    

}
