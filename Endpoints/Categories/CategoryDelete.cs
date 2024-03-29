﻿namespace IWantApp.Endpoints.Categories;

public class CategoryDelete
{
    public static string Template => "/categories/{id:guid}";
    public static string[] Methods => new string[] { HttpMethod.Delete.ToString() };
    public static Delegate Hendle => Action;

    public static IResult Action([FromRoute] Guid id, ApplicationDbContext context)
    {
        var category = context.Categories.Where(c => c.Id == id).FirstOrDefault();
        if (category == null)
        {
            return Results.NotFound();
        }

        context.Categories.Remove(category);
        context.SaveChanges();
        return Results.Ok();
    }
}
