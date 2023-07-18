using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchManager : MonoBehaviour
{
    public float laserLength = .3f;


    void Start()
    {

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up * laserLength);
            Debug.DrawRay(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up * laserLength, Color.red);
            if (hit.collider != null)
            {
                // Debug.Log(hit.collider.gameObject.name);
                //hit.collider.GetComponent<Animator>().SetBool("Destroy", true);
                Destroy(this.gameObject, .4f);
            }
        }
    }
}
