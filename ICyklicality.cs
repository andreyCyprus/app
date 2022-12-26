using System;
namespace CYKLIKALITY_ЦИКЛИЧНОСТЬ
{
	public interface ICyklicality
	{
        void InputData();   //ввод данных
        void Recognition(); //оценка или обработка
        void Calculation(); //расчёты
        void Analis();      // анализ расчётов
        void Result();      // вывод результатов
    }
}

