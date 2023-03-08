using UnityEngine;

public static class BetterRigidBody
{
    /// <summary>
    /// "Locks the rigidbody in place"
    /// </summary>
    /// <param name="rb">affected RigidBody</param>
    public static void Lock(this Rigidbody rb) {
        rb.isKinematic = true;
        rb.useGravity = false;
    }

    /// <summary>
    /// "Unlocks the rigidbody"
    /// </summary>
    /// <param name="rb">affected RigidBody</param>
    public static void Unlock(this Rigidbody rb)
    {
        rb.isKinematic = false;
        rb.useGravity = true;
    }
}
