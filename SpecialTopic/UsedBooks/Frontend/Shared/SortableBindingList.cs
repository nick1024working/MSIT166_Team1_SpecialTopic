using System.Collections.Generic;
using System.ComponentModel;

namespace SpecialTopic.UsedBooks.Frontend.Shared
{
    /// <summary>
    /// ChatGPT 產生的dgv擴充資料源
    /// </summary>
    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection;
        private PropertyDescriptor _sortProperty;

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => _isSorted;
        protected override PropertyDescriptor SortPropertyCore => _sortProperty;
        protected override ListSortDirection SortDirectionCore => _sortDirection;

        public SortableBindingList() : base() { }

        public SortableBindingList(IEnumerable<T> collection)
            : base(new List<T>(collection)) { }

        public void ApplySort(PropertyDescriptor prop, ListSortDirection direction)
        {
            ApplySortCore(prop, direction);
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            var itemsList = (List<T>)Items;
            itemsList.Sort((x, y) =>
            {
                var xValue = prop.GetValue(x);
                var yValue = prop.GetValue(y);
                return direction == ListSortDirection.Ascending
                    ? Comparer<object>.Default.Compare(xValue, yValue)
                    : Comparer<object>.Default.Compare(yValue, xValue);
            });

            _sortProperty = prop;
            _sortDirection = direction;
            _isSorted = true;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            _isSorted = false;
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
    }
}
