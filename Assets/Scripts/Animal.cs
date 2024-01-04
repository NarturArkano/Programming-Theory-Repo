using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected float jumpMult = 1;
    protected float walkSpeed;
    private string CreatureName { get; set; }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump()
    {

    }

    public void Walk()
    {

    }

    protected void Speak(string voice)
    {
        Debug.Log(CreatureName + ": " + voice);
    }
}
