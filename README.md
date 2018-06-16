# Azurlane-scripts-autopatcher
A tool to automatically modify *Azurlane scripts* and generate several modified scripts, a.k.a *modded scripts* which can be used to play the game in *easier* and *illegal* way.

## Download
You can grab the binary from the [releases page](https://github.com/k0np4ku/Azurlane-scripts-autopatcher/releases), also take a look at [Azurlane-LuaHelper](https://github.com/k0np4ku/Azurlane-LuaHelper) if you want to do it **manually**.

## Requirements
1. Python 3.0 or newer
2. NET Framework 3.5 or newer

## Usage and Examples
Open `Azurlane.exe` and select *Azurlane AssetBundle* file named **scripts**, or by command `Azurlane.exe <path-to-scripts>`

You can obtain Azurlane AssetBundle file named scripts from:
- Japan: Android/data/com.YoStarJP.AzurLane/files/AssetBundles
- China (bilibili): Android/data/com.bilibili.azurlane/files/AssetBundles
- Korean: Android/data/com.txwy.and.blhx/files/AssetBundles

### Examples
```
$ azurlane scripts-jp
[+] Copying AssetBundle to temp workspace...<done>
[+] Decrypting and Unpacking AssetBundle...<done>
[+] Decrypting and Decompiling Lua...1/3...2/3...3/3...<done>
[+] Cloning Lua and AssetBundle...1/6...2/6...3/6...4/6...5/6...6/6...<done>
[+] Rewriting Lua...1/6...2/6...3/6...4/6...5/6...6/6...<done>
[+] Recompiling and Encypting Lua...1/6...2/6...3/6...4/6...5/6...6/6...<done>
[+] Repacking and Encrypting AssetBundle...1/6...2/6...3/6...4/6...5/6...6/6...<done>
[+] Copying all modified AssetBundle to original location...1/6...2/6...3/6...4/6...5/6...6/6...<done>
[+] Cleaning...

Everything is ok, we're done.
Press any key to exit.
```
