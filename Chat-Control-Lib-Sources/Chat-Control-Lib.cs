using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using DG.Tweening;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using UnityModManagerNet;

namespace MtC.Mod.ChineseParents.ChatControlLib
{
    /// <summary>
    /// 记录对话 ID 的枚举
    /// </summary>
    public enum ChatId
    {
        ////----////----//// 流程剧情，这部分对话是随着回合增加自动出现的，而且与各项功能分离 ////----////----////
        
        /// <summary>
        /// 新一代开幕（你也有了自己的孩子）
        /// </summary>
        PLOT_NEW_ROUND_OPEN = 59001,
        /// <summary>
        /// 新一代开幕-上一代是女儿版结局，新一代开幕父母对话（我XX也有了娃）
        /// </summary>
        PLOT_NEW_ROUND_OPEN_MOTHER = 33001,
        /// <summary>
        /// 第二天出现的对脑洞的对话
        /// </summary>
        PLOT_NAODONG_INFO = 18001,
        /// <summary>
        /// 第三天出现的推荐点技能的对话
        /// </summary>
        PLOT_PROMOTE_STUDY_SKILL = 16001,
        /// <summary>
        /// 第四天出现的对悟性消耗量的解释对话
        /// </summary>
        PLOT_POTENTIAL = 17001,
        /// <summary>
        /// 面子事件第一次出现
        /// </summary>
        PLOT_FACING_VISIT = 15001,
        /// <summary>
        /// 索取功能开启对话
        /// </summary>
        PLOT_CLAIM = 19001,
        /// <summary>
        /// 重点小学达标期望出现对话
        /// </summary>
        PLOT_IMPORTANT_PRIMARY_SCHOOL = 11001,
        /// <summary>
        /// 继承父母性格对话
        /// </summary>
        PLOT_INHERIT_CHARACTER = 42001,
        /// <summary>
        /// 升小学对话
        /// </summary>
        PLOT_PRIMARY_SCHOOL = 51601,
        /// <summary>
        /// 开启商店对话
        /// </summary>
        PLOT_SHOP_OPEN = 20001,
        /// <summary>
        /// 第一次出现考试事件对话
        /// </summary>
        PLOT_EXAMINATION = 26001,
        /// <summary>
        /// 第一次出现做题而不是脑洞的对话
        /// </summary>
        PLOT_WTITE_EXAM = 27001,
        /// <summary>
        /// 重点初中达标期望出现对话
        /// </summary>
        PLOT_IMPORTANT_JUNIOR_MIDDLE_SCHOOL = 12001,
        /// <summary>
        /// 升初中的对话
        /// </summary>
        PLOT_JUNIOR_MIDDLE_SCHOOL = 51401,
        /// <summary>
        /// 社交按钮出现的对话
        /// </summary>
        PLOT_JUNIOR_LOVING_OPEN = 21001,
        /// <summary>
        /// 班主任：楼道里就听见你们吵
        /// </summary>
        PLOT_NOISY = 51101,
        /// <summary>
        /// 王胜男转学事件的对话
        /// </summary>
        PLOT_TRANSFER_WANGSHENGNAN = 53001,
        /// <summary>
        /// 李若放转学事件的对话
        /// </summary>
        PLOT_TRANSFER_LIRUOFANG = 53002,
        /// <summary>
        /// 汤金娜转学事件的对话
        /// </summary>
        PLOT_TRANSFER_TANGJINNA = 53003,
        /// <summary>
        /// 重点高中达标期望出现对话
        /// </summary>
        PLOT_IMPORTANT_HIGH_SCHOOL = 13001,
        /// <summary>
        /// 苏芳允转学事件的对话
        /// </summary>
        PLOT_TRANSFER_SUFANGYUN = 53004,
        /// <summary>
        /// 牧唯转学事件的对话
        /// </summary>
        PLOT_TRANSFER_MUWEI = 53005,


        ////----////----//// 满意和压力 ////----////----////

        /// <summary>
        /// 高满意度事件对话（我站在高高的沙发旁边）
        /// </summary>
        SATISFACTION_GOOD_8 = 508001,
        /// <summary>
        /// 高满意度事件对话（带你去吃好吃的）
        /// </summary>
        SATISFACTION_GOOD_9 = 509001,
        /// <summary>
        /// 高满意度事件对话（真不愧是我亲生的）
        /// </summary>
        SATISFACTION_GOOD_10 = 510001,
        
        /// <summary>
        /// 低压力事件对话
        /// </summary>
        PRESSURE_GOOD_2 = 512001,
        /// <summary>
        /// 低压力事件对话（内心平稳）
        /// </summary>
        PRESSURE_GOOD_3 = 513001,

