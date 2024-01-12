using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UrbanStyleApp.Model;
using Xamarin.Forms;

namespace UrbanStyleApp.ViewModels
{
    public class ScheduleEventsViewModel : BindableObject
    {
        private ObservableCollection<ScheduleTimeModel> scheduleTimeModelContainer;

        public ObservableCollection<ScheduleTimeModel> ScheduleTimeModelContainer
        {
            get { return scheduleTimeModelContainer; }
            set
            {
                scheduleTimeModelContainer = value;
                OnPropertyChanged();
            }

        }


        private ObservableCollection<TimerModel> privateTimeContainer;

        public ObservableCollection<TimerModel> PrivateTimeContainer
        {
            get { return privateTimeContainer; }
            set
            {
                privateTimeContainer = value;
                OnPropertyChanged();
            }

        }



        private ObservableCollection<TimerModel> timeContainer;

        public ObservableCollection<TimerModel> TimeContainer
        {
            get { return timeContainer; }
            set
            {
                timeContainer = value;
                OnPropertyChanged();
            }

        }
        private int _GetSelectedIndex;
        public int GetSelectedIndex
        {
            get { return _GetSelectedIndex; }
            set
            {
                _GetSelectedIndex = value;
                OnPropertyChanged();
            }
        }
        private DateTime headerDateTime;
        public DateTime HeaderDateTime
        {
            get { return headerDateTime; }
            set
            {
                headerDateTime = value;
                OnPropertyChanged();
            }
        }

        #region Command
        public ICommand SelectCommand { get; }
        public ICommand PreviousMonthCommand { get; }
        public ICommand NextMonthCommand { get; }
        #endregion
        public ScheduleEventsViewModel()
        {
            PreviousMonthCommand = new Command(NewPreviousMonthCommand);
            NextMonthCommand = new Command(NewNextMonthCommand);
            SelectCommand = new Command(CollectionSelected);
            ScheduleTimeModelContainer = new ObservableCollection<ScheduleTimeModel>
            {
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "9:00 am"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "9:30 am"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "10:00 am"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "10:30"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "11:00 am"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "11:30 am"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "12:00 pm"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "12:30 pm"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "1:00 pm"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "1:30 pm"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "2:00 pm"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "2:30 pm"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "3:00 pm"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "3:30 pm"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "4:00 pm"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "4:30 pm"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "5:00 pm"
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = "5:30 pm"
                    }
            };
            HeaderDateTime = DateTime.UtcNow.ToLocalTime();
            GenerateCalanderTimes(HeaderDateTime);
        }
        private void NewNextMonthCommand(object obj)
        {

            HeaderDateTime = HeaderDateTime.AddMonths(1);
            GenerateCalanderTimes(HeaderDateTime);

        }

        private void NewPreviousMonthCommand(object obj)
        {
            HeaderDateTime = HeaderDateTime.AddMonths(-1);
            GenerateCalanderTimes(HeaderDateTime);

        }

        private async void CollectionSelected(object obj)
        {
            var content = obj as TimerModel;

            if (content == null)
                return;
            PrivateTimeContainer = TimeContainer;
            foreach (var item in PrivateTimeContainer)
            {
                if (item.Id == content.Id)
                {
                    item.Selected = true;
                }
                else
                {
                    item.Selected = false;
                }
            }
            TimeContainer = new ObservableCollection<TimerModel>();
            TimeContainer = PrivateTimeContainer;
            GetSelectedIndex = content.Id - 1;

        }
        internal void GenerateCalanderTimes(DateTime headerDateTime)
        {
            TimeContainer = new ObservableCollection<TimerModel>();

            //get todays date in int

            int gettodaydate = HeaderDateTime.Day;

            //Get total no of days in a month in int

            for (int i = 1; i <= DateTime.DaysInMonth(HeaderDateTime.Year, HeaderDateTime.Month); i++)
            {
                DateTime dt = new DateTime(HeaderDateTime.Year, HeaderDateTime.Month, i);

                TimerModel timerModel = new TimerModel
                {
                    Day = dt.ToString("ddd"),
                    Date = i,
                    Id = i,
                    Selected = false
                };
                if (gettodaydate == i)
                {
                    timerModel.Selected = true;
                }
                else
                {
                    timerModel.Selected = false;
                }
                TimeContainer.Add(timerModel);

                GetSelectedIndex = HeaderDateTime.Day;
            }
        }
    }
}