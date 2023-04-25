using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{

    public Animator anim;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //pegando input do teclado
        
        
        //imprimindo valores no console
        //Debug.Log("Horizontal: " + x); 
        //Debug.Log("Vertical: " + y);

        
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0f);
        
        anim.SetFloat("Horizontal",movimento.x);
        anim.SetFloat("Vertical",movimento.y);
        anim.SetFloat("Speed",movimento.magnitude);

        transform.position = transform.position + movimento * Speed * Time.deltaTime;
    }
}