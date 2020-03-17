using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerBot
{
    class Bot
    {
        string[,] prices =
        {
            {"телевизор","телефон","монитор","холодильник","роутер"},
            {"1000","5000","7000","6500","700"},
            {"1","1","0","1","0"} //1 - в наличии, 0 - нет
        };
        string[] answers = { "+3809897484", "Вернадского 27б", "www.shop.com/feedback/", "Пн-птн 9:00-20:00,сб,вс - выходные" };



        public string answer(string question)
        {
            string answer = "";
            for(int i = 0; i < 5; i++)
            {
                if (question.IndexOf("цен", StringComparison.OrdinalIgnoreCase) != -1 && question.IndexOf(prices[0, i], StringComparison.OrdinalIgnoreCase) != -1)
                {
                    answer = "Bot: Цена на " + prices[0, i] + " " + prices[1, i] + " грн";
                    break;
                }
                else if (question.IndexOf("Здравствуй", StringComparison.OrdinalIgnoreCase) != -1 || question.IndexOf("Привет", StringComparison.OrdinalIgnoreCase) != -1)
                {
                    answer = "Bot: Cлушаю Вас!";
                    break;
                }
                else if (question.IndexOf("цена", StringComparison.OrdinalIgnoreCase) != -1 || question.IndexOf(prices[0, i], StringComparison.OrdinalIgnoreCase) != -1)
                {
                    if(question.IndexOf(prices[0, i], StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        answer = "Bot: Цена на товар '" + prices[0, i] + "' " + prices[1, i] + " грн";
                        if (prices[2, i] == "1")
                        {
                            answer += ", есть в наличии!";
                        }
                        else
                        {
                            answer += ", нет в наличии!";
                        }
                    }
                    else
                    {
                        answer = "Bot: Цену какого товара Вы хотите узнать?";
                    }
                    break;
                } 
                else if (question.IndexOf(prices[0, i], StringComparison.OrdinalIgnoreCase) != -1)
                {
                    answer = "Bot: Цена на товар '" + prices[0, i] + "' " + prices[1, i] + " грн";
                    if(prices[2, i] == "1")
                    {
                        answer += ", есть в наличии!";
                    }
                    else
                    {
                        answer += ", нет в наличии!";
                    }
                    break;
                }
                else if (question.IndexOf("номер", StringComparison.OrdinalIgnoreCase) != -1 || question.IndexOf("контактный", StringComparison.OrdinalIgnoreCase) != -1 || question.IndexOf("ваш телефон", StringComparison.OrdinalIgnoreCase) != -1 || question.IndexOf("связат", StringComparison.OrdinalIgnoreCase) != -1)
                {
                    answer = "Bot: Наш контактный номер телефона " + answers[0];
                    break;
                }
                else if (question.IndexOf("наличи", StringComparison.OrdinalIgnoreCase) != -1 && question.IndexOf(prices[0,i], StringComparison.OrdinalIgnoreCase) != -1 )
                {
                    if(prices[2,i] == "1")
                    {
                        answer = "Bot: Товар '" + prices[0, i] + "' есть в наличии!";
                    } else
                    {
                        answer = "Bot: Товара '" + prices[0, i] + "' нет в наличии!";
                    }
                    break;
                }
                else if (question.IndexOf("адрес", StringComparison.OrdinalIgnoreCase) != -1 || question.IndexOf("находитесь", StringComparison.OrdinalIgnoreCase) != -1)
                {
                    answer = "Bot: Наш адрес " + answers[1];
                    break;
                }
                else if (question.IndexOf("отзыв", StringComparison.OrdinalIgnoreCase) != -1)
                {
                    answer = "Bot: Отзывы наших покупателей: " + answers[2];
                    break;
                }
                else if (question.IndexOf("график", StringComparison.OrdinalIgnoreCase) != -1)
                {
                    answer = "Bot: График работы магазина: " + answers[3];
                    break;
                }
            }
            return answer;
        }
    }
}
