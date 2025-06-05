using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerGirlNPCManager : MonoBehaviour
{
    private Animator animator;

    public float lastSelfieTime;
    public float selfieCooldown = 12f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastSelfieTime + selfieCooldown + Random.Range(0, 3))
        {
            Selfie();
            lastSelfieTime = Time.time;
        }
    }

    void Selfie()
    {
        animator.SetTrigger("selfie");
    }
}
