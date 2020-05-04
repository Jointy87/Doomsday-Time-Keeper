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
	
	void Start()
	{
		SpawnExpertise();
	}


	void Update()
	{
		
	}

	private void SpawnExpertise()
	{
		var expertiseAmountToSpawn = expertDataFile.expertise.Length;

		for(int expertiseAmount = 0; expertiseAmount < expertiseAmountToSpawn; expertiseAmount++)
		{
			var thisExpertise = expertiseSlots[expertiseAmount];

			IssueCategoryData relevantExpertise = expertDataFile.expertise[expertiseAmount];	//THIS IS WHERE THE PROBLEM IS
			Sprite expertiseImage = relevantExpertise.categoryImage.sprite;			
		}
	}
}
