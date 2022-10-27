using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ResponsiveSize : MonoBehaviour
{
    public bool w_check;
    public float width;
    public bool h_check;
    public float height;
    GameObject parent;
    RectTransform object_rect;
    RectTransform parent_rect;
    
    void Start()
    {
        parent = gameObject.transform.parent.gameObject;
        object_rect = this.gameObject.GetComponent<RectTransform>();
        parent_rect = parent.GetComponent<RectTransform>();
    }

    void Update()
    {
        if (w_check)
        {
            object_rect.sizeDelta = new Vector2(parent_rect.rect.width * width, object_rect.rect.height);
        }
        else
        {
            width = 0f;
        }

        if (h_check)
        {
            object_rect.sizeDelta = new Vector2(object_rect.rect.width, parent_rect.rect.height * height);
        }
        else
        {
            height = 0f;
        }
    }
}
