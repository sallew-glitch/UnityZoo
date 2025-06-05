using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceNPCManager : MonoBehaviour
{
    private Animator animator;

    public float lastDrinkTime;
    public float drinkCooldown = 4f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastDrinkTime + drinkCooldown + Random.Range(0, 3))
        {
            Drink();
            lastDrinkTime = Time.time;
        }
    }

    void Drink()
    {
        animator.SetTrigger("drink");
    }
}
