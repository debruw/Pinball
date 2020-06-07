using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmScript : MonoBehaviour
{
    public float force = 25;
    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.velocity = new Vector3(0, force, 0);

    }
}
