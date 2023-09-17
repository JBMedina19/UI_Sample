using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SlidingUI : MonoBehaviour
{
    public RectTransform mainMenu, PlayMenu, signUpMenu,levelUpMenu;
    public float uiTransitionSpeed;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.DOAnchorPos(Vector2.zero,0);
    }

    // Update is called once per frame
 
    public void StartGameButton()
    {
        mainMenu.DOAnchorPos(new Vector2(-1100,0), uiTransitionSpeed).SetEase(Ease.Linear);
        PlayMenu.DOAnchorPos(Vector2.zero, uiTransitionSpeed).SetEase(Ease.Linear);
    }
    public void SignUpScreen()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(signUpMenu.DOAnchorPos(Vector2.zero,0));
        sequence.Append(signUpMenu.DOScale(Vector2.zero, 0));
        sequence.AppendInterval(.5f);
        sequence.Append(signUpMenu.DOScale(Vector2.one, .5f));
        
    }

    public void CloseSignUp()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(signUpMenu.DOScale(Vector2.zero,.5f));
        sequence.Append(signUpMenu.DOAnchorPos(new Vector2(-1100, 0), uiTransitionSpeed));
        sequence.Append(signUpMenu.DOScale(Vector2.one,0));

    }
}
