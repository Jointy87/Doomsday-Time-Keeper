using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Expert : MonoBehaviour
{
	//Config
	[Header("Expert Data")]
	[Tooltip("Expert data file")] [SerializeField] ExpertData expertDataFile;

	[Header("Element Slots")]
	[Tooltip("The slots that will become the expertise of expert")] [SerializeField] GameObject[] expertiseSlots;
	[Tooltip("Image of the expert")] [SerializeField] GameObject expertImage;
	[Tooltip("The clock prefab")] [SerializeField] TimeZoneClock clock;

	//Cache
	float dayStart;
	float dayEnd;
	void Awake()
	{
		SetExpertDayTime();
	}

	void Start()
	{
		FetchAndSpawnExpertises();
		SetExpertImage();
	}
	private void FetchAndSpawnExpertises()
	{
		var expertiseAmountToSpawn = expertDataFile.expertise.Length;

		for(int expertiseAmount = 0; expertiseAmount < expertiseAmountToSpawn; expertiseAmount++)
		{
			var thisExpertise = expertiseSlots[expertiseAmount];

			FetchExpertise(expertiseAmount, thisExpertise);
			SpawnExpertise(thisExpertise);
		}
	}
	private void FetchExpertise(int expertiseAmount, GameObject thisExpertise)
	{
		var relevantExpertise = expertDataFile.expertise[expertiseAmount] as IssueCategoryData; //Need to put the as here or else for some reason it wouldn't work
		Sprite expertiseImage = relevantExpertise.categoryImage.sprite;
		thisExpertise.GetComponent<Image>().sprite = expertiseImage;
	}
	private static void SpawnExpertise(GameObject thisExpertise)
	{
		thisExpertise.gameObject.SetActive(true);
	}
	private void SetExpertImage()
	{
		Sprite expertImageToSpawn = expertDataFile.expertImage.sprite;
		expertImage.GetComponent<Image>().sprite = expertImageToSpawn;
	}
	private void SetExpertDayTime()
	{
		dayStart = expertDataFile.dayStart;
		dayEnd = expertDataFile.dayEnd;
		clock.SetDayTimes(dayStart, dayEnd);
	}
}
