using UnityEngine;

public class Key : Collectable
{
    public Door doorScript;
    public void Unlock()
    {
        doorScript.isLocked = false;
    }
    public override void Collect()
    {
        base.Collect();
        Key key = FindAnyObjectByType<Key>();
        if (key)
        {
            Unlock();
        }
        

    }
}
