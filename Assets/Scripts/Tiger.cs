using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiger : Animal
{
    private float walkSpeed = 6;

    public override void Speak()
    {
        Speak("Roar!");
    }

    public override void Jump()
    {
        Vector3 direction = new Vector3(0, 6, 0.5f);
        Jump(direction);
    }

    public override void Walk(float input)
    {
        Walk(walkSpeed, input);
    }
}
