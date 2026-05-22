using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppRewired
{
	// Token: 0x020000DE RID: 222
	[OriginalName("Rewired_Core.dll", "Rewired", "InputSource")]
	public enum InputSource
	{
		// Token: 0x040014BE RID: 5310
		None,
		// Token: 0x040014BF RID: 5311
		DirectInput,
		// Token: 0x040014C0 RID: 5312
		XInput,
		// Token: 0x040014C1 RID: 5313
		OSX,
		// Token: 0x040014C2 RID: 5314
		Fallback,
		// Token: 0x040014C3 RID: 5315
		RawInput,
		// Token: 0x040014C4 RID: 5316
		Fallback_PreConfigured,
		// Token: 0x040014C5 RID: 5317
		Linux,
		// Token: 0x040014C6 RID: 5318
		WindowsUWP,
		// Token: 0x040014C7 RID: 5319
		WebGL,
		// Token: 0x040014C8 RID: 5320
		Steam = 18,
		// Token: 0x040014C9 RID: 5321
		SDL2,
		// Token: 0x040014CA RID: 5322
		Ouya,
		// Token: 0x040014CB RID: 5323
		XboxOne,
		// Token: 0x040014CC RID: 5324
		PS4,
		// Token: 0x040014CD RID: 5325
		NintendoSwitch = 24,
		// Token: 0x040014CE RID: 5326
		Stadia,
		// Token: 0x040014CF RID: 5327
		GameCoreXboxOne,
		// Token: 0x040014D0 RID: 5328
		GameCoreScarlett,
		// Token: 0x040014D1 RID: 5329
		PS5,
		// Token: 0x040014D2 RID: 5330
		InternalDriver = 49,
		// Token: 0x040014D3 RID: 5331
		UnityKeyboardAndMouse,
		// Token: 0x040014D4 RID: 5332
		Custom = 100
	}
}
