using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class animHDD : MonoBehaviour
{

    public Animator anim;
    public AudioSource sound_open;
    [SerializeField] ParticleSystem EnergyExplosion = null;
   // private Vector2 touchPosition = default;
   // private Camera arCamera;
    //string btnName;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.touchCount >0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = touch.position;
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;
                if (Physics.Raycast(ray, out hitObject))
                {
                    Collect();
                    anim.Play("open");
                    sound_open.Play();
                }
            }
        }


        */

      
        

            for (int i = 0; i < Input.touchCount; ++i)
                //if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("none"))
                if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("open"))


                {
                    Collect();
                    anim.Play("open");
                    sound_open.Play();
                }


                else
                { 
       
                   
                }

      

        



        //  if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("none"))
        // else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("close"))
        //{
        //    anim.Play("open");
        //}
        // else if (Input.GetKeyDown("1") && anim.GetCurrentAnimatorStateInfo(0).IsName("open"))
        //{
        //    anim.Play("close");
        //  }
        /*/
                for (int i = 0; i < Input.touchCount; ++i)
                {
                    if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("none"))
                    {
                        anim.Play("open");
                    }
                    else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("close"))
                    {
                        anim.Play("open");
                    }
                    else if (Input.GetTouch(i).phase == TouchPhase.Began && anim.GetCurrentAnimatorStateInfo(0).IsName("open"))
                    {
                        anim.Play("close");
                    }
        }*/



    }
    public void Collect()
    {
        EnergyExplosion.Play();
    }
}