        ////----////----//// 考试 ////----////----////

        /// <summary>
        /// 考试结果为优的对话
        /// </summary>
        EXAMINATION_EXCELLENT = 840004,

        ////----////----//// 抽奖 ////----////----////

        /// <summary>
        /// 抽奖-没中的对话
        /// </summary>
        LUCK_DRAW_0 = 80004,

        ////----////----//// 选秀 ////----////----////

        /// <summary>
        /// 选秀开场白
        /// </summary>
        DRAFT_OPEN = 600002,

        /// <summary>
        /// 选秀开赛，就是选秀选择特长后的对话
        /// </summary>
        DRAFT_BATTLE = 620000,

        ////----////----//// 挑战 ////----////----////

        /// <summary>
        /// 艾殷散（理科挑战）挑战信息
        /// </summary>
        CHALLENGE_AIYINSAN_INFO = 201000101,
        /// <summary>
        /// 李二（运动挑战）挑战信息
        /// </summary>
        CHALLENGE_LIER_INFO = 201000201,
        /// <summary>
        /// 肖芬琪（艺术挑战）挑战信息
        /// </summary>
        CHALLENGE_XIAOFENQI_INFO = 201000301,
        /// <summary>
        /// 聪聪（金钱挑战）挑战信息
        /// </summary>
        CHALLENGE_CONGCONG_INFO = 201000501,
        /// <summary>
        /// 宣洁衣（美貌挑战）挑战信息
        /// </summary>
        CHALLENGE_XUANJIEYI_INFO = 201000601,

        ////----////----//// 技能相关 ////----////----////

        ////----//// 学会技能后立刻出现的对话 ////----////

        //// 普通线 ////

        /// <summary>
        /// 学习-学会-普通-学会走路技能后的对话
        /// </summary>
        SKILL_STUDY_NORMAL_WALK = 80100041,
        /// <summary>
        /// 学习-学会-普通-学会跑步技能后的对话
        /// </summary>
        SKILL_STUDY_NORMAL_RUN = 80100051,

        //// 情绪线 ////

        /// <summary>
        /// 学习-学会-情绪-学会说话技能后的对话，可能是上一代是女儿才会出现的
        /// </summary>
        SKILL_STUDY_EMOTION_TALK_MOTHER = 80200011,
        /// <summary>
        /// 学习-学会-情绪-学会忍耐技能后的对话，可能是上一代是女儿才会出现的
        /// </summary>
        SKILL_STUDY_EMOTION_EXERCISE_PATIRNCE = 80200021,
        /// <summary>
        /// 学习-学会-情绪-学会延迟满足技能后的对话，可能是上一代是女儿才会出现的
        /// </summary>
        SKILL_STUDY_EMOTION_DELAYER_SATISFACTION = 80200031,

        //// 语文线 ////

        /// <summary>
        /// 学习-学会-语文-学会识字写字后的对话（永字八法）
        /// </summary>
        SKILL_STUDY_CHINESE_LITERACY_AND_WRITING = 80300021,
        /// <summary>
        /// 学习-学会-语文-学会语文作文后的对话
        /// </summary>
        SKILL_STUDY_CHINESE_CHINESE_COMPOSITION = 80300041,
        /// <summary>
        /// 学习-学会-语文-学会写小说后的对话
        /// </summary>
        SKILL_STUDY_CHINESE_NOVEL = 80300051,

        //// 数学线 ////

        /// <summary>
        /// 学习-学会-数学-学会四则运算后的对话
        /// </summary>
        SKILL_STUDY_MATH_FOUR_ARITHMETIC = 80400011,
        /// <summary>
        /// 学习-学会-数学-学会数学概率后的对话
        /// </summary>
        SKILL_STUDY_MATH_PROBABILITY = 80400041,

        //// 英语线 ////

        /// <summary>
        /// 学习-学会-英语-学会英语单词后的对话
        /// </summary>
        SKILL_STUDY_ENGLISH_ENGLISH_WORDS = 80500021,
        /// <summary>
        /// 学习-学会-英语-学会英语听力后的对话（东北大碴子味
        /// </summary>
        SKILL_STUDY_ENGLISH_ENGLISH_LISTENING = 80500051,

        //// 文综线 ////

        /// <summary>
        /// 学习-学会-文综-学会历史常识后的对话（五千年的风和雨，藏了多少梦）
        /// </summary>
        SKILL_STUDY_INTEGRATED_HISTORICAL_COMMON_SCESE = 80600031,
        /// <summary>
        /// 学习-学会-文综-学会世界地理后的对话
        /// </summary>
        SKILL_STUDY_INTEGRATED_WORLD_GEOGRAPHY = 80600071,
        /// <summary>
        /// 学习-学会-文综-学会经济常识后的对话（郁金香泡沫）
        /// </summary>
        SKILL_STUDY_INTEGRATED_ECONOMIC_KNOWLEDGE = 80600101,

