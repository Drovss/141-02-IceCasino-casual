using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _icePrefab;
    [SerializeField] private List<Vector2> _startPosition;
    [SerializeField] private Transform _groupTransform;


    public void CreatedIce()
    {
        for (int i = 0; i < _startPosition.Count; i++)
        {
            Instantiate(_icePrefab, _startPosition[i], Quaternion.identity, _groupTransform);
        }
    }
}
