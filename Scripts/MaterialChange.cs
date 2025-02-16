using UnityEngine;
using DG.Tweening;

public class MaterialChange : DOTweenHandler
{
    [SerializeField] private Material _material;

    private void Start()
    {
        _material.DOColor(Color.red,Duration).SetLoops(Repeat, _loopType);
    }
}
