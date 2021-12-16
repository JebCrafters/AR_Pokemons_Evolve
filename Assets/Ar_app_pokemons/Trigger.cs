using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
  public GameObject obj_hide; 
  public GameObject obj_reveal;

    private void OnTriggerEnter(Collider Colider)
  {
        if (Colider.gameObject.name == "heart_evolve")
        {
            Debug.Log(Colider.gameObject.name);
            obj_hide.SetActive(false);
            obj_reveal.SetActive(true);
        }
  }

  private void OnTriggerExit(Collider Colider)
  {
        if (Colider.gameObject.name == "heart_evolve")
        {
            obj_hide.SetActive(true);
            obj_reveal.SetActive(false);
        }
  }
}
