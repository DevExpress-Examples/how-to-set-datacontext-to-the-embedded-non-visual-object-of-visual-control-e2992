using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;

namespace DataContextSLSample {

    public class SomeVisualControl : Control, IDataContextOwner {
        DataContextBinder dataContextBinder;

        public SomeVisualControl() {
            this.dataContextBinder = new DataContextBinder(this);
        }
        public static readonly DependencyProperty InnerDataStoreProperty =
            DependencyProperty.Register("InnerDataStore", typeof(DataStore), typeof(SomeVisualControl), new PropertyMetadata(null));

        public DataStore InnerDataStore { 
            get { return (DataStore)GetValue(InnerDataStoreProperty); } 
            set { SetValue(InnerDataStoreProperty, value); } 
        }


        object IDataContextOwner.DataContext {
            get { return DataContext; }
        }
        void IDataContextOwner.UpdateInnerDataContext(object dataContext) {
            if (InnerDataStore != null)
                InnerDataStore.DataContext = dataContext;
        }
    }
    
}
