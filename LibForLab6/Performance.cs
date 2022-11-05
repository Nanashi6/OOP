using System;
using System.Collections.Generic;

namespace LibForLab6
{
    public class Performance
    {
        private static List<Ticket> tickets = new List<Ticket>();

        /// <summary>
        /// Метод добавляет билет
        /// </summary>
        /// <param name="date">Дата представления</param>
        /// <param name="ticketCount">Кол-во билетов</param>
        /// <param name="place">Тип места</param>
        public static void CreateTicket(DateTime date, int ticketCount, Place place)
        {
            Ticket ticket = new Ticket(date, place);
            for (int i = 0; i < ticketCount; i++)
            {
                tickets.Add(ticket);
            }
        }

        /// <summary>
        /// Метод удаляет созданные билеты
        /// </summary>
        /// <param name="date">Дата представления</param>
        /// <param name="ticketCount">Кол-во билетов</param>
        /// <param name="place">Тип места</param>
        public static void RemoveTicket(DateTime date, int ticketCount, Place place)
        {
            Ticket ticket = new Ticket(date, place);
            for (int i = 0; i < ticketCount; i++)
            {
                tickets.Remove(ticket);
            }
        }

        /// <summary>
        /// Метод изменяет дату уже созданного билета
        /// </summary>
        /// <param name="date">Старая дата</param>
        /// <param name="ticketCount">Кол-во билетов</param>
        /// <param name="place">Старое место</param>
        /// <param name="newDate">Новая дата</param>
        /// <param name="newPlace">Новое место</param>
        public static void ChangeTicket(DateTime date, int ticketCount, Place place, DateTime newDate, Place newPlace)
        {
            RemoveTicket(date, ticketCount, place);
            CreateTicket(newDate, ticketCount, newPlace);
        }

        /// <summary>
        /// Метод возвращает все билеты представления 
        /// </summary>
        /// <returns></returns>
        public static List<Ticket> GetList()
        {
            return tickets;
        }

        /// <summary>
        /// Метод сообщает сколько билетов было продано на заданную дату
        /// </summary>
        /// <param name="dateNew">Заданная дата</param>
        /// <returns>int</returns>
        public static int SalesTickets(DateTime date)
        {
            int amountOfTicket = 0;

            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].date == date)
                {
                    amountOfTicket++;
                }
            }

            return amountOfTicket;
        }

        /// <summary>
        /// Среднее кол-во билетов, проданных в партер, лоджию и балкон, за указанный промежуток
        /// </summary>
        /// <param name="date">Начало периода</param>
        /// <param name="date1">Конец периода</param>
        /// <returns>int, int, int</returns>
        public static void GetAverageSales(DateTime firstDate, DateTime lastDate, out double colParterre, out double colLoggia, out double colBalcony)
        {
            int colDays = (lastDate - firstDate).Days + 1;
            colParterre = colLoggia = colBalcony = 0;

            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].date <= lastDate && tickets[i].date >= firstDate)
                {
                    switch (tickets[i].place)
                    {
                        case Place.Loggia:
                            colLoggia++;
                            break;
                        case Place.Balcony:
                            colBalcony++;
                            break;
                        case Place.Parterre:
                            colParterre++;
                            break;
                    }
                }
            }

            colParterre /= colDays;
            colLoggia /= colDays;
            colBalcony /= colDays;
        }

        /// <summary>
        /// Метод сообщает дату с минимальным кол-вом проданных билетов
        /// </summary>
        /// <param name="date">Начало периода</param>
        /// <param name="date1">Конец периода</param>
        /// <returns>DateTime</returns>
        public static DateTime GetMinSales(DateTime firstDate, DateTime lastDate)
        {
            DateTime minSalesDate = firstDate;
            int amountOfTicket = SalesTickets(firstDate);
            int colTicket;

            for (DateTime day = firstDate.AddDays(1); day.Ticks <= lastDate.Ticks; day = day.AddDays(1))
            {
                colTicket = SalesTickets(day);

                if (colTicket < amountOfTicket)
                {
                    amountOfTicket = colTicket;
                    minSalesDate = day;
                }
            }

            return minSalesDate;
        }
    }
}
