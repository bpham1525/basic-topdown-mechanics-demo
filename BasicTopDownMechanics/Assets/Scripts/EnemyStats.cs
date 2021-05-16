using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float health = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Kill() {
        Destroy(gameObject);
    }

    public void updateHealth(float amount) {
        health += amount;
        if (health <= 0.0f) {
            Kill();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        WeaponStats ws = col.gameObject.GetComponent<WeaponStats>();
        updateHealth(-1 * ws.damage);
        Debug.Log(this.name + ": Ow, my health is " + health.ToString() + ".");
    }
}
