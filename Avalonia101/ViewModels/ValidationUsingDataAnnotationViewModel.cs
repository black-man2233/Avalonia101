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

    private string? _EMail;

    /// <summary>
    /// Validation using DataAnnotation
    /// </summary>
    [Required]
    [EmailAddress]
    public string? EMail
    {
        get { return _EMail; }
        set { this.RaiseAndSetIfChanged(ref _EMail, value); }
    }

    #endregion


    #region Constructors

    #endregion

}