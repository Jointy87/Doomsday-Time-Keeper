using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeZoneClock : MonoBehaviour
{
	//Config
	[SerializeField] float realSecPerDay = 30f;
	[SerializeField] Image clockHand;

	//Cache
	float day;
	void Update()
	{
		day += Time.deltaTime / realSecPerDay;
		float normalizedDay = day % 1f;
		float rotationDegreesPerDay = 360f;
		clockHand.transform.eulerAngles = new Vector3(0, 0, -normalizedDay * rotationDegreesPerDay);
	}
}
