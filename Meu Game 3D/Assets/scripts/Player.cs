using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public Rigidbody rb;
    public int forcaPulo = 10;
    public bool noChao = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message:"start");
        TryGetComponent(out rb);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Chão")
        {
            noChao = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message:"update");
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(x:h, 0, y);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Inpulse);
        }
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
