using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovimentoPersonagem : MonoBehaviour
{
    public float speed;
    public Animator anim;
    public int vida = 3;



    void Update()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        anim.SetFloat("Horizontal", movimento.x);
        anim.SetFloat("Vertical", movimento.y);
        anim.SetFloat("Speed", movimento.magnitude);

        transform.position = (transform.position + movimento * speed * Time.deltaTime);
        if (vida == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D dano)
    {
        if (dano.gameObject.tag == "Inimigo")
        {
            vida = vida - 1;
        }

    }
}