using MediatR;
using Shared.DataTransferObjects;
using System.Windows.Input;

namespace Application.Commands
{
    public sealed record UpdateCompanyCommand(Guid Id, CompanyForUpdateDto Company, bool TrackChanges) : IRequest;
}
