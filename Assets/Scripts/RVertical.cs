using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RVertical : MonoBehaviour, IPointerEnterHandler , IPointerExitHandler
{
    public RectTransform Variable2;
    public bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        Variable2 = transform.Find("Contenedor").GetComponent<RectTransform>();
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Scale = Variable2.localScale;   //(1,1,1)
        Scale.y = Mathf.Lerp(Scale.y, isOpen ? 1 : 0, Time.deltaTime * 12);
        Variable2.localScale = Scale; //guarda nuevo valor
    }


    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        isOpen = true;
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        isOpen = false;
    }
}
