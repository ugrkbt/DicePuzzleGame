using UnityEngine;
using System.Collections;
using Assets;
public class asagiKay : MonoBehaviour {
    Hareket nesne = new Hareket();
    EkranKaydırma nesne1 = new EkranKaydırma();
    void OnTriggerEnter(Collider col)
    {
        //her hangi bir  objeye çarptığında çalışır
        if (col.gameObject.tag == "Asagi")
        {
            nesne1.aşagıKay();
            nesne.aşagıKay();
            Matris.AsagiGitti();
            Matris.AsagiGitti();

        }

    }
}
