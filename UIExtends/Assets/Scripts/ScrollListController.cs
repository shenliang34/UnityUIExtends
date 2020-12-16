using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[ExecuteInEditMode]
public class ScrollListController : UIBehaviour
{
    // Start is called before the first frame update
    override protected void Awake()
    {
        base.Awake();

        Debug.Log("Awake");
    }

    override protected void OnValidate()
    {
        base.OnValidate();

        Debug.Log("OnValidate");
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();

        Debug.Log("OnDestroy");
    }

    protected override void OnEnable()
    {
        base.OnEnable();

        Debug.Log("OnEnable");
    }

    protected override void OnDisable()
    {
        base.OnDisable();

        Debug.Log("OnDisable");
    }

    protected override void OnBeforeTransformParentChanged()
    {
        base.OnBeforeTransformParentChanged();

        Debug.Log("OnBeforeTransformParentChanged");
    }

    protected override void OnCanvasGroupChanged()
    {
        base.OnCanvasGroupChanged();

        Debug.Log("OnCanvasGroupChanged");
    }

    protected override void OnCanvasHierarchyChanged()
    {
        base.OnCanvasHierarchyChanged();

        Debug.Log("OnCanvasHierarchyChanged");
    }

    protected override void OnTransformParentChanged()
    {
        base.OnTransformParentChanged();

        Debug.Log("OnTransformParentChanged");
    }

    protected override void OnDidApplyAnimationProperties()
    {
        base.OnDidApplyAnimationProperties();

        Debug.Log("OnDidApplyAnimationProperties");
    }
    protected override void OnRectTransformDimensionsChange()
    {
        base.OnRectTransformDimensionsChange();

        Debug.Log("OnRectTransformDimensionsChange");
    }

    protected override void Reset()
    {
        base.Reset();

        Debug.Log("Reset");
    }
}
