using UnityEngine;

namespace Core
{
    public class Entity
    {
        public Entity(Attributes attribute, float weight)
        {
            this.attribute = attribute;
            this.weight = Mathf.Max(weight, 0.0f);
        }

        public Attributes attribute { get; private set; }
        public float weight { get; private set; }
    }
}