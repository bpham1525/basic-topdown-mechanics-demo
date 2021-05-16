using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGFX : MonoBehaviour
{
    public Camera cam;
    bool facingRight = true;
    Vector2 movement = new Vector2(0, 0);
    Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*movement.x = Input.GetAxisRaw("Horizontal");

        if (movement.x < 0 && facingRight)
        {
            facingRight = false;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (movement.x > 0 && !facingRight)
        {
            facingRight = true;
            transform.localScale = new Vector3(1, 1, 1);
        }*/

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        Vector2 lookDir = mousePos - (Vector2)transform.position;

        if (lookDir.x < 0 && facingRight)
        {
            facingRight = false;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (lookDir.x > 0 && !facingRight)
        {
            facingRight = true;
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
