using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Cards/Object")]
public class Card : ScriptableObject
{
	public GameObject cardType;
	public new string name;
	[TextArea]
	public string description;
	public GameObject model;


}
