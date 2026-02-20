using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       

        //To make the hands spin
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z -= rotationSpeed * Time.deltaTime;

        transform.eulerAngles = currentRotation;

        Debug.Log(transform.eulerAngles);

    }
}
