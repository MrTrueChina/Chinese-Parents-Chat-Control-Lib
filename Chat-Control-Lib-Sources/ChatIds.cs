using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtC.Mod.ChineseParents.ChatControlLib
{
    /// <summary>
    /// 对话起始 id 收录，不完整，不保证更新
    /// </summary>
    public static class ChatIds
    {
        /// <summary>
        /// 流程性对话，一个游戏流程里必然会出现的对话，大部分是固定时间的
        /// </summary>
        public static class Plot
        {
            /// <summary>
            /// 新一代开幕（你也有了自己的孩子）
            /// </summary>
            public const int NEW_ROUND_OPEN = 59001;
            /// <summary>
            /// 新一代开幕-上一代是女儿版结局，新一代开幕父母对话（我XX也有了娃）
            /// </summary>
            public const int NEW_ROUND_OPEN_MOTHER = 33001;
            /// <summary>
            /// 第二天出现的对脑洞的对话
            /// </summary>
            public const int NAODONG_INFO = 18001;
            /// <summary>
            /// 第三天出现的推荐点技能的对话
            /// </summary>
            public const int PROMOTE_STUDY_SKILL = 16001;
            /// <summary>
            /// 第四天出现的对悟性消耗量的解释对话
            /// </summary>
            public const int POTENTIAL = 17001;
            /// <summary>
            /// 面子事件第一次出现
            /// </summary>
            public const int FACING_VISIT = 15001;
            /// <summary>
            /// 索取功能开启对话
            /// </summary>
            public const int CLAIM = 19001;
            /// <summary>
            /// 重点小学达标期望出现对话
            /// </summary>
            public const int IMPORTANT_PRIMARY_SCHOOL = 11001;
            /// <summary>
            /// 继承父母性格对话
            /// </summary>
            public const int INHERIT_CHARACTER = 42001;
            /// <summary>
            /// 升小学对话
            /// </summary>
            public const int PRIMARY_SCHOOL = 51601;
            /// <summary>
            /// 开启商店对话
            /// </summary>
            public const int SHOP_OPEN = 20001;
            /// <summary>
            /// 第一次出现考试事件对话
            /// </summary>
            public const int EXAMINATION = 26001;
            /// <summary>
            /// 第一次出现做题而不是脑洞的对话
            /// </summary>
            public const int WTITE_EXAM = 27001;
            /// <summary>
            /// 重点初中达标期望出现对话
            /// </summary>
            public const int IMPORTANT_JUNIOR_MIDDLE_SCHOOL = 12001;
            /// <summary>
            /// 升初中的对话
            /// </summary>
            public const int JUNIOR_MIDDLE_SCHOOL = 51401;
            /// <summary>
            /// 社交按钮出现的对话
            /// </summary>
            public const int JUNIOR_LOVING_OPEN = 21001;
            /// <summary>
            /// 班主任：楼道里就听见你们吵
            /// </summary>
            public const int NOISY = 51101;
            /// <summary>
            /// 王胜男转学事件的对话
            /// </summary>
            public const int TRANSFER_WANGSHENGNAN = 53001;
            /// <summary>
            /// 李若放转学事件的对话
            /// </summary>
            public const int TRANSFER_LIRUOFANG = 53002;
            /// <summary>
            /// 汤金娜转学事件的对话
            /// </summary>
            public const int TRANSFER_TANGJINNA = 53003;
            /// <summary>
            /// 重点高中达标期望出现对话
            /// </summary>
            public const int IMPORTANT_HIGH_SCHOOL = 13001;
            /// <summary>
            /// 苏芳允转学事件的对话
            /// </summary>
            public const int TRANSFER_SUFANGYUN = 53004;
            /// <summary>
            /// 牧唯转学事件的对话
            /// </summary>
            public const int TRANSFER_MUWEI = 53005;
        }
        /// <summary>
        /// 满意度相关
        /// </summary>
        public static class Satisfaction
        {
            /// <summary>
            /// 高满意度
            /// </summary>
            public static class Good
            {
                /// <summary>
                /// 高满意度事件对话（我站在高高的沙发旁边）
                /// </summary>
                public const int GOOD_8 = 508001;
                /// <summary>
                /// 高满意度事件对话（带你去吃好吃的）
                /// </summary>
                public const int GOOD_9 = 509001;
                /// <summary>
                /// 高满意度事件对话（真不愧是我亲生的）
                /// </summary>
                public const int GOOD_10 = 510001;
            }
        }
        /// <summary>
        /// 压力相关
        /// </summary>
        public static class Pressure
        {
            /// <summary>
            /// 低压力
            /// </summary>
            public static class Good
            {
                /// <summary>
                /// 低压力事件对话
                /// </summary>
                public const int GOOD_2 = 512001;
                /// <summary>
                /// 低压力事件对话（内心平稳）
                /// </summary>
                public const int GOOD_3 = 513001;
            }
        }
        /// <summary>
        /// 考试相关对话
        /// </summary>
        public static class Examiation
        {
            /// <summary>
            /// 考试结果为优的对话
            /// </summary>
            public const int EXCELLENT = 840004;
        }
        /// <summary>
        /// 抽奖相关对话
        /// </summary>
        public static class LuckDraw
        {
            /// <summary>
            /// 没有抽中的号的对话
            /// </summary>
            public const int Zero = 80004;
        }
        /// <summary>
        /// 选秀相关对话
        /// </summary>
        public static class Draft
        {
            /// <summary>
            /// 选秀开场白
            /// </summary>
            public const int OPEN = 600002;

            /// <summary>
            /// 选秀开赛，就是选秀选择特长后的对话
            /// </summary>
            public const int BATTLE = 620000;
        }
        /// <summary>
        /// 面子挑战相关对话
        /// </summary>
        public static class Challenge
        {
            /// <summary>
            /// 艾殷散（理科挑战）挑战信息
            /// </summary>
            public const int AIYINSAN_INFO = 201000101;
            /// <summary>
            /// 李二（运动挑战）挑战信息
            /// </summary>
            public const int LIER_INFO = 201000201;
            /// <summary>
            /// 肖芬琪（艺术挑战）挑战信息
            /// </summary>
            public const int XIAOFENQI_INFO = 201000301;
            /// <summary>
            /// 聪聪（金钱挑战）挑战信息
            /// </summary>
            public const int CONGCONG_INFO = 201000501;
            /// <summary>
            /// 宣洁衣（美貌挑战）挑战信息
            /// </summary>
            public const int XUANJIEYI_INFO = 201000601;
        }
        /// <summary>
        /// 技能相关对话
        /// </summary>
        public static class Skill
        {
            /// <summary>
            /// 学会技能后立刻出现的对话
            /// </summary>
            public static class Study
            {
                /// <summary>
                /// 普通线
                /// </summary>
                public static class Normal
                {
                    /// <summary>
                    /// 学会走路技能后的对话
                    /// </summary>
                    public const int WALK = 80100041;
                    /// <summary>
                    /// 学会跑步技能后的对话
                    /// </summary>
                    public const int RUN = 80100051;
                }
                /// <summary>
                /// 情绪线
                /// </summary>
                public static class Emotion
                {
                    /// <summary>
                    /// 学会说话技能后的对话，可能是上一代是女儿才会出现的
                    /// </summary>
                    public const int TALK_MOTHER = 80200011;
                    /// <summary>
                    /// 学会忍耐技能后的对话，可能是上一代是女儿才会出现的
                    /// </summary>
                    public const int EXERCISE_PATIRNCE = 80200021;
                    /// <summary>
                    /// 学会延迟满足技能后的对话，可能是上一代是女儿才会出现的
                    /// </summary>
                    public const int DELAYER_SATISFACTION = 80200031;
                }
                /// <summary>
                /// 语文线
                /// </summary>
                public static class Chinese
                {
                    /// <summary>
                    /// 学会识字写字后的对话（永字八法）
                    /// </summary>
                    public const int LITERACY_AND_WRITING = 80300021;
                    /// <summary>
                    /// 学会语文作文后的对话
                    /// </summary>
                    public const int CHINESE_COMPOSITION = 80300041;
                    /// <summary>
                    /// 学会写小说后的对话
                    /// </summary>
                    public const int NOVEL = 80300051;
                }
                /// <summary>
                /// 数学线
                /// </summary>
                public static class Math
                {
                    /// <summary>
                    /// 学会四则运算后的对话
                    /// </summary>
                    public const int FOUR_ARITHMETIC = 80400011;
                    /// <summary>
                    /// 学会数学概率后的对话
                    /// </summary>
                    public const int PROBABILITY = 80400041;
                }
                /// <summary>
                /// 英语线
                /// </summary>
                public static class English
                {
                    /// <summary>
                    /// 学会英语单词后的对话
                    /// </summary>
                    public const int ENGLISH_WORDS = 80500021;
                    /// <summary>
                    /// 学会英语听力后的对话（东北大碴子味
                    /// </summary>
                    public const int ENGLISH_LISTENING = 80500051;
                }
                /// <summary>
                /// 文综线
                /// </summary>
                public static class Integrated
                {

                    /// <summary>
                    /// 学会历史常识后的对话（五千年的风和雨，藏了多少梦）
                    /// </summary>
                    public const int HISTORICAL_COMMON_SCESE = 80600031;
                    /// <summary>
                    /// 学会世界地理后的对话
                    /// </summary>
                    public const int WORLD_GEOGRAPHY = 80600071;
                    /// <summary>
                    /// 学会经济常识后的对话（郁金香泡沫）
                    /// </summary>
                    public const int ECONOMIC_KNOWLEDGE = 80600101;
                }
                /// <summary>
                /// 理综线
                /// </summary>
                public static class Science
                {

                    /// <summary>
                    /// 学会物理常识后的对话
                    /// </summary>
                    public const int PHYSICS_KNOWLEDGE = 80700031;
                    /// <summary>
                    /// 学会模型常识后的对话
                    /// </summary>
                    public const int MODEL_KNOWLEDGE = 80700051;
                    /// <summary>
                    /// 学会初中生物后的对话（21世纪是____的世纪）
                    /// </summary>
                    public const int JUNIOR_MIDDLE_SCHOOL_BIOLOGY = 80700081;
                }
                /// <summary>
                /// 体育线
                /// </summary>
                public static class PE
                {
                    /// <summary>
                    /// 学会体能训练技能后出现的事件的对话
                    /// </summary>
                    public const int PHYSICAL_TRAINING = 80800051;
                    /// <summary>
                    /// 学会校队训练技能后出现的事件的对话
                    /// </summary>
                    public const int SCHOOL_TEAM_TRAINING = 80800061;
                    /// <summary>
                    /// 学会中学篮球集训技能后出现的事件的对话
                    /// </summary>
                    public const int MIDDLE_SCHOOL_BASKETBALL_TRAINING = 80800071;
                    /// <summary>
                    /// 学会美式特训技能后出现的事件的对话
                    /// </summary>
                    public const int AMERICAN_SPECIAL_TRAINING = 80800081;
                    /// <summary>
                    /// 学会专业篮球特训技能后出现的事件的对话
                    /// </summary>
                    public const int PROFESSIONAL_BASKETBALL = 80800091;
                    /// <summary>
                    /// 学会国青队集训技能后出现的事件的对话
                    /// </summary>
                    public const int NATIONAL_YOUTH_TEAM_TRAINING = 80800101;
                }
                /// <summary>
                /// 艺术线
                /// </summary>
                public static class Art
                {
                    /// <summary>
                    /// 学会色彩技能后出现的事件的对话
                    /// </summary>
                    public const int COLOR = 80900051;
                }
                /// <summary>
                /// 编程线
                /// </summary>
                public static class Computer
                {
                    /// <summary>
                    /// 学会计算机入门后的对话
                    /// </summary>
                    public const int INTRODUCTION = 81200011;
                    /// <summary>
                    /// 学会超文本后的对话
                    /// </summary>
                    public const int HYPERTEXT = 81200021;
                }
                /// <summary>
                /// 正义线
                /// </summary>
                public static class Justice
                {
                    /// <summary>
                    /// 学会跆拳道后的对话
                    /// </summary>
                    public const int TAEKWONDO = 81100011;
                }
            }
            /// <summary>
            /// 学会技能后出现事件的对话
            /// </summary>
            public static class Event
            {
                /// <summary>
                /// 体育线
                /// </summary>
                public static class PE
                {
                    /// <summary>
                    /// 学会体育课技能后出现的事件的对话
                    /// </summary>
                    public const int CLASS = 70100101;
                    /// <summary>
                    /// 学会 50米跑 技能后出现的事件的对话
                    /// </summary>
                    public const int RUN_50M = 70100201;
                    /// <summary>
                    /// 学会仰卧起坐技能后出现的事件的对话
                    /// </summary>
                    public const int ABDOMINAL_CURL = 70100301;
                    /// <summary>
                    /// 学会仰卧起坐技能并且上一个事件出现过后出现的事件的对话
                    /// </summary>
                    public const int ABDOMINAL_CURL_2 = 70100311;
                    /// <summary>
                    /// 学会投篮技能后出现的事件的对话
                    /// </summary>
                    public const int SHOOT = 70100401;
                    /// <summary>
                    /// 学会投篮技能后出现的事件的对话
                    /// </summary>
                    public const int SHOOT_2 = 70100421;
                    /// <summary>
                    /// 学会美式特训技能后出现的事件的对话
                    /// </summary>
                    public const int AMERICAN_SPECIAL_TRAINING = 70100501;
                }
                /// <summary>
                /// 艺术线
                /// </summary>
                public static class Art
                {
                    /// <summary>
                    /// 学会美术课技能后出现的事件的对话
                    /// </summary>
                    public const int CLASS = 70200101;
                    /// <summary>
                    /// 学会涂鸦技能后出现的事件的对话
                    /// </summary>
                    public const int GRAFFITI = 70200201;
                    /// <summary>
                    /// 学会艺术赏析技能后出现的事件的对话
                    /// </summary>
                    public const int APPRECIATION = 70200301;
                    /// <summary>
                    /// 学会素描技能后出现的事件的对话
                    /// </summary>
                    public const int SKETCH = 70200401;
                    /// <summary>
                    /// 学会色彩技能后出现的事件的对话
                    /// </summary>
                    public const int COLOR = 70200501;
                }
                /// <summary>
                /// 编程线
                /// </summary>
                public static class Computer
                {
                    /// <summary>
                    /// 学会计算机入门后出现的事件的对话
                    /// </summary>
                    public const int INTRODUCTION = 70400101;
                    /// <summary>
                    /// 学会超文本后出现的事件的对话
                    /// </summary>
                    public const int HYPERTEXT = 70400201;
                }
                /// <summary>
                /// 正义线
                /// </summary>
                public static class Justice
                {
                    /// <summary>
                    /// 学习-学会-正义-学会跆拳道后的对话
                    /// </summary>
                    public const int TAEKWONDO = 70300101;
                    /// <summary>
                    /// 学习-学会-正义-学会跆拳道后的第二个对话
                    /// </summary>
                    public const int TAEKWONDO_2 = 70300111;
                }
            }
        }
        /// <summary>
        /// 社交相关
        /// </summary>
        public static class Loving
        {
            /// <summary>
            /// 以玩家为主
            /// </summary>
            public static class Player
            {
                /// <summary>
                /// 好感度增加
                /// </summary>
                public const int GOOD = 8000001;
                /// <summary>
                /// 儿子版-几乎无警告（该找谁呢）
                /// </summary>
                public const int ALERT_SON_NONE = 715001;
            }
            /// <summary>
            /// 以刘偏偏为主
            /// </summary>
            public static class LiuPianPian
            {
                /// <summary>
                /// 不符合对话条件
                /// </summary>
                public const int CANT_TALK = 8200101;
            }
            /// <summary>
            /// 以席梦来为主
            /// </summary>
            public static class XiMengLai
            {
                /// <summary>
                /// 不符合对话条件
                /// </summary>
                public const int CANT_TALK = 8200201;
                /// <summary>
                /// 开场白
                /// </summary>
                public const int START_LOVING = 8100201;
                /// <summary>
                /// 好效果
                /// </summary>
                public const int GOOD = 8300201;
            }
            /// <summary>
            /// 以秦屿路为主
            /// </summary>
            public static class QinYuLu
            {
                /// <summary>
                /// 不符合对话条件
                /// </summary>
                public const int CANT_TALK = 8200501;
            }
            /// <summary>
            /// 以章涵之为主
            /// </summary>
            public static class ZangHanZhi
            {
                /// <summary>
                /// 不符合对话条件
                /// </summary>
                public const int CANT_TALK = 8200601;
            }
            /// <summary>
            /// 以王胜男为主
            /// </summary>
            public static class WangShegnNan
            {
                /// <summary>
                /// 不符合对话条件
                /// </summary>
                public const int CANT_TALK = 8200301;
            }
            /// <summary>
            /// 以李若放为主
            /// </summary>
            public static class LiRuoFang
            {
                /// <summary>
                /// 不符合对话条件
                /// </summary>
                public const int CANT_TALK = 8200401;
            }
            /// <summary>
            /// 以汤金娜为主
            /// </summary>
            public static class TangJinNa
            {
                /// <summary>
                /// 不符合对话条件
                /// </summary>
                public const int CANT_TALK = 8200701;
            }
            /// <summary>
            /// 以苏芳允为主
            /// </summary>
            public static class SuFangYun
            {
                /// <summary>
                /// 不符合对话条件
                /// </summary>
                public const int CANT_TALK = 8200801;
            }
            /// <summary>
            /// 以牧唯为主
            /// </summary>
            public static class MuWei
            {
                /// <summary>
                /// 社交-牧唯-不符合对话条件
                /// </summary>
                public const int CANT_TALK = 8200901;
            }
            /// <summary>
            /// 以闺蜜为主
            /// </summary>
            public static class MengMeng
            {
                /// <summary>
                /// 闺蜜长时间不陪伴隐藏剧情
                /// </summary>
                public const int NO_COMPANY = 8200101;
            }
        }
    }
}
