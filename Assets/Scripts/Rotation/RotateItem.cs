using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour
{

    public float RotateSpeed;    //ou float RotateSpeed = 5f (je vois pas la différence)

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotateSpeed = Time.deltaTime *200f;
        transform.Rotate(0, RotateSpeed, 0);

    }
}
