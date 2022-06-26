using AltaBt.DBContext;
using AltaBt.iRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBangdiem, BangdiemRP>();
builder.Services.AddScoped<IUser, UserRP>();
builder.Services.AddScoped<ITeacher, TeacherRP>();
builder.Services.AddScoped<IMonhoc, MonhocRP>();
builder.Services.AddScoped<IKhoahoc, KhoahocRP>();
builder.Services.AddScoped<IBaiKiemtra, BaikiemtraRP>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
