using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Issue : MonoBehaviour
{
	//Config
	[SerializeField] Image[] issueCategorySlots;
	[SerializeField] Image[] options;

	//Cache
	int difficulty;
	GlobalIssuesCategories gic;

	void Start()
	{
		gic = FindObjectOfType<GlobalIssuesCategories>();
		
		difficulty = Random.Range(1, 4);
		print(difficulty);

		for(int diffRating = 0; diffRating < difficulty; diffRating++)
		{
			var issueCategory = gic.FetchGlobalIssueCategory(Random.Range(0, 6));
			print(issueCategory);

			Sprite issueImage = gic.FetchGlobalIssueImage(issueCategory);

			var thisIssue = issueCategorySlots[diffRating];
			thisIssue.gameObject.SetActive(true);
			thisIssue.GetComponent<Image>().sprite = issueImage;			
		}
	}


	void Update()
	{
		
	}
}
