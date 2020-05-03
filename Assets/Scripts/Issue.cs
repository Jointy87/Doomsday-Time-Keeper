using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Issue : MonoBehaviour
{
	//Config
	[Header("Time")]
	[Tooltip("Time in s to complete easy issue")] [SerializeField] float easyTimeAmount;
	[Tooltip("Time in s to complete medium issue")] [SerializeField] float mediumTimeAmount;
	[Tooltip("Time in s to complete hard issue")] [SerializeField] float hardTimeAmount;
	[Tooltip("Timer visualization prefab")] [SerializeField] GameObject timerPrefab;

	[Header("Issue Categories")]
	[Tooltip("Array of issue category date files")] [SerializeField] IssueCategoryDataCreator[] categoryDataFiles;
	
	[Header("Element slots")]
	[Tooltip("The slots that will become the categories")] [SerializeField] GameObject[] issueCategorySlots;
	[Tooltip("The slots that will become the options")] [SerializeField] GameObject[] options;

	//Cache
	int difficulty;
	//GlobalIssuesCategories gic;
	float[] issueTimes;
	float issueTimeAmount;
	Image timerImage;
	float timeLeft;

	void Awake()
	{
		issueTimes = new float[] { easyTimeAmount, mediumTimeAmount, hardTimeAmount };
		//gic = FindObjectOfType<GlobalIssuesCategories>();
		timerImage = timerPrefab.GetComponent<Image>();

	}
	void Start()
	{
		difficulty = Random.Range(1, 4); //Decides the amount of categories

		SpawnCategories();
		SetTimer();
	}

	void Update()
	{
		TimerCountDown();
	}

	private void SpawnCategories()
	{
		for (int diffRating = 0; diffRating < difficulty; diffRating++) //For each of total categories...
		{
			var thisIssue = issueCategorySlots[diffRating];

			SelectCategory(thisIssue);
			SpawnCategory(thisIssue);
		}
	}

	private void SelectCategory(GameObject thisIssue)
	{
		var issueCategory = categoryDataFiles[Random.Range(0, 6)];
		Sprite categoryImage = issueCategory.categoryImage.sprite;
		thisIssue.GetComponent<Image>().sprite = categoryImage;
	}
	private void SpawnCategory(GameObject thisIssue)
	{
		thisIssue.gameObject.SetActive(true);
	}

	private void SetTimer()
	{
		issueTimeAmount = issueTimes[difficulty-1];
		timeLeft = issueTimeAmount;
	}

	private void TimerCountDown()
	{
		if(timeLeft > 0)
		{
			timeLeft -= Time.deltaTime;
			timerImage.fillAmount = timeLeft / issueTimeAmount;
		}
	}
}
