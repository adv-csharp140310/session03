using session03.Model;
using session03.Utils;
using System.Reflection;

namespace session03;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonReflection_Click(object sender, EventArgs e)
    {
        var forms = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(x => x.BaseType == typeof(Form));

        MessageBox.Show(GetProps(typeof(User)));
        MessageBox.Show(GetProps(typeof(Product)));

    }

    public string GetProps(Type type)
    {
        string result = "";

        foreach (var prop in type.GetProperties())
        {
            result += prop.Name + ", ";
        }

        return result;
    }

    public string ToJSON(object obj)
    {
        var type = obj.GetType();
        string result = "{";

        foreach (var prop in type.GetProperties())
        {
            result += $"\"{prop.Name}\":{prop.GetValue(obj)},";
        }

        return result + "}";
    }

    private void buttonPrivate_Click(object sender, EventArgs e)
    {
        var user = new User();
        var userType1 = typeof(User);
        var userType2 = user.GetType();

        var passInfo = userType2.GetField("password", BindingFlags.NonPublic | BindingFlags.Instance);
        var password = passInfo.GetValue(user);
        MessageBox.Show(password.ToString());
        passInfo.SetValue(user, "xyz");

        // userType1 == userType2 // true

    }

    private void buttonToJSON_Click(object sender, EventArgs e)
    {
        var user = new User
        {
            ID = 1,
            Name = "Ali",
            Family = "Ramezani",
            Email = "nadarim@gmail.com",
            IsActive = true
        };

        MessageBox.Show(ToJSON(user));
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //DynamicFormUtils.DesignForm(panelUser, typeof(User));
        panelUser.DesignForm(typeof(User));
        groupBoxProduct.DesignForm(typeof(Product));
    }

    private void buttonSetUser_Click(object sender, EventArgs e)
    {
        panelUser.SetFormData(new User
        {
            Email = "email@gmail.com",
            Family = "Seyedmorad",
            Name = "Masoumeh",
            IsActive = true,
            ID = 1
        });
    }

    private void buttonGetProductData_Click(object sender, EventArgs e)
    {
        var data = groupBoxProduct.GetFormData(typeof(Product));
        MessageBox.Show(ToJSON(data));
        //groupBoxProduct.GetFormData(new Product { });
    }
}
