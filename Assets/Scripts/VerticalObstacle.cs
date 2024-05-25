using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalObstacle : MonoBehaviour
{
    private float _movingDuration = 2f;
    private float _currentTime;
    private Vector3 _startPosition;
    private Vector3 _endPosition;

    private void Start()
    {
        var start = Random.Range(0f, 10f);
        _startPosition = new Vector3(transform.position.x, transform.position.y + start, transform.position.z);
        _endPosition = new Vector3(transform.position.x, transform.position.y + start + 5, transform.position.z);
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _movingDuration) / _movingDuration;
        transform.position = Vector3.Lerp(_startPosition, _endPosition, progress);
    }
}
