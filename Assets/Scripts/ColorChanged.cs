using DG.Tweening;
using UnityEngine;

public class ColorChanged : ChandgedItem
{
    [SerializeField] private SpriteRenderer _renderer;

    private void Start()
    {
        Color color = Random.ColorHSV();

        _renderer.DOFade(color.a, Duration);

        _renderer.DOColor(color, Duration)
            .SetLoops(EndlessLoops, LoopType);
    }
}
