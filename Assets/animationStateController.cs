using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class animationStateController : MonoBehaviour
{
    Animator animator;
    public GameObject soldier;
    public Transform zombie;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(zombie);
    }

    public void Orient()
    {

    }
}
