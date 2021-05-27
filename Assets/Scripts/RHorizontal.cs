using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RHorizontal : MonoBehaviour , IPointerClickHandler
{
    public RectTransform Variable;
    public bool abierto;
    // Start is called before the first frame update
    void Start()
    {
        Variable = transform.Find("Contenedor").GetComponent<RectTransform>();
        abierto = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Escala = Variable.localScale;   //(1,1,1)
        Escala.x = Mathf.Lerp(Escala.x, abierto ? 1 : 0, Time.deltaTime * 12);
        Variable.localScale = Escala; //guarda nuevo valor
    }


    public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        abierto = !abierto;     //valor=opuesto
    }
}


/*
 * abierto ? 1:0...........
 * if(abierto==true)
 * {
 * abierto = 1;
 * }
 * else
 * {
 * abierto = 0;
 * }
 * 
 */