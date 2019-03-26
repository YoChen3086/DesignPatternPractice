using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Resume
    {
        private string name;
        private string sex;
        private int age;
        private string timeArea;
        private string company;

        public Resume(string name)
        {
            this.name = name;
        }

        // 設定個人資訊
        public void SetPersonlInfo(string sex, int age)
        {
            this.sex = sex;
            this.age = age;
        }

        // 設定工作經歷
        public void SetWorkExperience(string timeArea, string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }

        // 顯示
        public void Display()
        {
            Console.WriteLine($"{name} {sex} {age}");
            Console.WriteLine($"工作經歷: {timeArea} {company}");
        }
    }
}
