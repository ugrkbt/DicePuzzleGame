using UnityEngine;
using System.Collections;

public class Düsüs : MonoBehaviour {

    Vector3 localPos;


    void Awake()
    {
        localPos = transform.position;
       
    }

    void LateUpdate()
    {


        transform.localPosition += localPos;
       
    }
}
