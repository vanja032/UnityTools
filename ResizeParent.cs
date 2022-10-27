using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ResizeParent : MonoBehaviour
{
    public bool w_check;
    public float width;
    public bool h_check;
    public float height;
    public float horizontal_padding;
    public float vertical_padding;
    public float fixed_amount;

    void Update()
    {
        Resize();
    }

    private void Resize()
    {
        int count = this.gameObject.transform.childCount;
        float max_width = 0;
        float max_height = 0;
        for (int i = 0; i < count; i++)
        {
            if (this.gameObject.transform.GetChild(i).GetComponent<RectTransform>().rect.width > max_width)
                max_width = this.gameObject.transform.GetChild(i).GetComponent<RectTransform>().rect.width;
            if (this.gameObject.transform.GetChild(i).GetComponent<RectTransform>().rect.height > max_height)
                max_height = this.gameObject.transform.GetChild(i).GetComponent<RectTransform>().rect.height;
        }
        float this_height = this.gameObject.GetComponent<RectTransform>().rect.height;
        if (w_check)
            this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(max_width * width + horizontal_padding * fixed_amount, this_height);
        float this_width = this.gameObject.GetComponent<RectTransform>().rect.width;
        if (h_check)
            this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(this_width, max_height * height + vertical_padding * fixed_amount);
    }
}
