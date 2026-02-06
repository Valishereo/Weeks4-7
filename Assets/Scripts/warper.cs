using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class warper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool shouldWrap = Mouse.current.leftButton.wasPressedThisFrame && !EventSystem.current.IsPointerOverGameObject();

        if (shouldWrap == true)
        {
            Vector3 currentMousePosition = Mouse.current.position.ReadValue();
            transform.position = currentMousePosition;
        }
    }
}
