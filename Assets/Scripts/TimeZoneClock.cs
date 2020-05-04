using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeZoneClock : MonoBehaviour
{
	//Config
	[Header("Time data")]
	[Tooltip("The amount of real life seconds that make an in-game day")] [SerializeField] float realSecPerDay = 30f;
	[Tooltip("Time the day ends in normalized value")] [SerializeField] float dayEnd;

	[Header("Elements")]
	[Tooltip("The clockhand that will turn as time passes")] [SerializeField] Image clockHand;
	[Tooltip("The area on the clock that indicates the expert's awake time")] [SerializeField] Image timeZoneIndicator;

	//Cache
	float day;
	float normalizedDay;
	float timeStart;
	bool isDaytime = false;
	void Start()
	{
		day = timeStart;
		timeZoneIndicator.GetComponent<Image>().fillAmount = dayEnd;
	}
	void Update()
	{
		TimePasses();
		CheckForDayOrNight();
	}

	private void TimePasses()
	{
		day += Time.deltaTime / realSecPerDay;
		normalizedDay = day % 1f;
		float rotationDegreesPerDay = 360f;
		clockHand.transform.eulerAngles = new Vector3(0, 0, -normalizedDay * rotationDegreesPerDay);
	}
	private void CheckForDayOrNight()
	{
		if (normalizedDay >= 0 && normalizedDay <= dayEnd)
		{
			isDaytime = true;
		}
		else
		{
			isDaytime = false;
		}
	}
	public void SetStartTime(float startTime)
	{
		timeStart = startTime;
	}
}
