using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats : MonoBehaviour
{
    public float damage = 34;
    public float aps = 1;
    public float cps = 1;
    public bool isAttack = true;

    public Animator foreground_anim;
    public Animator background_anim;

    float acps;

    // Start is called before the first frame update
    void Start()
    {
        if (isAttack)
        {
            acps = aps;
        }
        else
        {
            acps = cps;
        }

        if (foreground_anim) {
            foreground_anim.speed = acps;
        }
        if (background_anim)
        {
            background_anim.speed = acps;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
