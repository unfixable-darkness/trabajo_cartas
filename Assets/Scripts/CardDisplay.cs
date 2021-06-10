using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;
	
	public GameObject CardType;
	//public GameObject Model;
	public Transform CardsParent;
	public Transform ModelsParent;
	public TMP_Text NameText;
	[TextArea]
	public TMP_Text DescriptionText;
	
	
    void Start()
    {
		LoadCardInfo();
    }
	
	public void LoadCardInfo()
	{
		//------Apagar los hijjos de Cartas y Modelos------
		foreach( Transform child in CardsParent)
		{
			child.gameObject.SetActive(false);
		}
		foreach( Transform child in ModelsParent)
		{
			//child.gameObject.SetActive(false);
			GameObject.Destroy(child.gameObject);
		}
		
		//------Prender objects y Asignar información------
		CardType.SetActive(true);
		NameText.text = card.name;
		DescriptionText.text = card.description;
		var NewModel = Instantiate(card.model, ModelsParent.position, ModelsParent.rotation);
		NewModel.transform.parent = ModelsParent.transform;
		//Model.SetActive(true);
	}
}
