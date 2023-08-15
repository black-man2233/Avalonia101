using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Security.Cryptography;
using HSecond.Models;
using ReactiveUI;

namespace HSecond.ViewModels;
#pragma  warning disable

public class LoginFormVm : ViewModelBase
{
    public LoginFormVm()
    {
        CreatedUsers = new ObservableCollection<UserModel>
        {
            new UserModel("UserName", "PassWord"),
            new UserModel("Kevin", "*****")
        };

        ClearCommand = ReactiveCommand.Create<object>(Clear);
    }


    public ReactiveCommand<object, Unit> ClearCommand { get; }

    void Clear(object parameter)
    {
        try
        {
            if (UserName != null)
                if (PassWord != null)
                    CreatedUsers.Add(new UserModel(UserName, PassWord));
            UserName = String.Empty;
            PassWord = String.Empty;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    #region Properties

    private ObservableCollection<UserModel>? _createdUsers { get; set; }

    public ObservableCollection<UserModel>? CreatedUsers
    {
        get => _createdUsers;
        set
        {
            _createdUsers = value;
            OnPropertyChanged(nameof(CreatedUsers));
        }
    }

    private string? _userName { get; set; }

    public string? UserName
    {
        get => _userName;
        set
        {
            _userName = value;
            OnPropertyChanged(nameof(UserName));
        }
    }

    private string? _passWord { get; set; }

    public string? PassWord
    {
        get => _passWord;
        set
        {
            _passWord = value;
            OnPropertyChanged(nameof(PassWord));
        }
    }

    #endregion
}