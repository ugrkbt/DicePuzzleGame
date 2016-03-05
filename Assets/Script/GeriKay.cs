using UnityEngine;
using System.Collections;
using Assets;
public class GeriKay : MonoBehaviour {
    Hareket nesne = new Hareket();
    EkranKaydırma nesne1 = new EkranKaydırma();
    void OnTriggerEnter(Collider col)
    {
        //her hangi bir  objeye çarptığında çalışır
        if (col.gameObject.tag == "Geri")
        {
            nesne.geriKay();
            nesne1.geriKay();
            Matris.SolaGitti();
            Matris.SolaGitti();
           
        }

    }
}
