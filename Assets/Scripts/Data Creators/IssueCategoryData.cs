using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "IssueCategoryDataFile")]
public class IssueCategoryData : ScriptableObject
{
    public string categoryName;
    public Image categoryImage;
}
