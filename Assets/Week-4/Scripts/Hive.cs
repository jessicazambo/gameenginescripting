using NotTheBees;
using UnityEngine;

namespace NotTheBees
{
    public class Hive : MonoBehaviour
    {
        [SerializeField] float honeyProductionRate;
        [SerializeField] int startingNumberOfBees;
        [SerializeField] GameObject beePrefab;

        private int nectar;
        private int honey;

        private float time;

        void Start()
        {
            time = honeyProductionRate;
            System.Diagnostics.Debug.WriteLine("test");


            for (int i = 0; i < startingNumberOfBees; i++)
            {
                GameObject bee = Instantiate(beePrefab, transform.position, beePrefab.transform.rotation);
                bee.GetComponent<Bee>().Init(this);
            }
        }

        void Update()
        {
            if (HasNectar() == false) return;
            ProduceHoney();
        }

        public void GiveNectar()
        {
            nectar++;
        }

        public int CollectHoney()
        {
            int amt = honey;
            honey = 0;
            return amt;
        }

        bool HasNectar()
        {
            return nectar > 0;
        }

        void ProduceHoney()
        {
            if (time <= 0) return;
            time -= Time.deltaTime;

            if (time <= 0)
            {
                nectar--;
                honey++;
                time = honeyProductionRate;
            }
        }
    }
}