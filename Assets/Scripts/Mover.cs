using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    public float speed = 0f;
    bool rightIsPressed, leftIsPressed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 currentMousePos = Mouse.current.position.ReadValue();
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(currentMousePos);
        worldMousePos.z = 0;

        //If right arrow is pressed then tank moves to the right
        //If left arrow is pressed then tank moves to the left

        rightIsPressed = Mouse.current.rightButton.isPressed;
        if (rightIsPressed )
        {
           
        }


        //Avoid tank from reaching the border


    }
}
