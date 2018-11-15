<!-- default file list -->
*Files to look at*:

* [DataContextSLSampleTestPage.aspx](./CS/DataContextSLSample.Web/DataContextSLSampleTestPage.aspx) (VB: [DataContextSLSampleTestPage.aspx](./VB/DataContextSLSample.Web/DataContextSLSampleTestPage.aspx))
* [DataContextBinder.cs](./CS/DataContextSLSample/DataContextBinder.cs) (VB: [DataContextBinder.vb](./VB/DataContextSLSample/DataContextBinder.vb))
* [InnerClasses.cs](./CS/DataContextSLSample/InnerClasses.cs) (VB: [InnerClasses.vb](./VB/DataContextSLSample/InnerClasses.vb))
* [MainPage.xaml](./CS/DataContextSLSample/MainPage.xaml) (VB: [MainPage.xaml.vb](./VB/DataContextSLSample/MainPage.xaml.vb))
* [MainPage.xaml.cs](./CS/DataContextSLSample/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/DataContextSLSample/MainPage.xaml.vb))
* [Model.cs](./CS/DataContextSLSample/Model.cs) (VB: [Model.vb](./VB/DataContextSLSample/Model.vb))
* [ViewClasses.cs](./CS/DataContextSLSample/ViewClasses.cs) (VB: [ViewClasses.vb](./VB/DataContextSLSample/ViewClasses.vb))
* [ViewModel.cs](./CS/DataContextSLSample/ViewModel.cs) (VB: [ViewModel.vb](./VB/DataContextSLSample/ViewModel.vb))
<!-- default file list end -->
# How to set DataContext to the embedded non-visual object of visual control


<p>This example presents a technique used to set the DataContext to an internal non-visual object if the application is built upon MVVM template. <br />
To accomplish this task, a new class DataContextBinder is implemented. It tracks changes of the owner context and notifies the owner that the new context settings should be applied to inner objects. An instance of this class is created in the visual control constructor. The visual control itself implements the IDataContextOwner interface providing the ability for the DataContext setting to propagate to the objects not contained in the visual tree.<br />
</p>

<br/>


