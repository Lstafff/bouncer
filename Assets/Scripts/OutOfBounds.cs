using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Player") == true)
        {
            rigidbody.GetComponent<LineForce>().Reset();
        }
    }
}
