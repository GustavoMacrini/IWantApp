using IWantApp.Infra.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;

namespace IWantApp.Endpoints.Employees;

public class EmployeeGetAll
{
    public static string Template => "/employees";
    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Hendle => Action;

    [Authorize(Policy = "EmployeePolicy")]
    public static async Task<IResult> Action(int? page, int? rows, QueryAllUsersWithClaimName query)
    {
        var errors = new List<string>()
        {
            page == null ? "Page is required" : null,
            rows == null ? "Rows is required" : null,
            rows > 5 ? "Rows needs to be equal or less than 5" : null
        };
        
        var errorsFiltered = errors.Where(error => error != null).ToList();        
        if (!errorsFiltered.IsNullOrEmpty())
        {
            return Results.BadRequest(errorsFiltered);
        }

        var result = await query.Execute(page.Value, rows.Value);
        return Results.Ok();
    }
    
}
