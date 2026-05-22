using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036A RID: 874
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryHeaderEnum")]
	[Serializable]
	public enum BinaryHeaderEnum
	{
		// Token: 0x04002FA0 RID: 12192
		SerializedStreamHeader,
		// Token: 0x04002FA1 RID: 12193
		Object,
		// Token: 0x04002FA2 RID: 12194
		ObjectWithMap,
		// Token: 0x04002FA3 RID: 12195
		ObjectWithMapAssemId,
		// Token: 0x04002FA4 RID: 12196
		ObjectWithMapTyped,
		// Token: 0x04002FA5 RID: 12197
		ObjectWithMapTypedAssemId,
		// Token: 0x04002FA6 RID: 12198
		ObjectString,
		// Token: 0x04002FA7 RID: 12199
		Array,
		// Token: 0x04002FA8 RID: 12200
		MemberPrimitiveTyped,
		// Token: 0x04002FA9 RID: 12201
		MemberReference,
		// Token: 0x04002FAA RID: 12202
		ObjectNull,
		// Token: 0x04002FAB RID: 12203
		MessageEnd,
		// Token: 0x04002FAC RID: 12204
		Assembly,
		// Token: 0x04002FAD RID: 12205
		ObjectNullMultiple256,
		// Token: 0x04002FAE RID: 12206
		ObjectNullMultiple,
		// Token: 0x04002FAF RID: 12207
		ArraySinglePrimitive,
		// Token: 0x04002FB0 RID: 12208
		ArraySingleObject,
		// Token: 0x04002FB1 RID: 12209
		ArraySingleString,
		// Token: 0x04002FB2 RID: 12210
		CrossAppDomainMap,
		// Token: 0x04002FB3 RID: 12211
		CrossAppDomainString,
		// Token: 0x04002FB4 RID: 12212
		CrossAppDomainAssembly,
		// Token: 0x04002FB5 RID: 12213
		MethodCall,
		// Token: 0x04002FB6 RID: 12214
		MethodReturn
	}
}
