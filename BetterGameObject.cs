using UnityEngine;

public static class BetterGameObject
{
    /// <summary>
    /// "Sets the tag of all children recursively. This method is slow, avoid using it often"
    /// </summary>
    /// <param name="go">"The affected GameObject"</param>
    /// <param name="tag">"Tag Name"</param>
    public static void SetTagAllChildren(this GameObject go, string _tag) {
        if (go == null) return;
        go.tag = _tag;
        if (go.transform.childCount > 0)
        {
            for (int i = 0; i < go.transform.childCount; i++)
            {
                go.transform.GetChild(i).gameObject.SetTagAllChildren(_tag);
            }
        }
    }

    /// <summary>
    /// "Sets the layer of all children recursively. This method is slow, avoid using it often"
    /// </summary>
    /// <param name="go">"The affected GameObject"</param>
    /// <param name="layer">"Layer Name"</param>
    public static void SetLayerAllChildren(this GameObject go, string _layer)
    {
        if (go == null) return;
        go.layer = LayerMask.NameToLayer(_layer);
        if (go.transform.childCount > 0)
        {
            for (int i = 0; i < go.transform.childCount; i++)
            {
                go.transform.GetChild(i).gameObject.SetLayerAllChildren(_layer);
            }
        }
    }

    /// <summary>
    /// "Sets the layer of all children recursively. This method is slow, avoid using it often"
    /// </summary>
    /// <param name="go">"The affected GameObject"</param>
    /// <param name="layer">"Layer"</param>
    public static void SetLayerAllChildren(this GameObject go, int _layer)
    {
        if (go == null) return;
        go.layer = _layer;
        if (go.transform.childCount > 0)
        {
            for (int i = 0; i < go.transform.childCount; i++)
            {
                go.transform.GetChild(i).gameObject.SetLayerAllChildren(_layer);
            }
        }
    }

}
