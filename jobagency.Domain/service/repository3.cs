namespace jobagency.Domain.service;

/// <summary>
/// Обобщенный интерфейс для операций над коллекциями доменных сущностей.
/// </summary>
/// <typeparam name="TEntity">Тип доменной сущности.</typeparam>
/// <typeparam name="TKey">Тип ключевого поля сущности.</typeparam>
public interface IRepository<TEntity, TKey>
    where TEntity : class
    where TKey : struct
{
    /// <summary>
    /// Получение всего списка сущностей.
    /// </summary>
    /// <returns>Список всех сущностей.</returns>
    Task<IList<TEntity>> GetAll();

    /// <summary>
    /// Получение сущности по ее идентификатору.
    /// </summary>
    /// <param name="key">Идентификатор сущности.</param>
    /// <returns>Сущность или null, если сущность не найдена.</returns>
    Task<TEntity?> Get(TKey key);

    /// <summary>
    /// Добавление новой сущности в коллекцию.
    /// </summary>
    /// <param name="entity">Новая сущность.</param>
    /// <returns>Добавленная сущность.</returns>
    Task<TEntity> Add(TEntity entity);

    /// <summary>
    /// Обновление полей существующей сущности.
    /// </summary>
    /// <param name="entity">Отредактированная сущность.</param>
    /// <returns>Обновленная сущность.</returns>
    Task<TEntity> Update(TEntity entity);

    /// <summary>
    /// Удаление сущности из коллекции.
    /// </summary>
    /// <param name="key">Идентификатор удаляемой сущности.</param>
    /// <returns>True, если удаление прошло успешно, иначе False.</returns>
    Task<bool> Delete(TKey key);

    /// <summary>
    /// Получить количество сущностей в коллекции.
    /// </summary>
    /// <returns>Количество сущностей.</returns>
    Task<int> Count();

    /// <summary>
    /// Проверить, существует ли сущность с указанным идентификатором.
    /// </summary>
    /// <param name="key">Идентификатор сущности.</param>
    /// <returns>True, если сущность существует, иначе False.</returns>
    Task<bool> Exists(TKey key);
}