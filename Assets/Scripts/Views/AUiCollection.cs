using System.Collections.Generic;
using UnityEngine;

namespace Views
{
    public abstract class AUiCollection<TVIew>:MonoBehaviour where TVIew:MonoBehaviour
    {
        [SerializeField] protected Transform root;
        [SerializeField] protected TVIew prefab;
        private List<TVIew> itemCollection = new List<TVIew>();

        public TVIew Add()
        {
            var item = Instantiate(prefab, root);
            itemCollection.Add(item);
            return item;
        }

        public void Clear()
        {
            for (int i = 0; i < itemCollection.Count; i++)
            {
                Destroy(itemCollection[i].gameObject);
            }
            itemCollection.Clear();
        }
    }
}