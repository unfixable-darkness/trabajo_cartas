using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void SyncCardToButton(Card cardinfo)
	{
		GameObject Manager = GameObject.Find("MANAGER");		
		var cardDisplay = Manager.GetComponent<CardDisplay>();
		cardDisplay.card = cardinfo;
		cardDisplay.LoadCardInfo();
	}
}
