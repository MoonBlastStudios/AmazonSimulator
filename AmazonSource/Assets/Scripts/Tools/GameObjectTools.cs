using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Tools
{
    public class GameObjectTools
    {
        public static List<GameObject> GetAllChildren(Transform p_parent)
        {
            return (from Transform child in p_parent select child.gameObject).ToList();
        }
    }
}
