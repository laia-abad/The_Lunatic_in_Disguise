using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentSimple : MonoBehaviour
{
    int collision; //1 -> NPC, 2 -> Object, 0 -> Nothing
    public bool Mov;
    public bool notesObertes;
    private Rigidbody2D rb;
    public Animator animator;
    public float velocity = 10;
    public GameObject[] limit;
    public AudioSource audio;

    public int level1;
    public int level2;
    public int level3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        setOrderRender();
        if (Mov && !notesObertes)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            SpriteRenderer spriteRobin = GetComponent<SpriteRenderer>(); //SpriteRenderer FlipX
            /*if (verticalInput > 0)
            {
                horizontalInput = verticalInput / 2;
            }
            if (verticalInput < 0)
            {
                horizontalInput = verticalInput / 2;
            }*/

            //if (verticalInput != 0) horizontalInput = verticalInput / 2;
            //spriteRobin.flipX = (horizontalInput > 0);

            if (horizontalInput < 0)
            {
                spriteRobin.flipX = false;
            }

            if (horizontalInput > 0)
            {
                spriteRobin.flipX = true;
            }

            rb.velocity = new Vector2(horizontalInput * velocity, verticalInput * velocity / 2); //mirar pujar diagonal

            animator.SetFloat("Speed", Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
            //Debug.Log("horiztonal = " + horizontalInput + ". Vertical = " + verticalInput);

        } else {
            if (Input.GetKey(KeyCode.F))
            {
                Mov = true;
                notesObertes = false;
            }
            rb.velocity = new Vector2(0, 0);
            animator.SetFloat("Speed", 0);
        }
    }

    public void setOrderRender()
    {
       if (this.transform.position.y > limit[0].transform.position.y)
        {
            this.GetComponent<SpriteRenderer>().sortingOrder = level1;
            
        }
       else if(this.transform.position.y > limit[1].transform.position.y)
        {
            this.GetComponent<SpriteRenderer>().sortingOrder = level2;
        }
        else if (this.transform.position.y > limit[2].transform.position.y)
        {
            this.GetComponent<SpriteRenderer>().sortingOrder = level3;
        }
        //Debug.Log("Ordre es= " + this.GetComponent<SpriteRenderer>().sortingOrder);
    }

    public void playEffect()
    {
        audio.Play();
    }
}
