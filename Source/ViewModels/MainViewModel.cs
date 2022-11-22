using Source.Command;
using Source.Models;
using Source.Repositories.Abstracts;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Source.ViewModels;

public class MainViewModel : BaseViewModel
{
    
    private readonly IUserRepository _userRepository;

    public ObservableCollection<User> Users { get; set; }
    public User? CurrentUser { get; set; }

    
    public ICommand LoginCommand { get; set; }

    public MainViewModel(IUserRepository userRepository)
    {
        _userRepository = userRepository;
        Users = new(_userRepository.GetList() ?? new List<User>());

        LoginCommand = new RelayCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
    }


    void ExecuteLoginCommand(object? parameter)
        => MessageBox.Show("You pressed login...");

    bool CanExecuteLoginCommand(object? parameter)
        => true;

}