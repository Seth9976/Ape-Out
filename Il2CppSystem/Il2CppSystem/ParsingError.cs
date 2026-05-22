using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x02000035 RID: 53
	[OriginalName("System.dll", "System", "ParsingError")]
	public enum ParsingError
	{
		// Token: 0x04000272 RID: 626
		None,
		// Token: 0x04000273 RID: 627
		BadFormat,
		// Token: 0x04000274 RID: 628
		BadScheme,
		// Token: 0x04000275 RID: 629
		BadAuthority,
		// Token: 0x04000276 RID: 630
		EmptyUriString,
		// Token: 0x04000277 RID: 631
		LastRelativeUriOkErrIndex = 4,
		// Token: 0x04000278 RID: 632
		SchemeLimit,
		// Token: 0x04000279 RID: 633
		SizeLimit,
		// Token: 0x0400027A RID: 634
		MustRootedPath,
		// Token: 0x0400027B RID: 635
		BadHostName,
		// Token: 0x0400027C RID: 636
		NonEmptyHost,
		// Token: 0x0400027D RID: 637
		BadPort,
		// Token: 0x0400027E RID: 638
		BadAuthorityTerminator,
		// Token: 0x0400027F RID: 639
		CannotCreateRelative
	}
}
