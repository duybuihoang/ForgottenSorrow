using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MinigamePotion", fileName = "Recipe")]
public class PotionSO : ScriptableObject
{
    [SerializeField] List<int> container;
    [SerializeField] List<int> correctRecipe;
    [SerializeField] int size;

    public List<int> getContainer()
    {
        return container;
    }    

    public List<int> getCorrectRecipe()
    {
        return correctRecipe;
    }

}