        //// 理综线 ////

        /// <summary>
        /// 学习-学会-理综-学会物理常识后的对话
        /// </summary>
        SKILL_STUDY_SCIENCE_PHYSICS_KNOWLEDGE = 80700031,
        /// <summary>
        /// 学习-学会-理综-学会模型常识后的对话
        /// </summary>
        SKILL_STUDY_SCIENCE_MODEL_KNOWLEDGE = 80700051,
        /// <summary>
        /// 学习-学会-理综-学会初中生物后的对话（21世纪是____的世纪）
        /// </summary>
        SKILL_STUDY_SCIENCE_JUNIOR_MIDDLE_SCHOOL_BIOLOGY = 80700081,

        //// 体育线 ////

        /// <summary>
        /// 学习-事件-体育-学会体能训练技能后出现的事件的对话
        /// </summary>
        SKILL_STUDY_PE_PHYSICAL_TRAINING = 80800051,
        /// <summary>
        /// 学习-事件-体育-学会校队训练技能后出现的事件的对话
        /// </summary>
        SKILL_STUDY_PE_SCHOOL_TEAM_TRAINING = 80800061,
        /// <summary>
        /// 学习-事件-体育-学会中学篮球集训技能后出现的事件的对话
        /// </summary>
        SKILL_STUDY_PE_MIDDLE_SCHOOL_BASKETBALL_TRAINING = 80800071,
        /// <summary>
        /// 学习-事件-体育-学会美式特训技能后出现的事件的对话
        /// </summary>
        SKILL_STUDY_PE_AMERICAN_SPECIAL_TRAINING = 80800081,
        /// <summary>
        /// 学习-事件-体育-学会专业篮球特训技能后出现的事件的对话
        /// </summary>
        SKILL_STUDY_PE_PROFESSIONAL_BASKETBALL = 80800091,
        /// <summary>
        /// 学习-事件-体育-学会国青队集训技能后出现的事件的对话
        /// </summary>
        SKILL_STUDY_PE_NATIONAL_YOUTH_TEAM_TRAINING = 80800101,

        //// 艺术线 ////

        /// <summary>
        /// 学习-事件-艺术-学会色彩技能后出现的事件的对话
        /// </summary>
        SKILL_STUDY_ART_COLOR = 80900051,

        //// 编程线 ////

        /// <summary>
        /// 学习-学会-计算机-学会计算机入门后的对话
        /// </summary>
        SKILL_STUDY_COMPUTER_INTRODUCTION = 81200011,
        /// <summary>
        /// 学习-学会-计算机-学会超文本后的对话
        /// </summary>
        SKILL_STUDY_COMPUTER_HYPERTEXT = 81200021,

        //// 正义线 ////

        /// <summary>
        /// 学习-学会-正义-学会跆拳道后的对话
        /// </summary>
        SKILL_STUDY_JUSTICE_TAEKWONDO = 81100011,

        ////----//// 学会技能后出现的事件的对话 ////----////

        //// 体育线 ////

        /// <summary>
        /// 学习-事件-体育-学会体育课技能后出现的事件的对话
        /// </summary>
        SKILL_EVENT_PE_CLASS = 70100101,
        /// <summary>
        /// 学习-事件-体育-学会 50米跑 技能后出现的事件的对话
        /// </summary>
        SKILL_EVENT_PE_50M = 70100201,
        /// <summary>
        /// 学习-事件-体育-学会仰卧起坐技能后出现的事件的对话
        /// </summary>
        SKILL_EVENT_PE_ABDOMINAL_CURL = 70100301,
        /// <summary>
        /// 学习-事件-体育-学会仰卧起坐技能并且上一个事件出现过后出现的事件的对话
        /// </summary>
        SKILL_EVENT_PE_ABDOMINAL_CURL_2 = 70100311,
        /// <summary>
        /// 学习-事件-体育-学会投篮技能后出现的事件的对话
        /// </summary>
        SKILL_EVENT_PE_SHOOT = 70100401,
        /// <summary>
        /// 学习-事件-体育-学会投篮技能后出现的事件的对话
        /// </summary>
        SKILL_EVENT_PE_SHOOT_2 = 70100421,
        /// <summary>
        /// 学习-事件-体育-学会美式特训技能后出现的事件的对话
        /// </summary>
        SKILL_EVENT_PE_AMERICAN_SPECIAL_TRAINING = 70100501,

        //// 艺术线 ////

