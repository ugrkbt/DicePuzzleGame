using UnityEngine;
using System.Collections;


public class LocationZar : MonoBehaviour {
    public GameObject sad;
    void LateUpdate()
    {
        this.transform.position = sad.transform.position;
    }

}
