using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "IssueCategoryDataFile")]
[System.Serializable]
public class IssueCategoryDataCreator : ScriptableObject
{
    public string categoryName;
    public Image categoryImage;
}
