using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porta : MonoBehaviour
{
    
    public string Cena;
    public string Saida;
    void OnTriggerEnter2D(Collider2D poita)
    {
        // Verifica se o objeto que colidiu é o jogador
        if (poita.CompareTag("Player"))
        {
            PlayerPrefs.SetString("portaEntrada", Saida);
            SceneManager.LoadScene(Cena);
        }
    }
    
}