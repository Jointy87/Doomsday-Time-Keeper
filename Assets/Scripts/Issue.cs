using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Issue : MonoBehaviour
{
	//Config
	[SerializeField] Image[] categories;
	[SerializeField] Image[] options;

	//Cache
	int difficulty;
	void Start()
	{
		difficulty = Random.Range(1, 4);
		print(difficulty);

		for(int diffRating = 0; diffRating < difficulty; diffRating++)
		{
			categories[diffRating].gameObject.SetActive(true);
		}
	}


	void Update()
	{
		
	}
}
