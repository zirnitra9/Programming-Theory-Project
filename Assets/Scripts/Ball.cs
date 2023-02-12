using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    protected Rigidbody objectsRb;
    [SerializeField]private bool isGoingForward = true;
    [SerializeField]private bool hasChangedDirectionRecently = false;

    protected string tagToBounce = "Wall";
    public string TagToBounce { get => tagToBounce; set { } }

    // Start is called before the first frame update
    void Start()
    {
        InitializeObject();
        SpecialBehaviour();
    }

    void Update()
    {
        MoveItself();
    }

    private void MoveItself()
    {
        if (isGoingForward)
        {
            objectsRb.AddForce(GetSpeed() * Time.deltaTime * GetForwardDir(), ForceMode.Impulse);
        }
        else
        {
            objectsRb.AddForce(GetSpeed() * Time.deltaTime * GetBackwardDir(), ForceMode.Impulse);
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

    private void InitializeObject()
    {
        objectsRb = gameObject.GetComponent<Rigidbody>();
        //tagToBounce = "Wall";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tagToBounce) && !hasChangedDirectionRecently)
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

    public virtual void SpecialBehaviour()
    {

    }

}
