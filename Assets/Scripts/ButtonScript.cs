using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void SyncCardAToButton(Card cardinfo)
	{
		GameObject Manager = GameObject.Find("MANAGER");		
		var cardDisplay = Manager.GetComponent<CardDisplay>();
		cardDisplay.card = cardinfo;
		cardDisplay.LoadCardInfo();
	}
	
	public void SyncCardBToButton(CardB cardinfo)
	{
		GameObject Manager = GameObject.Find("MANAGER");		
		var cardDisplay = Manager.GetComponent<CardBDisplay>();
		cardDisplay.cardB = cardinfo;
		cardDisplay.LoadCardInfo();
	}
}
