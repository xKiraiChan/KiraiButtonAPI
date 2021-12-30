# KiraiButtonAPI

**It is expected that you bundle a compiled binary over copy-pasting into your project**

If you copy-paste then have fun with an invalid language version and the code running worse due to duplication.

#

Any objects you create **will** be destroyed automatically when `Unload` is called, unless you pass `managed = false` 

Due to this, you should create all of your UI elements in `OnUILoad`

You can subscribe to `OnUIUnload` if you want to make your mod disable accordingly.

# Example Usage
```cs
KiraiMod.KiraiButtonAPI.Controller.OnUILoad += ui =>
{
    var group = ui.CreateGroup("KiraiMod");
    group.CreateButton("Button 1", () => MelonLogger.Msg("Button 1 Clicked"));
    group.CreateButton("Button 2", () => MelonLogger.Msg("Button 2 Clicked"));
    group.CreateButton("Button 3", () => MelonLogger.Msg("Button 3 Clicked"));
    group.CreateButton("Button 4", () => MelonLogger.Msg("Button 4 Clicked"));
};
```

# Features:
- [x] Auto disable the carosel banners
- [x] Unloading & Reloading
- [x] Groups
- [x] Buttons
- [ ] Pages
- [ ] Toggles 
- [ ] Sliders
