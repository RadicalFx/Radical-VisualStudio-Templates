using System;
using Topics.Radical.Windows.Presentation;

namespace RadicalTemplate.Presentation
{
	class MainViewModel : AbstractViewModel
	{
		public MainViewModel()
		{
			this.SetInitialPropertyValue( () => this.SampleText, "Welcome to Radical." );
		}

		public String SampleText
		{
			get { return this.GetPropertyValue( () => this.SampleText ); }
			set { this.SetPropertyValue( () => this.SampleText, value ); }
		}
	}
}
