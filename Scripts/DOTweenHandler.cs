using DG.Tweening;
using UnityEngine;

public class DOTweenHandler : MonoBehaviour
{
    [SerializeField] protected float Duration = 2f;
    [SerializeField] protected int Repeat = -1;
    [SerializeField] protected LoopType _loopType = LoopType.Yoyo;
}
