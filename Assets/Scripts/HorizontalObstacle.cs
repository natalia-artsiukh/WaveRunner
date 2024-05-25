using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class HorizontalObstacle : MonoBehaviour
{

    private float _movingDuration = 2f;
    private float _currentTime;
    private Vector3 _startPosition;
    private Vector3 _endPosition;

    private void Start()
    {
        _startPosition = new Vector3(-3, transform.position.y, transform.position.z);
        _endPosition = new Vector3(3, transform.position.y, transform.position.z);
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _movingDuration) / _movingDuration;
        transform.position = Vector3.Lerp(_startPosition, _endPosition, progress);
    }
}
