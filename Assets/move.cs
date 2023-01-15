using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public GameObject Character;
    public float Speed = 5f;
    public bool canControl;

    void Update()
    {
        if (canControl == true)
        {
            float h = Input.GetAxis("Horizontal") * Speed;
            float v = Input.GetAxis("Vertical") * Speed;

            Character.transform.Translate(h * Time.deltaTime, 0, v * Time.deltaTime);
        }
    }
}
