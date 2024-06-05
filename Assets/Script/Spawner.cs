using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] protected List<Transform> prefabs;

    protected void Reset()
    {
        this.loadComponents();
    }

    protected void Awake()
    {
        //
    }
    protected virtual void loadComponents()
    {
        this.loadPrefabs();
    }
     
    protected virtual void loadPrefabs()
    {
        Transform prefabObj = transform.Find("Prefabs");
        foreach (Transform prefab in prefabObj)
        {
            this.prefabs.Add(prefab);
        }
        this.hidePrefabs();
    }

    protected virtual void hidePrefabs()
    {
        foreach(Transform prefab in this.prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }

}

