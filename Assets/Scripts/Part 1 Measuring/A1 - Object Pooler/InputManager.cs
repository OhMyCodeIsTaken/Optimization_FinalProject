using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _prefabsInstantiated;
    [SerializeField] private GameObject _prefabToCreate;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            InstantiatePrefabXTimes(2000);
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            DestroyPrefabXTimes(2000);
        }
    }

    private void InstantiatePrefabXTimes(int numberOfInstantiations)
    {
        for (int i = 0; i < numberOfInstantiations; i++)
        {
            Instantiate(_prefabToCreate, transform);
        }
    }

    private void DestroyPrefabXTimes(int numberOfDestroys)
    {
        for (int i = 0; i < numberOfDestroys; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
