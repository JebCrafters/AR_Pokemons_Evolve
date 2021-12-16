using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Distance : MonoBehaviour
{
    public GameObject track1; //track1
    public GameObject track2; //track2
    public GameObject obj_hide1; //obj_hide_1
    public GameObject obj_hide2; //obj_hide_2
    public GameObject camera; //camera
    public float Distance1; //distance track to track
    public float Distance2; //distance camera to track 1
    public float Distance3; //distance camera to track 2
    public float between; // (d1+d2)/2
    public float vector_track_to_track; //change_distance
    public GameObject object5; //new_evolve_obj

    void Update()
    {
        Distance1 = Vector3.Distance(track1.transform.position, track2.transform.position);
        Distance2 = Vector3.Distance(camera.transform.position, track1.transform.position);
        Distance3 = Vector3.Distance(camera.transform.position, track2.transform.position);
       between = (Distance2 + Distance3) / 2;
        vector_track_to_track = 0.125F;
        if (between > Distance1)
        {
            vector_track_to_track = vector_track_to_track + (between - Distance1);
        }
        else
        {

        }
        if (Distance1 < vector_track_to_track)
           // if (Distance1 < 0.14)
            {
            //Destroy(object1);
            //Destroy(object2);

            // Instantiate(prefab);
            obj_hide1.SetActive(false);
            obj_hide2.SetActive(false);
            object5.SetActive(true);
            // object1.GetComponent<Renderer>().enabled = false;
            //object2.GetComponent<Renderer>().enabled = false;
        }
        else
        {
            obj_hide1.SetActive(true);
            obj_hide2.SetActive(true);
            object5.SetActive(false);
        }
                
    }
}
