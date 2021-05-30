using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardBDisplay : MonoBehaviour
{
    public CardB cardB;
	
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
			//child.gameObject.SetActive(false);
			GameObject.Destroy(child.gameObject);
		}
		
		//------Prender objects y Asignar información------
		CardType.SetActive(true);
		NameText.text = cardB.name;
		PVText.text = cardB.PV;
		ATKText.text = cardB.ATK;
		DescriptionText.text = cardB.description;
		var NewModel = Instantiate(cardB.model, ModelsParent.position, ModelsParent.rotation);
		NewModel.transform.parent = ModelsParent.transform;
		//Instantiate(cardB.model, ModelsParent.position, ModelsParent.rotation);
		//Model.SetActive(true);
	}
}
