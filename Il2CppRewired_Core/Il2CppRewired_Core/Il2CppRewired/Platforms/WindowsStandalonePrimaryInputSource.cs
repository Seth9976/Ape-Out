using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppRewired.Platforms
{
	// Token: 0x02000165 RID: 357
	[OriginalName("Rewired_Core.dll", "Rewired.Platforms", "WindowsStandalonePrimaryInputSource")]
	public enum WindowsStandalonePrimaryInputSource
	{
		// Token: 0x040020AC RID: 8364
		RawInput,
		// Token: 0x040020AD RID: 8365
		DirectInput,
		// Token: 0x040020AE RID: 8366
		XInput,
		// Token: 0x040020AF RID: 8367
		SDL2 = 10,
		// Token: 0x040020B0 RID: 8368
		Unity = 100
	}
}
