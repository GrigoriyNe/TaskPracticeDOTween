using DG.Tweening;
using UnityEngine.UI;

public class ChangeAddText : CommonChangerText
{
    protected override void ChangedText()
    {
        Text.DOText(AddedTest, Duration)
            .SetLoops(EndlessLoops, LoopType)
            .SetRelative();
    }
}
