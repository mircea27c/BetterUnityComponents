using UnityEngine;

public static class BetterTransform
{
    /// <summary>
    /// "Resets the local position, rotation and scale"
    /// </summary>
    /// <param name="trans">The affected Transform</param>
    public static void ResetLocal(this Transform trans) {
        trans.localPosition = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = Vector3.one;
    }

    /// <summary>
    /// "Resets the world position, rotation and scale"
    /// </summary>
    /// <param name="trans">The affected Transform</param>
    public static void ResetWorld(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.rotation = Quaternion.identity;
        trans.localScale = Vector3.one;
    }

    /// <summary>
    /// "Resets the local position and rotation"
    /// </summary>
    /// <param name="trans">The affected Transform</param>
    public static void ResetLocal_PosRot(this Transform trans)
    {
        trans.localPosition = Vector3.zero;
        trans.localRotation = Quaternion.identity;
    }

    /// <summary>
    /// "Resets the world position and rotation"
    /// </summary>
    /// <param name="trans">The affected Transform</param>
    public static void ResetWorld_PosRot(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.rotation = Quaternion.identity;
    }

    /// <summary>
    /// "Destroys all children of the Transform"
    /// </summary>
    /// <param name="trans">The affected Transform</param>
    public static void DestroyChildren(this Transform trans) {
        foreach (Transform child in trans)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    
}
