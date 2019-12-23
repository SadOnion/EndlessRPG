using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTo : MonoBehaviour
{
    public float speed;
    float timer;
    public float time;
    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if(timer>time)enabled=false;
       transform.Rotate(Vector3.forward*Time.deltaTime*speed);
    }
}
