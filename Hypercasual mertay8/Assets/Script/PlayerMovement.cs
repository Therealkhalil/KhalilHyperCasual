using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float limitvalue;
    [SerializeField] private Transform TransformPlayer;
    [SerializeField] private float speedHorizontal;

    private Touch touchPos;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touchPos = Input.GetTouch(0);
            MovePlayer();
        }   
    }


    private void MovePlayer()
    {
        //Calculate X position and modify it
        float halfScreen = Screen.width / 2;
        float xPos = (touchPos.position.x - halfScreen) / halfScreen;
        float finalPosx = Mathf.Clamp(xPos * limitvalue, -limitvalue, limitvalue);
        float moveX = finalPosx - TransformPlayer.localPosition.x;
        TransformPlayer.localPosition += new Vector3(moveX * speedHorizontal * Time.deltaTime, 0, 0);
    }
   
}


//float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;