using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject _prefabToCreate;
    [SerializeField] private ExampleMonobehaviorPooler _pooler;
    [SerializeField] private List<ExampleMonobehavior> _pooledObjects = new List<ExampleMonobehavior>();

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

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GetPooledObjects(2000);
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            SetOffPooledObjects(2000);
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

    private void GetPooledObjects(int numberOfInstances)
    {
        for (int i = 0; i < numberOfInstances; i++)
        {
            _pooledObjects.Add(_pooler.GetPooledObject());
        }
    }

    private void SetOffPooledObjects(int numberOfInstances)
    {
        for (int i = 0; i < numberOfInstances; i++)
        {
            _pooler.PushPooledInstance(_pooledObjects[0]);
            _pooledObjects.RemoveAt(0);
        }
    }
}
