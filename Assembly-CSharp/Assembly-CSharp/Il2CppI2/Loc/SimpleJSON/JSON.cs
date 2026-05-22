using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc.SimpleJSON
{
	// Token: 0x02000278 RID: 632
	public static class JSON : Object
	{
		// Token: 0x0600474F RID: 18255 RVA: 0x0002A0ED File Offset: 0x000282ED
		// Note: this type is marked as 'beforefieldinit'.
		static JSON()
		{
			Il2CppClassPointerStore<JSON>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc.SimpleJSON", "JSON");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSON>.NativeClassPtr);
			JSON.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100670631);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x0010AB84 File Offset: 0x00108D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116624, XrefRangeEnd = 116625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode Parse(string aJSON)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aJSON);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSON.NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x0002A126 File Offset: 0x00028326
		public JSON(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002CC5 RID: 11461
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0;
	}
}
