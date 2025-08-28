using Ardalis.Result;
using Ardalis.SharedKernel;

namespace App.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