        /// <summary>
        /// 学习-事件-艺术-学会美术课技能后出现的事件的对话
        /// </summary>
        SKILL_EVENT_ART_CLASS = 70200101,
        /// <summary>
        /// 学习-事件-艺术-学会涂鸦技能后出现的事件的对话
        /// </summary>
        SKILL_EVENT_ART_GRAFFITI = 70200201,
        /// <summary>
        /// 学习-事件-艺术-学会艺术赏析技能后出现的事件的对话
        /// </summary>
        SKILL_EVENT_ART_APPRECIATION = 70200301,
        /// <summary>
        /// 学习-事件-艺术-学会素描技能后出现的事件的对话
        /// </summary>
        SKILL_EVENT_ART_SKETCH = 70200401,
        /// <summary>
        /// 学习-事件-艺术-学会色彩技能后出现的事件的对话
        /// </summary>
        SKILL_EVENT_ART_COLOR = 70200501,

        //// 编程线 ////

        /// <summary>
        /// 学习-事件-计算机-学会计算机入门后出现的事件的对话
        /// </summary>
        SKILL_EVENT_COMPUTER_INTRODUCTION = 70400101,
        /// <summary>
        /// 学习-事件-计算机-学会超文本后出现的事件的对话
        /// </summary>
        SKILL_EVENT_COMPUTER_HYPERTEXT = 70400201,

        //// 正义线 ////

        /// <summary>
        /// 学习-学会-正义-学会跆拳道后的对话
        /// </summary>
        SKILL_EVENT_JUSTICE_TAEKWONDO = 70300101,
        /// <summary>
        /// 学习-学会-正义-学会跆拳道后的第二个对话
        /// </summary>
        SKILL_EVENT_JUSTICE_TAEKWONDO_2 = 70300111,

        ////----////----//// 社交 ////----////----////

        /// <summary>
        /// 社交-旁白君-好感度增加
        /// </summary>
        LOVING_PANGBAI_GOOD = 8000001,

        /// <summary>
        /// 社交-警告-儿子版-几乎无警告（该找谁呢）
        /// </summary>
        LOVING_ALERT_SON_NONE = 715001,

        ////----//// 刘偏偏 ////----////

        /// <summary>
        /// 社交-刘偏偏-不符合对话条件
        /// </summary>
        LOVING_LIUPIANPIAN_CANT_TALK = 8200101,

        ////----//// 席梦来 ////----////

        /// <summary>
        /// 社交-席梦来-不符合对话条件
        /// </summary>
        LOVING_XIMENGLAI_CANT_TALK = 8200201,
        /// <summary>
        /// 社交-席梦来-开场白
        /// </summary>
        LOVING_XIMENGLAI_START_LOVING = 8100201,
        /// <summary>
        /// 社交-席梦来-好效果
        /// </summary>
        LOVING_XIMENGLAI_GOOD = 8300201,

        ////----//// 秦屿路 ////----////

        /// <summary>
        /// 社交-秦屿路-不符合对话条件
        /// </summary>
        LOVING_QINYULU_CANT_TALK = 8200501,

        ////----//// 章涵之 ////----////

        /// <summary>
        /// 社交-章涵之-不符合对话条件
        /// </summary>
        LOVING_ZHANGHANZHI_CANT_TALK = 8200601,

        ////----//// 王胜男 ////----////

        /// <summary>
        /// 社交-王胜男-不符合对话条件
        /// </summary>
        LOVING_WANGSHENGNAN_CANT_TALK = 8200301,

        ////----//// 李若放 ////----////

        /// <summary>
        /// 社交-李若放-不符合对话条件
        /// </summary>
        LOVING_LIRUOFANG_CANT_TALK = 8200401,

        ////----//// 汤金娜 ////----////

        /// <summary>
        /// 社交-汤金娜-不符合对话条件
        /// </summary>
        LOVING_TANGJINNA_CANT_TALK = 8200701,

        ////----//// 苏芳允 ////----////

        /// <summary>
        /// 社交-苏芳允-不符合对话条件
        /// </summary>
        LOVING_SUFANGYUN_CANT_TALK = 8200801,

        ////----//// 牧唯 ////----////

        /// <summary>
        /// 社交-牧唯-不符合对话条件
        /// </summary>
        LOVING_MUWEI_CANT_TALK = 8200901,

        ////----//// 闺蜜-萌萌 ////----////
        
        /// <summary>
        /// 闺蜜长时间不陪伴隐藏剧情
        /// </summary>
        LOVING_MENGMENG_NO_COMPANY = 8200101
    }

    /// <summary>
    /// 这个 Mod 的设置
    /// </summary>
    public class Settings : UnityModManager.ModSettings, IDrawable
    {

