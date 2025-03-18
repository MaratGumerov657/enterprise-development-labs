using jobagency.Domain.model;

namespace jobagency.Domain.Data
{
    /// <summary>
    /// Класс для заполнения коллекций данными
    /// </summary>
    public static class DataSeeder
    {
        /// <summary>
        /// Коллекция соискателей, использующаяся для первичного наполнения базы данных 
        /// </summary>
        public static readonly List<JobSeeker> jobSeekers =
            new()
            {
                new() { Id = 1, FullName = "Иванов Иван Иванович", Experience = 5, Education = "Высшее", DesiredSalary = 70000 },
                new() { Id = 2, FullName = "Петров Петр Петрович", Experience = 3, Education = "Среднее специальное", DesiredSalary = 50000 },
                new() { Id = 3, FullName = "Сидоров Сидор Сидорович", Experience = 8, Education = "Высшее", DesiredSalary = 90000 },
            };

        /// <summary>
        /// Коллекция работодателей, использующаяся для первичного наполнения базы данных 
        /// </summary>
        public static readonly List<Employer> employers =
            new()
            {
                new() { Id = 1, CompanyName = "ООО Рога и Копыта", ContactPerson = "Иванов И.И.", Phone = "123-456-7890" },
                new() { Id = 2, CompanyName = "АО Прогресс", ContactPerson = "Петров П.П.", Phone = "098-765-4321" },
                new() { Id = 3, CompanyName = "ЗАО Надежда", ContactPerson = "Сидоров С.С.", Phone = "555-555-5555" },
            };

        /// <summary>
        /// Коллекция заявок, использующаяся для первичного наполнения базы данных 
        /// </summary>
        public static readonly List<JobApplication> jobApplications =
            new()
            {
                new() { Id = 1, JobSeekerId = 1, EmployerId = 1, Position = "Программист", SubmissionDate = DateTime.Now },
                new() { Id = 2, JobSeekerId = 2, EmployerId = 2, Position = "Бухгалтер", SubmissionDate = DateTime.Now },
                new() { Id = 3, JobSeekerId = 3, EmployerId = 3, Position = "Маркетолог", SubmissionDate = DateTime.Now },
            };
    }
}
