using System.ComponentModel.DataAnnotations;

namespace jobagency.Domain.model
{
    /// <summary>
    /// Вакансия
    /// </summary>
    public class JobPosition
    {
        /// <summary>
        /// Идентификатор вакансии
        /// </summary>
        [Key]
        public required int Id { get; set; }

        /// <summary>
        /// Код вакансии
        /// </summary>
        public required string JobCode { get; set; }

        /// <summary>
        /// Категория вакансии (IT, Финансы, Маркетинг)
        /// </summary>
        public required string Category { get; set; } // Например: "IT", "Finance", "Marketing"

        /// <summary>
        /// Название должности
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Описание вакансии
        /// </summary>
        public string? Description { get; set; }

        internal static JobPosition FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Перегрузка метода, возвращающего строковое представление объекта
        /// </summary>
        /// <returns>Информация о вакансии</returns>
        public override string ToString() => $"{Title ?? "<Без названия>"} ({Category})";
    }
}