using System.ComponentModel.DataAnnotations;

namespace jobagency.Domain.model
{
    /// <summary>
    /// Заявка соискателя на вакансию
    /// </summary>
    public class JobApplication
    {
        /// <summary>
        /// Идентификатор заявки
        /// </summary>
        [Key]
        public required int Id { get; set; }

        /// <summary>
        /// Идентификатор соискателя
        /// </summary>
        public required int JobSeekerId { get; set; }

        /// <summary>
        /// Идентификатор вакансии
        /// </summary>
        public required int JobPositionId { get; set; }

        /// <summary>
        /// Дата подачи заявки
        /// </summary>
        public required DateTime ApplicationDate { get; set; }

        /// <summary>
        /// Перегрузка метода, возвращающего строковое представление объекта
        /// </summary>
        /// <returns>Информация о заявке</returns>
        public override string ToString() =>
            $"Заявка {Id}: Соискатель {JobSeekerId} на вакансию {JobPositionId}, дата подачи {ApplicationDate}";
    }
}
