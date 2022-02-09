using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Sirenix.OdinInspector;
using TMPro;

public class tryingOut : MonoBehaviour
{
    [BoxGroup("Move setting")]
    [SerializeField]
    Transform target;

    [BoxGroup("Move setting")]
    [SerializeField]
    Ease ease = Ease.Linear;

    [BoxGroup("TMP")]
    [SerializeField]
    TMP_Text txt;

    private Sequence Sequence;

    // Start is called before the first frame update
    private void Start()
    {
        txt.DOText("My name is khan", 5).SetEase(Ease.InFlash);
    }

    [TabGroup("Buttons")]
    [Button(ButtonSizes.Small)]
    void moveAndScale()
    {
        Sequence = DOTween.Sequence().SetAutoKill(false);
        Sequence.Append(this.transform.DOMove(target.position, 1).SetEase(ease));
        Sequence.Append(this.transform.DOScale(Vector3.one * 2, 0.1F).SetEase(Ease.Flash));
        Sequence.Append(this.transform.DOScale(Vector3.one, 0.1F).SetEase(Ease.Flash));
    }

    [TabGroup("Buttons")]
    [Button(ButtonSizes.Small)]
    void Reset()
    {
        Sequence.Rewind();
    }
}
