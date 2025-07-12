using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MascotNPCManager : MonoBehaviour
{
    private Animator animator;

    public float lastWaveTime;
    public float waveCooldown = 12f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastWaveTime + waveCooldown + Random.Range(0, 3))
        {
            Wave();
            lastWaveTime = Time.time;
        }
    }

    void Wave()
    {
        animator.SetTrigger("wave");
    }
}
