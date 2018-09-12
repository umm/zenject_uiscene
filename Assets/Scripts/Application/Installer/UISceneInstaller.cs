using UnityEngine;
using Zenject;
using ZenjectModule.UIScene.Component;

namespace ZenjectModule.UIScene.Application.Installer
{
    public class UISceneInstaller : MonoInstaller<UISceneInstaller>
    {
        [SerializeField] private Camera uiCamera;
        private Camera UICamera => uiCamera;

        public override void InstallBindings()
        {
            Container.Bind<Camera>().WithId(Constant.InjectId.UICamera).FromInstance(UICamera).AsSingle();
            Container.Bind<UICameraCoordinator>().FromComponentsInHierarchy().AsTransient();
        }
    }
}