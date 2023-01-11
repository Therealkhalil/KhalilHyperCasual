using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjDet : MonoBehaviour
{
    private float max =  4f, min = -0.030f;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "booster" && transform.position.y < max)
        {
            transform.position += new Vector3(0f, 0.01f, 0f);
        }

        if(other.gameObject.tag == "lava" && transform.position.y > min)
        {
            transform.position -= new Vector3(0f, 0.01f, 0f);
        }
    }


}
