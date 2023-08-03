using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    public float speed;
    public float tempoAndando;
    private float tempo;
    public bool direcao ;
    public int vidaTotal = 30;
    private int vidaAtual;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        vidaAtual = vidaTotal;
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;

        if (tempo>= tempoAndando)
        {
            direcao = !direcao;
            tempo = 0f;
        }

        if (direcao == false)
        {
            transform.eulerAngles = new Vector2(0f,0f);
            rig.velocity = Vector2.left * speed;
        }
        else
        {
            rig.velocity = Vector2.right * speed;
            transform.eulerAngles = new Vector2(0f,180f);
        }
        
    }

    public void DanoTomado()
    {
        vidaAtual -= 10;
        if (vidaAtual <= 0)
        {
            Morte();
        }
    }

    private void Morte()
    {
        Destroy(gameObject);
    }
}