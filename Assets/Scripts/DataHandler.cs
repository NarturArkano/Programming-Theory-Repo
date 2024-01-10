using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHandler : MonoBehaviour
{
    public static DataHandler Instance;
    private string animalName;
    private int animalType;

    // Set Singleton instance of DataHandler
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    // Set the name of the animal based on user input
    public void setName(string name)
    {
        animalName = name;
    }

    // Get the animal's name
    public string getName()
    {
        return animalName;
    }

    // Set the animal's type based on user input
    public void setType(int type)
    {
        animalType = type;
    }

    // Get animal's type
    public int getType()
    {
        return animalType;
    }
}
