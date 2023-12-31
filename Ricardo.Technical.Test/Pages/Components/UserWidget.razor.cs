﻿using Microsoft.AspNetCore.Components;

using Ricardo.Technical.Test.Utility;

namespace Ricardo.Technical.Test.Pages.Components
{
	public partial class UserWidget : IDisposable
	{
		[Inject] private Navigation NavManager { get; set; } = default!;
		[Inject] private SessionManager SessionManager { get; set; } = default!;

		protected override void OnInitialized()
		{
			SessionManager.OnSignIn += StateHasChanged;
			base.OnInitialized();
		}

		public void NavigateToSignIn()
		{
			NavManager.NavigateTo("/signin");
		}

		public void Dispose()
		{
			SessionManager.OnSignIn -= StateHasChanged;
		}

	}
}
