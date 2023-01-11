using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float limitvalue;
    [SerializeField] private Transform TransformPlayer;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            MovePlayer();
        }

    }


    private void MovePlayer()
    {
        //Calculate X position and modify it
        float halfScreen = Screen.width / 2;
        float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;
        float finalPosx = Mathf.Clamp(xPos * limitvalue,-limitvalue,limitvalue);
        TransformPlayer.localPosition = new Vector3(finalPosx, 0, 0);    
    }
}
