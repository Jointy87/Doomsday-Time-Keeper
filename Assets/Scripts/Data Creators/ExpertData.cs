using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ExpertDataFile")]
public class ExpertData : ScriptableObject
{
	[Tooltip("Name of the expert")] public string expertName;
	[Tooltip("Image of the expert")] public Image expertImage;
	[Tooltip("When does day start in normalized value")] public float dayStart;
	[Tooltip("When does day end in normalized value")] public float dayEnd;
	[Tooltip("Which expertises does the expert have")] public ScriptableObject[] expertise; //type is wrong, this is probably why I had difficulty calling on it in Expert.cs
}
