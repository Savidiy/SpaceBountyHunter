using UnityEngine;

namespace BountyHunter
{
    [CreateAssetMenu(fileName = "Settings", menuName = "StaticData/Create settings", order = 0)]
    public class Settings : ScriptableObject
    {
        public ShipHierarchy ShipPrefab;
    }
}