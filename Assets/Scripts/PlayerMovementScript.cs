using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField] PlayerScript playerScript;

    // Start is called before the first frame update
    void Start()
    {
        print("PlayerMovementScript Starting");
        playerScript.rb2d.velocity = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        ////if (playerScript.inputScript.isRightPressed)
        ////{
        ////    MovePlayerRight();
        ////}
        ////else if (playerScript.inputScript.isLeftPressed)
        ////{
        ////    MovePlayerLeft();
        ////}
        ////else
        ////{
        ////    StopMovement();
        ////}
    }

    private void FixedUpdate()
    {
        if (playerScript.inputScript.isRightPressed)
        {
            MovePlayerRight();
        }
        else if (playerScript.inputScript.isLeftPressed)
        {
            MovePlayerLeft();
        }
        else
        {
            //StopMovement();
        }
    }

    private void MovePlayerLeft()
    {
        playerScript.rb2d.velocity = new Vector2(-playerScript.walkSpeed, 0);
    }

    private void MovePlayerRight()
    {
        playerScript.rb2d.velocity = new Vector2(playerScript.walkSpeed, 0);
    }

    private void StopMovement()
    {
        playerScript.rb2d.velocity = new Vector2(0, 0);
    }
}
