using UnityEngine;
using UnityEngine.UI;

public abstract class CommonChangerText : ChandgedItem
{
    protected const string ReplasedTest = "This text replaced ";
    protected const string AddedTest = " - This text added ";
    protected const string HackTest = "This text hacked";

    [SerializeField] protected Text Text;

    private void Start()
    {
        ChangedText();
    }

    protected abstract void ChangedText();
}
