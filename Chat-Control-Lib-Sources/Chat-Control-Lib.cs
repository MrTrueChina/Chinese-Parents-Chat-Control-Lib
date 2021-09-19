using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
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
        /// 高满意度事件对话
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

        //// 文综线 ////

        /// <summary>
        /// 学习-学会-文综-学会历史常识后的对话（五千年的风和雨，藏了多少梦）
        /// </summary>
        SKILL_STUDY_INTEGRATED_HISTORICAL_COMMON_SCESE = 80600031,
        /// <summary>
        /// 学习-学会-文综-学会世界地理后的对话
        /// </summary>
        SKILL_STUDY_INTEGRATED_WORLD_GEOGRAPHY = 80600071,

        //// 理综线 ////

        /// <summary>
        /// 学习-学会-理综-学会物理常识后的对话
        /// </summary>
        SKILL_STUDY_SCIENCE_PHYSICS_KNOWLEDGE = 80700031,
        /// <summary>
        /// 学习-学会-理综-学会模型常识后的对话
        /// </summary>
        SKILL_STUDY_SCIENCE_MODEL_KNOWLEDGE = 80700051,

        //// 编程线 ////

        /// <summary>
        /// 学习-学会-计算机-学会计算机入门后的对话
        /// </summary>
        SKILL_STUDY_COMPUTER_INTRODUCTION = 81200011,
        /// <summary>
        /// 学习-学会-计算机-学会超文本后的对话
        /// </summary>
        SKILL_STUDY_COMPUTER_HYPERTEXT = 81200021,

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

        //// 编程线 ////

        /// <summary>
        /// 学习-事件-计算机-学会计算机入门后出现的事件的对话
        /// </summary>
        SKILL_EVENT_COMPUTER_INTRODUCTION = 70400101,
        /// <summary>
        /// 学习-事件-计算机-学会超文本后出现的事件的对话
        /// </summary>
        SKILL_EVENT_COMPUTER_HYPERTEXT = 70400201,

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

        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            // 保存 Mod 对象
            ModEntry = modEntry;
            ModEntry.OnToggle = OnToggle;

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
    }
}
