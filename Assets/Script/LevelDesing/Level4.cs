using UnityEngine;
using System.Collections;
using Assets;

public class Level4 : MonoBehaviour {

    public Transform obje;
    public Transform zar;
    public Transform bitis;


    void Awake()
    {
        Matris.MatrisBoyut(5, 5);
        for (int x = 1; x < 4; x++)
        {
            for (int y = 1; y < 4; y++)
            {
                Matris.MatrisEkle(x, y);
            }

        }

    }
    void Start()
    {

        Invoke("bir", 0);
        Invoke("iki", 0.3f);
        Invoke("üc", 0.6f);
       

        Invoke("birx", 0.1f);
        Invoke("ikix", 0.4f);
        Invoke("ücx", 0.7f);
        Invoke("bir1", 0.2f);
        Invoke("iki1", 0.5f);
       


        Invoke("Bitis", 1f);
        Invoke("Zar", 1.3f);


    }
    void Zar()
    {
        Instantiate(zar, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
    }
    void bir()
    {
        Instantiate(obje, new Vector3(0, -0.625f, 0), Quaternion.identity);
    }
    void iki()
    {
        Instantiate(obje, new Vector3(0, -0.625f, -1), Quaternion.identity);
    }
    void üc()
    {
        Instantiate(obje, new Vector3(0, -0.625f, -2), Quaternion.identity);
    }
   
    void birx()
    {
        Instantiate(obje, new Vector3(1, -0.625f, 0), Quaternion.identity);
    }
    void ikix()
    {
        Instantiate(obje, new Vector3(1, -0.625f, -1), Quaternion.identity);
    }
    void ücx()
    {
        Instantiate(obje, new Vector3(1, -0.625f, -2), Quaternion.identity);
    }
    void bir1()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, 0), Quaternion.identity);
    }
    void iki1()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -1), Quaternion.identity);
    }
    void Bitis()
    {
        Instantiate(bitis, new Vector3(-1, -0.625f, -2), Quaternion.identity);
    }
}
