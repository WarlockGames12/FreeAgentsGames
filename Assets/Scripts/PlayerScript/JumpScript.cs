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
    public Camera firstPersonCamera;
    public Camera JumpCamera;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        ShowCloserView(); //start with the closerview
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
            ShowCloserView(); 
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
        ShowOverheadView();
    }
   
    public void ShowOverheadView()
    {
        //Show only the far away camera
        firstPersonCamera.enabled = false;
        JumpCamera.enabled = true;
    }

   
    public void ShowCloserView()
    {
        //show the closer camera
        firstPersonCamera.enabled = true;
        JumpCamera.enabled = false;
    }

}
