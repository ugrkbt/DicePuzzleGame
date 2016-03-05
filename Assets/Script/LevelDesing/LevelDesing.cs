using UnityEngine;
using System.Collections;
using Assets;

public class LevelDesing : MonoBehaviour {

    void Awake()
    {
        Matris.MatrisBoyut(13,13);
        for(int x=0; x < 13; x++)
        {
            for (int y = 0; y <13; y++)
            {
                Matris.MatrisEkle(x, y);
            }

        }
       


    }
}
