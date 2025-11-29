# NativeUICompat

NativeUICompat is an open-source compatibility library designed to bring a modern, minimal, and ScriptHookVDotNet 3-friendly menu framework for GTA V mod developers.

This framework is:

- ✔ Lightweight  
- ✔ Fully open-source  
- ✔ Optimized for SHVDN 3.7+  
- ✔ Compatible with GTA V (latest Steam/Epic/RGL versions)  
- ✔ Designed for beginners and advanced developers

This library is **not a drop-in replacement** for the old NativeUI — instead it provides a clean, modernized structure for building custom menu systems in GTA V scripts.

---

## Installation

Download the latest **NativeUICompat.dll** from the releases page and place it in:

Grand Theft Auto V/scripts/

Mods that use NativeUICompat should place it next to their main `.dll` script.

---

## 🔧 Development Usage

1. Reference `NativeUICompat.dll` inside your Visual Studio project.  
2. Use:

```csharp
using NativeUICompat;

3. Create a menu using:
var menu = new Core.Menu("Example Menu");
menu.AddItem(new Core.MenuItem("Button Example"));

4. Ensure your mod builds for: 
Platform: x64
.NET Framework: 4.8