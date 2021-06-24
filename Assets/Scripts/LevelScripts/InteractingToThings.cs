using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractingToThings : MonoBehaviour
{
    public static bool InteractEvent = false;
    public GameObject Interact;
    

    // Start is called before the first frame update
    void Start()
    {
        Interact.SetActive(false);
    }

    

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Interact.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("Do event thingy :D");
            }
        }
    }

    void OnTriggerExit(Collider col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            Interact.SetActive(false);
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("Do Nothing :(");
            }
        }
    }
}
