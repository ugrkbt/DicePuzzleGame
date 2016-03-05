using UnityEngine;
using System.Collections;
using Assets;

public class Level7 : MonoBehaviour {

    public Transform obje;
    public Transform zar;
    public Transform bitis;


    void Awake()
    {
        Matris.MatrisBoyut(7, 7);
        for (int x = 2; x <6; x++)
        {
            if (x != 3)
            {
                for (int y = 1; y < 6; y++)
                {
                    Matris.MatrisEkle(x, y);
                }
            }
        }
        Matris.MatrisEkle(3, 1);
        Matris.MatrisEkle(3, 5);

    }
    void Start()
    {

        Invoke("bir", 0);
        Invoke("iki", 0.3f);
        Invoke("üc", 0.6f);
        Invoke("dört", 0);
        Invoke("bes", 0.3f);


        Invoke("birx", 0.1f);
        Invoke("ikix", 0.4f);
        Invoke("ücx", 0.7f);
        Invoke("dörtx", 0);
      
        Invoke("bir1", 0.2f);
        Invoke("iki1", 0.2f);
        Invoke("biry", 0.1f);
        Invoke("ikiy", 0.4f);
        Invoke("ücy", 0.7f);
        Invoke("dörty", 0);
        Invoke("besy", 0.3f);



        Invoke("Bitis", 1f);
        Invoke("Zar", 1.3f);


    }
    void Zar()
    {
        Instantiate(zar, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
    }
    void bir()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, 0), Quaternion.identity);
    }
    void iki()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -1), Quaternion.identity);
    }
    void üc()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -2), Quaternion.identity);
    }
    void dört()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -3), Quaternion.identity);
    }
    void bes()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -4), Quaternion.identity);
    }
    void biry()
    {
        Instantiate(obje, new Vector3(-2, -0.625f, 0), Quaternion.identity);
    }
    void ikiy()
    {
        Instantiate(obje, new Vector3(-2, -0.625f, -1), Quaternion.identity);
    }
    void ücy()
    {
        Instantiate(obje, new Vector3(-2, -0.625f, -2), Quaternion.identity);
    }
    void dörty()
    {
        Instantiate(obje, new Vector3(-2, -0.625f, -3), Quaternion.identity);
    }
    void besy()
    {
        Instantiate(obje, new Vector3(-2, -0.625f, -4), Quaternion.identity);
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
 
    void bir1()
    {
        Instantiate(obje, new Vector3(0, -0.625f, 0), Quaternion.identity);
    }
    void iki1()
    {
        Instantiate(obje, new Vector3(0, -0.625f, -4), Quaternion.identity);
    }
    void Bitis()
    {
        Instantiate(bitis, new Vector3(1, -0.625f, -4), Quaternion.identity);
    }
}
