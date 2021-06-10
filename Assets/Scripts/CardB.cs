using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Cards/Character")]
public class CardB : ScriptableObject
{
    public GameObject cardType;
	public new string name;
	public string PV;
	public string ATK;
	[TextArea]
	public string description;
	public GameObject model;
}
