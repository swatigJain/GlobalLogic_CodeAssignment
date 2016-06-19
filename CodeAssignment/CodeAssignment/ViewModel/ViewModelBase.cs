using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace CodeAssignment.ViewModel
{
    public class ViewModelBase: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged<T>(Expression<Func<T>> property)
        {
            var memberExpression = property.Body as MemberExpression;
            RaisePropertyChanged(memberExpression.Member.Name);
        }
        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
