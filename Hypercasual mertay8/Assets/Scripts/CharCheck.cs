using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCheck : MonoBehaviour
{
    public bool is_dead = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "lava")
        {
            is_dead = true;
        }
    }

}
