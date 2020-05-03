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

	Image issueImage;
	GlobalIssues chosenIssueCategory;

	public GlobalIssues FetchGlobalIssueCategory(int issue)
	{
		chosenIssueCategory = (GlobalIssues)issue;
		return chosenIssueCategory;
	}
	public Image FetchGlobalIssueImage(GlobalIssues issue)
	{
		if (issue == GlobalIssues.climate)
		{
			issueImage = climateIcon;
		}
		else if (issue == GlobalIssues.pandemic)
		{
			issueImage = pandemicIcon;
		}
		else if (issue == GlobalIssues.etSecurity)
		{
			issueImage = etSecurityIcon;
		}
		else if (issue == GlobalIssues.nuclearThreat)
		{
			issueImage = nuclearThreatIcon;
		}
		else if (issue == GlobalIssues.globalSecurity)
		{
			issueImage = globalSecurityIcon;
		}
		else if (issue == GlobalIssues.ai)
		{
			Image issueImage = aiIcon;
		}

		return issueImage;
	}
}
