using UnityEngine;
using System.Collections;
using Assets;
using UnityEngine.UI;
public class Hareket : MonoBehaviour {

    static Vector3 ileri = new Vector3(0, 0, 0);
    Quaternion rotR = Quaternion.identity;
    Quaternion eski;
    // Use this for initialization
    AudioSource hareket;
    public AudioClip ses1;
    public AudioClip ses2;
   Animator anim;
    void Awake()
    {
        ileri = new Vector3(0, 0, 0);
        hareket = gameObject.GetComponent<AudioSource>();
        anim = GameObject.FindGameObjectWithTag("Camera").GetComponent<Animator>();
    }
    void falseyap() {
        
        anim.SetBool("ileri", false);
        anim.SetBool("geri", false);
        anim.SetBool("sag", false);
        anim.SetBool("sol", false);
       
    }
    // Update is called once per frame
    void Update ()
    {
         float step = 10f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, ileri, step);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotR*eski, step*90);
      
       



        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<EkranKaydırma>().enabled = false;

            if (Matris.SolGit())
            {
                
                eski = transform.rotation;
                rotR = Quaternion.AngleAxis(90, Vector3.right);
                hareket.PlayOneShot(ses1);     
               ileri += new Vector3(0, 0, 1);
             
                Matris.SolaGitti();
            }
            else
            {
                hareket.PlayOneShot(ses2);
                anim.SetBool("sol", true);
                Invoke("falseyap", 0.2f);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.GetComponent<EkranKaydırma>().enabled = false;
            if (Matris.SagGit())
            {
                eski = transform.rotation;
                rotR = Quaternion.AngleAxis(-90, Vector3.right);
                hareket.PlayOneShot(ses1);
             
                ileri += new Vector3(0, 0, -1);
                Matris.SagaGitti();
               
            }
            else
            {
                hareket.PlayOneShot(ses2);
                anim.SetBool("sag", true);
                Invoke("falseyap", 0.2f);
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.GetComponent<EkranKaydırma>().enabled = false;
            if (Matris.ileriGit())
            {
                eski = transform.rotation;
                rotR = Quaternion.AngleAxis(-90, Vector3.forward);
                hareket.PlayOneShot(ses1);
              
                ileri += new Vector3(1, 0, 0);
                Matris.ileriGitti();
            }
            else
            {
                hareket.PlayOneShot(ses2);
                anim.SetBool("ileri", true);
                Invoke("falseyap", 0.2f);
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.GetComponent<EkranKaydırma>().enabled = false;
            if (Matris.AsagiGit())
            {
                eski = transform.rotation;
                rotR = Quaternion.AngleAxis(90, Vector3.forward);
                hareket.PlayOneShot(ses1);
             
                ileri += new Vector3(-1, 0, 0);
                Matris.AsagiGitti();
            }
            else
            {
                
                hareket.PlayOneShot(ses2);
                anim.SetBool("geri", true);
                Invoke("falseyap", 0.2f);

            }

        }
    }
    public void aşagıKay()
    {
        ileri += new Vector3(-2, 0, 0);
    }
    public void yukariKay()
    {
        ileri += new Vector3(2, 0, 0);
    }
    public void ileriKay()
    {
        ileri += new Vector3(0, 0, -2);
    }
    public void geriKay()
    {
        ileri += new Vector3(0, 0, 2);
    }
}
