using jobagency.Domain.model;

namespace jobagency.Domain.service;
/// <summary>
/// Репозиторий для работы с заявками соискателей.
/// </summary>
public interface IJobApplicationRepository : IRepository<JobApplication, int>
{
    /// <summary>
    /// Вывести информацию обо всех заявках на заданную должность.
    /// </summary>
    /// <param name="jobPositionId">Идентификатор должности.</param>
    /// <returns>Список заявок.</returns>
    Task<IList<JobApplication>> GetApplicationsByJobPosition(int jobPositionId);

    /// <summary>
    /// Вывести топ 5 работодателей по количеству заявок.
    /// </summary>
    /// <returns>Список кортежей с названием работодателя и количеством заявок.</returns>
    Task<IList<(string EmployerName, int ApplicationCount)>> Top5EmployersByApplications { get; }

    /// <summary>
    /// Вывести средний предлагаемый уровень зарплаты по каждому разделу вакансий.
    /// </summary>
    /// <returns>Список кортежей с разделом вакансий и средним уровнем зарплаты.</returns>
    Task<IList<(string JobCategory, decimal AverageSalary)>> GetAverageSalaryByJobCategory();
}
