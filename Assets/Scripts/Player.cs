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
        Animate();
        FlipSprite();
    }

    private void FlipSprite()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = true;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = false;
        }
    }

    void Walk()
    {
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVelocity;
    }

    private void Animate()
    {
        if (Input.GetAxis("Horizontal") != 0) 
        { 
            anim.SetBool("IsMoving", true); 
        }
        else
        {
            anim.SetBool("IsMoving", false);
        }
    }
}
