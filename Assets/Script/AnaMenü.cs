using UnityEngine;
using System.Collections;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

public class AnaMenü : MonoBehaviour {
    AudioSource ses;
    public AudioClip ses1;
    void Start()
    {
        ses = gameObject.GetComponent<AudioSource>();
    }
    public void levelSelect()
    {
        
        ses.PlayOneShot(ses1);
        Application.LoadLevel(16);
        
       
    }
    public void Yorum()
    { 
        ses.PlayOneShot(ses1);
       
        Application.OpenURL("https://www.microsoft.com/store/apps/9nblggh4q9z6/");
    }
    public void cıkıs()
    {
        ses.PlayOneShot(ses1);
        Application.Quit();
    }
  
}
