using UnityEngine;

public class Colorslider : MonoBehaviour
{
    public Appear appearTopping;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToppingsColor (float colorValue)
    {
        //Debug.Log("Slider value:" + colorValue);
        
        //Using GetComponent to change the toppings color with the slider

        GameObject currentTopping = appearTopping.GetTopping();

        if (currentTopping != null) // if the topping prefab exists then:
        {
            //here we use get componetn
            SpriteRenderer colorRenderer = currentTopping.GetComponent<SpriteRenderer>(); 
            Color ToppingsColor = Color.HSVToRGB(colorValue, 1f, 1f); //this makes the color change in a rainbow type of way
            colorRenderer.color = ToppingsColor;
        }
    }

}
