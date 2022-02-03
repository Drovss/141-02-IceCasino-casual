using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IceMover : MonoBehaviour
{
    [SerializeField] private Transform _iceGroupTransform;
    [SerializeField] private float _timeMove;
    [SerializeField] private float _distanceMoveY;

    public UnityEvent MoveEvent;

    private void Start()
    {
        StartCoroutine(NextMove());
    }

    IEnumerator NextMove()
    {
        yield return new WaitForSeconds(_timeMove);

        Move();
        MoveEvent.Invoke();
        StartCoroutine(NextMove());
    }

    private void Move()
    {
        _iceGroupTransform.position = new Vector2(_iceGroupTransform.position.x, _iceGroupTransform.position.y + _distanceMoveY);
    }
}
