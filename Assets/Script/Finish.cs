using UnityEngine;
using System.Collections;
using Assets;



public class Finish : MonoBehaviour {
   

    public string kod;
   
    void Start()
    {
     
        

    }
    void OnTriggerEnter(Collider col)
    {


       


        //her hangi bir  objeye çarptığında çalışır
        if (col.gameObject.tag == "Finish")
        {   //Yeni levele geçilip geçilmediğini kontrol eder.   
          


            if (Application.loadedLevel+1 > PlayerPrefs.GetInt("level"))
            {
                Level.levelArt();
                PlayerPrefs.SetInt("level", Level.level);
            }
           //Yeni oynamadaki şeyi locale atıyor
            PlayerPrefs.SetInt("Local" + Application.loadedLevel,AdımSayar.sayiLocal);
        
            PlayerPrefs.SetInt("All", AdımSayar.sayi);
         
            // en son leveli kaydeder.
            PlayerPrefs.SetInt("loadlevel", Application.loadedLevel);
            //ileriki levele gider
          
            Application.LoadLevel(Application.loadedLevel+1);  
        }

    }
    public void levelSelect()
    {
        Application.LoadLevel(16);


        
    }
   
   
    public void Yorum()
    {
        Application.OpenURL("http://ugrkbt.blogspot.com.tr/2015/09/windows-phone-yorum-yap-ve-mail-at.html");
    }

}
