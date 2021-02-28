using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainController : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("speed", move);
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * move * Time.deltaTime;
        transform.position = position;

        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("jump");
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 15f), ForceMode2D.Impulse);
        }
    }
}
