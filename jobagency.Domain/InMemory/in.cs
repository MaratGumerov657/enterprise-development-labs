using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jobagency.Domain.model;
using jobagency.Domain.service;

namespace jobagency.Domain.service.InMemory;

/// <summary>
/// Имплементация репозитория для соискателей, которая хранит коллекцию в оперативной памяти.
/// </summary>
public class ApplicantInMemoryRepository : IRepository<Applicant, int>
{
    private List<Applicant> applicants;

    /// <summary>
    /// Конструктор репозитория.
    /// </summary>
    public ApplicantInMemoryRepository()
    {
        // Инициализация тестовыми данными
        applicants = new List<Applicant>
        {
            new Applicant { ApplicantId = 1, FullName = "Иванов Иван Иванович", Phone = "+79111111111", Experience = "5 лет в IT", Education = "Высшее техническое", DesiredSalary = 100000 },
            new Applicant { ApplicantId = 2, FullName = "Петров Петр Петрович", Phone = "+79222222222", Experience = "3 года в финансах", Education = "Высшее экономическое", DesiredSalary = 80000 },
            new Applicant { ApplicantId = 3, FullName = "Сидорова Анна Владимировна", Phone = "+79333333333", Experience = "2 года в рекламе", Education = "Высшее гуманитарное", DesiredSalary = 70000 }
        };
    }

    /// <inheritdoc/>
    public Task<Applicant> Add(Applicant entity)
    {
        try
        {
            applicants.Add(entity);
        }
        catch
        {
            return Task.FromResult<Applicant>(null!);
        }
        return Task.FromResult(entity);
    }

    /// <inheritdoc/>
    public async Task<bool> Delete(int key)
    {
        try
        {
            var applicant = await Get(key);
            if (applicant != null)
                applicants.Remove(applicant);
        }
        catch
        {
            return false;
        }
        return true;
    }

    /// <inheritdoc/>
    public Task<Applicant?> Get(int key) =>
        Task.FromResult(applicants.FirstOrDefault(item => item.ApplicantId == key));

    /// <inheritdoc/>
    public Task<IList<Applicant>> GetAll() =>
        Task.FromResult((IList<Applicant>)applicants);

    /// <inheritdoc/>
    public async Task<Applicant> Update(Applicant entity)
    {
        try
        {
            await Delete(entity.ApplicantId);
            await Add(entity);
        }
        catch
        {
            return null!;
        }
        return entity;
    }
}