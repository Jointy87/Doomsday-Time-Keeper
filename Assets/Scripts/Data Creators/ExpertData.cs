using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ExpertDataFile")]
public class ExpertData : ScriptableObject
{
	public string expertName;
	public Image expertImage;
	public int wakeTime;
	public int sleepTime;
	public ScriptableObject[] expertise;
}
