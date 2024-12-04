using Microsoft.EntityFrameworkCore;
using ToDo.Models;

var builder = WebApplication.CreateBuilder(args);

// DbContext'i servislere ekleyin
builder.Services.AddDbContext<ToDoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Diğer servis kayıtları...
builder.Services.AddControllers(); 