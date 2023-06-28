using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullManager : MonoBehaviour
{
    private GameObject[] _emptyArray;

    // Start is called before the first frame update
    void Start()
    {
        InitEmptyArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ArrayNullComparison();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ArrayNullReferenceEquals();
        }
    }

    private void InitEmptyArray()
    {
        _emptyArray = new GameObject[30000];

        for (int i = 0; i < _emptyArray.Length; i++)
        {
            _emptyArray[i] = null;
        }
    }

    private void ArrayNullComparison()
    {
        foreach (GameObject go in _emptyArray)
        {
            if (go != null)
            {
                Debug.Log("Found none-null element!");
            }
        }
    }

    private void ArrayNullReferenceEquals()
    {
        foreach (GameObject go in _emptyArray)
        {
            /* Strangely, this loop does occur 30k times, but the profiler
             * doesnt show 30k calls to ReferenceEquals(go, null). 
             * Uncommnet the below Debug.Log to see 30k calls indeed occur. */


            //Debug.Log("check 30k calls"); 
            if (!ReferenceEquals(go, null))
            {
                Debug.Log("Found none-null element!");
            }
        }
    }
}
