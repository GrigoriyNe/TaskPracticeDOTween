using DG.Tweening;
using UnityEngine;

public class Rotator : ChandgedItem
{
    [SerializeField] private float _valueRotation = 100;

    private void Start()
    {
        transform.DORotate(GetRandomRotation(), Duration)
            .SetLoops(EndlessLoops, LoopType);
    }

    private Vector3 GetRandomRotation()
    {
        Vector3 rotation = new Vector3(transform.rotation.x - _valueRotation,
            transform.rotation.y - _valueRotation,
            transform.rotation.z - _valueRotation
            );

        return rotation;
    }
}
