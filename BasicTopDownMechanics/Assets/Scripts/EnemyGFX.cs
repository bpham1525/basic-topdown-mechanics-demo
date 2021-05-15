using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;
    private bool facingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x < 0 && facingRight) {
            facingRight = false;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (aiPath.desiredVelocity.x > 0 && !facingRight) {
            facingRight = true;
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
