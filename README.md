# 中国式家长 对话控制前置 Mod

## 对于普通玩家：
这个 Mod 对于普通玩家只有一个功能，在它的配置中有一个“使用旧版对话文本”的选项，开启这个选项后将会使用旧版文本。  
旧版文本非常老二次元，新版文本降低了二刺猿浓度。 

## 对于开发者：
这个 Mod 提供了修改和添加对话的功能和部分的对话数据，以下是简化版文档，编译后文件附带完整 XML 注释文件：
## namespace：MtC.Mod.ChineseParents.ChatControlLib
### Class：ChatControl
``` C#
public static List<int> ChatControl.AddChats(List<AddChatPrams> chatParams, int lovingEffect, int effect, int task);
添加一段对话。

public static void BeforeModifyChat(Func<ChatData, ChatData, ChatData> modify);
对所有对话进行修改，在针对性修改之前执行。

public static void RemoveBeforeModifyChat(Func<ChatData, ChatData, ChatData> modify);
取消指定的对所有对话进行修改的功能。

public static void ModifyChat(int chatId, Func<ChatData, ChatData, ChatData> modify);
对指定 ID 的对话进行针对性修改。

public static void RemoveModifyChat(int chatId, Func<ChatData, ChatData, ChatData> modify);
取消对指定的 ID 的对话进行指定的修改的功能。
```

### Class：ChatIds
这个类记录了部分对话的 ID。

### Class：CharacterData
这个类记录了部分对话中出现的人物的数据，包括 ID、名称、立绘。

### Class：BackgroundGraphs
这个类记录了部分可以用作对话背景的图片。

## 使用方式
**[点击此处前往 releases 页面查看这个 Mod 的版本和使用方式](https://github.com/MrTrueChina/Chinese-Parents-Chat-Control-Lib/releases)**  

**[点击此处前往中国式家长 Mod 导航库查看中国式家长所有 Mod 的使用方式](https://github.com/MrTrueChina/Chinese-Parents-Mods)**  
