using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IssueSpawner : MonoBehaviour
{
	//Config
	[SerializeField] Issue issuePrefab;
	[SerializeField] IssueSlot[] issueSlots;
	[SerializeField] float minInterval, maxInterval;
	[SerializeField] bool looping = true;

	//Cache
	bool isSlotOccupied;

	IEnumerator Start() // Start is now a coroutine.
	{
		do
		{
			yield return StartCoroutine(GenerateIssue());  //This starts given coroutine and also waits till it's done
		}
		while (looping);
	}

	private IEnumerator GenerateIssue()
	{
		List<IssueSlot> freeSlots = new List<IssueSlot>(); //Creates empty list

		foreach (IssueSlot issueSlot in issueSlots)
		{
			isSlotOccupied = issueSlot.FetchOccupationStatus(); //Checks occupation
			print(issueSlot + " occupation is " + isSlotOccupied);

			if (!isSlotOccupied)
			{
				freeSlots.Add(issueSlot); //Adds slot to list if free
				print(freeSlots.Count);
			}
		}

		if (freeSlots.Count > 0)
		{
			var slotToSpawnAt = freeSlots.Count - 1;
			print("free slot at coordinates " + freeSlots[slotToSpawnAt].transform.position);

			Canvas canvas = FindObjectOfType<Canvas>();
			Issue spawnedIssue = Instantiate(issuePrefab, freeSlots[slotToSpawnAt].transform.localPosition, Quaternion.identity);
			spawnedIssue.transform.SetParent(canvas.transform, false);
		}

		float intervalTime = Random.Range(minInterval, maxInterval);
		yield return new WaitForSeconds(intervalTime);
	}
}
