using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ObjectStructure
    {
        private IList<Element> elements = new List<Element>();

        // 增加
        public void Attach(Element element)
        {
            elements.Add(element);
        }

        // 移除
        public void Dettach(Element element)
        {
            elements.Remove(element);
        }

        // 查看顯示
        public void Accept(Visitor vistor)
        {
            foreach (Element element in elements)
            {
                element.Accept(vistor);
            }
        }
    }
}
