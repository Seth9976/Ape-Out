using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Bindings
{
	// Token: 0x02000015 RID: 21
	public class FreeFunctionAttribute : NativeMethodAttribute
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00003EB0 File Offset: 0x000020B0
		// Note: this type is marked as 'beforefieldinit'.
		static FreeFunctionAttribute()
		{
			Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "FreeFunctionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr);
			FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr, 100663343);
			FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr, 100663344);
			FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr, 100663345);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003F1C File Offset: 0x0000211C
		[CallerCount(0)]
		public unsafe FreeFunctionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003F58 File Offset: 0x00002158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513993, XrefRangeEnd = 513994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreeFunctionAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003FA4 File Offset: 0x000021A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513994, XrefRangeEnd = 513995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreeFunctionAttribute(string name, bool isThreadSafe)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isThreadSafe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002570 File Offset: 0x00000770
		public FreeFunctionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;
	}
}
