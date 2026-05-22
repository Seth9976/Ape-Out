using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000375 RID: 885
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "MessageEnum")]
	[Flags]
	[Serializable]
	public enum MessageEnum
	{
		// Token: 0x04003007 RID: 12295
		NoArgs = 1,
		// Token: 0x04003008 RID: 12296
		ArgsInline = 2,
		// Token: 0x04003009 RID: 12297
		ArgsIsArray = 4,
		// Token: 0x0400300A RID: 12298
		ArgsInArray = 8,
		// Token: 0x0400300B RID: 12299
		NoContext = 16,
		// Token: 0x0400300C RID: 12300
		ContextInline = 32,
		// Token: 0x0400300D RID: 12301
		ContextInArray = 64,
		// Token: 0x0400300E RID: 12302
		MethodSignatureInArray = 128,
		// Token: 0x0400300F RID: 12303
		PropertyInArray = 256,
		// Token: 0x04003010 RID: 12304
		NoReturnValue = 512,
		// Token: 0x04003011 RID: 12305
		ReturnValueVoid = 1024,
		// Token: 0x04003012 RID: 12306
		ReturnValueInline = 2048,
		// Token: 0x04003013 RID: 12307
		ReturnValueInArray = 4096,
		// Token: 0x04003014 RID: 12308
		ExceptionInArray = 8192,
		// Token: 0x04003015 RID: 12309
		GenericMethod = 32768
	}
}
