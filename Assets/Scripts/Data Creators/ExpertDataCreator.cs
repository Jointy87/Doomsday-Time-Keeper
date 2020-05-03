using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ExpertDataFile")]
public class ExpertDataCreator : ScriptableObject
{
	[SerializeField] string expertName;
	[SerializeField] Image expertImage;
	[SerializeField] int wakeTime;
	[SerializeField] int sleepTime;
	[SerializeField] ScriptableObject[] expertise;
}
