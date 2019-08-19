using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                selectMonths.Items.Add(i.ToString());//初始化月份下拉列表
            }
            for (int j = 1; j <= 31; j++)
            {
                selectDays.Items.Add(j.ToString());//初始化天数下拉列表
            }
            selectMonths.SelectedIndex = selectDays.SelectedIndex = 0;//默认选择1月1日
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = new DateTime(1, Convert.ToInt32(selectMonths.SelectedItem.ToString()), Convert.ToInt32(selectDays.SelectedItem.ToString()));//获取选择的生日
                XZname.Text = Search.GetConstellation(dt);//根据生日获取所属星座名称
                //获取其他信息
                string[] info = Search.ConstellationDescription(Search.GetConstellation(dt));
                TZname.Text = info[0];//星座特征
                YSname.Text = info[1];//幸运颜色
                SZname.Text = info[2];//幸运数字
                RQname.Text = info[3];//幸运日期
                DDname.Text = info[4];//幸运地点
                GXname.Text = info[5];//个性特征
                YDname.Text = info[6];//星座优点
                QDname.Text = info[7];//星座缺点
                switch (XZname.Text.Trim())
                {
                    case "白羊座":
                        pictureBox1.Image = Properties.Resources.白羊座; break;
                    case "处女座":
                        pictureBox1.Image = Properties.Resources.处女座; break;
                    case "金牛座":
                        pictureBox1.Image = Properties.Resources.金牛座; break;
                    case "巨蟹座":
                        pictureBox1.Image = Properties.Resources.巨蟹座; break;
                    case "摩羯座":
                        pictureBox1.Image = Properties.Resources.摩羯座; break;
                    case "射手座":
                        pictureBox1.Image = Properties.Resources.射手座; break;
                    case "狮子座":
                        pictureBox1.Image = Properties.Resources.狮子座; break;
                    case "双鱼座":
                        pictureBox1.Image = Properties.Resources.双鱼座; break;
                    case "双子座":
                        pictureBox1.Image = Properties.Resources.双子座; break;
                    case "水瓶座":
                        pictureBox1.Image = Properties.Resources.水瓶座; break;
                    case "天秤座":
                        pictureBox1.Image = Properties.Resources.天枰座; break;
                    case "天蝎座":
                        pictureBox1.Image = Properties.Resources.天蝎座; break;
                }
            }
            catch
            {
                MessageBox.Show("选择的日期有误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int m, d;
            DateTime thismonment = DateTime.Now;
            m = Int32.Parse(selectMonths.Text);
            d = Int32.Parse(selectDays.Text);
            //int dr; (判断闰年计算日期没有做完）
            //if (m == 2)
            //    dr = 28;
            //else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            //    dr = 31;
            //else dr = 30;

            if (thismonment.Month < m)//如果当前月份小于出生月份

                YueFen.Text = (m - thismonment.Month).ToString();//出生月份-当前月份

            else if (thismonment.Month == m) //出生月份为当前月，且出生日期小于当前日期

                if (thismonment.Day < d)

                    YueFen.Text = (0).ToString();

                else

                    YueFen.Text = (12).ToString();

            else //如果出生月份小于当前月份

                YueFen.Text = (12 + m - thismonment.Month).ToString();//12+出生月份-当前月份
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void RQname_Click(object sender, EventArgs e)
        {

        }

        private void GXname_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }
    }
    public class Search
    {
        /// <summary>
        /// 根据星座返回相应的星座特色、幸运色、幸运数字、幸运日、幸运地、个性特征、优点、缺点
        /// </summary>
        /// <param name="str">方法的参数，代表某个星座名称</param>
        /// <returns></returns>
        public static string[] ConstellationDescription(string str)
        {
            string[] Description = new string[8];
            if (str != "")
            {
                switch (str)
                {
                    case "摩羯座":
                        Description[0] = "现实、安全、平稳。";//个性特征
                        Description[1] = "暗绿色";//幸运颜色
                        Description[2] = "6";//幸运数字
                        Description[3] = "星期三";//幸运日期
                        Description[4] = "宁静的地点";//幸运地点
                        Description[5] = "你深思谨慎，冷静而准确的判断力，给人沉稳而严肃的印象。你有强烈的责任感和企业图心，时时鞭策自己努力实现理想。但是，你凡事都太过认真，乃至拘泥，而显得过于刚强，冥顽不灵。";//个性特征
                        Description[6] = "1、有实际的人生观；2、做事脚踏实地；3、意志力强,不容易受影响；4、处处谨慎；5、有克服困难的毅力；6、坚守原则,重视纪律；7、有家庭观念；8、对人谦逊；9、有独树一格的幽默感；";//星座优点
                        Description[7] = "1、太过现实；2、固执；3、不够乐观；4、个人利已主义；5、缺乏浪漫情趣；6、过于压抑自己的欲望；7、太专注于个人的目标；8、缺乏对人群的关怀和热情；9、不擅于沟通；10、不能随机应变；";//星座缺点
                        break;
                    case "水瓶座":
                        Description[0] = "博爱、反传统";
                        Description[1] = "古铜色";
                        Description[2] = "22";
                        Description[3] = "星期六";
                        Description[4] = "繁华大都市";
                        Description[5] = "水瓶座的人富知性理性，善于分析与思考，具有思想家的气质，因此天生有清晰冷静的头脑和丰富的创造力。水瓶座的你感觉十分敏锐，喜欢追求新奇的事物。由于这个特质，你也是善变的。然而只要是自己有兴趣的事，便会积极的投入、钻研，而有杰出的表现。";//个性特征
                        Description[6] = "1、崇尚自由；2、充满人道精神；3、兴趣广泛、创意十足；4、乐于发掘真象；5、有前瞻性；6、拥有理性的智慧；7、独立，有个人风格；8、乐于助人；9、对自己的感情忠实；";//优点
                        Description[7] = "1、缺乏热情；2、想法过于理想化；3、不按牌理出牌；4、打破砂锅问到底；5、太相信自己的判断；6、思想多变，没有恒心；7、对朋友很难推心置腹；8、过于强调生活的自主权；9、喜欢多管闲事；10、太过理智，情趣不足 ";//缺点

                        break;
                    case "双鱼座":
                        Description[0] = "包容性、意志薄弱";
                        Description[1] = "各种的薄荷色";
                        Description[2] = "11";
                        Description[3] = "星期四";
                        Description[4] = "海边的城市";
                        Description[5] = "从表面上看，双鱼座的人内向而羞怯，然而内心常常是复杂而矛盾的，同时存在着善与恶，精神与物质等对立的挣扎。虽然有丰富的想象力，相对的也容易不切实际地做白日梦，幻想着白马王子（白雪公主）的出现，而忽略了现实生活中的缘份。";//个性特征
                        Description[6] = "1、感情丰富；2、心地仁慈，舍已为人，不自私；3、具有想像力；4、善解人意；5、直觉力强；6、懂得包容；7、温和有礼；8、容易信赖别人，不多疑；9、浪漫；";//星座优点
                        Description[7] = "1、不够实际,幻想太多；2、没有足够的危险意识；3、太情绪化,多愁善感；4、意志不坚定；5、缺乏面对现实的勇气；6、容易陷入沮丧而不可自拔；7、很容易养成说谎的习惯；8、不善于理财；9、容易受环境影响；10、缺乏理性,感情用事； ";//星座缺点
                        break;
                    case "白羊座":
                        Description[0] = "冲动、年青、希望";
                        Description[1] = "鲜红色";
                        Description[2] = "5";
                        Description[3] = "星期二";
                        Description[4] = "大都市";
                        Description[5] = "性格爽朗，不拘小节，极具领袖气质。充满自信而固执，有旺盛的企图心，喜欢接受挑战。因此，会坚决地贯彻自己的决定。";//个性特征
                        Description[6] = "1、做事积极，热情有活力；2、有担当，讲义气；3、乐观进取有自信；4、勇于接受新观念；5、有明快的决断力；6、坦白率真；7、爆发力强；8、勇于接受挑战；9、不畏权势";//星座优点
                        Description[7] = "1、自我中心太强；2、急躁缺乏耐性；3、粗心大意，不善观察；4、有一点臭屁；5、说话欠考虑；6、做事瞻前不顾后；7、只有三分钟热度；8、容易脑羞成怒；9、缺乏时间观念；10、不懂照顾身体；";//星座缺点
                        break;
                    case "金牛座":
                        Description[0] = "稳定、温顺";
                        Description[1] = "粉红色";
                        Description[2] = "6";
                        Description[3] = "星期五";
                        Description[4] = "静谧之处";
                        Description[5] = "追求脚踏实地的平实感，个性温和，庄重正直，从不作任何不切实际的幻想。喜好一切美好的事物，对音乐，舞蹈的节奏感有着与生俱来的天赋。天生的艺术才华，真是令人称羡";//个性特征
                        Description[6] = "1、耐性十足；2、一往情深；3、有艺术天份；4、脚踏实地；5、做事有计划；6、能坚持到底；7、择善固执；8、追求和平；9、生活有规律；10、值得信赖；";//星座优点
                        Description[7] = "1、占有欲太强，善妒；2、顽固的死硬派；3、缺乏协调性，不善于分工合作；4、做事态度过于严肃；5、缺乏幽默感；6、不知变通；7、过于坚持自己的步调；8、规矩太多；9、太过谨慎，缺乏求新求变的勇气；";//星座缺点
                        break;
                    case "双子座":
                        Description[0] = "适应力、意外性";
                        Description[1] = "黄色";
                        Description[2] = "7";
                        Description[3] = "星期三";
                        Description[4] = "海平面之上";
                        Description[5] = "兼具光明开朗的一面和阴霾低潮的一面，所以应该好好的了解自己，掌握自己，以避免内心的冲突。由于你敏捷的反应，学习能力强，显得才华洋溢，但如果不能坚持到底，往往会半途而废徒劳无功。";//个性特征
                        Description[6] = "1、多才多艺；2、见人说人话,见鬼说鬼话；3、足智多谋,反应灵敏；4、八面玲珑,善于交际；5、懂得随机应变；6、充满生命力；7、擅长沟通；8、知进退,有分寸；9、适应力强；10、风趣幽默；";//星座优点
                        Description[7] = "1、三分钟热度；2、善变、处世缺乏原则；3、举一反十，过于神经质；4、做事蜻蜓点水不深入；5、过于圆滑；6、容易紧张；7、意志不坚定；8、让人觉得不可靠；9、不专心；";//星座缺点
                        break;
                    case "巨蟹座":
                        Description[0] = "情绪化、仁慈母性";
                        Description[1] = "绿色";
                        Description[2] = "2";
                        Description[3] = "星期一";
                        Description[4] = "近水的地方";
                        Description[5] = "你是那么亲切、感性、情感细腻、敏锐、想像力丰富；带着母性的情怀善待自己所爱的亲人，朋友；对家庭十分依恋，是标准的贤妻良母或好丈夫、好家长。";//个性特征
                        Description[6] = "1、情感真挚深切；2、想象力丰富；3、念旧、重情义；4、有包容力；5、直觉敏锐；6、懂得体贴、关怀；7、亲切温暖；8、善解人意；9、有同情心；";//星座优点
                        Description[7] = "1、跟着情绪走；2、提不起、放不下；3、太过多愁善感；4、不知适可而止；5、缺乏理性思考；6、经不起打击；7、说话拐弯抹角，不直接；8、过度保护自己；9、沉溺于往事，无法面对事实；10、心肠太软；";//星座缺点
                        break;
                    case "狮子座":
                        Description[0] = "勇气、开朗";
                        Description[1] = "金色、橘色";
                        Description[2] = "5、9";
                        Description[3] = "星期日";
                        Description[4] = "社交场所";
                        Description[5] = "如同灿烂耀眼的太阳一般，狮子座的你热情洋溢。本质上阳刚、乐天，却也容易傲慢顽固。王者星座的你，具领导能力与侠义风范，充满活力和强烈的企图心，却不善于作深入的思考，外向开朗之下，却常感到内心孤寂。";//个性特征
                        Description[6] = "1、有领导能力；2、具有激励人心的气质；3、组织力强；4、热情开朗、对人慷慨大方；5、心胸宽大，懂得宽怒；6、一言九鼎，有信用；7、乐观；8、不多疑；9、诚恳正直；";//星座优点
                        Description[7] = "1、死爱面子活受罪；2、好大喜功；3、莫名的优越感；4、喜欢接受奉承；5、缺乏耐性；6、刚愎自用，自以为是；7、缅怀过去；8、能伸不能屈；9、缺乏节俭的美德；10、喜欢指挥别人；";//星座缺点
                        break;
                    case "处女座":
                        Description[0] = "刻苦耐劳、吹毛求疵";
                        Description[1] = "灰色";
                        Description[2] = "7";
                        Description[3] = "星期三";
                        Description[4] = "小城市";
                        Description[5] = "你是个完美主义者，感觉细腻敏锐，但同时也保有冷静的头脑，对事物能作出正确的判断。因为自我要求甚高，很容易精神紧张；而且清晰敏感的头脑，对现实利益看得很实际。";//个性特征
                        Description[6] = "1、追求完美，永不气馁；2、脚踏实地；3、事事谨慎小心；4、善于搜集资料；5、勤奋努力；6、守本份，靠得住；7、谦逊不夸大；8、有精确的观察力；9、有耐性；10、对爱情忠实；";//星座优点
                        Description[7] = "1、太过吹毛求疵；2、唠叨琐碎；3、自扫门前雪；4、有洁癖顷向；5、缺乏接受批评的雅量；6、不够浪漫、不尊重他人的梦想；7、人际关系待加强；8、太过实际，缺乏远见；";//星座缺点
                        break;
                    case "天秤座":
                        Description[0] = "公平、决断力低";
                        Description[1] = "褐色";
                        Description[2] = "3";
                        Description[3] = "星期五";
                        Description[4] = "社交场所";
                        Description[5] = "你总是宽容,讲求和平不喜争斗,常常扮演和平使者的角色。你极具理性,很能明辨是非,有高明的社交能力和谈话技巧。然而,相对的,若是面临必须作选择时,会出现计算利害得失,或难作取舍而犹豫不决。";//个性特征
                        Description[6] = "1、公平客观；2、有正义感；3、适应力强；4、对美感有鉴赏力；5、逻辑强，善分析；6、天生有优雅风采；7、浪漫的恋爱高手；8、有外交手腕；9、因事制宜，能屈能伸，适应力强；";//星座优点
                        Description[7] = "1、优柔寡断，犹豫不决；2、意志不坚定，容易受人影响；3、怕得罪人；4、不能承受压力，没有担当；5、过分要求公平，吃不得亏；6、息事宁人，治标不治本；7、总是自圆其说，藉口太多；8、喜欢享受，好逸恶劳；9、常不经意地乱放电；10、缺乏自省能力；";//星座缺点
                        break;
                    case "天蝎座":
                        Description[0] = "善恶分明、嫉妒";
                        Description[1] = "暗红色";
                        Description[2] = "4";
                        Description[3] = "星期二";
                        Description[4] = "近水的地方";
                        Description[5] = "深沉内敛，沉默寡言，凡事都十分谨慎且深思熟虑，很能掌握事物本质。天蝎座的人性情复杂，不善于表达感情，容易给人顺从的错觉，其实，内心是坚决而固执的。";//个性特征
                        Description[6] = "1、深谋远虑2、恩怨分明3、直觉敏锐4、对决定的事有执行力5、不畏挫折，坚持到底；6、对朋友讲义气7、天生有性感魅力8、坚持追求事情的真相9、善于保守秘密10、对人生有潜在的热情";//星座优点
                        Description[7] = "1、太过好强2、占有欲过高3、善妒、爱吃醋；4、疑心病重5、报复心太强6、得理不饶人7、感情用事，明知故犯；8、口是心非，城府太深；9、爱恨太强烈 ";//星座缺点
                        break;
                    case "射手座":
                        Description[0] = "开朗、开放";
                        Description[1] = "浅蓝色";
                        Description[2] = "6";
                        Description[3] = "星期四";
                        Description[4] = "户外地方";
                        Description[5] = "你是个热情，热爱生命的乐天主义者。你的率直，天真的性格使你广受欢迎，但你的坦白却可能因缺乏深思熟虑，导致他人的不悦。因为你崇尚自由，反应灵敏，行动敏捷，但常常想到什么就立刻化为行动，有太过草率之率。";//个性特征
                        Description[6] = "1、天生乐观；2、对人生充满理想；3、正直坦率；4、丰富的幽默感；5、酷爱和平；6、待人友善；7、行动力强；8、有自己的处世哲学；9、经得起打击；10、有救世救人的热情；";//星座优点
                        Description[7] = "1、粗心大意；2、心直口快易得罪人；3、缺乏耐性；4、不懂人情世故；5、做事冲动，不懂三思而行；6、不信邪不听劝告；7、过度理想化,不切实际；8、缺乏按部就班的计划；9、喜怒太形于色";//星座缺点
                        break;
                    default:
                        Description[0] = "星座输入错误";
                        break;
                }
            }
            return Description;
        }
        /// 根据生日查询所属星座
        public static string GetConstellation(DateTime strBirthday)
        {
            string strConstellation = null;//定义一个字符串，用来记录星座
            float birthday = 0.00F;//定义一个float变量，用来记录使用生日组成的数字
            if (strBirthday.Month == 1 && strBirthday.Day < 20)
            {
                birthday = float.Parse(string.Format("13.{0}", strBirthday.Day));//将生日格式化为数字
            }
            else
            {
                if (strBirthday.Day < 10)//判断生日中的天数是否小于10
                    birthday = float.Parse(string.Format("{0}.0{1}", strBirthday.Month, strBirthday.Day));
                else
                    birthday = float.Parse(string.Format("{0}.{1}", strBirthday.Month, strBirthday.Day));
            }
            float[] atomBound = { 1.20F, 2.20F, 3.21F, 4.21F, 5.21F, 6.22F, 7.23F, 8.23F, 9.23F, 10.23F, 11.21F, 12.22F, 13.20F };//定义星座间隔之间的数字
            string[] atoms = { "水瓶座", "双鱼座", "白羊座", "金牛座", "双子座", "巨蟹座", "狮子座", "处女座", "天秤座", "天蝎座", "射手座", "摩羯座" };//定义星座名称
            for (int i = 0; i < atomBound.Length - 1; i++)//遍历星座间隔之间的数字
            {
                if (atomBound[i] <= birthday && atomBound[i + 1] > birthday)//判断遍历到的数字跟生日的大小
                {
                    strConstellation = atoms[i];//获取星座名称
                    break;
                }


            }
            //添加意外检测1.2-1.9
            if (strBirthday.Month == 1 && strBirthday.Day < 10 && strBirthday.Day > 1)
                strConstellation = atoms[11];
            return strConstellation;//返回得到的星座名称
        }
    }
}


