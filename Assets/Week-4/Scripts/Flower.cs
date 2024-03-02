using UnityEngine;

namespace NotTheBees
{
    public class Flower : MonoBehaviour
    {
        [SerializeField] float nectarProductionRate;
        [SerializeField] Color colorReady;
        [SerializeField] Color colorNotReady;

        SpriteRenderer spriteRenderer;
        bool hasNectar = true;

        float time;

        void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            UpdateFlowerColor();
        }

        void Update()
        {
            ProduceNectar();
        }

        public bool HasNectar()
        {
            return hasNectar;
        }

        public void GetNectar()
        {
            if (!hasNectar)
            {
                hasNectar = false;
                spriteRenderer.color = colorNotReady;
                time = nectarProductionRate;
            }
        }

        void ProduceNectar()
        {
            if (hasNectar) return;

            if (time <= 0)
            {
                hasNectar = true;
                spriteRenderer.color = colorReady;
            }
            else
            {
                time -= Time.deltaTime;
            }
        }

        void UpdateFlowerColor()
        {
            spriteRenderer.color = hasNectar ? colorReady : colorNotReady;
        }
    }
}
