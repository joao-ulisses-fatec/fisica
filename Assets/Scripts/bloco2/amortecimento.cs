using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amortecimento : MonoBehaviour
{
    public Vector3 accelerationVector;
    public Vector3 relativeForceVector;
    public Vector3 velocityVector;
    public float constanteElastica;
    public float massa = 2;
    public float resistencia = 2;

    // Update is called once per frame
    void FixedUpdate()
    {
        Velocidade();
        Posicao();
    }

    void Forca()
    {
        relativeForceVector = (-constanteElastica * transform.position) + (-resistencia * velocityVector);
    }

    void Aceleracao()
    {
        Forca();
        accelerationVector = relativeForceVector / massa;
    }

    void Velocidade()
    {
        Aceleracao();
        velocityVector += accelerationVector * Time.deltaTime;
    }

    void Posicao()
    {

        transform.position += velocityVector * Time.deltaTime;

    }

}
