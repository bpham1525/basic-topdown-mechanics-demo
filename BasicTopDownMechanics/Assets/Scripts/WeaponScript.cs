using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public Camera cam;
    public Animator foreground_anim;
    public Animator background_anim;
    public Collider2D hitbox;
    public ParticleSystem ParticleGFX;
    public ParticleSystem ParticleCollision;

    bool facingRight = true;

    Vector2 mousePos;
    bool fire;
    
    // Start is called before the first frame update
    void Start()
    {
        hitbox = this.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        // Detect if mouse 1 is being held (mouse 0 in Unity) and relay that to the animator
        fire = Input.GetButton("Fire1");
        if (foreground_anim) {
            foreground_anim.SetBool("Fire", fire);
        }
        if (background_anim) {
            background_anim.SetBool("Fire", fire);
        }

        // Rotate the weapon towards the mouse, flip depending if mouse is left or right of the character
        Vector2 lookDir = mousePos - (Vector2)transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        if (lookDir.x < 0 && facingRight)
        {
            facingRight = false;
            transform.localScale = new Vector3(-1, 1, 1);

            Vector3 current_pos = transform.localPosition;

            current_pos.x = current_pos.x * -1;
            transform.localPosition = current_pos;
        }
        else if (lookDir.x > 0 && !facingRight)
        {
            facingRight = true;
            transform.localScale = new Vector3(1, 1, 1);

            Vector3 current_pos = transform.localPosition;

            current_pos.x = current_pos.x * -1;
            transform.localPosition = current_pos;
        }

        if (!facingRight)
        {
            angle = angle - 180f;
        }

        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.rotation = rotation;
    }

    public void EnableHitBox()
    {
        hitbox.enabled = true;
    }

    public void DisableHitBox()
    {
        hitbox.enabled = false;
    }

    public void EnableParticles()
    {
        if (ParticleGFX) {
            ParticleGFX.Play();
        }
        if (ParticleCollision)
        {
            ParticleCollision.Play();
        }
    }

    public void DisableParticles()
    {
        if (ParticleGFX) {
            ParticleGFX.Stop();
        }
        if (ParticleCollision)
        {
            ParticleCollision.Stop();
        }
    }
}
