using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2ndCam : MonoBehaviour
{
    //define player game object
    public GameObject player;

    void Start()
    {
        LateUpdate();
    }
    //wait for lateupdate
    void LateUpdate()
    {
        //define start and end of level. 
        //This will detach the camera from the player until it enters the range again

        if (player.transform.position.x > -12f && player.transform.position.x < 10000f)
        {
            transform.position = new Vector3(player.transform.position.x, 0f, -7f);
        }
    }
}

