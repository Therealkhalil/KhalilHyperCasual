using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCheck : MonoBehaviour
{
    public bool is_dead = false;
    [SerializeField] private Animator deadanim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lava")
        {
            is_dead = true;
            deadanim.SetBool("is_dead", is_dead);
        }
    }

}
