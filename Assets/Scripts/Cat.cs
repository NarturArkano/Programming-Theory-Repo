using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    private float walkSpeed = 1;

    public override void Jump()
    {
        Jump(new Vector3(0, 4, .5f));
    }

    public override void Speak()
    {
        Speak("Meow.");
    }

    public override void Walk(float input)
    {
        Walk(walkSpeed, input);
    }
}
