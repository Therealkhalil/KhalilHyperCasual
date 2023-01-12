using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activebarel : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "barel")
        {
            other.GetComponent<MeshRenderer>().enabled = true;
            //Debug.Log("active");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "barel")
        {
            other.GetComponent<MeshRenderer>().enabled = false;
            //Debug.Log("active");
        }
    }
}
