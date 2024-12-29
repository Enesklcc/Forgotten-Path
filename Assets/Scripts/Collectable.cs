using UnityEngine;

public class Collectable : Targetable
{
    public virtual void Collect()
    {
        Destroy(this.gameObject);
    }
}
