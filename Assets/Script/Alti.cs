using UnityEngine;
using System.Collections;
using Assets;
public class Alti : MonoBehaviour {

    public Transform obje;
    void OnTriggerEnter(Collider col)
    {
        //her hangi bir  objeye çarptığında çalışır
        if (col.gameObject.tag == "Alti")
        {
            if (Application.loadedLevel == 11)
            {
                Matris.MatrisEkle(3,2);
                Instantiate(obje, new Vector3(1, -0.625f,-1), Quaternion.identity);
            }
            if (Application.loadedLevel == 12)
            {
                Matris.MatrisEkle(2, 4);
                Instantiate(obje, new Vector3(0, -0.625f, -3), Quaternion.identity);
            }
            if (Application.loadedLevel == 13)
            {
                Matris.MatrisEkle(3, 5);
                Instantiate(obje, new Vector3(1, -0.625f, -4), Quaternion.identity);
            }
            if (Application.loadedLevel == 14)
            {
                Matris.MatrisEkle(6, 1);
                Matris.MatrisEkle(4, 4);

                Instantiate(obje, new Vector3(-2, -0.625f, 0), Quaternion.identity);
                Instantiate(obje, new Vector3(0, -0.625f, -3), Quaternion.identity);
            }
            if (Application.loadedLevel == 15)
            {
                Matris.MatrisEkle(3, 2);  
                Instantiate(obje, new Vector3(1, -0.625f, -1), Quaternion.identity);
            }
        }

    }
}
