namespace DbService.UseCase.Results;

public record Result(bool IsSuccess, Exception? Exception = null);