using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session03.Utils;
public static class DynamicFormUtils
{
    public static void DesignForm(this Control target, Type type)
    {
        int yOffest = 20;
        foreach (var propertyInfo in type.GetProperties())
        {
            var label = new Label
            {
                Text = propertyInfo.Name + ": ",
                Location = new Point(20, yOffest),
                AutoSize = true,
            };

            var control = CreateControl(propertyInfo.PropertyType);
            control.Location = new Point(200, yOffest);
            control.Width = 200;

            target.Controls.Add(label);
            target.Controls.Add(control);

            yOffest += 30;
        }
    }



    private static Control CreateControl (Type Prop)
    {
        if (Prop == typeof(int) || Prop == typeof(float)) return new NumericUpDown();
        if (Prop == typeof(string)) return new TextBox();
        if (Prop == typeof(Boolean)) return new CheckBox();
        return new Control();
    }
}
