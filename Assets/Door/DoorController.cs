using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator anim;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool("isOpening", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("isOpening", false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}