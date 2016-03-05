using UnityEngine;
using UnityEngine.UI;


public class AdımSayar : MonoBehaviour {
    public static int sayi = 0;
    public static int sayiLocal = 0;
	// Use this for initialization
	void Start () {
        sayiLocal = 0;
      
        sayi = PlayerPrefs.GetInt("All");
        sayi = sayi - PlayerPrefs.GetInt("Local" + Application.loadedLevel);
        GameObject.Find("MoveText").GetComponent<Text>().text = Application.loadedLevel.ToString() ;
      //  GameObject.Find("MoveLocalText").GetComponent<Text>().text = sayi.ToString();
    }
	public static void art()
    {
        sayi++;
        sayiLocal++;
       
        GameObject.Find("MoveLocalText").GetComponent<Text>().text = sayi.ToString();
  
       
     
    }
    public void levelSelectClik()
    {
        Application.LoadLevel(0);
    }
    public void refresh()
    {
        Application.LoadLevel(Application.loadedLevel);
    }


}
