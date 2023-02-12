using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Ball
{
    public override Vector3 GetBackwardDir()
    {
        //Debug.Log("UP");
        return Vector3.up;
    }

    public override Vector3 GetForwardDir()
    {
        //Debug.Log("down");
        return Vector3.down;
    }

    public override float GetSpeed()
    {
        return 0.2f;
    }

    public override void SpecialBehaviour()
    {
        tagToBounce = "Floor";
        objectsRb.AddTorque(0, 0, GetRandomZTorque(8f), ForceMode.Impulse);
    }

    private float GetRandomZTorque(float flo)
    {
        return Random.Range(-flo, flo);
    }
}
