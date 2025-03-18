using jobagency.Domain.model;

namespace jobagency.Domain.service;

/// <summary>
/// Репозиторий для работы с кадровым агентством.
/// </summary>
public interface IEmploymentAgencyRepository : IRepository<Applicant, int>
{
    /// <summary>
    /// Вывести информацию о всех соискателях, ищущих работу по заданной должности, упорядочить по ФИО.
    /// </summary>
    /// <param name="positionName">Название должности.</param>
    /// <returns>Список соискателей, ищущих работу по заданной должности.</returns>
    Task<IList<Applicant>> GetApplicantsByPosition(string positionName);

    /// <summary>
    /// Вывести информацию о соискателях, оставивших заявки за заданный период.
    /// </summary>
    /// <param name="startDate">Начальная дата периода.</param>
    /// <param name="endDate">Конечная дата периода.</param>
    /// <returns>Список соискателей, оставивших заявки за заданный период.</returns>
    Task<IList<Applicant>> GetApplicantsByApplicationDateRange(DateTime startDate, DateTime endDate);

    /// <summary>
    /// Вывести информацию о соискателях, соответствующих определенной заявке работодателя.
    /// </summary>
    /// <param name="employerApplicationId">ID заявки работодателя.</param>
    /// <returns>Список соискателей, соответствующих заявке работодателя.</returns>
    Task<IList<Applicant>> GetApplicantsMatchingEmployerApplication(int employerApplicationId);

    /// <summary>
    /// Вывести информацию о количестве заявок по каждому разделу и должности.
    /// </summary>
    /// <returns>Список кортежей с разделом, должностью и количеством заявок.</returns>
    Task<IList<(string CategoryName, string PositionName, int ApplicationCount)>> GetApplicationCountByCategoryAndPosition();

    /// <summary>
    /// Вывести топ 5 работодателей по количеству заявок.
    /// </summary>
    /// <returns>Список кортежей с работодателями и количеством их заявок.</returns>
    Task<IList<(Employer employer, int ApplicationCount)>> TopEmployersByApplicationCount { get; }

    /// <summary>
    /// Вывести информацию о работодателях, открывших заявки с максимальным уровнем зарплаты.
    /// </summary>
    /// <returns>Список работодателей с максимальным уровнем зарплаты в заявках.</returns>
    Task<IList<Employer>> GetEmployersWithMaxSalaryApplications();