using UnityEngine;
using System.Collections;
using Assets;
public class yukarıKay : MonoBehaviour {
    Hareket nesne = new Hareket();
    EkranKaydırma nesne1 = new EkranKaydırma();
    void OnTriggerEnter(Collider col)
    {
        //her hangi bir  objeye çarptığında çalışır
        if (col.gameObject.tag == "Yukari")
        {
            nesne1.yukariKay();
            nesne.yukariKay();
            Matris.ileriGitti();
            Matris.ileriGitti();

        }

    }
}
