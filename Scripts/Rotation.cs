using UnityEngine;
using DG.Tweening;

public class Rotation : DOTweenHandler
{
    [SerializeField] private Vector3 _rotation;

    private void Start()
    {
        transform.DORotate(_rotation, Duration).SetLoops(Repeat, _loopType); 
    }
}
