using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ReactiveUI;

namespace Avalonia101.ViewModels;
#pragma warning disable
public class ViewModelBase : ReactiveObject, INotifyDataErrorInfo
{
    #region PropertieChanged

    public event PropertyChangedEventHandler? PropertyChanged;
    public event PropertyChangingEventHandler? PropertyChanging;

    public void RaisePropertyChanging(PropertyChangingEventArgs args)
    {
        throw new System.NotImplementedException();
    }

    public void RaisePropertyChanged(PropertyChangedEventArgs args)
    {
        throw new System.NotImplementedException();
    }

    #endregion

    #region Implements

    // Implement members of INotifyDataErrorInfo

    public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

    // we have errors present if errors.Count is greater than 0
    public bool HasErrors => errors.Count > 0;

    /// <inheritdoc />
    public IEnumerable GetErrors(string? propertyName)
    {
        // Get entity-level errors when the target property is null or empty
        if (string.IsNullOrEmpty(propertyName))
        {
            return errors.Values.SelectMany(static errors => errors);
        }

        // Property-level errors, if any
        if (this.errors.TryGetValue(propertyName!, out List<ValidationResult>? result))
        {
            return result;
        }

        // In case there are no errors we return an empty array.
        return Array.Empty<ValidationResult>();
    }

    // Store Errors in a Dictionary
    private Dictionary<string, List<ValidationResult>> errors = new Dictionary<string, List<ValidationResult>>();

    /// <summary>
    /// Clears the errors for a given property name.
    /// </summary>
    /// <param name="propertyName">The name of the property to clear or all properties if <see langword="null"/></param>
    protected void ClearErrors(string? propertyName = null)
    {
        // Clear entity-level errors when the target property is null or empty
        if (string.IsNullOrEmpty(propertyName))
        {
            errors.Clear();
        }
        else
        {
            errors.Remove(propertyName);
        }

        // Notify that errors have changed
        ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        this.RaisePropertyChanged(nameof(HasErrors));
    }

    /// <summary>
    /// Adds a given error message for a given property name.
    /// </summary>
    /// <param name="propertyName">the name of the property</param>
    /// <param name="errorMessage">The error message to show</param>
    protected void AddError(string propertyName, string errorMessage)
    {
        // Add the cached errors list for later use.
        if (!errors.TryGetValue(propertyName, out List<ValidationResult>? propertyErrors))
        {
            propertyErrors = new List<ValidationResult>();
            errors.Add(propertyName, propertyErrors);
        }

        propertyErrors.Add(new ValidationResult(errorMessage));

        // Notify that errors have changed
        ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        this.RaisePropertyChanged(nameof(HasErrors));
    }

    #endregion
}