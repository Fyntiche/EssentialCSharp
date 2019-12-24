using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Store
    {
        private Article[] articles = new Article[6];

        public Article this[int index]
        {
            get
            {
                if (index > 0 && index < articles.Length)
                {
                    return articles[index];
                }
                else
                {
                    return null;
                }

            }
            set
            {
                if (index < 0 && index < articles.Length)
                {
                    articles[index] = value;
                }
            }
        }

        public Article this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].NameProduct == index)
                    {
                        return articles[i];
                    }
                }
                return null;
            }
        }

        public Store()
        {
            Random random = new Random();
            for (int i = 0; i < articles.Length; i++)
            {
                articles[i] = new Article($"Phone {i}", $"Apple {i}", random.Next(0, 2514));
            }
        }
    }
}
