using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    [SerializeField] PlayerScript playerScript;

    internal bool isLeftPressed;
    internal bool isRightPressed;
    internal bool isUpPressed;
    internal bool isDownPressed;

    // Start is called before the first frame update
    void Start()
    {
        print("PlayerInputScript Starting");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            isLeftPressed = true;
        } 
        else
        {
            isLeftPressed = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            isRightPressed = true;
        }
        else
        {
            isRightPressed = false;
        }

        if (Input.GetKey(KeyCode.E))
        {
            isUpPressed = true;
        }
        else
        {
            isUpPressed = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            isDownPressed = true;
        }
        else
        {
            isDownPressed = false;
        }
    }
}
