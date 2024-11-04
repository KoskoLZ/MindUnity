using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class SafeScript : MonoBehaviour
{
    public float[] fechaduras = new float[5];
    public bool[] fechadurasabertas = new bool[5];
    public RectTransform rectTransform;

    public float rotacaoZ;
    int fechaduraatual;
    public int quantFechaduras;

    public float velocidadeRotacao = 50f;

    void Update()
    {
        if (rectTransform != null)
        {
            // Obtém a rotação atual
            Vector3 rotacaoAtual = rectTransform.eulerAngles;

            // Ajusta a rotação no eixo Z com base na entrada do teclado
            if (Input.GetKey(KeyCode.D))
            {
                rotacaoAtual.z += velocidadeRotacao * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                rotacaoAtual.z -= velocidadeRotacao * Time.deltaTime;
            }

            // Aplica a nova rotação
            rectTransform.eulerAngles = rotacaoAtual;
        }
        else
        {
            Debug.LogError("RectTransform não atribuído.");
        }
        
        rotacaoZ = rectTransform.eulerAngles.z - 180;
        quantFechaduras = fechaduras.Length;
        if(margin(fechaduras[fechaduraatual] - 1, fechaduras[fechaduraatual] + 1, rotacaoZ))
        {
            fechadurasabertas[fechaduraatual] = true;

            if(fechadurasabertas[fechaduraatual])
            {
                fechaduraatual += 1;
                if(fechaduraatual == quantFechaduras)
                {
                for (int i = 0; i < quantFechaduras; i++)
                {
                    if(fechadurasabertas[i])
                    {
                         Debug.Log("TODAS ABERTAS");
                    }
                }
                }
            }

            
        }

        

    }

    bool margin( float min, float max, float n)
    {
	    return ( n>min && n< max);
    }

}

