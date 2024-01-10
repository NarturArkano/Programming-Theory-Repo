using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Animal> animals = new();
    private float forwardInput;
    private int activeAnimal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum Animal
    {
        Dog,
        Cat,
        Tiger
    }
}
