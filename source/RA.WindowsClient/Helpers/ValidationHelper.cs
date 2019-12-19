using RA.WindowsClient.Attributes;
using RA.WindowsClient.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ValidationResult = System.ComponentModel.DataAnnotations;

namespace RA.WindowsClient.Helpers
{
    public static class ValidationHelper
    {
        public static Dictionary<Type, DependencyProperty> DependencyConnection = new Dictionary<Type, DependencyProperty>
            {
                { typeof(TextBox), TextBox.TextProperty },
                { typeof(ComboBox), ComboBox.SelectedIndexProperty },
                { typeof(PasswordBox), PasswordBoxHelper.BoundPassword },
            };

        public static void Validate(Window window, BaseViewModel model)
        {
            Panel mainContainer = (Panel)window.Content;
            UIElementCollection element = mainContainer.Children;
            List<FrameworkElement> lstElement = element.Cast<FrameworkElement>().ToList();
            IEnumerable<Control> controls = lstElement.OfType<Control>();

            ValidationContext context = new ValidationContext(model);

            List<ValidationResult.ValidationResult> results = new List<ValidationResult.ValidationResult>();
            bool valid = Validator.TryValidateObject(model, context, results, true);

            if (valid == false)
            {
                foreach (ValidationResult.ValidationResult result in results)
                {
                    foreach (string member in result.MemberNames)
                    {
                        PropertyInfo property = model.GetType().GetProperty(member);
                        if (property != null)
                        {
                            DetailViewAttribute detailView = property.GetCustomAttribute<DetailViewAttribute>();
                            if (detailView != null)
                            {
                                Control control = window.FindName(detailView.ControlName) as Control;
                                if (control != null)
                                {
                                    DependencyProperty dependencyProperty = DependencyConnection[control.GetType()];
                                    if(dependencyProperty != null)
                                    {
                                        BindingExpression bindingExpression = BindingOperations.GetBindingExpression(control, dependencyProperty);
                                        BindingExpressionBase bindingExpressionBase = BindingOperations.GetBindingExpressionBase(control, dependencyProperty);
                                        ValidationError validationError = new ValidationError(new DataErrorValidationRule(), bindingExpression);
                                        validationError.ErrorContent = result.ErrorMessage;
                                        Validation.MarkInvalid(bindingExpressionBase, validationError);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
