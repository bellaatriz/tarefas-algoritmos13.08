using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int velocidadeGiro = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<GameManager>().SubtrairMoedas(1);
            Destroy(gameObject);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * velocidadeGiro * Time.deltaTime);
    }
}
