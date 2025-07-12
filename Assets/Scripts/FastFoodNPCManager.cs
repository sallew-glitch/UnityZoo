using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastFoodNPCManager : MonoBehaviour
{

    private Animator animator;

    public float lastNosePickTime;
    public float nosePickCooldown = 15f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastNosePickTime + nosePickCooldown + Random.Range(0,3))
        {
            NosePick();
            lastNosePickTime = Time.time;
        }
    }

    void NosePick()
    {
        animator.SetTrigger("pickNose");
    }
}
