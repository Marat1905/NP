using NP.Break.Models;
using NP.Break.Services;
using NP.Break.Services.Interfaces;
using NP.ChangeSettings.Services.Interfaces;
using NP.DAL.Entityes;
using NP.DAL.Interfaces;
using NP.Infrastructure.Enums;
using NP.TestWpf.Infrastructure.Base;
using NP.TestWpf.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace NP.TestWpf.ViewModels
{
    internal class MainWindowViewModel:ViewModel
    {
        private readonly IBreakService _BreakService;
        private readonly IChangeRunSettingsService _RunSettingsService;



        #region Заголовок окна. 
        private string _Title = "Главное окно";
      
        /// <summary>Заголовок окна.</summary>
        public string Title { get => _Title; set { Set(ref _Title, value); } }
        #endregion

        #region Break : bool - Имитация обрыва

        /// <summary>Имитация обрыва </summary>
        private bool _Break = false;

        /// <summary>Имитация обрыва</summary>
        public bool Break
        {
            get => _Break;
            set
            {
                if (value == false)
                    _BreakService.BreakInt = 0;
                else
                    _BreakService.BreakInt = 1;

                Set(ref _Break, value);
            }
        }

        #endregion

        #region IEnumerable<BreakInfo> : BreakList - Модель поиска аэропортов по радиусу

        /// <summary>Модель поиска аэропортов по радиусу</summary>
        private IEnumerable<BreakInfo>? _BreakList;

        /// <summary>Модель поиска аэропортов по радиусу </summary>
        public IEnumerable<BreakInfo>? BreakList { get => _BreakList; set => Set(ref _BreakList, value); }

        #endregion


        #region Command BreakCommand - Кнопка имитации обрыва

        /// <summary>Кнопка имитации обрыва</summary>
        private ICommand _BreakCommand;

        /// <summary>Кнопка имитации обрыва</summary>
        public ICommand BreakCommand => _BreakCommand
            ??= new LambdaCommand(OnBreakCommandExecuted, CanBreakCommandExecute);

        /// <summary>Проверка возможности выполнения - Кнопка имитации обрыва</summary>
        private bool CanBreakCommandExecute(object p) => true;

        /// <summary>Логика выполнения - Кнопка имитации обрыва</summary>
        private void OnBreakCommandExecuted(object p)
        {
          
        }

        #endregion

        public MainWindowViewModel(IBreakService breakService, IChangeRunSettingsService runSettingsService)
        {
            _BreakService = breakService;
            _RunSettingsService = runSettingsService;
           
            _BreakService.Notify += _BreakService_Notify;

            BreakList = _BreakService.Breaks;
            if (_BreakService != null)
            {
               if(_BreakService.BreakInt == 1)
                {
                    Break=true;
                }
               else
                    Break=false;

                var result1 = _BreakService.Period<BreakInfo>(new DateTime(2023, 08, 02, 08, 00, 00), new DateTime(2023, 08, 02, 20, 00, 00)).ToList();
                var result2 = _BreakService.SmenaSearch<BreakInfo>(new DateTime(2023, 08, 02), Smena.Day, TimeSpan.FromMinutes(20)).ToList();

                var result3 = _BreakService.Period<BreakInfo>(new DateTime(2023, 08, 02, 20, 00, 00), new DateTime(2023, 08, 03, 08, 00, 00),TimeSpan.FromMinutes(20)).ToList();
                var result4 = _BreakService.SmenaSearch<BreakInfo>(new DateTime(2023, 08, 02), Smena.Night, TimeSpan.FromMinutes(20)).ToList();
                //BreakList = result2;
            }
        }

        private void _BreakService_Notify(BreakService sender, Break.Infrastructure.EventArgs.BreakEventArgs e)
        {
            BreakList = _BreakService.Breaks;
        }
    }
}
