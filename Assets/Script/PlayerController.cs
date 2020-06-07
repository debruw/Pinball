using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Arm1, Arm2;
    public float speed = 100;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //Arm1- (-25/+25)
            Arm1.transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
            if(Arm1.transform.eulerAngles.z <= 30)
            {
                Arm1.transform.eulerAngles = new Vector3(0, 0, Mathf.Clamp(Arm1.transform.eulerAngles.z, 0, 25));
            }
            if(Arm1.transform.eulerAngles.z >= 330)
            {
                Arm1.transform.eulerAngles = new Vector3(0, 0, Mathf.Clamp(Arm1.transform.eulerAngles.z, 336, 385));
            }
        }
        else
        {
            Arm1.transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
            if (Arm1.transform.eulerAngles.z <= 30)
            {
                Arm1.transform.eulerAngles = new Vector3(0, 0, Mathf.Clamp(Arm1.transform.eulerAngles.z, 0, 25));
            }
            if (Arm1.transform.eulerAngles.z >= 330)
            {
                Arm1.transform.eulerAngles = new Vector3(0, 0, Mathf.Clamp(Arm1.transform.eulerAngles.z, 336, 385));
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Arm2- (-25/+25)
            Arm2.transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
            if (Arm2.transform.eulerAngles.z <= 30)
            {
                Arm2.transform.eulerAngles = new Vector3(0, 0, Mathf.Clamp(Arm2.transform.eulerAngles.z, 0, 25));
            }
            if (Arm2.transform.eulerAngles.z >= 330)
            {
                Arm2.transform.eulerAngles = new Vector3(0, 0, Mathf.Clamp(Arm2.transform.eulerAngles.z, 336, 385));
            }
        }
        else
        {
            Arm2.transform.Rotate(new Vector3(0, 0, +speed * Time.deltaTime));
            if (Arm2.transform.eulerAngles.z <= 30)
            {
                Arm2.transform.eulerAngles = new Vector3(0, 0, Mathf.Clamp(Arm2.transform.eulerAngles.z, 0, 25));
            }
            if (Arm2.transform.eulerAngles.z >= 330)
            {
                Arm2.transform.eulerAngles = new Vector3(0, 0, Mathf.Clamp(Arm2.transform.eulerAngles.z, 336, 385));
            }
        }
    }
}
