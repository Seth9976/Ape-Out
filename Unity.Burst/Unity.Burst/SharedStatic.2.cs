using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Burst
{
	// Token: 0x0200000C RID: 12
	public static class SharedStatic : Object
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00003754 File Offset: 0x00001954
		// Note: this type is marked as 'beforefieldinit'.
		static SharedStatic()
		{
			Il2CppClassPointerStore<SharedStatic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "SharedStatic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatic>.NativeClassPtr);
			SharedStatic.NativeFieldInfoPtr_HashToType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatic>.NativeClassPtr, "HashToType");
			SharedStatic.NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic>.NativeClassPtr, 100663352);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000037AC File Offset: 0x000019AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439718, XrefRangeEnd = 439720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref getHashCode64;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getSubHashCode64;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOf;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic.NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022A0 File Offset: 0x000004A0
		public SharedStatic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000380C File Offset: 0x00001A0C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000022A9 File Offset: 0x000004A9
		public unsafe static Dictionary<long, Type> HashToType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SharedStatic.NativeFieldInfoPtr_HashToType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<long, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SharedStatic.NativeFieldInfoPtr_HashToType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_HashToType;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateSharedStaticInternal_Public_Static_ptr_Void_Int64_Int64_UInt32_UInt32_0;

		// Token: 0x0200001F RID: 31
		public class PreserveAttribute : Attribute
		{
			// Token: 0x06000099 RID: 153 RVA: 0x00002539 File Offset: 0x00000739
			// Note: this type is marked as 'beforefieldinit'.
			static PreserveAttribute()
			{
				Il2CppClassPointerStore<SharedStatic.PreserveAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SharedStatic>.NativeClassPtr, "PreserveAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatic.PreserveAttribute>.NativeClassPtr);
				SharedStatic.PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatic.PreserveAttribute>.NativeClassPtr, 100663354);
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00005308 File Offset: 0x00003508
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PreserveAttribute()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatic.PreserveAttribute>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatic.PreserveAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600009B RID: 155 RVA: 0x0000256D File Offset: 0x0000076D
			public PreserveAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400022E RID: 558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
