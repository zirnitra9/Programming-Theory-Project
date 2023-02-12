using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : Ball
{
    public override Vector3 GetBackwardDir()
    {
        return Vector3.forward;
    }

    public override Vector3 GetForwardDir()
    {
        return Vector3.back;
    }

    public override float GetSpeed()
    {
        return 5f;
    }
}
