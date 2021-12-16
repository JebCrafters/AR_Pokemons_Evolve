using UnityEngine;

public class Open_pockeball : MonoBehaviour
{
    string btnName;
    public Animation anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        anim["open"].layer = 123;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "myButton1":
                        anim.Play("open");
                        break;
                }
            }
        }
    }
}

            
