using UnityEngine;
using TMPro;

namespace SpaceShooter
{
    public class ScoreManager : MonoBehaviour
    {
        //TODO: Expose a TextMeshProUGUI variable that you can assign a label
        //      You need to create a Canvas for your label to live

        //TODO: Create a private static ScoreManager variable here called instance

        //TODO: Create a private non-static int variable here called score


        private void Awake()
        {
            //TODO: Call GetComponent and look for ScoreManager and assign the return value into instance

        }

        public static void IncrementScore()
        {
            //TODO: Reference instance and call privIncrementScore

        }

        private void privIncrementScore()
        {
            //TODO: increment the score variable by 1

            //TODO: update the text value of the label to show what the score it

        }
    }
}