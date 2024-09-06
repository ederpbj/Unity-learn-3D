using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 25.0f;
    public float horizontalInput;
    public float forwardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Veículo movimenta para frente e trás
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Gira o carro para esquerda e direita (rotação no eixo Y)
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
}
