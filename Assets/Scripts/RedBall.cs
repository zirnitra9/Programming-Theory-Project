using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class RedBall : Ball
{
    // POLYMORPHISM
    public override Vector3 GetBackwardDir()
    {
        return Vector3.forward;
    }
    // POLYMORPHISM
    public override Vector3 GetForwardDir()
    {
        return Vector3.back;
    }
    // POLYMORPHISM
    public override void SpecialBehaviour()
    {
        speed = 5f;
    }
}
