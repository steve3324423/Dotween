using UnityEngine;
using DG.Tweening;

public class Mover : DOTweenHandler
{
    [SerializeField] private Vector3 _movePosition;

    private void Start()
    {
        transform.DOMove(_movePosition, Duration).SetLoops(Repeat,_loopType);
    }
}
