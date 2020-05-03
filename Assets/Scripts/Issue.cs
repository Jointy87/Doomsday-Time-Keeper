using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Issue : MonoBehaviour
{
	//Config

	[Header("Time per difficulty")]
	[Tooltip("Time in s to complete easy issue")] [SerializeField] float easyTimeAmount;
	[Tooltip("Time in s to complete medium issue")] [SerializeField] float mediumTimeAmount;
	[Tooltip("Time in s to complete hard issue")] [SerializeField] float hardTimeAmount;
	
	[Header("Element slots")]
	[Tooltip("The slots that will become the categories")] [SerializeField] GameObject[] issueCategorySlots;
	[Tooltip("The slots that will become the options")] [SerializeField] GameObject[] options;

	//Cache
	int difficulty;
	GlobalIssuesCategories gic;

	void Awake()
	{
		gic = FindObjectOfType<GlobalIssuesCategories>();
	}
	void Start()
	{
		difficulty = Random.Range(1, 4);

		SpawnCategories();
	}

	private void SpawnCategories()
	{
		for (int diffRating = 0; diffRating < difficulty; diffRating++)
		{
			var thisIssue = issueCategorySlots[diffRating];

			SelectCategory(thisIssue);

			thisIssue.gameObject.SetActive(true);
		}
	}

	private void SelectCategory(GameObject thisIssue)
	{
		var issueCategory = gic.FetchGlobalIssueCategory(Random.Range(0, 6));
		Sprite issueImage = gic.FetchGlobalIssueImage(issueCategory);
		thisIssue.GetComponent<Image>().sprite = issueImage;
	}
}
