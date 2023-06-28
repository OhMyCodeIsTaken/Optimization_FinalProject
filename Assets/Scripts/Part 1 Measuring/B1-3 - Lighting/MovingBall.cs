using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBall : MonoBehaviour
{
    [SerializeField] private GameObject _targetCheckPoint;
    [SerializeField] private float _moveSpeed;

    private void Start()
    {
        _targetCheckPoint = CheckpointManager.Instance.GetRandomCheckPoint();
        _moveSpeed = new System.Random().Next(2, 7 + 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetCheckPoint.transform.position, _moveSpeed * Time.deltaTime);

        if((_targetCheckPoint.transform.position - transform.position).magnitude < 0.1)
        {
            transform.position = _targetCheckPoint.transform.position;
            _targetCheckPoint = CheckpointManager.Instance.GetRandomCheckPoint();
        }
    }
}
