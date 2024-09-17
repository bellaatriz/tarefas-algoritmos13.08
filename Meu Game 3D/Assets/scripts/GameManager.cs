using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, MsgVitoria;
    public int restantes; 

    public AudioClip Clipemoeda, clipvitoria;

    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<Moeda>().Length;

        hud.text = $"Moedas restantes:{restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"Moedas restantes:{restantes}";
        source.PlayOneShot(Clipemoeda);

        if (restantes <= 0)
        {
            MsgVitoria.text = "Parabéns!";
            source.Stop();
            source.PlayOneShot(clipvitoria);
        }
    }


}
