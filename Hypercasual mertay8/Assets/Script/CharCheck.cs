using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CharCheck : MonoBehaviour
{
    [SerializeField] private GameObject camera; 
    public bool is_dead = false,is_win = false;
    [SerializeField] private Animator chanim;
    private Transform target;

    private void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lava")
        {
            is_dead = true;
            chanim.SetBool("is_dead", is_dead);
        }
        if (other.gameObject.tag == "Finish")
        {
            is_win = true;
            chanim.SetBool("is_win", is_win);
        }
    }

}
