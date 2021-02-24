using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController1 : MonoBehaviour
{
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
        transform.LookAt(soldier);
    }
}
