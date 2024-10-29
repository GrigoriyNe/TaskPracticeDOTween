using DG.Tweening;
using UnityEngine;

public class Scaler : ChandgedItem
{
    [SerializeField] private float _valueScale = 100;

    private void Start()
    {
        transform.DOScale (_valueScale, Duration)
        .SetLoops(EndlessLoops, LoopType);
    }
}
