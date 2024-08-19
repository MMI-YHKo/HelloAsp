var builder = WebApplication.CreateBuilder(args);

// ��Ʈ�ѷ� ���񽺸� �߰��մϴ�.
builder.Services.AddControllersWithViews();

// AddConnections�� ���ʿ��� �� �ֽ��ϴ�. ���� ���� ���񽺰� �ʿ��� ��� ���⿡ �߰��� �� �ֽ��ϴ�.
// builder.Services.AddConnections();

var app = builder.Build();     
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}"
);


app.Run();

