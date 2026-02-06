using UnityEngine;
using UnityEngine.UI;

public class burgerclock : MonoBehaviour
{
    public Slider burgerSlider;
    public float clockDuration;
    public GameObject warperObject;

    private float timeWaiting = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeWaiting += Time.deltaTime * 1;
        burgerSlider.value = timeWaiting;

        if (timeWaiting > clockDuration)
        {
            timeWaiting = 0f;
            Debug.Log("Time is up");

            //When timer is up
            //Either:
            //Turn the warper object off when it is on
            //Turn the wraper object on when it is off

            bool shouldTurnOn = warperObject.activeInHierarchy;
            bool shouldTurnOff = warperObject.activeInHierarchy;

            if (shouldTurnOn == true)
            {
                warperObject.SetActive(true);
            }

          
            if (shouldTurnOff)
            {
                warperObject.SetActive(false);
            }

        }

    }
}
