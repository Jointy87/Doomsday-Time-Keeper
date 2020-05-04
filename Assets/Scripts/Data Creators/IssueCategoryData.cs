using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "IssueCategoryDataFile")]
public class IssueCategoryData : ScriptableObject
{
    [Tooltip("Name of issue category")] public string categoryName;
    [Tooltip("Icon of issue category")] public Image categoryImage;
}
