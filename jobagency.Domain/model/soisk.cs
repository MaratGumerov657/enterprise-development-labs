using System.ComponentModel.DataAnnotations;

namespace jobagency.Domain.model
{ 
    /// <summary>
    /// Класс для представления соискателя
    /// </summary>
    public class JobSeeker
    {
        /// <summary>
        /// Идентификатор соискателя
        /// </summary>
        [Key]
        public required int Id { get; set; }

        /// <summary>
        /// ФИО соискателя
        /// </summary>
        public required string FullName { get; set; }

        /// <summary>
        /// Год рождения соискателя
        /// </summary>
        public int BirthYear { get; set; }

        /// <summary>
        /// Телефон соискателя
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Опыт работы соискателя (в годах)
        /// </summary>
        public int Experience { get; set; }

        /// <summary>
        /// Уровень образования соискателя
        /// </summary>
        public string? Education { get; set; }

        /// <summary>
        /// Желаемый уровень зарплаты
        /// </summary>
        public decimal DesiredSalary { get; set; }
    }
}