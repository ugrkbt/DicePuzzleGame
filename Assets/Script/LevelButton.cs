using UnityEngine;
using System.Collections;
using Assets;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour {
    AudioSource ses;
    public AudioClip ses1;
    void Start () {
        
        ses = gameObject.GetComponent<AudioSource>();
        Level.level = PlayerPrefs.GetInt("level");
       int y= Level.level;
       for(int x = 0; x < y; x++)
        {
            if(x<15)
            GameObject.Find("Level (" + (x + 1)+")").GetComponent<Button>().interactable = true;
        }
	}
	
	public void click(int x)
    {
        ses.PlayOneShot(ses1);
        Application.LoadLevel(x);
       
    }
   
  
}
