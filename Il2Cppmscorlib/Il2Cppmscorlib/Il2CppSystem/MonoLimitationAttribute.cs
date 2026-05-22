using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200005D RID: 93
	public class MonoLimitationAttribute : MonoTODOAttribute
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x00003F83 File Offset: 0x00002183
		// Note: this type is marked as 'beforefieldinit'.
		static MonoLimitationAttribute()
		{
			Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoLimitationAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr);
			MonoLimitationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr, 100664313);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0003EF90 File Offset: 0x0003D190
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoLimitationAttribute(string comment)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(comment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoLimitationAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00003FBC File Offset: 0x000021BC
		public MonoLimitationAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
