using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [SerializeField] float runSpeed = 5f;
    [SerializeField] Animator anim;

    Rigidbody2D myRigidbody;
    SpriteRenderer sr;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        sr= GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        FireWeapon();
        Animate();
        FlipSprite();
    }

    private bool FireWeapon()
    {
        return Input.GetKeyDown(KeyCode.Mouse0);
    }

    private void FlipSprite()
    {
        if (CrossPlatformInputManager.GetAxis("Horizontal") < 0)
        {
            sr.flipX = true;
        }
        else if (CrossPlatformInputManager.GetAxis("Horizontal") > 0)
        {
            sr.flipX = false;
        }
    }

    private bool Walk()
    {
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVelocity;

        return controlThrow != 0;
    }

    private void Animate()
    {
        anim.SetBool("IsMoving", Walk());
        anim.SetBool("IsShooting", FireWeapon());
    }
}
