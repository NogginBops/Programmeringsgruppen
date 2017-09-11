using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasskamp
{
    enum AttributeType
    {
        Foreground,
        Background
    }

    class BestString
    {
        const ConsoleColor defaultColor = ConsoleColor.White;
        
        string str;

        List<StringAttribute> attributes;

        public int Length
        {
            get
            {
                return str.Length;
            }
        }

        public BestString(string str)
        {
            this.str = str;

            attributes = new List<StringAttribute>();
        }
        
        public void Print()
        {
            for (int i = 0; i < str.Length; i++)
            {
                List<StringAttribute> attribs = GetAttributesAt(i);
                if (attribs.Count > 0)
                {
                    foreach (StringAttribute attrib in attribs)
                    {
                        switch (attrib.type)
                        {
                            case AttributeType.Foreground:
                                Console.ForegroundColor = attrib.attribute;
                                break;
                            case AttributeType.Background:
                                Console.BackgroundColor = attrib.attribute;
                                break;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = defaultColor;
                }
                
                Console.Write(str[i]);
            }
        }

        public void AddAttribute(int start, int end, AttributeType type, ConsoleColor color)
        {
            attributes.Add(new StringAttribute(start, end, type, color));
        }
        
        List<StringAttribute> GetAttributesAt(int index)
        {
            List<StringAttribute> attribs = new List<StringAttribute>();

            foreach (StringAttribute strAtt in attributes)
            {
                if (strAtt.startIndex <= index && strAtt.endIndex > index)
                {
                    attribs.Add(strAtt);
                }
            }

            return attribs;
        }

        struct StringAttribute
        {
            public int startIndex, endIndex;
            public ConsoleColor attribute;

            public AttributeType type;

            public StringAttribute(int start, int end, AttributeType type, ConsoleColor attrib)
            {
                startIndex = start;
                endIndex = end;
                attribute = attrib;

                this.type = type;
            }
        }
    }
}
