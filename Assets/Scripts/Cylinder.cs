using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Ball
{
    // POLYMORPHISM
    public override Vector3 GetBackwardDir()
    {
        return Vector3.up;
    }

    // POLYMORPHISM
    public override Vector3 GetForwardDir()
    {
        return Vector3.down;
    }

    // POLYMORPHISM
    public override void SpecialBehaviour()
    {
        tagToBounce = "Floor";
        objectsRb.AddTorque(0, 0, GetRandomZTorque(8f), ForceMode.Impulse);
        speed = 0.2f;
    }

    // POLYMORPHISM
    // ABSTRACTION
    private float GetRandomZTorque(float flo)
    {
        return Random.Range(-flo, flo);
    }
}
