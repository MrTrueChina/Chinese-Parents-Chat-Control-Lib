# 中国式家长 对话控制前置 Mod

## 对于普通玩家：
这个 Mod 对于普通玩家只有一个功能，在它的配置中有一个“使用”旧版对话文本的选项，开启这个选项后将会使用旧版文本。  
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
