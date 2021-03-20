using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour
{
    public void ETG()
    {
        Lean.Localization.LeanLocalization.CurrentLanguage = "Gujarati";
    }

    public void GTE()
    {
        Lean.Localization.LeanLocalization.CurrentLanguage = "English";
    }

    

}
