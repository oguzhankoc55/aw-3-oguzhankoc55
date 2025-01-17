using MediatR;
using Vb.Base.Response;
using Vb.Schema;

namespace Vb.Business.Cqrs;

public record GetAllEftTransactionQuery() : IRequest<ApiResponse<List<EftTransactionResponse>>>;
public record GetEftTransactionByIdQuery(int Id) : IRequest<ApiResponse<EftTransactionResponse>>;
public record CreateEftTransactionCommand(EftTransactionRequest Model) : IRequest<ApiResponse<EftTransactionResponse>>;
public record UpdateEftTransactionCommand(int Id, EftTransactionRequest Model) : IRequest<ApiResponse>;
public record DeleteEftTransactionCommand(int Id) : IRequest<ApiResponse>;
public record GetEftTransactionByParameterQuery(string ReferenceNumber, DateTime TransactionDate, decimal Amount, string Description) : IRequest<ApiResponse<List<EftTransactionResponse>>>;