        [Draw("在游戏内显示发起对话方法被调用的提示 - Show Start Chat Method Run In Game")]
        public bool showStartChatTip = false;

        [Draw("输出发起对话方法被调用的 Log - Print Start Chat Method Run To Log")]
        public bool printStartChatLog = false;

        [Draw("输出对话数据的 Log - Print Chat Data To Log")]
        public bool printChatDataLog = false;

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            Save(this, modEntry);
        }

        public void OnChange()
        {
        }
    }

    public static class Main
    {
        /// <summary>
        /// Mod 对象
        /// </summary>
        public static UnityModManager.ModEntry ModEntry { get; set; }

        /// <summary>
        /// 这个 Mod 是否启动
        /// </summary>
        public static bool enabled;

        /// <summary>
        /// 这个 Mod 的设置
        /// </summary>
        public static Settings settings;

        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            // 读取设置
            settings = Settings.Load<Settings>(modEntry);

            // 保存 Mod 对象并绑定事件
            ModEntry = modEntry;
            ModEntry.OnToggle = OnToggle;
            ModEntry.OnGUI = OnGUI;
            ModEntry.OnSaveGUI = OnSaveGUI;

            // 加载 Harmony
            var harmony = new Harmony(modEntry.Info.Id);
            harmony.PatchAll();

            modEntry.Logger.Log("对话控制前置 Mod 加载完成");

            // 返回加载成功
            return true;
        }

        /// <summary>
        /// Mod Manager 对 Mod 进行控制的时候会调用这个方法
        /// </summary>
        /// <param name="modEntry"></param>
        /// <param name="value">这个 Mod 是否激活</param>
        /// <returns></returns>
        static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            // 将 Mod Manager 切换的状态保存下来
            enabled = value;

            // 返回 true 表示这个 Mod 切换到 Mod Manager 切换的状态，返回 false 表示 Mod 依然保持原来的状态
            return true;
        }

        static void OnGUI(UnityModManager.ModEntry modEntry)
        {
            settings.Draw(modEntry);
        }

        static void OnSaveGUI(UnityModManager.ModEntry modEntry)
        {
            settings.Save(modEntry);
        }
    }

    ////////--------////////--------//////// 辅助测试功能 ////////--------////////--------////////

    /// <summary>
    /// 发起对话方法
    /// </summary>
    [HarmonyPatch(typeof(chat_manager), "start_chat")]
    public static class record_manager_saverecord
    {
        private static void Prefix(chat_manager __instance, int id)
        {
            // 如果 Mod 未启动则直接按照游戏原本的逻辑进行调用
            if (!Main.enabled)
            {
                return;
            }

            // 在需要的情况下显示发起对话方法调用提示
            if (Main.settings.showStartChatTip)
            {
                TipsManager.instance.AddTips("ID 为 " + id + " 的对话即将开始", 1);
            }

            // 在需要的情况下将发起对话方法调用输出到 Log
            if (Main.settings.printStartChatLog)
            {
                Main.ModEntry.Logger.Log("ID 为 " + id + " 的对话即将开始");
            }

            // 在需要的情况下将对话数据输出到 Log
            if (Main.settings.printChatDataLog)
            {
                PrintChatData(id);
            }
        }

        /// <summary>
        /// 输出对话数据的方法，用于辅助测试
        /// </summary>
        /// <param name="id"></param>
        private static void PrintChatData(int id)
        {
            Main.ModEntry.Logger.Log("输出对话数据：id = " + id);

            if (!ReadXml.HaveData("chat", id))
            {
                Main.ModEntry.Logger.Log("没有 id " + id + " 的对话数据");
                return;
            }

            XmlData data = ReadXml.GetData("chat", id);

            foreach (KeyValuePair<string, string> pair in data.value)
            {
                Main.ModEntry.Logger.Log("输出对话数据：id = " + id + ", key = " + pair.Key + ", value = " + pair.Value);
            }
        }

        // 以下是对原代码的提取和注释，留作参考
        //private static bool Prefix(chat_manager __instance, ref GameObject ___PanelGameObject, ref bool ___changedBGM, ref List<string> ___chatPlayerList, ref List<string>[] ___chatPlayerLists, ref List<string>[] ___chatDaughterLists, ref int ___effectId, ref int ___nextId, ref int ___curId, int id, int next, int next2, begintalkoverAction completeAction, string newtext, Transform parentTransform, string param, bool moreText, bool isAnniversary)
        //{
        //    // 如果 Mod 未启动则直接按照游戏原本的逻辑进行调用
        //    if (!Main.enabled)
        //    {
        //        return true;
        //    }

        //    PrintChatData(id);

        //    // 不是目标
        //    if (id != 8200801 && id != 8200901)
        //    {
        //        return true;
        //    }

        //    Main.ModEntry.Logger.Log("发现目标，进行 ID = " + id + " 的对话");

        //    // 疑似是试玩版的面子对决特殊处理，15001 是第一次出现面子对决事件，201000001 是第一次出现面子挑战事件
        //    if (DEF.isApproval && (id == 15001 || id == 201000001))
        //    {
        //        begintalkoverAction begintalkoverAction = completeAction;
        //        if (begintalkoverAction != null)
        //        {
        //            begintalkoverAction();
        //        }
        //        return false;
        //    }

        //    // 疑似是对开发者的特殊处理，开发者应该可以在另一个位置看对话
        //    Transform transform;
        //    if (DEF.IsDevelopment)
        //    {
        //        transform = UIManager.instance.Canvas_transform;
        //        ___PanelGameObject = (Resources.Load("UIpanel/Panel_chat") as GameObject);
        //    }
        //    else
        //    {
        //        transform = __instance.transform;
        //        if (__instance.transform == null)
        //        {
        //            transform = UIManager.instance.Canvas_transform;
        //            Debug.Log("transform" + __instance.transform);
        //        }
        //    }

        //    // aGameObject 目前看来是对话的根物体，之后的大量操作都是从这个 aGameObject 向下搜索进行
        //    GameObject aGameObject = UnityEngine.Object.Instantiate<GameObject>(___PanelGameObject, transform.position, Quaternion.identity, transform);
        //    // 禁用了 "next" 物体，这个物体从名字看应该就是进入下一段对话的功能的物体，但是考虑到对话是按空格或左键都可以向后，这个物体可能并不是按钮
        //    aGameObject.transform.Find("next").gameObject.SetActive(false);

        //    // 获取对话数据
        //    XmlData data = ReadXml.GetData("chat", id);

        //    // 与周年纪念日有关，但不确定是什么事件，isAnniversary 翻译过来是“是周年纪念日”，不同于常见的对话 id 和 type 相同，没有 id 7000000 的对话
        //    if (data.GetInt("type") == 7000000 && !isAnniversary)
        //    {
        //        // XXX：此处不知道对不对
        //        MethodInfo anniversaryTipMethod = typeof(chat_manager).GetMethod("AnniversaryTip", BindingFlags.NonPublic | BindingFlags.Instance);
        //        completeAction = (begintalkoverAction)Delegate.CreateDelegate(typeof(chat_manager), anniversaryTipMethod);
        //    }

        //    // 周年剧情的特殊处理，7001003 是周年剧情
        //    if (id == 7001003)
        //    {
        //        ___changedBGM = true;
        //        audio_manager.InstanceAudioManager.PlayBGM("brithday", false);
        //    }

        //    // 获取人物图片信息
        //    string @string = data.GetString("image", true);

        //    // 疑似是恋爱对话好结果的处理，代码是创建了一个好结果的物体，然后延迟删除
        //    if (data.GetString("loving_effect") == "1")
        //    {
        //        GameObject obj = UnityEngine.Object.Instantiate<GameObject>(__instance.LovinggoodGameObject, aGameObject.gameObject.transform.position, Quaternion.identity, aGameObject.gameObject.transform);
        //        UnityEngine.Object.Destroy(obj, 1f);
        //    }

        //    // 疑似是恋爱对话坏结果的处理，代码是创建了一个坏结果的物体，然后延迟删除
        //    if (data.GetString("loving_effect") == "2")
        //    {
        //        GameObject obj2 = UnityEngine.Object.Instantiate<GameObject>(__instance.LovingbadGameObject, aGameObject.gameObject.transform.position, Quaternion.identity, aGameObject.gameObject.transform);
        //        UnityEngine.Object.Destroy(obj2, 1f);
        //    }

        //    // 如果没人物图片，禁用掉人物图片物体
        //    if (@string == "0")
        //    {
        //        aGameObject.transform.Find("Image").gameObject.transform.GetComponent<Image>().sprite = null;
        //        aGameObject.transform.Find("Image").gameObject.SetActive(false);
        //    }

        //    // 开始创建人物图片
        //    Sprite sprite = new Sprite();
        //    Vector2 anchoredPosition = default(Vector2);

        //    // 获取玩家名称
        //    string text = data.GetStringLanguage("player", true);
        //    Main.ModEntry.Logger.Log("第一次获取名称文本 = " + text);

        //    if (@string.Contains("son") || @string.Contains("daughter"))
        //    {
        //        // 无从解释，怀疑是跟玩家图片有关的
        //        Main.ModEntry.Logger.Log("疑似和玩家图片有关的 if 调用，对话 id = " + id);
        //        TipsManager.instance.AddTips("疑似和玩家图片有关的 if 调用，对话 id = " + id, 1);

        //        for (int i = 0; i < player_data.GrowSort.Length - 1; i++)
        //        {
        //            if (player_data.Instance.Round_current >= player_data.GrowRounds[player_data.GrowSort[i]] && player_data.Instance.Round_current < player_data.GrowRounds[player_data.GrowSort[i + 1]])
        //            {
        //                string text2 = (!@string.Contains("son")) ? "daughter" : "son";
        //                int index = ___chatPlayerList.IndexOf(@string.Replace(text2, "player"));
        //                string str = (!@string.Contains("son")) ? ___chatDaughterLists[i][index].Replace("player", text2) : ___chatPlayerLists[i][index].Replace("player", text2);
        //                sprite = (Resources.Load("UI/Main_ui/chat/" + str, typeof(Sprite)) as Sprite);
        //                break;
        //            }
        //        }
        //        if (DEF.IsDevelopment)
        //        {
        //            string str2 = (!@string.Contains("son")) ? @string.Insert(@string.LastIndexOf("daughter") + 8, "16") : @string.Insert(@string.LastIndexOf("son") + 3, "16");
        //            sprite = (Resources.Load("UI/Main_ui/chat/" + str2, typeof(Sprite)) as Sprite);
        //        }
        //        anchoredPosition = new Vector2(663f, -540f);
        //    }
        //    else
        //    {
        //        string text3 = "UI/Main_ui/chat/" + @string;
        //        if (@string.Contains("mom"))
        //        {
        //            Main.ModEntry.Logger.Log("疑似和母亲有关的 if 调用，对话 id = " + id);
        //            TipsManager.instance.AddTips("疑似和母亲有关的 if 调用，对话 id = " + id, 1);

        //            if (!record_manager.InstanceManagerRecord.IsFather())
        //            {
        //                text3 += "_girl";
        //            }
        //            else
        //            {
        //                text3 = text3 + "_" + record_manager.InstanceManagerRecord.CurrentRecord.mother_id;
        //            }
        //        }
        //        else if (@string.Contains("father"))
        //        {
        //            Main.ModEntry.Logger.Log("疑似和父亲有关的 if 调用，对话 id = " + id);
        //            TipsManager.instance.AddTips("疑似和父亲有关的 if 调用，对话 id = " + id, 1);

        //            if (record_manager.InstanceManagerRecord.CurrentRecord.father_name != string.Empty && player_data.Instance.Generations != 1)
        //            {
        //                text3 += "_boy";
        //            }
        //            else
        //            {
        //                text3 = text3 + "_" + record_manager.InstanceManagerRecord.CurrentRecord.father_id;
        //            }
        //        }
        //        else if (@string.Contains("boy") && BoysManager.Instance.curInviteBoyId != 0)
        //        {
        //            Main.ModEntry.Logger.Log("疑似和男生有关的 if 调用，对话 id = " + id);
        //            TipsManager.instance.AddTips("疑似和男生有关的 if 调用，对话 id = " + id, 1);

        //            text3 = text3 + "_" + BoysManager.Instance.curInviteBoyId;
        //            text = BoysManager.Instance.AllBoys[BoysManager.Instance.curInviteBoyId].name;
        //        }

        //        sprite = (Resources.Load(text3, typeof(Sprite)) as Sprite);
        //        anchoredPosition = new Vector2(-663f, -540f);
        //    }

        //    // 这里开始应该是显示部分
        //    Image component = aGameObject.transform.Find("Image").GetComponent<Image>();
        //    RectTransform component2 = aGameObject.transform.Find("Image").GetComponent<RectTransform>();
        //    // 这里是左侧的人物图片的初始化
        //    component.sprite = sprite;
        //    component2.anchoredPosition = anchoredPosition;
        //    component2.DOScale(new Vector3(1.15f, 1.15f, 1f), 0f);
        //    // 人物名称文本
        //    aGameObject.transform.Find("name/Text").gameObject.GetComponent<Text>().text = text;
        //    // 清空对话框里的文本
        //    aGameObject.transform.Find("Text").GetComponent<Text>().text = string.Empty;
        //    // 对话框的那个弹一下的动画效果
        //    if (data.GetString("shake") == "1" && !moreText)
        //    {
        //        aGameObject.transform.Find("inner_bg").DOPunchScale(new Vector3(0.1f, 0.1f, 0f), 0.2f, 1, 0.5f);
        //    }
        //    // 第一次领零用钱但由母亲发的对话，20001 是第一次零用钱事件，这个事件在儿子版是父亲发的，女儿版在这里增加了一个母亲发的替换
        //    if (id == 20001 && !record_manager.InstanceManagerRecord.IsFather())
        //    {
        //        string str3 = "chat_mom_girl";
        //        sprite = (Resources.Load("UI/Main_ui/chat/" + str3, typeof(Sprite)) as Sprite);
        //        component.sprite = sprite;
        //        aGameObject.transform.Find("name/Text").gameObject.GetComponent<Text>().text = ReadXml.GetString("ChatMother");
        //    }
        //    component.SetNativeSize();

        //    // 这里应该是对话背景图
        //    if (data.GetString("graph") == "0")
        //    {
        //        aGameObject.transform.Find("bg").gameObject.SetActive(false);
        //    }
        //    else
        //    {
        //        aGameObject.transform.Find("bg").gameObject.transform.GetComponent<Image>().sprite = (Resources.Load("graph/" + data.GetString("graph"), typeof(Sprite)) as Sprite);
        //    }

        //    // 疑似是对话框里的文本
        //    string text4;
        //    if (newtext == null)
        //    {
        //        // 没有通过 newtext 参数传入对话内容
        //        if (param != string.Empty)
        //        {
        //            // 通过 param 参数传入内容，对文本进行格式化替换
        //            text4 = string.Format(data.GetStringLanguage("text", true), param);
        //        }
        //        else
        //        {
        //            // 没有通过 param 参数传入对话内容，直接获取文本
        //            text4 = data.GetStringLanguage("text", true);
        //        }
        //    }
        //    else
        //    {
        //        // 这里是 newtext 参数传入的对话框内容
        //        text4 = newtext;
        //    }
        //    string nextText = string.Empty;
        //    if (text4.Contains("@@"))
        //    {
        //        int num = text4.IndexOf("@@");
        //        nextText = text4.Substring(num + 2, text4.Length - num - 2);
        //        text4 = text4.Substring(0, num);
        //    }
        //    Tweener aTweener = aGameObject.transform.Find("Text").gameObject.GetComponent<Text>().DOText(text4, (float)text4.Length * 0.1f, true, ScrambleMode.None, null).SetEase(Ease.Linear);
        //    bool doneclik = false;
        //    if (!DEF.IsDevelopment)
        //    {
        //        SpaceController.SpaceAction action = delegate ()
        //        {
        //            if (!doneclik)
        //            {
        //                aTweener.timeScale = (float)typeof(chat_manager).GetField("speedUp", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
        //                doneclik = true;
        //            }
        //        };
        //        SpaceController.Instance.SetAction(action);
        //    }

        //    aTweener.OnUpdate(delegate
        //    {
        //        if (Input.GetMouseButtonDown(0) && !doneclik)
        //        {
        //            aTweener.timeScale = (float)typeof(chat_manager).GetField("speedUp", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
        //            doneclik = true;
        //        }
        //    });

        //    int @int = data.GetInt("add_task", true);
        //    if (@int != 0)
        //    {
        //        task_manager.InstancManager.add_task(@int, false);
        //        MessageCenter.sendMessage("refresh_ui_data", null);
        //    }

        //    if (!parentTransform)
        //    {
        //        if (nextText == string.Empty)
        //        {
        //            ___effectId = data.GetInt("effect");
        //            ___nextId = data.GetInt("next_id", true);
        //        }
        //        else
        //        {
        //            ___curId = id;
        //        }
        //        aTweener.OnComplete(delegate
        //        {
        //            typeof(chat_manager).GetField("isOnComplete", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(__instance, true);
        //            aGameObject.transform.Find("next").gameObject.SetActive(true);
        //            typeof(chat_manager).GetField("aGameObject", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(__instance, aGameObject);
        //            typeof(chat_manager).GetField("next", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(__instance, next);
        //            typeof(chat_manager).GetField("next2", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(__instance, next2);
        //            typeof(chat_manager).GetField("nextText", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(__instance, nextText);
        //            typeof(chat_manager).GetField("isAnniversary", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(__instance, isAnniversary);
        //            typeof(chat_manager).GetField("completeAction", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(__instance, completeAction);
        //            aGameObject.transform.GetComponent<Button>().onClick.AddListener(delegate ()
        //            {
        //                typeof(chat_manager).GetMethod("OnChatComplete", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(__instance, new object[0]);
        //            });
        //        });
        //    }
        //    else
        //    {
        //        aTweener.OnComplete(delegate
        //        {
        //        });
        //        aGameObject.transform.parent = parentTransform;
        //        aGameObject.transform.SetAsFirstSibling();
        //    }

        //    // 阻断对原方法的调用
        //    return false;
        //}
    }
}
