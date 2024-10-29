using DG.Tweening;
using UnityEngine;

public class Mover : ChandgedItem
{
    private float _minRandomValue  = -10;
    private float _maxRandomValue = 10;

    private void Start()
    {
        transform.DOMove(GetRandomPosition(), Duration)
            .SetLoops(EndlessLoops, LoopType);
    }

    private Vector3 GetRandomPosition()
    {
        float valueRandom = Random.Range(_minRandomValue, _maxRandomValue);

        return new Vector3(transform.position.x + valueRandom,
            transform.position.y + valueRandom,
            transform.position.z
            );
    }
}
