using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardBDisplay : MonoBehaviour
{
    public CardB card;
	
	public GameObject CardType;
	//public GameObject Model;
	public Transform CardsParent;
	public Transform ModelsParent;
	public TMP_Text NameText;
	public TMP_Text PVText;
	public TMP_Text ATKText;
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
			child.gameObject.SetActive(false);
		}
		
		//------Prender objects y Asignar información------
		CardType.SetActive(true);
		NameText.text = card.name;
		PVText.text = card.PV;
		ATKText.text = card.ATK;
		DescriptionText.text = card.description;
		Instantiate(card.model, ModelsParent.position, ModelsParent.rotation);
		//Model.SetActive(true);
	}
}
