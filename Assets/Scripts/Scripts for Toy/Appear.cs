using UnityEngine;

public class Appear : MonoBehaviour
{
    public GameObject toppingPrefab; //this one will be either the syrup, frosting or sprinkles prefab
    private GameObject spawnedTopping; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppearTopping ()
    {
       if (spawnedTopping == null)
        {
            spawnedTopping = Instantiate(toppingPrefab); //creates topping in the scene
        }
        else
        {
            Destroy(spawnedTopping); //destroy the topping from the scene
            spawnedTopping = null;
        }

    }
    public GameObject GetTopping() //so I can access it in other scripts
    {
        return spawnedTopping; 
    }
}
