using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    public Animator animator;
    public bool isOpen;
    public GameObject doorAxis;
    // Start is called before the first frame update
    void Start()
    {
        animator = doorAxis.GetComponent<Animator>();
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            animator.SetTrigger("Open");
            isOpen = true;
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (isOpen)
        {
            animator.SetTrigger("Close");
            isOpen = false; 
        }        
    }
}
