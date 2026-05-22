using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000128 RID: 296
	public static class Nullable : Object
	{
		// Token: 0x06001517 RID: 5399 RVA: 0x000073D5 File Offset: 0x000055D5
		// Note: this type is marked as 'beforefieldinit'.
		static Nullable()
		{
			Il2CppClassPointerStore<Nullable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Nullable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Nullable>.NativeClassPtr);
			Nullable.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Nullable>.NativeClassPtr, 100666952);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x000847AC File Offset: 0x000829AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 176121, RefRangeEnd = 176124, XrefRangeStart = 176113, XrefRangeEnd = 176121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetUnderlyingType(Type nullableType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nullableType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Nullable.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0000740E File Offset: 0x0000560E
		public Nullable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0;
	}
}
