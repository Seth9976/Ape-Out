using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.CompilerServices
{
	// Token: 0x02000015 RID: 21
	public class AssumeRangeAttribute : Attribute
	{
		// Token: 0x0600006F RID: 111 RVA: 0x000023EB File Offset: 0x000005EB
		// Note: this type is marked as 'beforefieldinit'.
		static AssumeRangeAttribute()
		{
			Il2CppClassPointerStore<AssumeRangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.CompilerServices", "AssumeRangeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssumeRangeAttribute>.NativeClassPtr);
			AssumeRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssumeRangeAttribute>.NativeClassPtr, 100663377);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004C18 File Offset: 0x00002E18
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssumeRangeAttribute(long min, long max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssumeRangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssumeRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002424 File Offset: 0x00000624
		public AssumeRangeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0;
	}
}
