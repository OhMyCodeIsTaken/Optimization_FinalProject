using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateManager : MonoBehaviour
{
    [SerializeField] private GameObject _movingBallPrefab;
    [SerializeField] private GameObject _lightPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InstantiatePrefabXTimes(_movingBallPrefab, 1000);
        InstantiatePrefabXTimes(_lightPrefab, 200);
    }
    
    private void InstantiatePrefabXTimes(GameObject gameObjectToInstantiate, int numberOfInstantiations)
    {
        for (int i = 0; i < numberOfInstantiations; i++)
        {
            Instantiate(gameObjectToInstantiate);
        }
    }
}
