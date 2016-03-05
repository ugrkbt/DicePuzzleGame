using UnityEngine;
using System.Collections;
using Assets;
public class Level1 : MonoBehaviour {
    public Transform obje;
    public Transform zar;
    public Transform bitis;
 
        void Awake()
    {
        Matris.MatrisBoyut(3, 7);
        Matris.MatrisEkle(1, 1);
        Matris.MatrisEkle(1, 2);
        Matris.MatrisEkle(1, 3);
        Matris.MatrisEkle(1, 4);
        Matris.MatrisEkle(1, 5);
     

    }
    void Start()
    {
      
        Invoke("bir", 0);
        Invoke("iki", 0.2f);
        Invoke("üc", 0.4f);
        Invoke("dört", 0.6f);
        Invoke("Bitis", 0.8f);
        Invoke("Zar", 1.1f);
        
       
    }
    void Zar()
    {
        Instantiate(zar, new Vector3(0, 0, 0),Quaternion.Euler(0,0,0));
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
    void Bitis()
    {
        Instantiate(bitis, new Vector3(0, -0.625f, -4), Quaternion.identity);
    }
}
