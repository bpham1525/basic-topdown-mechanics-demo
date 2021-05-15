using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public Camera cam;
    public Animator foreground_anim;
    public Animator background_anim;

    Vector2 mousePos;
    bool fire;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        fire = Input.GetButton("Fire1");
        foreground_anim.SetBool("Fire", fire);
        background_anim.SetBool("Fire", fire);
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - (Vector2) transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.rotation = rotation;
    }
}
