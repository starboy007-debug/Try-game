using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.Collections;
using UnityEngine;

public class Playerscipt : MonoBehaviour
{
    [Tooltip("this is a positive integer")]
    Rigidbody2D rb;
    public int Speedboost;
    public float jumpSpeed;
    public bool isGrounded;
    public Transform feet;
    public float boxWidth;
    public float boxHeight;
    public float delayForDoubleJump;
    public float feetRadius;
    public LayerMask whatIsGround;
    public Transform leftBulletSpwanpos, rightBulletSpwanpos;
    public GameObject leftBullet, rightBullet;

    Animator anim;
    SpriteRenderer sr;
    bool isJumping, canDoubleJump;
    bool rightPressed, leftPressed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //       isGrounded = Physics2D.OverlapCircle(feet.position, feetRadius, whatIsGround);
        isGrounded = Physics2D.OverlapBox(new Vector2(feet.position.x, feet.position.y), new Vector2(boxWidth, boxHeight), 360.0f, whatIsGround);
        float PlayerSpeed = Input.GetAxisRaw("Horizontal");
        PlayerSpeed *= Speedboost;
        if (PlayerSpeed != 0)
            MoveHorizontal(PlayerSpeed);
        else
            StopMoving();

        if (Input.GetButtonDown("Jump"))
            Jump();

        if (Input.GetButtonDown("Fire1"))
        {
           // camAnim.SetTrigger("Shake");
            FireBullets();
        }


        if (leftPressed)
            MoveHorizontal(-Speedboost);

        if (rightPressed)
            MoveHorizontal(Speedboost);

    }

    void OnDrawGizmos()
    {
        //     Gizmos.DrawWireSphere(feet.position,feetRadius);
        Gizmos.DrawWireCube(feet.position, new Vector3(boxWidth, boxHeight, 0));
    }
    void MoveHorizontal(float PlayerSpeed)
    {
        rb.velocity = new Vector2(PlayerSpeed, rb.velocity.y);
        if (PlayerSpeed < 0)
            sr.flipX = true;
        else if (PlayerSpeed > 0)
            sr.flipX = false;
        if (!isJumping)
            anim.SetInteger("List", 1);
    }

    void StopMoving()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
        if (!isJumping)
            anim.SetInteger("List", 0);
    }


    void Jump()
    {
        if (isGrounded)
        {
            isJumping = true;
            rb.AddForce(new Vector2(0, jumpSpeed));
            anim.SetInteger("List", 2);

            Invoke("EnableDoubleJump", delayForDoubleJump);

        }
        if (canDoubleJump && !isGrounded)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, jumpSpeed));
            anim.SetInteger("List", 2);

            canDoubleJump = false;
        }
    }

    void EnableDoubleJump()
    {
        canDoubleJump = true;
    }

    void FireBullets()
    {
        if (sr.flipX)
        {
            Instantiate(leftBullet, leftBulletSpwanpos.position, Quaternion.identity);
        }
        if (!sr.flipX)
        {
            Instantiate(rightBullet, rightBulletSpwanpos.position, Quaternion.identity);
        }
        audioctrl.instance.Shootbullet(gameObject.transform.position);
    }

    public void MobileMoveLeft()
    {
        leftPressed = true;
    }

    public void MobileMoveRight()
    {
        rightPressed = true;
    }

    public void MobileStop()
    {
        rightPressed = false;
        leftPressed = false;
        StopMoving();
    }

    public void MobileFire()
    {
        FireBullets();
    }

    public void MobileJump()
    {
        Jump();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

}
