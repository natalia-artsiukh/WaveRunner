using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObstacle : MonoBehaviour
{
    private float _movingDuration = 2f;
    private float _currentTime;
    private Vector3 _startScale;
    private Vector3 _endScale;
    void Start()
    {
        _startScale = transform.localScale;
        _endScale = new Vector3(3, 3, 3);
    }
    
    void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _movingDuration) / _movingDuration;
        transform.localScale = Vector3.Lerp(_startScale, _endScale, progress);
    }
}
