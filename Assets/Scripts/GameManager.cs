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
        activeAnimal = DataHandler.Instance.getType();

        animals[activeAnimal].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animals[activeAnimal].Jump();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animals[activeAnimal].Speak();
        }

        animals[activeAnimal].Walk(forwardInput);
    }
}
