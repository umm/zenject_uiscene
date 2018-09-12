# Zenject UI Scene

## What

Provide general UI Scene for Zenject.

The scene provides Context of Zenject named `UI` act as parent.

If you want to create multiple scenes what contains `Canvas` component, can coordinate automatically RenderCamera to the `Camera` component included in `UI` scene.

## Requirement

* Zenject

## Install

```shell
yarn add "umm/zenject_uiscene#^1.0.0"
```

## Usage

* Append `UI` scene into `Scenes in Build` in Build Settings
    * You can find at `Assets/Modules/umm@zenject_uiscene/Scenes/UI.unity`
* Add `UICameraCoordinator` component into GameObject what attached `Canvas` component
* To load `UI` scene as multiple scenes
    * If you use [CAFU Scene](https://github.com/umm/cafu_scene), simply add `UI` as pre-load

## License

Copyright (c) 2018 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)
