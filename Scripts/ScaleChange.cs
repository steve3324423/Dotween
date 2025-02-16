using DG.Tweening;
using UnityEngine;

public class ScaleChange : DOTweenHandler
{
    [SerializeField] private Vector3 _scale;

    private void Start()
    {
        transform.DOScale(_scale, Duration).SetLoops(Repeat, _loopType);
    }
}
