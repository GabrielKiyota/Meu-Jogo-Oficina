using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class porta : MonoBehaviour
{
    public string aCena;

    private void OnTriggerEnter2D(Collider2D chegada)
    {
        if (chegada.CompareTag("Personagem"))
        {
            SceneManager.LoadScene(aCena); // Carrega a nova cena
        }
    }
}

