using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalIssuesCategories : MonoBehaviour
{
	//Config
	[SerializeField] Image climateIcon;
	[SerializeField] Image pandemicIcon;
	[SerializeField] Image etSecurityIcon;
	[SerializeField] Image nuclearThreatIcon;
	[SerializeField] Image globalSecurityIcon;
	[SerializeField] Image aiIcon;

	public enum GlobalIssues { climate, pandemic, etSecurity, nuclearThreat, globalSecurity, ai}

	Sprite issueImage;
	GlobalIssues chosenIssueCategory;

	public GlobalIssues FetchGlobalIssueCategory(int issue)
	{
		chosenIssueCategory = (GlobalIssues)issue;
		return chosenIssueCategory;
	}
	public Sprite FetchGlobalIssueImage(GlobalIssues issue)
	{

		if (issue == GlobalIssues.climate)
		{
			issueImage = climateIcon.GetComponent<Image>().sprite;
		}
		else if (issue == GlobalIssues.pandemic)
		{
			issueImage = pandemicIcon.GetComponent<Image>().sprite;
		}
		else if (issue == GlobalIssues.etSecurity)
		{
			issueImage = etSecurityIcon.GetComponent<Image>().sprite;
		}
		else if (issue == GlobalIssues.nuclearThreat)
		{
			issueImage = nuclearThreatIcon.GetComponent<Image>().sprite;
		}
		else if (issue == GlobalIssues.globalSecurity)
		{
			issueImage = globalSecurityIcon.GetComponent<Image>().sprite;
		}
		else if (issue == GlobalIssues.ai)
		{
			issueImage = aiIcon.GetComponent<Image>().sprite;
		}

		return issueImage;
	}
}
