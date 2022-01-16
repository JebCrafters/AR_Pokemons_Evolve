using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsyduckVSEevee : MonoBehaviour
{
    public GameObject obj_hide1;
    public GameObject obj_hide2;
    public GameObject obj_reveal;


    private void OnTriggerEnter(Collider Colider)
    {
        if (Colider.gameObject.name == "Eevee_model")
        {
            Debug.Log(Colider.gameObject.name);
            obj_hide1.SetActive(false);
            obj_hide2.SetActive(false);
            obj_reveal.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider Colider)
    {
        if (Colider.gameObject.name == "Eevee_model")
        {
            obj_hide1.SetActive(true);
            obj_hide2.SetActive(true);
            obj_reveal.SetActive(false);
        
        }
    }
}
