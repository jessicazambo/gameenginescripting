using UnityEngine;
using UnityEngine.UI;

public class HanoiTower : MonoBehaviour
{
    [SerializeField] private Transform peg1Transform;
    [SerializeField] private Transform peg2Transform;
    [SerializeField] private Transform peg3Transform;

    [SerializeField] private int[] peg1 = { 1, 2, 3, 4 };
    [SerializeField] private int[] peg2 = { 0, 0, 0, 0 };
    [SerializeField] private int[] peg3 = { 0, 0, 0, 0 };

    [SerializeField] private int currentPeg = 1;

    [SerializeField] private Text winText;

    void Start()
    {
        winText.gameObject.SetActive(false);
    }

    public void MoveToNextPeg()
    {
        currentPeg = (currentPeg % 3) + 1;
    }

    public void MoveToPreviousPeg()
    {
        currentPeg = ((currentPeg - 2 + 3) % 3) + 1;
    }

    public void MoveDisksToNextPeg()
    {
        MoveToNextPeg();
        MoveRight();
    }

    public void MoveDisksToPreviousPeg()
    {
        MoveToPreviousPeg();
        MoveLeft();
    }

    public void MoveRight()
    {
        if (!CanMoveRight()) return;

        int[] fromArray = GetPeg(currentPeg);
        int fromIndex = GetTopNumberIndex(fromArray);

        if (fromIndex == -1) return;

        int[] toArray = GetPeg(currentPeg + 1);
        int toIndex = GetIndexOfFreeSlot(toArray);

        if (toIndex == -1) return;

        if (!CanAddToPeg(fromArray[fromIndex], toArray)) return;

        MoveNumber(fromArray, fromIndex, toArray, toIndex);

        Transform disc = PopDiscFromCurrentPeg();
        Transform toPeg = GetPegTransform(currentPeg + 1);

        disc.SetParent(toPeg);

        if (CheckWinCondition())
        {
            winText.gameObject.SetActive(true);
        }
    }

    public void MoveLeft()
    {
        if (!CanMoveLeft()) return;

        int[] fromArray = GetPeg(currentPeg);
        int fromIndex = GetTopNumberIndex(fromArray);

        if (fromIndex == -1) return;

        int[] toArray = GetPeg(currentPeg - 1);
        int toIndex = GetIndexOfFreeSlot(toArray);

        if (toIndex == -1) return;

        if (!CanAddToPeg(fromArray[fromIndex], toArray)) return;

        MoveNumber(fromArray, fromIndex, toArray, toIndex);

        Transform disc = PopDiscFromCurrentPeg();
        Transform toPeg = GetPegTransform(currentPeg - 1);

        disc.SetParent(toPeg);

        if (CheckWinCondition())
        {
            winText.gameObject.SetActive(true);
        }
    }

    bool CheckWinCondition()
    {
        return peg3[0] == 1 && peg3[1] == 2 && peg3[2] == 3 && peg3[3] == 4;
    }

    public void IncrementPegNumber()
    {
        currentPeg++;
    }

    public void DecrementPegNumber()
    {
        currentPeg--;
    }

    Transform PopDiscFromCurrentPeg()
    {
        Transform currentPegTransform = GetPegTransform(currentPeg);
        int index = currentPegTransform.childCount - 1;
        Transform disk = currentPegTransform.GetChild(index);
        return disk;
    }

    Transform GetPegTransform(int pegNumber)
    {
        if (pegNumber == 1) return peg1Transform;
        if (pegNumber == 2) return peg2Transform;
        return peg3Transform;
    }

    void MoveNumber(int[] fromArr, int fromIndex, int[] toArr, int toIndex)
    {
        int value = fromArr[fromIndex];
        fromArr[fromIndex] = 0;

        for (int i = toArr.Length - 1; i >= 0; i--)
        {
            if (toArr[i] == 0)
            {
                toArr[i] = value;
                break;
            }
        }
    }


    bool CanMoveRight()
    {
        return currentPeg < 3;
    }

    bool CanMoveLeft()
    {
        return currentPeg > 1;
    }

    bool CanAddToPeg(int value, int[] peg)
    {
        int topNumberIndex = GetTopNumberIndex(peg);
        if (topNumberIndex == -1) return true;
        int topNumber = peg[topNumberIndex];
        return topNumber > value;
    }


    int[] GetPeg(int pegNumber)
    {
        if (pegNumber == 1) return peg1;
        if (pegNumber == 2) return peg2;
        return peg3;
    }

    int GetTopNumberIndex(int[] peg)
    {
        for (int i = 0; i < peg.Length; i++)
        {
            if (peg[i] != 0) return i;
        }
        return -1;
    }

    int GetIndexOfFreeSlot(int[] peg)
    {
        for (int i = peg.Length - 1; i >= 0; i--)
        {
            if (peg[i] == 0) return i;
        }
        return -1;
    }

    public void PegLeft()
    {
        MoveToPreviousPeg();
    }

    public void PegRight()
    {
        MoveToNextPeg();
    }

}

