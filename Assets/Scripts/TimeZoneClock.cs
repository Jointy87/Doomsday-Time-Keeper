using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeZoneClock : MonoBehaviour
{
	//Config
	[Tooltip("The amount of real life seconds that make an in-game day")] [SerializeField] float realSecPerDay = 30f;
	[Tooltip("The clockhand that will turn as time passes")] [SerializeField] Image clockHand;
	[Tooltip("The area on the clock that indicates the expert's awake time")] [SerializeField] Image timeZoneIndicator;

	//Cache
	float day;
	float normalizedDay;
	float dayStart;
	float dayEnd;
	bool isDaytime = false;
	void Start()
	{
		
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

	public void SetDayTimes(float startTime, float endTime)
	{
		dayStart = startTime;
		dayEnd = endTime;
	}
	private void CheckForDayOrNight()
	{
		if (dayStart < dayEnd)
		{
			if (normalizedDay >= dayStart && normalizedDay <= dayEnd)
			{
				isDaytime = true;
			}
			else
			{
				isDaytime = false;
			}
		}
		else if (dayStart > dayEnd)
		{
			if (normalizedDay >= dayStart || normalizedDay <= dayEnd)
			{
				isDaytime = true;
			}
			else
			{
				isDaytime = false;
			}
		}
	}
}
