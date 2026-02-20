using UnityEngine;
using TMPro; //textmeshpro from the Ui 

public class Timer : MonoBehaviour
{
    public float timeRemaining = 30f;
    public TextMeshProUGUI timerText;
    public GameObject endText;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
        if (timeRemaining > 0) //if the times still hasn't gone off
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = Mathf.Ceil(timeRemaining).ToString(); //countdown in text
        } 
       else
        {
            timeRemaining = 0;
            timerText.text = "0";
            endText.SetActive(true); //when the timer goes off this text appears on screen

            Debug.Log("Baking time is up");
        }
    }
}
