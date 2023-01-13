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
        if(is_win)
        {
            camera.transform.localEulerAngles = new Vector3(13.5f, 169f, 1.713f);
            camera.transform.position = Vector3.Lerp(camera.transform.position, new Vector3(0f, 2f, 80.01998f), Time.deltaTime);
        }
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
