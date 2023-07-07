using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagManager : MonoBehaviour
{
    [SerializeField] private GameObject _taggedGOPrefab;
    private List<GameObject> _taggedPrefabsList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        InstantiateAMillionEmptyGameObjects();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ListTagComparisonOperator();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ListCompareTagFunction();
        }
    }

    private void InstantiateAMillionEmptyGameObjects()
    {
        for (int i = 0; i < 1000000; i++)
        {
            _taggedPrefabsList.Add(Instantiate(_taggedGOPrefab));
        }
    }

    private void ListTagComparisonOperator()
    {
        foreach (GameObject go in _taggedPrefabsList)
        {
            if (go.tag == "Test Tag")
            {
                // nothing
            }
        }
    }

    private void ListCompareTagFunction()
    {
        foreach (GameObject go in _taggedPrefabsList)
        {
            if (go.CompareTag("Test Tag"))
            {
                // Nothing
            }
        }
    }
}
