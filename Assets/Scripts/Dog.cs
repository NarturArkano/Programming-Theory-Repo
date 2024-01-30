using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float walkSpeed = 4;

    public override void Jump()
    {
        Jump(new Vector3(0, 3, 3));
    }

    public override void Speak()
    {
        Speak("Woof!");
    }

    public override void Walk(float input)
    {
        Walk(walkSpeed, input);
    }
}
