# 测一测小程序  
__一个用来做小占卜的程序__

---

## 该软件可以测算什么？
* 星座
* 星座特征及优缺点
* 幸运数字
* 幸运色
* 幸运日期
* 幸运地点
* 距离下一次生日的时间
---

## 使用方法

运行 __<label style="color:red">小程序.exe__ 然后输入生日日期，即可测算出上述内容。

#### 软件截图
![测一测小程序界面图](Pic\Date.png)

---

## 部分源代码展示

``` csharp
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
```
---

## 程序漏洞

*未加入对 __<label style="color:red">闰年__ 的计算判断*

---

## 团队分工

#### 程序编写
* __尚朝龙__
* __李堃__

#### 单元重构
* __未完成__

#### Readme编写
* __游镇豪__

---

## 本程序源代码下载地址

*Alonellen的[GitHub](https://github.com/Alonellen/ShangChaoLong?tdsourcetag=s_pcqq_aiomsg/)链接。*
