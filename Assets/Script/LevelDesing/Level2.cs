using UnityEngine;
using System.Collections;
using Assets;

public class Level2 : MonoBehaviour {

    public Transform obje;
    public Transform zar;
    public Transform bitis;

    void Awake()
    {
        Matris.MatrisBoyut(5, 8);
        for (int x = 1; x < 3; x++)
        {
            for (int y = 1; y < 7; y++)
            {
                Matris.MatrisEkle(x, y);
            }

        }

    }
    void Start()
    {

        Invoke("bir", 0);
        Invoke("iki", 0.2f);
        Invoke("üc", 0.4f);
        Invoke("dört", 0.6f);
        Invoke("bes", 0.8f);
      
        Invoke("birx", 0.1f);
        Invoke("ikix", 0.3f);
        Invoke("ücx", 0.5f);
        Invoke("dörtx", 0.7f);
        Invoke("besx", 0.9f);
        Invoke("altıx", 1f);

        Invoke("Bitis", 1.1f);
        Invoke("Zar", 1.4f);


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
    void dört()
    {
        Instantiate(obje, new Vector3(0, -0.625f, -3), Quaternion.identity);
    }
    void bes()
    {
        Instantiate(obje, new Vector3(0, -0.625f, -4), Quaternion.identity);
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
    void dörtx()
    {
        Instantiate(obje, new Vector3(1, -0.625f, -3), Quaternion.identity);
    }
    void besx()
    {
        Instantiate(obje, new Vector3(1, -0.625f, -4), Quaternion.identity);
    }
    void altıx()
    {
        Instantiate(obje, new Vector3(1, -0.625f, -5), Quaternion.identity);
    }
    void Bitis()
    {
        Instantiate(bitis, new Vector3(0, -0.625f, -5), Quaternion.identity);
    }
}
