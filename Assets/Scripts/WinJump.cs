using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinJump : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(Vector3.up * 10f);
    }
}
