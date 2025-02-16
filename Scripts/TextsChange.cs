using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextsChange : DOTweenHandler
{
    [SerializeField] private float _delay = 4f;
    [SerializeField] private float _delaySecond = 6f;

    private Sequence _sequence = DOTween.Sequence();
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        _sequence.Append(_text.DOText("Hello", Duration).SetLoops(Repeat, _loopType))
            .Append(_text.DOText("Hello Freinds", Duration).SetRelative().SetDelay(_delay).SetLoops(Repeat, _loopType))
            .Append(_text.DOText("Loool", Duration, true, ScrambleMode.All).SetDelay(_delaySecond).SetLoops(Repeat, _loopType));
    }
}
