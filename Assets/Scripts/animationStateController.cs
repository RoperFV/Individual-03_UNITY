using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class animationStateController : MonoBehaviour
{
    Vector3 soldierPosition;
    Vector3 zombiePosition;

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
        // Makes the soldier character rotate to look at the object that is the zombie
        transform.LookAt(zombie);

        if(Vector3.Distance(soldierPosition, zombiePosition) < 1)
        {
            animator.SetBool("isClose2", true);

        }
        if (Vector3.Distance(soldierPosition, zombiePosition) > 1)
        {
            animator.SetBool("isClose2", false);
        }
    }

}
