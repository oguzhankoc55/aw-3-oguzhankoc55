using MediatR;
using Vb.Base.Response;
using Vb.Schema;

namespace Vb.Business.Cqrs;

public record GetAllAccountTransactionQuery() : IRequest<ApiResponse<List<AccountTransactionResponse>>>;
public record GetAccountTransactionByIdQuery(int Id) : IRequest<ApiResponse<AccountTransactionResponse>>;
public record CreateAccountTransactionCommand(AccountTransactionRequest Model) : IRequest<ApiResponse<AccountTransactionResponse>>;
public record UpdateAccountTransactionCommand(int Id, AccountTransactionRequest Model) : IRequest<ApiResponse>;
public record DeleteAccountTransactionCommand(int Id) : IRequest<ApiResponse>;
public record GetAccountTransactionByParameterQuery(string ReferenceNumber, DateTime TransactionDate, decimal Amount, string Description, string TransferType) : IRequest<ApiResponse<List<AccountTransactionResponse>>>;


