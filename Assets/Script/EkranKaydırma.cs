using UnityEngine;
using System.Collections;
using Assets;
using UnityEngine.UI;
public class EkranKaydırma : MonoBehaviour {
    Vector3 açı = new Vector3(0, 0, 0);
    static Vector3 ileri = new Vector3(0, 0, 0);
    Quaternion rotR = Quaternion.identity;
    Quaternion eski;

    float minSwipeDistY=100;

    float minSwipeDistX=100;

    private Vector2 startPos;
    AudioSource hareket;
    public AudioClip ses1;
    public AudioClip ses2;

    // Use this for initialization
    Animator anim;
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
    void Awake()
    {
        ileri = new Vector3(0, 0, 0);
        hareket = gameObject.GetComponent<AudioSource>();
        anim = GameObject.FindGameObjectWithTag("Camera").GetComponent<Animator>();
    }
    void falseyap()
    {
        anim.SetBool("ileri", false);
        anim.SetBool("geri", false);
        anim.SetBool("sag", false);
        anim.SetBool("sol", false);
    }
    void Update()
    {
        float step = 10f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, ileri, step);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotR * eski, step * 90);

        //#if UNITY_ANDROID
        if (Input.touchCount > 0)

        {

            Touch touch = Input.touches[0];
            gameObject.GetComponent<Hareket>().enabled = false;


            switch (touch.phase)

            {

                case TouchPhase.Began:

                    startPos = touch.position;

                    break;



                case TouchPhase.Ended:

                    float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;
                    float swipeDistHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
                    if (swipeDistVertical > swipeDistHorizontal)

                    {

                        float swipeValue = Mathf.Sign(touch.position.y - startPos.y);

                        if (swipeValue > 0)//up swipe
                        {
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

                        else if (swipeValue < 0)//down swipe
                        {
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

                   

                   else if (swipeDistHorizontal > swipeDistVertical)

                    {

                        float swipeValue = Mathf.Sign(touch.position.x - startPos.x);

                        if (swipeValue > 0) //right swipe
                        {
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

                        else if (swipeValue < 0) {
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
                        }//left swipe
                           

                    }
                    break;
            }
        }
    }
}

