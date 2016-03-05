using UnityEngine;
using System.Collections;
using Assets;
public class Level15 : MonoBehaviour {

    public Transform obje;
    public Transform zar;
    public Transform bitis;
    public Transform asagi;
    public Transform yukari;
    public Transform alti;
    public Transform ileri;


    void Awake()
    {
        Matris.MatrisBoyut(9, 9);
        for (int x = 4; x < 6; x++)
        {
            for (int y = 1; y < 4; y++)
            {
                Matris.MatrisEkle(x, y);
            }

        }
        for (int x = 6; x < 8; x++)
        {
            for (int y = 4; y < 7; y++)
            {
                Matris.MatrisEkle(x, y);
            }

        }
        
        Matris.MatrisEkle(2, 2);
        Matris.MatrisEkle(4, 5);
        Matris.MatrisEkle(4, 6);
        Matris.MatrisEkle(7, 3);
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

        Invoke("besx", 0.4f);
        Invoke("bir1", 0);
        Invoke("iki1", 0.1f);
        Invoke("üc1", 0.2f);
        Invoke("dört1", 0.3f);
     

        Invoke("altiZemin", 0.5f);




        Invoke("Bitis", 0.5f);
        Invoke("Zar", 0.8f);


    }
    void Bitis()
    {
        Instantiate(bitis, new Vector3(2, -0.625f, -1), Quaternion.identity);
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
        Instantiate(obje, new Vector3(-1, -0.625f, 0), Quaternion.identity);
    }
    void dört()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -1), Quaternion.identity);
    }
    void bes()
    {
        Instantiate(ileri, new Vector3(0, -0.625f, -2), Quaternion.identity);
    }
    void altı()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -2), Quaternion.identity);
    }
    void birx()
    {
        Instantiate(obje, new Vector3(0, -0.625f, -4), Quaternion.identity);
    }
    void ikix()
    {
        Instantiate(asagi, new Vector3(0, -0.625f, -5), Quaternion.identity);
    }
    void ücx()
    {
        Instantiate(obje, new Vector3(-2, -0.625f, -3), Quaternion.identity);
    }

    void besx()
    {
        Instantiate(obje, new Vector3(-2, -0.625f, -4), Quaternion.identity);
    }

    void altiZemin()
    {
        Instantiate(alti, new Vector3(-3, -0.625f, -5), Quaternion.identity);
    }
    void bir1()
    {
        Instantiate(obje, new Vector3(-2, -0.625f, -5), Quaternion.identity);
    }
    void iki1()
    {
        Instantiate(obje, new Vector3(-3, -0.625f, -3), Quaternion.identity);
    }
    void üc1()
    {
        Instantiate(obje, new Vector3(-3, -0.625f, -4), Quaternion.identity);
    }
    void dört1()
    {
        Instantiate(yukari, new Vector3(-3, -0.625f, -2), Quaternion.identity);
    }


}
