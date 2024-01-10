using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private string CreatureName { get; set; }
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump(Vector3 direction)
    {

    }

    public void Walk(float walkSpeed, float input)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed * input);
    }

    protected void Speak(string voice)
    {
        Debug.Log(CreatureName + ": " + voice);
    }
}
