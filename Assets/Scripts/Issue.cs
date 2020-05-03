using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Issue : MonoBehaviour
{
	//Config
	
	[SerializeField] GameObject[] issueCategorySlots;
	[SerializeField] GameObject[] options;

	//Cache
	int difficulty;
	GlobalIssuesCategories gic;

	void Start()
	{
		gic = FindObjectOfType<GlobalIssuesCategories>();

		difficulty = Random.Range(1, 4);

		SelectAndSpawnIssueCategories();
	}

	private void SelectAndSpawnIssueCategories()
	{
		for (int diffRating = 0; diffRating < difficulty; diffRating++)
		{
			var thisIssue = issueCategorySlots[diffRating];
			thisIssue.gameObject.SetActive(true);

			var issueCategory = gic.FetchGlobalIssueCategory(Random.Range(0, 6));
			Sprite issueImage = gic.FetchGlobalIssueImage(issueCategory);
			thisIssue.GetComponent<Image>().sprite = issueImage;
		}
	}
}
