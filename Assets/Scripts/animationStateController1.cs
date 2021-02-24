using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController1 : MonoBehaviour
{
    Vector3 soldierPosition;
    Vector3 zombiePosition;

    Animator animator;
    public GameObject zombie;
    public Transform soldier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Makes the zombie character rotate to look at the object that is the soldier
        transform.LookAt(soldier);

        if (Vector3.Distance(soldierPosition, zombiePosition) < 1)
        {
            animator.SetBool("isClose", true);

        }
        if (Vector3.Distance(soldierPosition, zombiePosition) > 1)
        {
            animator.SetBool("isClose", false);
        }
    }
}
