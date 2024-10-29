using DG.Tweening;
using UnityEngine.UI;

public class ChangeText : CommonChangerText
{
    protected override void ChangedText()
    {
        Text.DOText(ReplasedTest, Duration)
            .SetLoops(EndlessLoops, LoopType);
    }
}
