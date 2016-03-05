using UnityEngine;
using System.Collections;
using Assets;

public class ileriKay : MonoBehaviour {
    Hareket nesne = new Hareket();
    EkranKaydırma nesne1 = new EkranKaydırma();
    void OnTriggerEnter(Collider col)
    {
        //her hangi bir  objeye çarptığında çalışır
        if (col.gameObject.tag == "ileri")
        {
            nesne1.ileriKay();
            nesne.ileriKay();
            Matris.SagaGitti();
            Matris.SagaGitti();

        }

    }
}
