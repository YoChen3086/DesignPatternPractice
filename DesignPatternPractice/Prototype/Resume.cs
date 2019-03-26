using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Resume : ICloneable
    {
        private string name;
        private string sex;
        private int age;
        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        // 設定個人資訊
        public void SetPersonlInfo(string sex, int age)
        {
            this.sex = sex;
            this.age = age;
        }

        // 設定工作經歷
        public void SetWorkExperience(string workDate, string company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }

        // 顯示
        public void Display()
        {
            Console.WriteLine($"{name} {sex} {age}");
            Console.WriteLine($"工作經歷: {work.WorkDate} {work.Company}");
        }

        public object Clone()
        {
            Resume resume = new Resume(this.work);
            resume.name = this.name;
            resume.sex = this.sex;
            resume.age = this.age;

            return resume;
        }
    }
}
