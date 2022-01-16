using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class chanbge_cam : MonoBehaviour
{
    public TMPro.TMP_Dropdown Mydrop;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject cam7;
    public GameObject cam8;
    public GameObject cam9;
    public GameObject cam10;
    public GameObject cam11;
    public GameObject cam12;
    // Start is called before the first frame update
    public void CameraSelector()
    {
        if (Mydrop.value == 0)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false);
            cam10.SetActive(false);
            cam11.SetActive(false);
            cam12.SetActive(false);
        }
        else if (Mydrop.value == 1)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false);
            cam10.SetActive(false);
            cam11.SetActive(false);
            cam12.SetActive(false);
        }
        else if (Mydrop.value == 2)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false);
            cam10.SetActive(false);
            cam11.SetActive(false);
            cam12.SetActive(false);
        }
        else if (Mydrop.value == 3)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(true);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false);
            cam10.SetActive(false);
            cam11.SetActive(false);
            cam12.SetActive(false);
        }
        else if (Mydrop.value == 4)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(true);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false);
            cam10.SetActive(false);
            cam11.SetActive(false);
            cam12.SetActive(false);
        }
        else if (Mydrop.value == 5)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(true);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false);
            cam10.SetActive(false);
            cam11.SetActive(false);
            cam12.SetActive(false);
        }
        else if (Mydrop.value == 6)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(true);
            cam8.SetActive(false);
            cam9.SetActive(false);
            cam10.SetActive(false);
            cam11.SetActive(false);
            cam12.SetActive(false);
        }
        else if (Mydrop.value == 7)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(true);
            cam9.SetActive(false);
            cam10.SetActive(false);
            cam11.SetActive(false);
            cam12.SetActive(false);
        }
        else if (Mydrop.value == 8)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(true);
            cam10.SetActive(false);
            cam11.SetActive(false);
            cam12.SetActive(false);
        }
        else if (Mydrop.value == 9)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false);
            cam10.SetActive(true);
            cam11.SetActive(false);
            cam12.SetActive(false);
        }
        else if (Mydrop.value == 10)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false);
            cam10.SetActive(false);
            cam11.SetActive(true);
            cam12.SetActive(false);
        }
        else if (Mydrop.value == 11)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            cam9.SetActive(false);
            cam10.SetActive(false);
            cam11.SetActive(false);
            cam12.SetActive(true);
        }
            //else
            {
                cam1.SetActive(true);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(false);
                cam5.SetActive(false);
                cam6.SetActive(false);
                cam7.SetActive(false);
                cam8.SetActive(false);
                cam9.SetActive(false);
                cam10.SetActive(false);
                cam11.SetActive(false);
                cam12.SetActive(false);
            }
    }
}
