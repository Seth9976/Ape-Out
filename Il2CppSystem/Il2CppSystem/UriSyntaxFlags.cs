using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x0200003E RID: 62
	[OriginalName("System.dll", "System", "UriSyntaxFlags")]
	[Flags]
	public enum UriSyntaxFlags
	{
		// Token: 0x040002E5 RID: 741
		None = 0,
		// Token: 0x040002E6 RID: 742
		MustHaveAuthority = 1,
		// Token: 0x040002E7 RID: 743
		OptionalAuthority = 2,
		// Token: 0x040002E8 RID: 744
		MayHaveUserInfo = 4,
		// Token: 0x040002E9 RID: 745
		MayHavePort = 8,
		// Token: 0x040002EA RID: 746
		MayHavePath = 16,
		// Token: 0x040002EB RID: 747
		MayHaveQuery = 32,
		// Token: 0x040002EC RID: 748
		MayHaveFragment = 64,
		// Token: 0x040002ED RID: 749
		AllowEmptyHost = 128,
		// Token: 0x040002EE RID: 750
		AllowUncHost = 256,
		// Token: 0x040002EF RID: 751
		AllowDnsHost = 512,
		// Token: 0x040002F0 RID: 752
		AllowIPv4Host = 1024,
		// Token: 0x040002F1 RID: 753
		AllowIPv6Host = 2048,
		// Token: 0x040002F2 RID: 754
		AllowAnInternetHost = 3584,
		// Token: 0x040002F3 RID: 755
		AllowAnyOtherHost = 4096,
		// Token: 0x040002F4 RID: 756
		FileLikeUri = 8192,
		// Token: 0x040002F5 RID: 757
		MailToLikeUri = 16384,
		// Token: 0x040002F6 RID: 758
		V1_UnknownUri = 65536,
		// Token: 0x040002F7 RID: 759
		SimpleUserSyntax = 131072,
		// Token: 0x040002F8 RID: 760
		BuiltInSyntax = 262144,
		// Token: 0x040002F9 RID: 761
		ParserSchemeOnly = 524288,
		// Token: 0x040002FA RID: 762
		AllowDOSPath = 1048576,
		// Token: 0x040002FB RID: 763
		PathIsRooted = 2097152,
		// Token: 0x040002FC RID: 764
		ConvertPathSlashes = 4194304,
		// Token: 0x040002FD RID: 765
		CompressPath = 8388608,
		// Token: 0x040002FE RID: 766
		CanonicalizeAsFilePath = 16777216,
		// Token: 0x040002FF RID: 767
		UnEscapeDotsAndSlashes = 33554432,
		// Token: 0x04000300 RID: 768
		AllowIdn = 67108864,
		// Token: 0x04000301 RID: 769
		AllowIriParsing = 268435456
	}
}
