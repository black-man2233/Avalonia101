using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ReactiveUI;

namespace Avalonia101.ViewModels;

/// <summary>
/// ValidationUsingDataAnnotationViewModel
/// </summary>
public class ValidationUsingDataAnnotationViewModel : ViewModelBase
{
    #region Properties

    private string? _eMail;

    /// <summary>
    /// Validation using DataAnnotation
    /// </summary>
    [Required]
    [EmailAddress]
    public string? EMail
    {
        get { return _eMail; }
        set { this.RaiseAndSetIfChanged(ref _eMail, value); }
    }

    #endregion
}