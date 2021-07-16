using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private GameObject doors;
    private Animator anim;
    void Start()
    {
        doors = this.transform.parent.gameObject;
        anim = doors.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    { 
        if (col.gameObject.tag == "Player") {

            anim.SetBool("open", true);

        }


    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {

            anim.SetBool("open", false);

        }


    }

}
