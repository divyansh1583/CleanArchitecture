using Ardalis.Result;
using Ardalis.SharedKernel;

namespace App.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
