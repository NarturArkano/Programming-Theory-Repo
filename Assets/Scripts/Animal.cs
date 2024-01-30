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

    public abstract void Jump();

    public void Jump(Vector3 direction)
    {
        rb.AddForce(direction, ForceMode.Impulse);
    }

    public abstract void Walk(float input);

    public void Walk(float walkSpeed, float input)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed * input);
    }

    public abstract void Speak();

    protected void Speak(string voice)
    {
        Debug.Log(CreatureName + ": " + voice);
    }
}
