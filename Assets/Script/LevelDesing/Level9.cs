using UnityEngine;
using System.Collections;
using Assets;

public class Level9 : MonoBehaviour {


    public Transform obje;
    public Transform zar;
    public Transform bitis;
    public Transform ileri;


    void Awake()
    {
        Matris.MatrisBoyut(5, 7);
        for (int x = 2; x <4; x++)
        {
            for (int y = 1; y < 3; y++)
            {
                Matris.MatrisEkle(x, y);
            }

        }
        for (int x = 2; x < 4; x++)
        {
            for (int y = 4; y <6; y++)
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
        

        Invoke("birx", 0.1f);
     
        Invoke("ücx", 0.45f);
        Invoke("dörtx", 0.7f);


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
        Instantiate(obje, new Vector3(-1, -0.625f, 0), Quaternion.identity);
    }
    void dört()
    {
        Instantiate(ileri, new Vector3(-1, -0.625f, -1), Quaternion.identity);
    }
    void birx()
    {
        Instantiate(obje, new Vector3(0, -0.625f, -3), Quaternion.identity);
    }
  
    void ücx()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -3), Quaternion.identity);
    }
    void dörtx()
    {
        Instantiate(obje, new Vector3(-1, -0.625f, -4), Quaternion.identity);
    }

    void Bitis()
    {
        Instantiate(bitis, new Vector3(0, -0.625f, -4), Quaternion.identity);
    }
}
