using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody objectsRb;
    private bool isGoingForward = true;
    private bool hasChangedDirectionRecently = false;

    // Start is called before the first frame update
    void Start()
    {
        InitializeObjectProperties();
    }

    void Update()
    {
        if (isGoingForward)
        {
            objectsRb.AddForce(GetSpeed() * Time.deltaTime * GetForwardDir(),ForceMode.Impulse);
        }
        else
        {
            objectsRb.AddForce(GetSpeed() * Time.deltaTime * GetBackwardDir(),ForceMode.Impulse);
        }
    }

    public virtual Vector3 GetForwardDir()
    {
        return Vector3.right;
    }

    public virtual Vector3 GetBackwardDir()
    {
        return Vector3.left;
    }

    public virtual float GetSpeed()
    {
        return 4f;
    }

    private void InitializeObjectProperties()
    {
        objectsRb = gameObject.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall") && !hasChangedDirectionRecently)
        {
            isGoingForward = !isGoingForward;
            hasChangedDirectionRecently = true;
            StartCoroutine(WaitForDirectionChange());
        }
    }

    private IEnumerator WaitForDirectionChange()
    {
        yield return new WaitForSeconds(5);
        hasChangedDirectionRecently = false;
    }
}
