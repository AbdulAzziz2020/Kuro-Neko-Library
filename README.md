# KuroNeko.Library

A reusable Unity library containing common extensions, utilities, and design patterns for Unity projects.

## Features

- **Extensions** — Reusable extension methods for Unity and C# types.
- **Patterns** — Generic implementations of commonly used design patterns.
- **Utilities** — Shared helper classes and general-purpose functionality.
- **Modular Architecture** — Organized into clear, reusable modules.
- **Unity Package Manager** — Installable and manageable through UPM.

## Requirements

- Unity 6.0 or later
- Dependencies:
    - [UniTask](https://github.com/Cysharp/UniTask)
    - Unity Newtonsoft Json (`com.unity.nuget.newtonsoft-json`)

Dependencies are only required when using library features that depend on them.

## Installation

### Install via Git URL

1. Open **Window → Package Management → Package Manager**.
2. Click the `+` button.
3. Select **Install package from git URL...**.
4. Enter the repository URL:

   ```text
   https://github.com/AbdulAzziz2020/KuroNeko.Library.git
   ```

5. Click **Install**.

To install a specific release:

```text
https://github.com/AbdulAzziz2020/KuroNeko.Library.git#v0.0.1
```

### Install from Disk

1. Download or clone this repository.
2. Open the Unity Package Manager.
3. Select **Install package from disk...**.
4. Select the `package.json` file in the package root.

## Package Structure

```text
KuroNeko.Library/
├── package.json
├── README.md
├── CHANGELOG.md
└── Runtime/
    ├── KuroNeko.Library.asmdef
    ├── Extensions/
    ├── Patterns/
    └── Utilities/
```

### Modules

| Module | Description |
|---|---|
| `Extensions` | Extension methods for common types and Unity APIs. |
| `Patterns` | Reusable implementations of common design patterns. |
| `Utilities` | General-purpose helper classes and functionality. |

## Assembly Definition

The package provides the following assembly:

```text
KuroNeko.Library
```

To use the library from another assembly, add `KuroNeko.Library` to the **Assembly Definition References** of your `.asmdef` file.

## Usage

Import the namespace provided by the feature you want to use.

```csharp
using UnityEngine;

// Import the relevant KuroNeko.Library namespace here.
```

Refer to the source code and XML documentation for individual API usage.

## Dependencies

This package may use the following dependencies:

- [UniTask](https://github.com/Cysharp/UniTask) — Asynchronous programming utilities for Unity.
- [Unity Newtonsoft Json](https://docs.unity3d.com/Packages/com.unity.nuget.newtonsoft-json@latest) — JSON serialization and deserialization.

Dependency versions are defined in `package.json`. Features that do not use these dependencies may remain independent of them.

## Versioning

This package follows Semantic Versioning:

- **MAJOR** — Incompatible API changes.
- **MINOR** — Backward-compatible functionality additions.
- **PATCH** — Backward-compatible bug fixes.

See [CHANGELOG.md](CHANGELOG.md) for release history.

## Contributing

Contributions, suggestions, and bug reports are welcome.

Before submitting changes, ensure that the package compiles and existing functionality remains compatible.

## License

Specify the license for this package before distributing it publicly.

If you intend to publish this library, include a `LICENSE` file in the repository.

---

Developed for reusable and maintainable Unity projects.
