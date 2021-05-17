using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxHandler : MonoBehaviour
{
    WeaponScript ws;

    // Start is called before the first frame update
    void Start()
    {
        ws = transform.parent.GetComponent<WeaponScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableHitBox()
    {
        ws.EnableHitBox();
    }

    public void DisableHitBox()
    {
        ws.DisableHitBox();
    }

    public void EnableParticles()
    {
        ws.EnableParticles();
    }

    public void DisableParticles()
    {
        ws.DisableParticles();
    }
}
