using DG.Tweening;
using UnityEngine.UI;

public class ChangeHackText : CommonChangerText
{
    protected override void ChangedText()
    {
        Text.DOText(HackTest, Duration, false, ScrambleMode.All)
            .SetLoops(EndlessLoops, LoopType);
    }
}
