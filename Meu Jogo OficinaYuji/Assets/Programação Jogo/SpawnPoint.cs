using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject personagem;

    void Start()
    {

        string portaEntrada = PlayerPrefs.GetString("portaEntrada");
        switch (portaEntrada)
        {
            case "Esquerda":
                GameObject spawnObject1 = GameObject.Find(portaEntrada);
                Vector3 spawnPosition1 = spawnObject1.transform.position;
                Instantiate(personagem, spawnPosition1, Quaternion.identity);
                break;
            case "Direita":
                GameObject spawnObject2 = GameObject.Find(portaEntrada);
                Vector3 spawnPosition2 = spawnObject2.transform.position;
                Instantiate(personagem, spawnPosition2, Quaternion.identity);
                break;
        }
        // Encontre o objeto que você quer destruir
        GameObject verificando = GameObject.Find("Personagem 1(Clone)");

// Verifique se ele existe na cena
        if (verificando != null)
        {
            GameObject destroi = GameObject.Find("Personagem 1");
            // Destrua outro objeto
            Destroy(destroi);
        }

        {
        
        }
        
    }
    void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}
