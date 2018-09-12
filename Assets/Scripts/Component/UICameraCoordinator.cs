using System.Linq;
using UnityEngine;
using Zenject;
using ZenjectModule.UIScene.Application;

namespace ZenjectModule.UIScene.Component
{
    public class UICameraCoordinator : MonoBehaviour
    {
        [Inject(Id = Constant.InjectId.UICamera)]
        private Camera UICamera { get; }

        [SerializeField] private bool includeChildren;
        private bool IncludeChildren => includeChildren;

        private void Awake()
        {
            // Search Canvas components
            (IncludeChildren ? GetComponentsInChildren<Canvas>(true) : GetComponents<Canvas>())
                .ToList()
                .ForEach(x => x.worldCamera = UICamera);
            // Kill self
            Destroy(this);
        }
    }
}