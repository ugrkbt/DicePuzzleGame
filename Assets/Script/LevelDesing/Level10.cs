using UnityEngine;
using System.Collections;
using Assets;
public class Level10 : MonoBehaviour {

    public Transform obje;
    public Transform zar;
    public Transform bitis;
    public Transform ileri;


    void Awake()
    {
        Matris.MatrisBoyut(5, 9);
        for (int x = 2; x < 4; x++)
        {
            for (int y = 1; y < 4; y++)
            {
                Matris.MatrisEkle(x, y);
            }

        }
        for (int x = 2; x < 4; x++)
        {
            for (int y = 5; y < 8; y++)
            {
                Matris.MatrisEkle(x, y);
            }

        }

    }
    void Start()
    {

        Invoke("bir", 0);
        Invoke("iki", 0.1f);
        Invoke("üc", 0.2f);
        Invoke("dört", 0.3f);
        Invoke("bes", 0.4f);
        Invoke("altı", 0.5f);
        Invoke("birx", 0);
        Invoke("ikix", 0.1f);
        Invoke("ücx", 0.2f);
        Invoke("dörtx", 0.3f);
        Invoke("besx", 0.4f);
       




        Invoke("Bitis", 0.6f);
        Invoke("Zar", 0.9f);


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
        Instantiate(obje, new Vector3(-1, -0.625f, 0), Quaternion.identity);
    }
    void bes()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -1), Quaternion.identity);
    }
    void altı()
    {
        Instantiate(ileri, new Vector3(-1, -0.625f, -2), Quaternion.identity);
    }
    void birx()
    {
        Instantiate(obje, new Vector3(0, -0.625f, -4), Quaternion.identity);
    }
    void ikix()
    {
        Instantiate(obje, new Vector3(0, -0.625f, -5), Quaternion.identity);
    }
    void ücx()
    {
        Instantiate(obje, new Vector3(0, -0.625f, -6), Quaternion.identity);
    }
    void dörtx()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -4), Quaternion.identity);
    }
    void besx()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -5), Quaternion.identity);
    }

    void Bitis()
    {
        Instantiate(bitis, new Vector3(-1, -0.625f, -6), Quaternion.identity);
    }
}
