using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : Singleton<CheckpointManager>
{
    private System.Random _rand = new System.Random();
    private int _randomIndex;
    [SerializeField] private List<GameObject> _checkPoints = new List<GameObject>();

    public GameObject GetRandomCheckPoint()
    {
        _randomIndex = _rand.Next(0, _checkPoints.Count);
        return _checkPoints[_randomIndex];
    }
}
